namespace Hillel_Lesson11_HW;

public class DateTimeGenerator : IDate
{

    private DateTime _dateTime;

    public DateTime DateTime
    {
        get
        {
            return _dateTime;
        }
        set
        {
            _dateTime = value;
        }
    }
    
    
    public DateTime GetCurrentDateTime()
    {
        _dateTime = DateTime.Now;

        return _dateTime;
    }


    public DateTime GetRandomDateTіme()
    {
        Random gen = new Random();
        int range = 5*365;        
        DateTime randomDate = DateTime.Today.AddDays(- gen.Next(range));

        return randomDate;
    }

    public DateTimeGenerator()
    {
        Random rnd = new Random();

        if (rnd.Next() % 2 == 0)
        {
            _dateTime = GetCurrentDateTime();
        }
        else
        {
            _dateTime = GetRandomDateTіme();
        }
    }
}