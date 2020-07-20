using System;
using System.Collections.Generic;

namespace QueueUsingTwoStacks
{
    public class Solution
    {
        static void Main(String[] args)
        {
            List<string> input = HackerRankIo.ReceiveInput();
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            var output = Solve(input);

            HackerRankIo.ReturnOutput(output);
        }


        public static List<string> Solve(List<string> input)
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

        public void Enqueue(string value)
        {
            

            if (Head == null)
            {
                Head = new Custom_Queue() { Value = value};
            }
            else
            {
                


                Custom_Queue newTail = Head.DeepCopy();
                //Create new Head w/ No Tail:
                Head = new Custom_Queue() { Value = value, Next = newTail };
            }
        }


        public string Dequeue()
        {
            string output = Head.Value;

            if (Head.Next != null)
            {
                Head = Head.Next;
            }
            else
            {
                Head = null;
            }

            return output;
        }

        public string GetHeadValue()
        {
            //This is a performance hit:
            Custom_Queue currentNode = Head;
            string output;

            do
            {
                output = currentNode.Value;

                currentNode = currentNode.Next;
            } while (currentNode != null);

            return output;
        }
    }

    public static class HackerRankIo
    {
        public static List<string> ReceiveInput()
        {
            int elementsInputted = Int32.Parse(System.Console.ReadLine());

            List<string> input = new List<string>();

            for (int i = 0; i < elementsInputted; i++)
            {
                input.Add(System.Console.ReadLine());
            }

            return input;
        }

        public static void ReturnOutput(List<string> output)
        {
            foreach (var currentOutput in output)
            {
                System.Console.WriteLine(currentOutput);
            }
        }
    }

}
