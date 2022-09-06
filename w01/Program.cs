// See https://aka.ms/new-console-template for more information
namespace w01;
public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
    }
    public bool isLeapYear(int year)
    {
        if(year % 4 == 0){
            return true;
        } 
        return false;
    }
}
