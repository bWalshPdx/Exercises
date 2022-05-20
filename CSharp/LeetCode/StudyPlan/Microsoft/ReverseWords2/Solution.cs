
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    
    public void ReverseWords(char[] input)
    {
        
    }
    
    
    public void ReverseCharArray(char[] input, int start = 0, int end = -1) 
    {
        if (end == -1)
            end = input.Length - 1;
       
        char temp = ' ';
        
        while (start < end)
        {
            temp =  input[start];
            input[start] = input[end];
            input[end] = temp;
            start++;
            end --;
        }
    }

    
}

public class Solution_Test
{
    [Fact]
    public void ReverseCharArray_Fact1()
    {
        Solution s = new Solution();
        char[] input = {'w', 'o', 'r', 'd'}; 
        char[] expectedOutput = {'d', 'r', 'o', 'w'};
        
        s.ReverseCharArray(input);
        input.Should().Equal(expectedOutput);
    }
    
    [Fact]
    public void ReverseCharArray_Fact2()
    {
        Solution s = new Solution();
        char[] input = {'b', 'l', 'u', 'e'}; 
        char[] expectedOutput = {'e', 'u', 'l', 'b'};
        
        s.ReverseCharArray(input);
        input.Should().Equal(expectedOutput);
    }
    
    [Fact]
    public void ReverseCharArray_Fact3()
    {
        Solution s = new Solution();
        char[] input = {'b', 'l', 'u', 'e', ' ', 'r', 'e', 'd'};
        char[] expectedOutput = { 'e', 'u', 'l', 'b', ' ', 'r', 'e', 'd' };
        
        s.ReverseCharArray(input, 0, 3);
        input.Should().Equal(expectedOutput);
    }
    
    
    [Fact]
    public void ReverseWords_Fact1()
    {
        // Input: s = ["t","h","e"," ","s","k","y"," ","i","s"," ","b","l","u","e"]
        // Output: ["b","l","u","e"," ","i","s"," ","s","k","y"," ","t","h","e"]
        throw new NotImplementedException("Setup test from leet code");
        
        // Solution s = new Solution();
        // char[] input = {'b', 'l', 'u', 'e', ' ', 'r', 'e', 'd'};
        // char[] input = {'1', 'l', 'u', ' ', 'r', 'e', 'd'};
        //
        //
        // s.ReverseWords(input);
        // input.Should().Equal(expectedOutput);
    }
}

