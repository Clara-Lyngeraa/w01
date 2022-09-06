// See https://aka.ms/new-console-template for more information
namespace w01;
public class Program{
    public static void Main(string[] args)
    {
    
        var program = new Program();


        Console.WriteLine(program.LeapYearOrNot(program.getInput(Console.ReadLine())));
        

        
    }

    public int getInput(string input)
    {
        int i = 0;
        if(int.TryParse(input, out i))
        {
            var n = Convert.ToInt32(input);
            return n;
        } else 
        {
            return i;
        }
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
