using System;
using QueueUsingTwoStacks;
using Xunit;

namespace Solution_Tests
{
    public class Solution_Tests
    {
        [Fact]
        public void Initialize_WhenRecievingAValue_ShouldAddValueToTheStack()
        {
            string testValue = "0";

            Custom_Queue queue = new Custom_Queue(testValue);

        }
    }
}
