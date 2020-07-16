using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using QueueUsingTwoStacks;
using Xunit;

namespace Solution_Tests
{
    public class Solution_Tests
    {
        [Fact]
        public void Initialize_GivenARecievedValue_ShouldAddValueToTheStack()
        {
            string testValue = "0";

            ManipulateQueue manipulateQueue = new ManipulateQueue();

            manipulateQueue.Enqueue(testValue);

            string value = manipulateQueue.Dequeue();

            value.Should().BeEquivalentTo(testValue);
        }

        [Fact]
        public void Enqueue_GivenARecievedValue_ShouldAddValueToTheStack()
        {
            string testValue = "0";

            ManipulateQueue manipulateQueue = new ManipulateQueue();

            manipulateQueue.Enqueue(testValue);

            string value = manipulateQueue.Dequeue();

            value.Should().BeEquivalentTo(testValue);
        }

        [Fact]
        public void Dequeue_GivenAValueCollection_ShouldReturnTheCorrectValues()
        {
            List<string> testValues = new List<string>(){"2", "3", "4"};

            ManipulateQueue manipulateQueue = new ManipulateQueue();


            foreach (var value in testValues)
            {
                manipulateQueue.Enqueue(value); 
            }

            List<string> output = new List<string>();

            foreach (var value in testValues)
            {
                string returnedValue = manipulateQueue.Dequeue();

                output.Add(returnedValue);
            }

            output.Should().BeEquivalentTo(new List<string>(){"4", "3", "2"});
        }

        /// <summary>
        /// Overkill test of both Enqueue and Dequeue
        /// </summary>
        [Fact]
        public void ManipulateQueue_GuidingTest()
        {
            List<string> testInput = Enumerable.Range(0, 100).Select(i => i.ToString()).ToList();

            ManipulateQueue manipulateQueue = new ManipulateQueue();

            List<string> output = new List<string>();

            foreach (var value in testInput)
            {
                manipulateQueue.Enqueue(value);
            }

            foreach (var value in testInput)
            {
                string returnedValue = manipulateQueue.Dequeue();

                output.Add(returnedValue);
            }

            testInput.Reverse();

            output.Should().BeEquivalentTo(testInput);

        }
    }
}