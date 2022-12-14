using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3.Classes
{
    internal class Stack
    {
        private string[] _items;

        private int counter;

        private const int lenghtArray = 4;

        public string this[int index]
        {
            get => _items[index];
        }

        public Stack()
        {
            _items = new string[lenghtArray];
        }

        public Stack(int lenghtArray)
        {
            _items = new string[lenghtArray];
        }

        private bool IsEmpty()
        {
             return counter == 0; 
        }

        public void Push(string item)
        {
            if(counter >= _items.Length)
                Array.Resize(ref _items, _items.Length * 2);
            _items[counter] = item;
            counter++;
        }

        public string Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Стек пуст");
            counter--;
            string result = _items[counter];
            _items[counter] = null;
            return result;
        }

        public int Size()
        {
            return counter;
        }

    }
}
