using GenericsAndMethodChaining.EnumsAndConstants;
using GenericsAndMethodChaining.MethodChaining;

namespace GenericsAndMethodChaining;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine(Nationality.Jordanian);

        Console.WriteLine();
        
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("HELLO");


        #region Generics

        Car<int, string> car = new()
        {
            Company = "Toyota",
            Model = "Camry",
            Engine = "Engine",
            Year = 2017
        };

        Engine engine = new() { Name = "Engine name", Capacity = 2000, HorsePower = 210 };

        Car<string, Engine> car1 = new()
        {
            Company = "Toyota",
            Model = "Camry",
            Engine = engine,
            Year = "2017"
        };

        #endregion

        #region Method Chaining

        User user = new User() { name = "Mohammad", age = 15 };

        bool usernameHasS = user.ReturnUserName().Contains("s");

        #endregion


        Console.ReadLine();
    }




    static void GenerateReport(User user)
    {
        ChangeReportTheme(user.Nationality);
        
        //Print report
    }

    static void ChangeReportTheme(Nationality nationality)
    {

        if (nationality == Nationality.Jordanian)
        {
            //print jordan flag
        }
        else if (nationality == Nationality.Palestinian)
        {
            //print palestine flag
        }
        
        
    }
}