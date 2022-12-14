using Ex._4.Classes;

namespace Ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue<string> queue = new MyQueue<string>();

            queue.Push("Tom");
            queue.Push("Chen");
            queue.Push("Lina");

            queue.Pop();
            queue.Pop();
            
            for(int i = 0; i < queue.Size(); i++)
            {
                Console.WriteLine(queue[i]);
            }
            Console.WriteLine(queue.Size());
        }
    }
}