List<int> GetAboveZero(int[] numbers)
{
    var result = new List<int>();
    
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
        if (number > 0)
            result.Add(number);
    }
    return result;
}
