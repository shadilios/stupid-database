namespace GenericsAndMethodChaining.Inheritance;

public interface IDatabaseManager
{
    public  void AddData(object data);

    public  string GetData(string dataName);

    public  void AddDataArray(object[] objects);

    public  object[] GetDataArray(string dataName);

    public  void DeleteData(string dataName);
}