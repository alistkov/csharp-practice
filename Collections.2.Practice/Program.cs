namespace Collections._2.Practice;

class Program
{
    static void Main(string[] args)
    {
    }
    
    public static string[] GetWordsWithEvenKeys(Dictionary<int, string> dictionary)
    {
        var words = new List<string>();

        foreach (var pair in dictionary)
        {
            if (pair.Key % 2 == 0)
                words.Add(pair.Value);
        }

        return words.ToArray();
    }
}