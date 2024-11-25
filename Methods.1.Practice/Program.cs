List<int> GetAboveZero(int[] numbers)
{
    // Какой вариант лучше использовать?
    var result = new List<int>();
    // List<int> result = [];
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
        if (number > 0)
            result.Add(number);
    }
    return result;
}
