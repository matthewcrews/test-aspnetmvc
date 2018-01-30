namespace TestWebsite
{
    public interface IGreeter
    {
        string GetMessageOfDay();
    }

    public class Greeter : IGreeter
    {
        public string GetMessageOfDay()
        {
            return "Howdy Do!";
        }
    }
}