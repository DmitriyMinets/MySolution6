using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4.Classes
{
    internal class Queue
    {
        private string[] _items;

        private const int _lenghtArray = 4;

        private int _counter;

        public string this[int index]
        {
            get => _items[index];   
        }

        public Queue()
        {
            _items = new string[_lenghtArray];
        }

        public Queue(int lenghtArray)
        {
            _items = new string[lenghtArray];
        }

        private bool IsEmpty()
        {
            return _counter == 0;
        }

        public void Push(string item)
        {
            if(_counter >= _items.Length)
                Array.Resize(ref _items, _items.Length * 2);
            _items[_counter++] = item;
        }

        public string Pop()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Очередь пуста");

            string result = _items[0];
            _items[0] = null;
            Swap();
            _counter--;

            return result;
        }

        private void Swap()
        {
            for (int i = 1; i < _items.Length; i++)
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
