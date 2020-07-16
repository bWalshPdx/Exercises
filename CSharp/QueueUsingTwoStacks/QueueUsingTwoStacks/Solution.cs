﻿using System;

namespace QueueUsingTwoStacks
{
    public class Solution
    {
        
    }

    

    public class Custom_Queue
    {
        public string Value { get; set; }
        public Custom_Queue Next { get; set; }

        public Custom_Queue DeepCopy()
        {
            return (Custom_Queue) this.MemberwiseClone();
        }
    }

    public class ManipulateQueue
    {
        private Custom_Queue Head { get; set; }

        public ManipulateQueue()
        {
            Head = new Custom_Queue();
        }

        public void Enqueue(string value)
        {
            Custom_Queue newTail = Head.DeepCopy();
            //Create new Head w/ No Tail:
            Head = new Custom_Queue(){Value = value, Next = newTail };
        }


        public string Dequeue()
        {
            string output = Head.Value;

            if (Head.Next != null)
            {
                Head = Head.Next;
            }

            return output;
        }
    }

}
