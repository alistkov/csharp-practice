var words = new[] { "word", "", "not empty string", "another string", "true", "", "", "last" };

foreach (var word in words)
{
    if (!string.IsNullOrEmpty(word))
        Console.WriteLine(word);
}