using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4.Classes
{
    internal class MyQueue<T>
    {
        private T[] _items;

        private int _counter;
       public T this[int index]
        {
            get => _items[index];   
        }
        public MyQueue(int lenghtArray = 4)
        {
            _items = new T[lenghtArray];
        }

        private bool IsEmpty()
        {
            return _counter == 0;
        }

        public void Push(T item)
        {
            if(_counter >= _items.Length)
                Array.Resize(ref _items, _items.Length * 2);
            _items[_counter++] = item;
        }

        public T Pop()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Очередь пуста");

            T result = _items[0];
             Swap();
            _items[--_counter] = default;

            return result;
        }

        private void Swap()
        {
            for (int i = 1; i < _counter; i++)
            {
                _items[i - 1] = _items[i];
            }
        }

        public int Size()
        {
            return _counter;
        }


    }
}
