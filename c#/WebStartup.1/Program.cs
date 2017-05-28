using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace WebStartup._1
{

    public class Greeter
    {
        public string Say() => "Hello, no Startup class";
    }

    public class Program
    {
        public static async Task configureContext(HttpContext context)
        {
            var greet = context.RequestServices.GetService<Greeter>();
            await context.Response.WriteAsync($"{greet.Say()} {DateTime.Now.ToString()}");
        }

        public static void configureApp(IApplicationBuilder app)
        {
            app.Run(configureContext);
        }

        public static void Main(string[] args)
        {
/*            IWebHostBuilder host = new WebHostBuilder();
            host = host.UseKestrel();
            host = host.ConfigureServices(services => services.AddSingleton(new Greeter()));
            host.Configure(configureApp);
*/
            var host = new WebHostBuilder()
                .UseKestrel()
                .ConfigureServices(service=>service.AddSingleton(new Greeter()))
                .Configure(app=>{
                    app.Run(context=> {
                        return context.Response.WriteAsync($"Hello {DateTime.UtcNow.ToString()}");
                    });
                }).Build();

            //IWebHost webhost = host.Build();
            //webhost.Run();
            host.Run();
        }
    }
}
