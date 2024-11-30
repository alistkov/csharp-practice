namespace LINQ._1.Practice;

class Program
{
    static void Main(string[] args)
    {
    }

    public static int[] GetEvenNumbers(int[] numbers)
    {
        return numbers.Where(n => n % 2 == 0).ToArray();
    }
}