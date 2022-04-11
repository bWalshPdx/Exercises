using System.Text;
using FluentAssertions;
using Xunit;

namespace ATOI_DFA;

public class State
{
    public String Input;
    public StringBuilder StringBuilder;
    public int Index;

    
    
    public State(String input, int index)
    {
        StringBuilder = new StringBuilder();
        Input = input;
        Index = index;
    }
}

public enum DFA_State
{
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
        return stateInput;
    }
}



public class Solution_Tests
{
    //TODO: Hard code the state expected output rather than just returning the input:
    [Fact]
    public async Task StartingState_HandleSingleWhitespace()
    {
        Solution solution = new Solution();
        
        State stateInput = new State("", 0);
        //State stateExpectedOutput = new State("", 0);
        State stateExpectedOutput = stateInput;
        
        State output = solution.StartingState(stateInput);

        output.Should().Be(stateExpectedOutput);
    }
}