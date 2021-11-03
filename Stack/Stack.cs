using System.Collections.Generic;

namespace LearningC_.Stack
{
    public class Stack
    {
        private readonly List<object> ObjectsInStack = new List<object>();
       
        void Push(object obj)
        {
            if(obj == null)
                throw new System.InvalidOperationException();

            ObjectsInStack.Add(obj);

        }

        object Pop()
        {
            if(ObjectsInStack.Count <= 0)
                throw new System.InvalidOperationException();

            int lastIndex = ObjectsInStack.Count - 1;
            object ObjectOnTopOfStack = ObjectsInStack[lastIndex];
            ObjectsInStack.RemoveAt(lastIndex);
            return ObjectOnTopOfStack;
        }

         void Clear()
         {
             ObjectsInStack.Clear();
         }

        public override string ToString()
        {
            foreach(object obj in ObjectsInStack)
            {
                System.Console.WriteLine(obj);
            }
            return "";
        }

        // public static void Main(string[] args)
        // {
        //     var stack = new Stack();
        //     stack.Push(3);
        //     stack.Push(2);
        //     stack.Push(1);
        //     stack.Clear();

        //     System.Console.WriteLine(stack.ToString());
        //     // System.Console.WriteLine(stack.Pop());

        //     // System.Console.WriteLine(stack.Pop());
        //     // System.Console.WriteLine(stack.Pop());
        // }




    }
}