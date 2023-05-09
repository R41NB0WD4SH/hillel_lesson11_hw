namespace Hillel_Lesson11_HW;

public class NamesGenerator : IName
{
    private string _name;
    
    public string Name
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

    public NamesGenerator(string[] allNames)
    {
        Random rnd = new Random();

        int position = rnd.Next(0, allNames.Length);

        _name = allNames[position];
    }
}