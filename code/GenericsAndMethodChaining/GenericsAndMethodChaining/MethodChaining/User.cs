using GenericsAndMethodChaining.EnumsAndConstants;

namespace GenericsAndMethodChaining.MethodChaining;

public class User
{
    public string name;
    public int age;
    public Nationality Nationality;
    
    public int ReturnUserAge()
    {
        return this.age;
    }

    public string ReturnUserName()
    {
        return this.name;
    }
}