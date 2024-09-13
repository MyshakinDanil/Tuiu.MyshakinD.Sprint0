using Tyuiu.MyshakinD.Sprint0.Task7.V0.Lib;
namespace Tyuiu.MyshakinD.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0, выполнил Мышакин Д., ПКТб-24-1";
            int[] ArrayNum1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение первого массива:");
            for (var i = 0; i < ArrayNum1.Length; i++)
            {
                Console.WriteLine(ArrayNum1[i] + " ");
            }
            int[] ArrayNum2 = new int[] { 7, 11, 2, 9, 3 };
            Console.WriteLine("Значение второго массива:");
            for (var i = 0; i < ArrayNum2.Length; i++)
            {
                Console.WriteLine(ArrayNum2[i] + " ");
            }
            if (ArrayNum1.Length == ArrayNum2.Length)
            {
                int[] ResultArray = DataService.AdditionArrays(ArrayNum1, ArrayNum2);
                for (var i = 0; i < ResultArray.Length; i++)
                {
                    Console.Write(ResultArray[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исхлдные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}
