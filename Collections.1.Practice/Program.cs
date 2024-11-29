namespace Collection._1.Pracrice;

class Program
{
    public static void Main(string[] args)
    {
    }

    public static List<int> GetAboveZero(List<int> numbers)
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

