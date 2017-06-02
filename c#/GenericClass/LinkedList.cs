using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericClass
{
    public class LinkedList<T>
    {
        private HashSet<T> _hash = new HashSet<T>();

        public void addNode(T element)
        {
            _hash.Add(element);

        }

        public T getFirstNode()
        {
            T value = default(T);
            if (_hash.Count > 0)
            {
                value = _hash.ElementAt(0);
                _hash.Remove(value);
            }

            return value;
        }

    }

}