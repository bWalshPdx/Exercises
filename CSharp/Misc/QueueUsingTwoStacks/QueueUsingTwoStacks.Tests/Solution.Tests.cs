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

        #region ManipulateQueue-Tests

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

            output.Should().Equal(new List<string>(){"2", "3", "4"});
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

        [Fact]
        public void Print_GivenPopulatedQueue_ShouldReturnCorrectValue()
        {
            List<string> testValues = new List<string>() { "2", "3", "4" };

            ManipulateQueue manipulateQueue = new ManipulateQueue();

            foreach (var value in testValues)
            {
                manipulateQueue.Enqueue(value);
            }

            string output = manipulateQueue.GetHeadValue();

            output.Should().BeEquivalentTo("2");
        }


        #endregion

        #region QueueUsingTwoStacks.Tests

        [Fact]
        public void Solve_GivenTestCase0_ShouldReturnTheCorrectValues()
        {
            List<string> input = new List<string>()
            {
                "1 42",
                "2",
                "1 14",
                "3",
                "1 28",
                "3",
                "1 60",
                "1 78",
                "2",
                "2"
            }; 

            List<string> expectedOutput = new List<string>()
            {
                "14",
                "14",
            };

            List<string> output = Solution.Solve(input);

            output.Should().BeEquivalentTo(expectedOutput);
        }

        [Fact]
        public void Solve_GivenTestCase1_ShouldReturnTheCorrectValues()
        {
            List<string> input = new List<string>()
            {
                "1 76",
                "1 33",
                "2",
                "1 23",
                "1 97",
                "1 21",
                "3",
                "3",
                "1 74",
                "3"
            };

            List<string> expectedOutput = new List<string>()
            {
                "33",
                "33",
                "33"
            };

            //Solution solution = new Solution();

            List<string> output = Solution.Solve(input);

            output.Should().BeEquivalentTo(expectedOutput);
        }

        #endregion
    }
}