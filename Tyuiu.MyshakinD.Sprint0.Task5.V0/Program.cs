using Tyuiu.MyshakinD.Sprint0.Task5.V0.Lib;
namespace Tyuiu.MyshakinD.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(8, 7));
            Console.WriteLine(DataService.Substraction(15, 8));
            Console.WriteLine(DataService.Multiplication(12, 12));
            Console.WriteLine(DataService.Division(225, 15));

            Console.WriteLine(DataService.Division(5, 0));

            Console.ReadKey();
        }
    }
}
