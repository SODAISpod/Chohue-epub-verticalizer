using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace ChoHoe
{
    static class Logger
    {
        public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static string ErrorMessage = "";
        static Logger()
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
