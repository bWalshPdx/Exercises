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
        public void GetBribeCount_GivenIdAtBackOfLine_ShouldReturnCorrectBribeCount()
        {
            string[] line = new string[5] {"1", "2", "3", "5", "4"};
            string id = "5";
            int expectedCount = 1;

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            int bribeCount = solution.GetBribeCount(line, id);

            bribeCount.Should().Be(expectedCount);
        }

        [Fact]
        public void GetBribeCount_GivenIdAtFrontOfLine_ShouldReturnCorrectBribeCount()
        {
            string[] line = new string[5] { "5", "1", "2", "3", "4" };
            string id = "5";
            int expectedCount = 4;

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            int bribeCount = solution.GetBribeCount(line, id);

            bribeCount.Should().Be(expectedCount);
        }

        [Fact]
        public void GetBribeCount_GivenIdIsFurtherBackInLine_ShouldReturnZeroBribeCount()
        {
            string[] line = new string[5] { "5", "1", "2", "3", "4" };
            string id = "1";
            int expectedCount = 0;

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            int bribeCount = solution.GetBribeCount(line, id);

            bribeCount.Should().Be(expectedCount);
        }

        [Fact]
        public void Solution_GivenFirstLineInput_ShouldReturnTotalBribeCount()
        {
            string[] line = new string[5] { "2", "1", "5", "3", "4" };
            string id = "1";
            int expectedCount = 3;

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            int bribeCount = solution.GetBribeCountForLine(line);

            bribeCount.Should().Be(expectedCount);
        }

    }
}
