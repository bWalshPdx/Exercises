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
            int[] line = new int[5] {1, 2, 3, 5, 4};
            int id = 5;
            int expectedCount = 1;

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            int bribeCount = solution.GetBribeCount(line, id);

            bribeCount.Should().Be(expectedCount);
        }

        [Fact]
        public void GetBribeCount_GivenIdAtFrontOfLine_ShouldReturnCorrectBribeCount()
        {
            int[] line = new int[5] { 5, 1, 2, 3, 4 };
            int id = 5;
            int expectedCount = 4;

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            int bribeCount = solution.GetBribeCount(line, id);

            bribeCount.Should().Be(expectedCount);
        }

        [Fact]
        public void GetBribeCount_GivenIdIsFurtherBackInLine_ShouldReturnZeroBribeCount()
        {
            int[] line = new int[5] { 5, 1, 2, 3, 4 };
            int id = 1;
            int expectedCount = 0;

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            int bribeCount = solution.GetBribeCount(line, id);

            bribeCount.Should().Be(expectedCount);
        }

        [Fact]
        public void GetBribeCountForLine_GivenFirstLineInput_ShouldReturnTotalBribeCount()
        {
            int[] line = new int[5] { 2, 1, 5, 3, 4 };
            string id = "1";
            string expectedCount = "3";

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            string bribeCount = solution.GetBribeCountForLine(line);

            bribeCount.Should().Be(expectedCount);
        }

        [Fact]
        public void IsToChaotic_GivenLineIsTooChaotic_ShouldReturnTrue()
        {
            int[] line = new int[5] { 2, 5, 1, 3, 4 };
            
            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            string output = solution.GetBribeCountForLine(line);

            output.Should().Be("Too chaotic");
        }

        [Fact]
        public void IsToChaotic_GivenLineIsValid_ShouldReturnFalse()
        {
            int[] line = new int[5] { 2, 1, 5, 3, 4 };

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            string output = solution.GetBribeCountForLine(line);

            output.Should().NotBe("Too chaotic");
        }

        [Fact]
        public void GetBribeCountForLine_GivenLineIsTooChaotic_ShouldReturnTooChaotic()
        {
            int[] line = new int[5] { 2, 5, 1, 3, 4 };
            

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            string result = solution.GetBribeCountForLine(line);

            result.Should().Be("Too chaotic");
        }

        [Fact]
        public void GetBribeCountForLine_GivenLineWith3Jumps_ShouldReturnThree()
        {
            int[] line = new int[5] { 2, 1, 5, 3, 4 };
            string id = "1";
            string expected = "3";

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            string result = solution.GetBribeCountForLine(line);

            result.Should().Be(expected);
        }

        [Fact]
        public void GetBribeCountForLine_GivenLineWith3Jumps_ShouldReturnSix()
        {
            int[] line = new int[8] { 1, 2, 5, 3, 7, 8, 6, 4 };
            string expected = "7";

            Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
            string result = solution.GetBribeCountForLine(line);

            result.Should().Be(expected);
        }
    }
}
