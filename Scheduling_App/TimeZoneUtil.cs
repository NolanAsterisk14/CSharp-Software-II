using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_App
{
    public static class TimeZoneUtil
    {
        private static TimeZoneInfo userTimeZone = TimeZoneInfo.Local;
        private static TimeZoneInfo dbTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

        public static DateTime ConvertToUserTimeZone(DateTime dateTime)
        {
            try
            {
                DateTime userDateTime = TimeZoneInfo.ConvertTime(dateTime, dbTimeZone, userTimeZone);
                return userDateTime;
            }

            catch (Exception except)
            {
                while (except.InnerException != null)
                {
                    except = except.InnerException;
                }
                return DateTime.MinValue;
            }
        }

        public static DateTime ConvertToDBTimeZone(DateTime dateTime)
        {
            try
            {
                DateTime dbDateTime = TimeZoneInfo.ConvertTime(dateTime, userTimeZone, dbTimeZone);
                return dbDateTime;
            }

            catch (Exception except)
            {
                while (except.InnerException != null)
                {
                    except = except.InnerException;
                }
                return DateTime.MinValue;
            }
        }

        public static String GetDBTimeZone()
        {
            return dbTimeZone.Id;
        }

        public static String GetUserTimeZone()
        {
            return userTimeZone.Id;
        }
    }
}
