
Dictionary<string, int> frequencyDict = new Dictionary<string, int>();
Random r = new Random();
foreach (string line in File.ReadAllLines("C:/input/voynaimir.txt"))
{
    var words = line.ToLower().Split(new char[] { ',', '.', '!', ':', '-', ' ' });
    foreach (var word in words)
    {
        if (word.Length > 0 && char.IsLetter(word[0]))
        {
            if (frequencyDict.Keys.Contains(word)) frequencyDict[word]++;
            else frequencyDict[word] = 1;
        }
    }
}
foreach (var k in frequencyDict.Keys)
{
    Console.WriteLine($"{k} - {frequencyDict[k]}");
}


