using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Generics
{
    public class MyStack<T>
    {
        Stack<T> TStack = new Stack<T>();
        public int Count { get; }
        public T Pop() => TStack.Pop();
        public void Push(T element)
        {
            TStack.Push(element);
        }
    }
}
