using Microsoft.Extensions.Configuration;
using Serilog;

namespace Session06
{
    internal static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  توضیحات فارسی.
        ///  
        ///  /// step 2
        /// </summary>
        [STAThread]
        static void Main()
        {

            Log.Logger = new LoggerConfiguration()
                        .WriteTo.File(Path.Join(AppContext.BaseDirectory , "TheCodeBuzz.txt"), rollingInterval: RollingInterval.Day)
                        .CreateLogger();


            
            var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class AppSettings
    {
        public string ConnectionString { get; set; }
        //Test git
    }
}