using Tyuiu.KosyakovDS.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KosyakovDS.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Substraction(10, 5));
            Console.WriteLine(DataService.Multiplication(10, 5));
            Console.WriteLine(DataService.Division(9, 3));
        }
    }
}