using class_1.Managers;

namespace class_1;

internal class Program
{
    static void Main(string[] args)
    {
        //Returns the path to the user profile folder
        string windowsUserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        
        CarsDatabase.CreateFile();

        Car car1 = new Car()
        {
            Company = "Mitsubishi",
            Year = "2016"
        };
        
        CarsDatabase.AddCar(car1);



    }
    
}