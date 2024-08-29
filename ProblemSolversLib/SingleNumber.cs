namespace ProblemSolversLib;

public class SingleNumber
{
    public int GetUniqueNumber(int[] numbers)
    {
        if (numbers.Length == 1)
        {
            return numbers[0];
        }

        Dictionary<int, bool> seen = new();

        foreach (int num in numbers)
        {
            if (seen.ContainsKey(num))
            {
                seen[num] = true;
            }
            else
            {
                seen.Add(num, false);
            }
        }

        return seen.FirstOrDefault(x => x.Value == false).Key;
    }


}
