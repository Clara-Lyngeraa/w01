// See https://aka.ms/new-console-template for more information
namespace w01;
public class Program{
    public static void Main(string[] args)
    {
    
        var program = new Program();

        var input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(program.LeapYearOrNot(input));
        

        
    }
    public bool isLeapYear(int year)
    {
        
        if(year % 4 == 0){
             if(year % 100 == 0)
            {
             return false;
            } else 
            {
                return true;
            }
        } 
        return false;
    }

    public string LeapYearOrNot(int year)
    {
        if(year < 1582){
            return "Neeeeeeeeeej for tideligt";
    
        }
        if(year % 4 == 0){
             if(year % 100 == 0)
            {
             return "nay";
            } else 
            {
                return "yay";
            }
        } 
        return "nay";
    }
}
