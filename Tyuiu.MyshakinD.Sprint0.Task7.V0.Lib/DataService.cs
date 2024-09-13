namespace Tyuiu.MyshakinD.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] NumOne, int[] NumTwo)
        {
            int[] ArraysResult = new int[5];
            for (var i = 0; i < ArraysResult.Length; i++)
            {
                ArraysResult[i] = NumOne[i] + NumTwo[i];
            }
            return ArraysResult;
        }

    }
}
