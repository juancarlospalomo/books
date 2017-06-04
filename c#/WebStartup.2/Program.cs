using System;
using Microsoft.AspNetCore.Hosting;

namespace WebStartup._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();                
        }
    }
}
