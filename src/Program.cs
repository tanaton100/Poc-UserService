using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace POC_UserService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                  .UseKestrel(option => option.Listen(IPAddress.Any, 5000))
                .UseStartup<Startup>();
    }
}
