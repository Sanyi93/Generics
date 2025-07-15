using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment1.cs
{
    public class GenericStack<T>
    {

        private List<T> _myStack = new List<T>();

        public void AddItem(T item)
        {
            _myStack.Add(item);

        }

        public T RemoveItem()
        {
            if(_myStack.Count > 0)
            {
                T removedItem = _myStack[_myStack.Count - 1];
                _myStack.RemoveAt(_myStack.Count - 1);
                return removedItem;
            }
            throw new InvalidOperationException("Nothing to remove, the stack is empty");
        }

        public void DisplayIt()
        {
            Console.WriteLine("The following elements are in the stack now: ");
            foreach (T item in _myStack)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
