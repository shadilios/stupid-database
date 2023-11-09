namespace GenericsAndMethodChaining.Inheritance;

public class DatabaseManager : IDatabaseManager
{
    public void AddData(object data)
    {
        //add data
    }
    
    public string GetData(string dataName)
    {
        //return data
        return "";
    }
    
    public void AddDataArray(object[] objects)
    {
        //add data objects
    }
    
    public object[] GetDataArray(string dataName)
    {
        return default;
    }
    
    public void DeleteData(string dataName)
    {
        //delete my data
    }
}