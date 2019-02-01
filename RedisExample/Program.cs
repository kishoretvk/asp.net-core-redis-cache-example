using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace RedisExample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                var host = new WebHostBuilder()
             .UseKestrel()
             .UseContentRoot(Directory.GetCurrentDirectory())
             .UseIISIntegration()
             .UseStartup<Startup>()
             .UseApplicationInsights()
             .Build();

                host.Run();
            }
            catch (System.Exception ex) 
            {

                throw ex; 
            }

        }
    }
}