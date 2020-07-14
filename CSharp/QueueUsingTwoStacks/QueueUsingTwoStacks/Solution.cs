using System;

namespace QueueUsingTwoStacks
{
    public class Solution
    {

    }

    public class Custom_Queue
    {
        private string Value { get; set; }
        private Custom_Queue Next { get; set; }

        public Custom_Queue(string value)
        {
            Value = value;
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
