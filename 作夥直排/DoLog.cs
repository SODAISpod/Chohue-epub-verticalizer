using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace ChoHoe
{
    static class DoLog
    {
        public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static string ErrorMessage = "";
        static DoLog()
        {


        }
        static public void ProcessErrorMessage(string message)
        {
            ErrorMessage = "";
            ErrorMessage= message;
        }
        static public string GetErrorMessage()
        {
            return ErrorMessage;
        }

    }
}
