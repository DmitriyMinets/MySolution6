namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[] { 3, 2, 1, 0, -1 };

            int[] reversArrayNumber;

            ArrayWorker arrayWorker = new ArrayWorker();

            reversArrayNumber = arrayWorker.Reverse(arrayNumbers);

            foreach (int i in reversArrayNumber)
            {
                Console.Write(i + " ");
            }


            


        }
    }


}