namespace ProblemSolversLib;

public enum BracketBalanceStatus
{
    Balanced,
    NotBalanced,
}

public class BalancedBrackets
{
    public BracketBalanceStatus CheckBalancedBrackets(string exp)
    {
        if (string.IsNullOrEmpty(exp))
        {
            return BracketBalanceStatus.NotBalanced;
        }

        if (exp.Length % 2 != 0)
        {
            return BracketBalanceStatus.NotBalanced;
        }

        Dictionary<char, char> bracketPairs = new()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        List<char> closingBracketStack = new();

        foreach (char currentBracket in exp)
        {
            if (bracketPairs.ContainsKey(currentBracket))
            {
                closingBracketStack.Add(bracketPairs[currentBracket]);

                continue;
            }

            char lastClosingBracket = closingBracketStack[closingBracketStack.Count - 1];

            if (currentBracket != lastClosingBracket)
            {
                return BracketBalanceStatus.NotBalanced;
            }

            closingBracketStack.RemoveAt(closingBracketStack.Count - 1);
        }

        if (closingBracketStack.Any())
        {
            return BracketBalanceStatus.NotBalanced;
        }

        return BracketBalanceStatus.Balanced;
    }

}
