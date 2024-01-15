using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackLinkedList
{
    public interface Interface1
    {
        /// <summary>
        /// Adds value to list appropriately for a stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(string value);

        public int Pop();

        public bool IsEmpty();

        int Size();


        public object Peek();

    }
}
