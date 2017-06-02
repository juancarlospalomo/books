using System;

namespace GenericClass
{

    public class Queue
    {
        private object[] _queue;
        private int _capacity;
        private int _header = -1;
        private int _tail = -1;

        public Queue(int capacity)
        {
            _capacity = capacity;
            _queue = new object[capacity];
        }

        private bool isEmpty
        {
            get
            {
                return _header == -1;
            }
        }

        private void fitPointers()
        {
            if (_header > _tail)
            {
                _header = 0;
                _tail = 0;
            }

            if (_header >= _capacity)
            {
                _header = 0;
            }
            if (_tail <= 0)
            {
                _tail = _capacity;
            }
        }

        public void Push<T>(T value)
        {
            if (isEmpty)
            {
                _tail = 0;
                _header = 0;
            }
            _queue[_tail] = value;
            _tail++;
            fitPointers();
        }

        public T Pop<T>()
        {
            T value = default(T);
            if (!isEmpty)
            {
                value = (T)_queue[_header];
                _queue[_header] = default(T);
                _header++;
                fitPointers();
            }
            return value;
        }

    }

}