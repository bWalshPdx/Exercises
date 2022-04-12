using System.Text;
using FluentAssertions;
using Xunit;

namespace ATOI_DFA;

public class State
{
    public string Input { get; set; }
    public StringBuilder StringBuilder { get; set; }
    public int Index { get; set; }
    public DFA_State NextState { get; set; }

    public State()
    {
    }
    
    public State(String input)
    {
        StringBuilder = new StringBuilder();
        Input = "";
        NextState = DFA_State.Start;
    }
}

public enum DFA_State
{
    Start,
    End
}

public class Solution
{
    public int MyAtoi(string input)
    {
        return 0;
    }
    
    public State StartingState(State stateInput)
    {
        char[] inputChars = stateInput.Input.ToCharArray();
        //Handle Whitespace:

        if (inputChars.Length < stateInput.Index)
            stateInput.NextState = DFA_State.End;
        else if (inputChars[stateInput.Index] == ' ')
            stateInput.NextState = DFA_State.Start;


        throw new NotImplementedException("Write up the next state logic with the index increment");


        return new State()
        {
            Input = stateInput.Input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.End
        };
    }
}


public class Solution_Tests
{
    //TODO: Hard code the state expected output rather than just returning the input:
    [Fact]
    public async Task StartingState_HandleSingleWhitespace()
    {
        Solution solution = new Solution();
        string input = "";
        
        State stateInput = new State("");
        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.End
        };
        
        State output = solution.StartingState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }


    [Fact]
    public async Task StartingState_HandleMultipleWhitespaces()
    {
        Solution solution = new Solution();
        string input = " ";

        State stateInput = new State(input);
        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.Start
        };

        State output = solution.StartingState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }
}