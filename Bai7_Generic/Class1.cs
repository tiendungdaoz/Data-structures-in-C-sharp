using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_Generic
{
    internal class MyGeneric<T>
    {
        private T[] items;
        //Ham khoi tao
        public MyGeneric(int size)
        { 
            items = new T[size]; 
        }
        //Property
        public T[] Items { get => items; set => items = value; }
        
        public T GetByInDex(int inDex)
        {
            if (inDex < 0 || inDex > items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return items[inDex];
            }
        }

        public void SetItemsValue(int inDex, T value)
        {
            if (inDex < 0 || inDex > items.Length )
            {
                throw new IndexOutOfRangeException();
            }
            else
            { items[inDex] = value; }
        }
    }
}
