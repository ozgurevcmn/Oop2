using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    // Generic class: Box
    class Box<T>
    {
        private T _item;

        public Box(T item)
        {
            _item = item;
        }

        public T GetItem()
        {
            return _item;
        }
    }
}
