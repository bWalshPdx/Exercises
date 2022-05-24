
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    
    public void ReverseWords(char[] input)
    {
        // input[0] = 'd';
        // input[1] = 'e';
        // input[2] = 'r';

        ReverseCharArray(input);
        
        var wordIndexes = GetEndOfWordIndexes(input);
        int wordStartIndex = 0;
        int wordEndIndex = 0;
        
        while (wordIndexes.Any())
        {
            wordEndIndex = wordIndexes.First();
            
            ReverseCharArray(input, wordStartIndex, wordEndIndex);

            wordIndexes.RemoveAt(0);

            wordStartIndex = wordEndIndex + 2;
        }
        
        
        

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


    public List<int> GetEndOfWordIndexes(char[] input)
    {
        List<int> endOfWordIndexes = new List<int>();

        int currentIndex = 0;
        while (true)
        {
            if(input[currentIndex] == ' ')
                endOfWordIndexes.Add(currentIndex - 1);

            if (currentIndex == input.Length - 1)
            {
                endOfWordIndexes.Add(currentIndex);
                return endOfWordIndexes;
            }
            
            currentIndex++;
        }

        throw new Exception("This should never be thrown");
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
    
    
    //[Fact(Skip = "Not ready for this yet")]
    [Fact]
    public void ReverseWords_Fact1()
    {
         Solution s = new Solution();
         char[] input = {'t','h','e',' ','s','k','y',' ','i','s',' ','b','l','u','e'};
         char[] expectedOutput = {'b','l','u','e',' ','i','s',' ','s','k','y',' ','t','h','e'};

         s.ReverseWords(input);
         input.Should().Equal(expectedOutput);
    }
    
    [Fact]
    public void ReverseWords_Fact2()
    {
        Solution s = new Solution();
        char[] input = {'r','e','d'};
        char[] expectedOutput = {'r','e','d'};

        s.ReverseWords(input);
        input.Should().Equal(expectedOutput);
    }
    
    
    [Fact]
    public void FindEndOfWords_Fact1()
    {
        Solution s = new Solution();
        char[] input = {'t','h','e',' ','s','k','y',' ','i','s',' ','b','l','u','e'};
        int[] expectedOutput = { 2, 6, 9, 14 };

        List<int> output = s.GetEndOfWordIndexes(input);
        output.Should().Equal(expectedOutput);
    }
    
    [Fact]
    public void FindEndOfWords_Fact2()
    {
        Solution s = new Solution();
        char[] input = {'b', 'l', 'u', 'e', ' ', 'r', 'e', 'd'};
        int[] expectedOutput = { 3, 7 };

        List<int> output = s.GetEndOfWordIndexes(input);
        output.Should().Equal(expectedOutput);
    }
    
    [Fact]
    public void FindEndOfWords_Fact3()
    {
        Solution s = new Solution();
        char[] input = {'d', 'e', 'r'};
        int[] expectedOutput = { 2 };

        List<int> output = s.GetEndOfWordIndexes(input);
        output.Should().Equal(expectedOutput);
    }
    
    
    [Fact]
    public void FindEndOfWords_Fact4()
    {
        Solution s = new Solution();
        char[] input = {'t','h','e',' ','s','k','y',' ','i','s',' ','b','l','u','e'};
        s.ReverseCharArray(input);
        
        int[] expectedOutput = { 3, 6, 10, 14 };

        List<int> output = s.GetEndOfWordIndexes(input);
        output.Should().Equal(expectedOutput);
    }
}

