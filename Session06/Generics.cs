using Session06.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06
{
    internal class Generics
    {
        public void getXyz<T>(T a, T b)
        {
            //
        }
        public Generics()
        {
            var stack = new Stack();
            stack.Push(10);
            stack.Push(9);
            stack.Push(15);

            var a = stack.Pop();
            //a = 15

            var stack2 = new StackGeneric<int>();
            stack2.Push(10);
            stack2.Push(9);
            stack2.Push(15);

            var a2 = stack.Pop();


            var stack3 = new StackGeneric<Country>();

        }
    }


    public class StackGeneric<T> 
    {
        List<T> data = new List<T>();

        public void Push(T a)
        {
            data.Add(a);
        }

        public T Pop()
        {
            var result = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return result;
        }
    }

    public class Stack
    {
        List<int> data  = new List<int>();

        public void Push(int a)
        {
            data.Add(a);
        }

        public int Pop()
        {
            var result = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return result;
        }
    }

    public class StackString
    {
        List<string> data = new List<string>();

        public void Push(string a)
        {
            data.Add(a);
        }

        public string Pop()
        {
            var result = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return result;
        }
    }
}
