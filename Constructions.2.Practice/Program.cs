string[] words = { "word", "", "not empty string", "another string", "true", "", "", "last" };

foreach (var word in words)
{
    if (word.Length > 0)
        Console.WriteLine(word);
}