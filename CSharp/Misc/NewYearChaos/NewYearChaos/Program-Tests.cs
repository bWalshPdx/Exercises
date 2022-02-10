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
        
        //[Fact]
        //public void IsToChaotic_GivenLineIsValid_ShouldReturnFalse()
        //{
        //    int[] line = new int[5] { 2, 1, 5, 3, 4 };

        //    Solution.New_Year_Chaos solution = new Solution.New_Year_Chaos();
        //    string output = solution.GetBribeCountForLine(line);

        //    output.Should().NotBe("Too chaotic");
        //}

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
