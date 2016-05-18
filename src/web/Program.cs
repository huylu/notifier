using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Notifier.Web
{
    public class Program
    {  // Entry point for the application.
        public static void Main(string[] args) 
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())                
                //.UseDefaultHostingConfiguration(args)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();   
        }         
    }      
}