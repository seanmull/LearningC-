using System;

namespace LearningC_.Generics
{
    //where T : IComparable
    //where T : Product
    //where T : struct
    //where T : class
    //where T : new()
    public class Utilities<T> where T: IComparable, new()

    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomeThing(T value)
        {
            var obj = new T();
        }
        public T Max<T>(T a, T b) where T: IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
            
        }
    }
}