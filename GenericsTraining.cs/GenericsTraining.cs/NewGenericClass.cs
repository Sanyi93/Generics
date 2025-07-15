using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTraining.cs
{
    public class NewGenericClass<T>
    {
        private List<T> newGenericList = new List<T>();

        public void PushIt (T item)
        {
            newGenericList.Add(item);

            foreach(T ite in newGenericList)
            {
                Console.WriteLine(ite);
            }
        }

        public T PopIt()
        {
            if(newGenericList.Count > 0)
            {
                T poppedItem = newGenericList[newGenericList.Count - 1];
                newGenericList.RemoveAt(newGenericList.Count - 1);
                return poppedItem;
            }
            return default(T);
        }
    }
}
