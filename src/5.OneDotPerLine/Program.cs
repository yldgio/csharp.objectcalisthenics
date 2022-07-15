using Microsoft.Extensions.Configuration;
using _5.OneDotPerLine;

class Program
{

    static void Main(string[] args)
    {
        var fakeConfig = new List<IConfigurationProvider>();
        IConfiguration config = new ConfigurationRoot(fakeConfig);
        var cityName = config.GetSection("location").GetSection("details")["city"];

        var bobby = new Pet();
        bobby.SetPostCode("any code");
        //config = new ConfigurationBuilder().Add().Add();
    }
}
