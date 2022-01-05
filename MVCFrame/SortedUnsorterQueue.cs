using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;
using Structures;
namespace MVCFrame
{
    class SortedUnsorterQueue<T> : IQueueable<T>
        where T : IComparable<T>
    {
        public int Count {
            get;
            set;
        }
        private IQueueable<T> sorted;
        private IQueueable<T> unsorted;

        public SortedUnsorterQueue() {
            sorted = new PriorityQueue<T, SortedLinkedList<T>>(new SortedLinkedList<T>());
            unsorted = new FIFOQueue<T, QueueableLinkedList<T>>(new QueueableLinkedList<T>());
            Count = 0;
        }
        public IQueueable<T> Sorted
        {
            get
            {
                return sorted;
            }
        }
        public IQueueable<T> Unsorted
        {
            get
            {
                return unsorted;
            }
        }
        public IQueueable<T> Sort ()
        {
            while (unsorted.Count !=0)
            {
                sorted.Put(unsorted.Item());
                unsorted.Remove();
            }
            return this;
        }

        public T Item()
        {
            if (sorted.Count == 0)
                this.Sort();
            return sorted.Item();
        }

        public IQueueable<T> Put(T value)
        {
            unsorted.Put(value);
            Count++;
            return this;
        }

        public IQueueable<T> Clear()
        {
            sorted.Clear();
            unsorted.Clear();
            Count = 0;
            return this;
        }

        public IQueueable<T> Remove()
        {
            sorted.Remove();
            Count--;
            return this;
        }

        public T[] ToArray()
        {
            T[] res = new T[sorted.Count + unsorted.Count];
            T[] sArr = sorted.ToArray();
            T[] unArr = unsorted.ToArray();
            sArr.CopyTo(res, 0);
            unArr.CopyTo(res, sorted.Count);
            return res;
        }
    }
}
