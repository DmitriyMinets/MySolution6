using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3.Classes
{
    internal class MyStack<T>
    {
        private T[] _items;

        private int counter;
        public T this[int index] 
        {
            get => _items[index];
        }

        public MyStack(int lenghtArray = 4)
        {
            _items = new T[lenghtArray];
        }

        private bool IsEmpty()
        {
             return counter == 0; 
        }

        public void Push(T item)
        {
            if(counter >= _items.Length)
                Array.Resize(ref _items, _items.Length * 2);
            _items[counter] = item;
            counter++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Стек пуст");
            counter--;
            T result = _items[counter];
            _items[counter] = default;
            return result;
        }

        public int Size()
        {
            return counter;
        }

    }
}
