using ProblemSolversLib;
using Xunit;

namespace ProblemSolvers.Tests;

public class BalancedBracketsTests
{
    private readonly BalancedBrackets _balancedBrackets;

    public BalancedBracketsTests()
    {
        _balancedBrackets = new BalancedBrackets();
    }

    [Theory]
    [InlineData("[]", BracketBalanceStatus.Balanced)]
    [InlineData("()", BracketBalanceStatus.Balanced)]
    [InlineData("{}", BracketBalanceStatus.Balanced)]
    [InlineData("({[]})", BracketBalanceStatus.Balanced)]
    [InlineData("[()]{}{[()()]()}", BracketBalanceStatus.Balanced)]
    public void CheckBalancedBrackets_BalancedInputs_ReturnsBalanced(string input, BracketBalanceStatus expected)
    {

        // Act
        var result = _balancedBrackets.CheckBalancedBrackets(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("", BracketBalanceStatus.NotBalanced)]
    [InlineData("(", BracketBalanceStatus.NotBalanced)]
    [InlineData("([)]", BracketBalanceStatus.NotBalanced)]
    [InlineData("({[})]", BracketBalanceStatus.NotBalanced)]
    [InlineData("({[]})]", BracketBalanceStatus.NotBalanced)]
    public void CheckBalancedBrackets_UnbalancedInputs_ReturnsNotBalanced(string input, BracketBalanceStatus expected)
    {

        // Act
        var result = _balancedBrackets.CheckBalancedBrackets(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
