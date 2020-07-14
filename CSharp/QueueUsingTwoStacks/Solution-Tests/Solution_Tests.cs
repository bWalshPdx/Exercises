using System;
using FluentAssertions;
using QueueUsingTwoStacks;
using Xunit;

namespace Solution_Tests
{
    public class Solution_Tests
    {
        [Fact]
        public void Initialize_GivengARecievedValue_ShouldAddValueToTheStack()
        {
            string testValue = "0";

            Custom_Queue queue = new Custom_Queue(testValue);

            string value = queue.Dequeue();

            value.Should().BeEquivalentTo(testValue);
        }
    }
}
