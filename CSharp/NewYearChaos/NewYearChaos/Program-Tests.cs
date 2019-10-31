using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MyNamespace;
using Xunit;

namespace NewYearChaos
{
    public class ProgramTests
    {
        [Fact]
        public void GetBribeCount_ShouldReturnCorrectBribeCount()
        {
            string[] line = new string[5] {"1", "2", "3", "5", "4"};
            string id = "5";
            int expectedCount = 1;

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            int bribeCount = solution.GetBribeCount(line, id);

            bribeCount.Should().Be(expectedCount);
        }
    }
}
