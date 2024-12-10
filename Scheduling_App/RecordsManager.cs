using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class RecordsManager : Form
    {
        public string loggedInUser;
        private List<ClientRecord> clientRecordsList = new List<ClientRecord>();
        private Client_Scheduling.client_scheduleEntities dbcontext = new Client_Scheduling.client_scheduleEntities();

        public RecordsManager(string loggedInUser)
        {
            InitializeComponent();
            RecordsDataGridView.AutoGenerateColumns = true;
            this.loggedInUser = loggedInUser;
        }

        private void RecordsManager_Load(object sender, EventArgs e)
        {
            //Get the fields for clientrecord from the database tables
            var query = from customer in dbcontext.customers
                        join address in dbcontext.addresses on customer.addressId equals address.addressId
                        select new ClientRecord
                        {
                            ClientID = customer.customerId,
                            ClientName = customer.customerName,
                            ClientAddressID = address.addressId,
                            ClientAddress = address.address1,
                            ClientPhone = address.phone
                        };
            //Store the results in the clientRecordsList and assign it to the binding source
            clientRecordsList = query.ToList();
            RecordsBindingSource.DataSource = clientRecordsList;
            RecordsDataGridView.DataSource = RecordsBindingSource;
            //Remove unnecessary columns
            if (RecordsDataGridView.Columns["ClientID"] != null)
            {
                RecordsDataGridView.Columns.Remove("ClientID");
            }
            if (RecordsDataGridView.Columns["ClientAddressID"] != null)
            {
                RecordsDataGridView.Columns.Remove("ClientAddressID");
            }
        }

        //Handle validation for adding or modifying records in the datagridview, then ensure they're trimmed
        private void RecordsDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (RecordsDataGridView.IsCurrentRowDirty)
            {
                //Ensure all fields are filled in
                foreach(DataGridViewCell cell in RecordsDataGridView.Rows[e.RowIndex].Cells)
                {
                    if (cell.Value == null)
                    {
                        MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        break;
                    }
                }
                //Ensure the phone number only contains digits and dashes
                if (RecordsDataGridView.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    if (!Regex.IsMatch(RecordsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), @"^[\d-]+$"))
                    {
                        MessageBox.Show("Phone number must only contain digits and dashes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                //Trim whitespace from all cells in the current row
                foreach (DataGridViewCell cell in RecordsDataGridView.Rows[e.RowIndex].Cells)
                {
                    if (cell != null && cell.Value != null)
                    {
                        cell.Value = cell.Value.ToString().Trim();
                    }
                }
            }
        }

        //Handle saving all the changes back to the database
        private void bindingNavigatorSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in RecordsDataGridView.Rows)
                {
                    if (row.DataBoundItem is ClientRecord record)
                    {
                        //Check if the customer already exists
                        var existingCustomer = dbcontext.customers.FirstOrDefault(c => c.customerId == record.ClientID);
                        var existingAddress = dbcontext.addresses.FirstOrDefault(a => a.addressId == record.ClientAddressID);

                        //CASE 1: update existing records
                        if (existingAddress != null)
                        {
                            //Only update the address and phone if they've changed
                            if (existingAddress.address1 != record.ClientAddress || existingAddress.phone != record.ClientPhone)
                            {
                                existingAddress.address1 = record.ClientAddress;
                                existingAddress.phone = record.ClientPhone;
                                existingAddress.lastUpdate = DateTime.Now;
                            }
                        }
                        if (existingCustomer != null)
                        {
                            //Only update the customer name if it's changed
                            if (existingCustomer.customerName != record.ClientName)
                            {
                                existingCustomer.customerName = record.ClientName;
                                existingCustomer.lastUpdate = DateTime.Now;
                            }
                        }

                        //CASE 2: add new records
                        if (existingAddress == null)
                        {
                            var newAddress = new Client_Scheduling.address
                            {
                                address1 = record.ClientAddress,
                                address2 = "",
                                //The cityId and postalCode assignments don't follow business logic
                                //I just used them in place of empty values ¯\_(ツ)_/¯
                                cityId = (dbcontext.addresses.Max(a => a.cityId)),
                                postalCode = (dbcontext.addresses.Max(a => a.postalCode) + 1),
                                phone = record.ClientPhone,
                                createDate = DateTime.Now,
                                createdBy = loggedInUser,
                                lastUpdate = DateTime.Now,
                                lastUpdateBy = loggedInUser
                            };

                            dbcontext.addresses.Add(newAddress);
                        }
                        if (existingCustomer == null)
                        {
                            var newCustomer = new Client_Scheduling.customer
                            {
                                customerName = record.ClientName,
                                addressId = record.ClientAddressID,
                                active = true,
                                createDate = DateTime.Now,
                                createdBy = loggedInUser,
                                lastUpdate = DateTime.Now,
                                lastUpdateBy = loggedInUser
                            };

                            dbcontext.customers.Add(newCustomer);

                        }
                    }
                }
                dbcontext.SaveChanges();
                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (DbEntityValidationException except)
            {
                foreach (var validationErrors in except.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //If user tries to save an invalid entry, stop tracking the invalid entry
                foreach (System.Data.Entity.Infrastructure.DbEntityEntry entry in dbcontext.ChangeTracker.Entries())
                {
                    if (entry.State == System.Data.Entity.EntityState.Modified || entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entry.State = System.Data.Entity.EntityState.Detached;
                    }
                }
            }

            catch (Exception except)
            {
                while (except.InnerException != null)
                {
                    except = except.InnerException;
                }
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Ensure the new row's hidden columns are properly assigned to
        private void RecordsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Prerequisite for CASE 2, so handle exceptions
            try
            {
                if (RecordsDataGridView.Rows[e.RowIndex].DataBoundItem is ClientRecord record)
                {
                    if (record.ClientID == -1)
                    {
                        record.ClientID = clientRecordsList.Max(c => c.ClientID) + 1;
                    }
                    if (record.ClientAddressID == -1)
                    {
                        record.ClientAddressID = clientRecordsList.Max(a => a.ClientAddressID) + 1;
                    }
                }
            }

            catch (Exception except)
            {
                while (except.InnerException != null)
                {
                    except = except.InnerException;
                }
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Handle deletion of records from the datagridview and dbcontext
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //CASE 3: delete the record
            if (RecordsDataGridView.CurrentRow != null && RecordsDataGridView.CurrentRow.DataBoundItem is ClientRecord record)
            {
                try
                {
                    var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var customer = dbcontext.customers.FirstOrDefault(c => c.customerId == record.ClientID);
                        var address = dbcontext.addresses.FirstOrDefault(a => a.addressId == record.ClientAddressID);

                        if (customer != null)
                        {
                            dbcontext.customers.Remove(customer);
                        }
                        if (address != null)
                        {
                            dbcontext.addresses.Remove(address);
                        }

                        RecordsDataGridView.Rows.Remove(RecordsDataGridView.CurrentRow);
                        if (clientRecordsList.Contains(record))
                        {
                            clientRecordsList.Remove(record);
                        }
                    }
                }

                catch (Exception except)
                {
                    while (except.InnerException != null)
                    {
                        except = except.InnerException;
                    }
                    MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //Handle refreshing the records in the datagridview
        private void bindingNavigatorRefreshButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to refresh the records? All unsaved changes will be lost.", "Confirm Refresh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                RecordsBindingSource.DataSource = null;
                RecordsDataGridView.DataSource = null;
                RecordsManager_Load(sender, e);
            }
        }
    }
}
