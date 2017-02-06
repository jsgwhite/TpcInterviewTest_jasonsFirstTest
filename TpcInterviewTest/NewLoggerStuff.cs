using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ConsoleLogger : IMessageLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);

            switch (logType)
            {
                case LogType.Console:
                    Console.WriteLine(message);
                    break;

                case LogType.Queue:
                    // Code to send message to printer
                    break;
            }
        }
    }

    public class ConsoleLogger : IMessageLogger
    {
        public void Log(string message)
        {



        }


        interface IMessageLogger
    {
        void Log(string message,);
    }
}
