using Ex._3.Classes;

namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();

            stack.Push("Lena");
            stack.Push("Dima");
            stack.Push("Yura");

            stack.Pop();
            stack.Pop();

            for (int i = 0; i < stack.Size(); i++)
            {
                Console.WriteLine(stack[i]);
            }




        }
    }
}