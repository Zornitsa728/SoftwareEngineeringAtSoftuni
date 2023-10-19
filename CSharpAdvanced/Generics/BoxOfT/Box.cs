using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }
        public int Count { get { return list.Count; } }

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Remove()
        {
            T lastEl = list[Count - 1];

            list.RemoveAt(Count - 1);

            return lastEl;
        }
    }
}
