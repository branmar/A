using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Generics
{
    public class GenericRepository<T> where T : Entity, IRepository<T>
    {
        List<T> TList = new List<T>();
        public void Add(T item)
        {
            TList.Add(item);
        }
        public void Remove(T id)
        {
            TList.Remove(id);
        }
        public void Save()
        {
            Console.WriteLine();
        }
        public IEnumerable<T> GetAll()
        {
            return TList;
        }

        public T? GetById(int item)
        {
            for (int i = 0; i < TList.Count; i++)
            {
                if (TList[i].Id == item)
                {
                    return TList[i];
                }
            }
            return null;
        }


    }
}
