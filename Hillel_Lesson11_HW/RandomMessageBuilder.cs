using System.Text;

namespace Hillel_Lesson11_HW;

public class RandomMessageBuilder : IMessage
{

    private IName _name;
    private IGreeting _greeting;
    private IDate _date;


    public IName Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public IGreeting Greeting
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

    public IDate Date
    {
        get
        {
            return _date;
        }
        set
        {
            _date = value;
        }
    }

    public RandomMessageBuilder(IName name, IGreeting greeting, IDate date)
    {
        _name = name;
        _greeting = greeting;
        _date = date;
    }

    public void AddDateTime(IDate date)
    {
        _date = date;
    }


    public void AddGreeting(IGreeting greeting)
    {
        _greeting = greeting;
    }


    public void AddName(IName name)
    {
        _name = name;
    }


    public void ShowResult()
    {
        Console.WriteLine($"Name: {Name.Name}, Greeting: {Greeting.Greeting}, DateTime: {Date.DateTime}");
    }
}