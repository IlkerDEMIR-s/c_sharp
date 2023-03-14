using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reca_Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new DatabaseLogger(),new FileLogger());
            //customerManager.logger = new DatabaseLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        //public ILogger logger { get; set; } // property injection

        private ILogger[] _loggers;

        public CustomerManager(params ILogger[] loggers)
        {
            _loggers = loggers;
        }
        public void Add()
        {
            foreach (var logger in _loggers)
            {
                logger.Log();
            }
            Console.WriteLine("Customer added!");            
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file.");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms.");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
