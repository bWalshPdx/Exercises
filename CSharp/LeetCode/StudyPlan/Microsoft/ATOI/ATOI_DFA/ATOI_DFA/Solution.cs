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
        Input = input;
        NextState = DFA_State.Start;
    }
}

public enum DFA_State
{
    Start,
    Digit,
    Sign,
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


        //If its empty go to Dead State (End):
        if (inputChars.Length == 0)
        {
            stateInput.NextState = DFA_State.End;
            stateInput.Index++;
        }
        //No input left to process:
        else if (inputChars.Length <= stateInput.Index)
        {
            stateInput.NextState = DFA_State.End;
        }
        //Empty string, iterate and process:
        else if (inputChars[stateInput.Index] == ' ')
        {
            stateInput.NextState = DFA_State.Start;
            stateInput.Index++;
        }
        //Go to digit  to process:
        else if (Char.IsDigit(inputChars[stateInput.Index]))
        {
            stateInput.NextState = DFA_State.Digit;
        }
        //Sign found:
        else if (inputChars[stateInput.Index] == '+' || inputChars[stateInput.Index] == '-')
        {
            stateInput.NextState = DFA_State.Sign;
        }
        else if (inputChars[stateInput.Index] != '+' || inputChars[stateInput.Index] != '-' || !Char.IsDigit(inputChars[stateInput.Index]))
        {
            stateInput.NextState = DFA_State.End;
        }
        return stateInput;
    }


    public State DigitState(State stateInput)
    {
        char[] inputChars = stateInput.Input.ToCharArray();

        //Process Current Digit:
        if ((inputChars.Length <= stateInput.Index))
        {
            stateInput.NextState = DFA_State.End;
        }
        else if (Char.IsDigit(inputChars[stateInput.Index]))
        {
            stateInput.StringBuilder.Append(inputChars[stateInput.Index]);
            stateInput.Index++;
            stateInput.NextState = DFA_State.Digit;
        }
        else
        {
            stateInput.NextState = DFA_State.End;
        }

        return stateInput;
    }

    public State SignState(State stateInput)
    {
        char[] inputChars = stateInput.Input.ToCharArray();

        if (inputChars.Length <= stateInput.Index)
        {
            stateInput.NextState = DFA_State.End;
        }
        else if (!Char.IsDigit(inputChars[stateInput.Index]))
        {
            stateInput.NextState = DFA_State.End;
        }
        else if (Char.IsDigit(inputChars[stateInput.Index]))
        {
            if (inputChars[stateInput.Index - 1] == '+' || inputChars[stateInput.Index - 1] == '-')
            {
                stateInput.StringBuilder.Append(stateInput.Index - 1);
            }
            
            stateInput.NextState = DFA_State.Digit;
        }

        return stateInput;
    }

    public int? EndState(State stateInput)
    {   
        return Convert.ToInt32(stateInput.StringBuilder.ToString());
    }

    public int? ToMyInt(string input)
    {
        double multiple = 1;
        double output = 0;

        foreach (char currentChar in input.Reverse())
        {
            Int32.TryParse(currentChar.ToString(), out int formattedInteger);
            output = (formattedInteger * multiple) + output;

            multiple = multiple * 10;
        }

        if (output > 2147483647)
        {
            return null;
        }

        return Convert.ToInt32(output);
    }
}


public class Solution_Tests
{
    #region StartingState
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

    [Fact]
    public async Task StartingState_HandleDigit()
    {
        Solution solution = new Solution();
        string input = "1";

        State stateInput = new State(input);
        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 0,
            NextState = DFA_State.Digit
        };

        State output = solution.StartingState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    [Fact]
    public async Task StartingState_HandleSign()
    {
        Solution solution = new Solution();
        string input = "+";

        State stateInput = new State(input);
        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 0,
            NextState = DFA_State.Sign
        };

        State output = solution.StartingState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    [Fact]
    public async Task StartingState_HandleNondigiitNonSign()
    {
        Solution solution = new Solution();
        string input = "A";

        State stateInput = new State(input);
        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 0,
            NextState = DFA_State.End
        };

        State output = solution.StartingState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }
    #endregion

    #region DigitState

    [Fact]
    public async Task DigitState_HandleSingleDigit()
    {
        Solution solution = new Solution();
        string input = "1";

        State stateInput = new State(input);
        
        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.Digit
        };

        stateExpectedOutput.StringBuilder.Append("1");
        
        State output = solution.DigitState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    [Fact]
    public async Task DigitState_HandleEndOfLine()
    {
        Solution solution = new Solution();
        string input = "1";

        State stateInput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.Digit
        };

        stateInput.StringBuilder.Append("1");

        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.End
        };

        stateExpectedOutput.StringBuilder.Append("1");
        
        State output = solution.DigitState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    [Fact]
    public async Task DigitState_HandleNonDigit()
    {
        Solution solution = new Solution();
        string input = "1a";

        State stateInput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.Digit
        };

        stateInput.StringBuilder.Append("1");

        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.End
        };

        stateExpectedOutput.StringBuilder.Append("1");

        State output = solution.DigitState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    #endregion

    #region SignState

    [Fact]
    public async Task SignState_HandleEndOfLine()
    {
        Solution solution = new Solution();
        string input = "+";

        State stateInput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.Sign
        };
        
        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.End
        };
        
        State output = solution.SignState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    [Fact]
    public async Task SignState_HandleNotADigit()
    {
        Solution solution = new Solution();
        string input = "+a";

        State stateInput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.Sign
        };

        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.End
        };

        State output = solution.SignState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    [Fact]
    public async Task SignState_HandleDigit()
    {
        Solution solution = new Solution();
        string input = "-1";

        State stateInput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.Sign
        };

        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.Digit
        };

        stateExpectedOutput.StringBuilder.Append("-");

        State output = solution.SignState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    #endregion

    #region EndState

    [Fact]
    public async Task EndState_ReturnsInteger()
    {
        Solution solution = new Solution();
        string input = "1";

        State stateInput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.End
        };

        stateInput.StringBuilder.Append("1");

       
        int? output = solution.EndState(stateInput);

        output.Value.Should().Be(1);
    }


    [Fact]
    public async Task ToMyInt_ReturnsInteger()
    {
        Solution solution = new Solution();
        string input = "12";

        int output = solution.ToMyInt(input);
        
        output.Should().Be(12);
    }

    #endregion

}