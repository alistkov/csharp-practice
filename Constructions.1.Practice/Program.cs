int[] numbers = new int [10];

for (var i = 0; i < numbers.Length; i += 1)
{
    numbers[i] = new Random().Next(-50, 50);
}

foreach (var number in numbers)
{
    if (number > 0)
        Console.WriteLine(number);
}
