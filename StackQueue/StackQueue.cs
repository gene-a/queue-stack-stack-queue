using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class StackQueue<T>
    {
        private Queue<T> _collection;

        public StackQueue()
        {
            _collection = new Queue<T>();
        }

        public void Enqueue(T item)
        {
            _collection.Enqueue(item);
        }

        public T Dequeue()
        {
            var result = default(T);
            var currentLength = Size();

            if (currentLength > 0)
            {
                result = _collection.ElementAt<T>(0);
                var tempCollection = _collection.ToArray();
                _collection.Clear();

                for (var i = 1; i < currentLength; i++)
                {
                    Enqueue(tempCollection[i]);
                }   

            }

            return result;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public long Size()
        {
            return _collection == null ? 0 : _collection.Count;
        }

        public void PrintStackQueue()
        {
            if (Size() > 0)
            {
                foreach(var item in _collection)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
