using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Generics
{
    public class MyList<T>
    {
        List<T> TList = new List<T>();
        public void Add(T element)
        {
            TList.Add(element);
        }
        public T Remove(int index)
        {
            return TList[index];
        }
        public bool Contains(T element)
        {
            return TList.Contains(element);
        }
        public void Clear()
        {
            TList.Clear();
        }
        public void InsertAt(T element, int index)
        {
            TList[index] = element;
        }
        public void DeleteAt(int index)
        {
            TList.RemoveAt(index);
        }
        public T Find(int index)
        {
            T element = TList[index];
            return element;
        }
    }
}
