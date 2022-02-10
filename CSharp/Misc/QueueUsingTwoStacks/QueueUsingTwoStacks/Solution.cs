using System;
using System.Collections.Generic;
using System.Globalization;

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
        public Custom_Queue Tail { get; set; }

    }

    public class ManipulateQueue
    {
        private Custom_Queue Head;
        private Custom_Queue Last_Node;

        public void Enqueue(string value)
        {
            if (Last_Node == null)
            {
                Last_Node = new Custom_Queue() { Value = value };
                Head = Last_Node;
                return;
            }

            Last_Node.Tail = new Custom_Queue() { Value = value };
            Last_Node = Last_Node.Tail;
        }


        public string Dequeue()
        {
            string output = Head.Value;

            if (Head.Tail != null)
            {
                Head = Head.Tail;
            }
            else
            {
                Head = null;
                Last_Node = null;
            }

            return output;
        }

        public string GetHeadValue()
        {
            return Head.Value;
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
