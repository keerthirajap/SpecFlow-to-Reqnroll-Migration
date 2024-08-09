namespace BDDTesting.Net7.Services
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ILoggerService
    {
        void Log(string message);
    }

    public class ConsoleLoggerService : ILoggerService
    {
        public ConsoleLoggerService()
        {
            // Ensure Trace listeners are configured
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.AutoFlush = true;
        }

        public void Log(string message)
        {
            Trace.WriteLine(message); // Write to Visual Studio Output window
        }
    }
}