using Microsoft.Extensions.Configuration;

namespace TestWebsite.Services
{
    public interface IGreeter
    {
        string GetMessageOfDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessageOfDay()
        {
            return _configuration["Greeting"];
        }
    }
}