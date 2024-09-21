using System.Reflection;
using WordsCount;
using WordsCount.Services;
string baseDir = AppDomain.CurrentDomain.BaseDirectory;
string projectDir = Directory.GetParent(baseDir)!.Parent!.Parent!.Parent!.FullName;
string[] fileNames = { "file1.txt", "file2.txt" };

var fileReader = new FileReader();
var wordProcessor = new WordProcessor();
var wordCounter = new WordCounter();
var resultFormatter = new ResultFormatter();

var aggregatedWordCount = new Dictionary<string, int>();

foreach (var file in fileNames)
{
    try
    {
        string filePath = Path.Combine(projectDir,"InputFiles", file).Replace("\\", "/");

        string fileContent = fileReader.ReadFile(filePath);

        IEnumerable<string> words = wordProcessor.ProcessText(fileContent);

        Dictionary<string, int> wordCount = wordCounter.CountWords(words);

        foreach (var word in wordCount)
        {
            if (aggregatedWordCount.ContainsKey(word.Key))
            {
                aggregatedWordCount[word.Key] += word.Value;
            }
            else
            {
                aggregatedWordCount[word.Key] = word.Value;
            }
        }
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

resultFormatter.PrintResults(aggregatedWordCount);

