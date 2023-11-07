using Newtonsoft.Json;

namespace class_1.Managers;

public class CarsDatabase
{
    private static string path ="C:\\Users\\shadi\\Desktop\\cars.json";
    
    
    public static void CreateFile()
    {
        bool fileExists = File.Exists(path);
        if (fileExists == false)
        {
            File.AppendAllText(path, "");
            SetupFile();
        }
    }

    public static void AddCar(Car car)
    {
        List<Car> myCars = ReadFile();
        myCars.Add(car);

        string allCars = JsonConvert.SerializeObject(myCars);
        WriteFile(allCars);

    }

    private static void SetupFile()
    {
        List<Car> cars = new();
        string carsJson = JsonConvert.SerializeObject(cars);
        WriteFile(carsJson);
    }

    public static List<Car> ReadFile()
    {
        var content = File.ReadAllText(path);
        List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(content);
        return cars;
    }

    public static void WriteFile(string json)
    {
        File.WriteAllText(path, json);
    }
}