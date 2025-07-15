using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTraining.cs
{
    //everything generic
    public class GenericClass<T>
    {
        private List<T> genericList = new List<T>();

        public void Push(T item)
        {
            genericList.Add(item);

            foreach(T ite in genericList)
            {
                Console.WriteLine(ite);
            }
        }

        public T Pop()
        {
            if(genericList.Count > 0)
            {
             T poppedItem = genericList[genericList.Count - 1];
             genericList.RemoveAt(genericList.Count - 1);
             return poppedItem;
            }
            return default(T);
           
        }

    }
}
