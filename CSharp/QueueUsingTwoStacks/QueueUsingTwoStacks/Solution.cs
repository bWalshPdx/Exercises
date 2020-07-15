using System;

namespace QueueUsingTwoStacks
{
    public class Solution
    {
        
    }

    

    public class Custom_Queue
    {
        private ValueTuple<string, ValueTuple> Head { get; set; }

        private ValueTuple<string, ValueTuple> Tail { get; set; }


        public void Enqueue(string value)
        {

            if(!String.IsNullOrEmpty(Head.Item1))
            {
                Head = (value, Head);
            }
        }


        public string Dequeue()
        {
            string output = Value;

            if (Next != null)
            {
                Value = Next.Dequeue();
            }

            return output;
        }
    }
}
