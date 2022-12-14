namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[] { 3, 2, 1, 0, -1};

            int[] arrayNumbers1 = new int[] { 43, 12, 4, 0, -1, -9, -12, -87};

            int[] reversArrayNumber;

            ArrayWorker arrayWorker = new ArrayWorker();

            reversArrayNumber = arrayWorker.Reverse(arrayNumbers);

            arrayWorker.PrintArray(reversArrayNumber);

            Console.WriteLine();

            reversArrayNumber = arrayWorker.Reverse(arrayNumbers1);

            arrayWorker.PrintArray(reversArrayNumber);

        }

    }


}