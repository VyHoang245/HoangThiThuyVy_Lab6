using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Lab6_CSE422
{
     class Logger
    {
        public void Log(object logEntry)
        {
            Type type = logEntry.GetType();
            PropertyInfo[] properties = type.GetProperties();
            string logMessage = type.Name + ": ";

            foreach (var property in properties)
            {
                logMessage += $"{property.Name} = {property.GetValue(logEntry)}, ";
            }

            Console.WriteLine(logMessage.TrimEnd(',', ' '));
        }
    }
}
