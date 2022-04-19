using System.Reflection.Metadata;
using System.Text;
using FluentAssertions;
using Xunit;

namespace ATOI_DFA;

public class State
{
    public string Input { get; set; }
    public StringBuilder StringBuilder { get; set; }
    public char Sign { get; set; }
    public int Index { get; set; }
    public DFA_State NextState { get; set; }

    public State()
    {
    }
    
    public State(String input)
    {
        StringBuilder = new StringBuilder();
        Input = input;
        Sign = ' ';
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
        State state = new State(input);
        
        while (true)
        {
            switch (state.NextState)
            {
                case DFA_State.Start:
                    state = StartingState(state);
                    break;
                case DFA_State.Digit:
                    state = DigitState(state);
                    break;
                case DFA_State.End:
                    return EndState(state).Value;
                    break;
                case DFA_State.Sign:
                    state = SignState(state);
                    break;
                default:
                    throw new NotImplementedException("State not found");
            }
        }


        
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
        else if (inputChars[stateInput.Index] == '+' || inputChars[stateInput.Index] == '-')
        {
            if (stateInput.Sign == ' ')
            {
                stateInput.Sign = inputChars[stateInput.Index];
                stateInput.Index++;
            }
            else
            {
                stateInput.NextState = DFA_State.End;
            }
        }
        else if (Char.IsDigit(inputChars[stateInput.Index]))
        {
            stateInput.NextState = DFA_State.Digit;
        }
        else if (!Char.IsDigit(inputChars[stateInput.Index]))
        {
            stateInput.NextState = DFA_State.End;
        }

        return stateInput;
    }

    public int? EndState(State stateInput)
    {
        int? converted = ToMyInt(stateInput.StringBuilder.ToString());

        if (stateInput.Sign == '-')
            converted = converted.Value * -1;




        return converted;
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
    #region MyATOI

    [Fact]
    public async Task MyAtoi_Fact1()
    {
        Solution solution = new Solution();
        int output = solution.MyAtoi("1");
        
        output.Should().Be(1);
    }

    [Fact]
    public async Task MyAtoi_Fact2()
    {
        Solution solution = new Solution();
        int output = solution.MyAtoi("10");

        output.Should().Be(10);
    }

    [Fact]
    public async Task MyAtoi_Fact3()
    {
        Solution solution = new Solution();
        int output = solution.MyAtoi("-100");

        output.Should().Be(-100);
    }

    [Fact]
    public async Task MyAtoi_Fact4()
    {
        Solution solution = new Solution();
        int output = solution.MyAtoi("42");

        output.Should().Be(42);
    }

    [Fact]
    public async Task MyAtoi_Fact5()
    {
        Solution solution = new Solution();
        int output = solution.MyAtoi("4193 with words");

        output.Should().Be(4193);
    }

    [Fact]
    public async Task MyAtoi_Fact6()
    {
        Solution solution = new Solution();
        int output = solution.MyAtoi("words and 987");

        output.Should().Be(0);
    }

    #endregion

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
            Sign = ' ',
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
            Sign = ' ',
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
            Sign = ' ',
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
            Sign = ' ',
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
            Sign = ' ',
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
            Sign = ' ',
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
            Sign = ' ',
            Index = 0,
            NextState = DFA_State.Sign
        };

        State stateExpectedOutput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Sign = '-',
            Index = 1,
            NextState = DFA_State.Sign
        };
        
        State output = solution.SignState(stateInput);

        output.Should().BeEquivalentTo(stateExpectedOutput);
    }

    #endregion

    #region EndState

    [Fact]
    public async Task EndState_ReturnsInteger1()
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
    public async Task EndState_ReturnsInteger160()
    {
        Solution solution = new Solution();
        string input = "160";

        State stateInput = new State()
        {
            Input = input,
            StringBuilder = new StringBuilder(),
            Index = 1,
            NextState = DFA_State.End
        };

        stateInput.StringBuilder.Append("1");
        stateInput.StringBuilder.Append("6");
        stateInput.StringBuilder.Append("0");


        int? output = solution.EndState(stateInput);

        output.Value.Should().Be(160);
    }

    [Fact]
    public async Task ToMyInt_ReturnsInteger()
    {
        Solution solution = new Solution();
        string input = "12";

        int? output = solution.ToMyInt(input);
        
        output.Should().Be(12);
    }
    #endregion

}