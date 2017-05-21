/*
    Test the application running 'dotnet run param1 param2'
 */
using System;
using System.Diagnostics;

namespace CmlParams
{
    class Program
    {
        //Configure teh TraceListener to send the trace message to the console
        //See Trace to find out more
        private static void configureTraceListener()
        {
            TextWriterTraceListener logger = new TextWriterTraceListener(System.Console.Out);
            Trace.Listeners.Add(logger);
        }

        static void Main(string[] args)
        {
            configureTraceListener();

            Console.WriteLine($"Number of command line parameters received: {args.Length}");

            Trace.TraceInformation("Using a 'for' loop");

            for (int index = 0; index < args.Length; index++)
            {
                Console.WriteLine($"Parameter number {index + 1} = {args[index]}");
            }

            Trace.TraceInformation("Using a 'foreach' loop");

            foreach (string arg in args)
            {
                Console.WriteLine($"Parameter = {arg}");
            }
        }
    }
}
