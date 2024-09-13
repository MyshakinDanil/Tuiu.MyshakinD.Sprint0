using Tyuiu.MyshakinD.Sprint0.Task6.V0.Lib;
namespace Tyuiu.MyshakinD.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 1, 2, 3, 4, 5};

            Console.WriteLine("Сумма элементов равна " + DataService.AdditionArray(numArray));
            Console.WriteLine("Разность элементов равна " + DataService.SubstractionArray(numArray));
            Console.WriteLine("Произведение элементов равна " + DataService.MultiplicationArray(numArray));

            Console.ReadKey();
        }
    }
}
