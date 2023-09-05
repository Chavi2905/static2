using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace static2
{
    static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("Starting the application...");

            // Your application logic here

            Logger.LogMessage("Application finished.");
        }
    }


  }
