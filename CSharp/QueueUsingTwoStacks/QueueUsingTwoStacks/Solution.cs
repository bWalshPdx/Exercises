using System;
using System.Collections.Generic;

namespace QueueUsingTwoStacks
{
    public class Solution
    {
        public List<string> Solve(List<string> input)
        {
            List<string> output = new List<string>();

            ManipulateQueue manipulateQueue = new ManipulateQueue();

            foreach (var currentInput in input)
            {
                string operationCode;
                string newValue = "";


                string[] splitInput = currentInput.Split(' ');

                operationCode = splitInput[0];

                if (splitInput.Length > 1)
                {
                    newValue = splitInput[1];
                }

                switch (operationCode)
                {
                    case "1":
                        manipulateQueue.Enqueue(newValue);
                        break;
                    case "2":
                        manipulateQueue.Dequeue();
                        break;
                    case "3":
                        output.Add(manipulateQueue.GetHeadValue());
                        break;

                }

            }

            return output;
        }
    }

    public class Custom_Queue
    {
        public string Value { get; set; }
        public Custom_Queue Next { get; set; }

        /// <summary>
        /// I need to make a copy that is not a reference:
        /// </summary>
        /// <returns></returns>
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

        public string GetHeadValue()
        {
            return Head.Value;
        }
    }

}
