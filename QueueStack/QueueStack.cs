using System.Collections;
using System.Linq;

namespace QueueStack
{
    public class QueueStack<T>
    {
        private Stack<T> _collection;
        public QueueStack()
        {
            _collection = new Stack<T>();
        }

        public void Push(T item)
        {
            _collection.Push(item);
        }

        public T Pop()
        {
            var currentLength = Size();
            var result = default(T);

            if (currentLength > 0)
            {
                result = _collection.ElementAt<T>(0);
                var tempCollection = _collection.ToArray();
                _collection.Clear();

                for (var i = 1; i < currentLength; i++)
                {
                    Push(tempCollection[i]);
                }
            }

            return result;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public int Size()
        {
            return _collection == null ? 0 : _collection.Count;
        }

        public void PrintQueueStack()
        {
            if (Size() > 0)
            {
                foreach (var item in _collection)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}