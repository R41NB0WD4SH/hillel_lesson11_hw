namespace Hillel_Lesson11_HW;

public class GreetingsGenerator : IGreeting
{
    private string _greeting;

    public string Greeting
    {
        get
        {
            return _greeting;
        }
        set
        {
            _greeting = value;
        }
    }


    public GreetingsGenerator(string[] allGreetings)
    {
        Random rnd = new Random();

        _greeting = allGreetings[rnd.Next(0, allGreetings.Length)];
    }
}