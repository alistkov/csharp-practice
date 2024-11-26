namespace Methods._1.Practice;

public class Calculator
{
    public List<int> GetAboveZero(int[] numbers)
    {
        var result = new List<int>();
    
        foreach (var number in numbers)
        {
            if (number > 0)
                result.Add(number);
        }
        return result;
    }
}