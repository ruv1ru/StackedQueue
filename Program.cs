using System.Collections;
using System;

namespace datastructdemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var q = new StackedQueueDemo();
            q.EnQueue(22);
            q.EnQueue(55);
            Console.WriteLine(q.DeQueue());
            q.EnQueue(11);
            Console.WriteLine(q.DeQueue());
            Console.WriteLine(q.DeQueue());

        }

    }

    public class StackedQueueDemo
    {
         public   Stack stack1;
         public   Stack stack2;

         public StackedQueueDemo()
         {
             stack1 = new Stack();
             stack2 = new Stack();
         }

        public void EnQueue(int i){
            stack1.Push(i);
        }
        public object DeQueue() {

            while(stack1.Count > 0) {
                stack2.Push(stack1.Pop());
            }

            var deQueueObj = stack2.Pop();

            while(stack2.Count > 0) {
                stack1.Push(stack2.Pop());
            }


            return deQueueObj;
        }
    }
}
