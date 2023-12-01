using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class Stack<T>
    {
        public int position { get; set; }
        public T[] data = new T[100];

        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];

    }

    public class StackMethod
    {
        public static void Swap<U>(ref U a, ref U b)
        {
            U temp = a;
            a = b;
            b = temp;
        }
    }

}
