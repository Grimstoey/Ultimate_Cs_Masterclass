List<string> test1 = new List<string>() { "Austin", "chook", "Jui" };

List<string> print = ProcessAll(test1);

foreach(string printWord in print)
{
    Console.WriteLine(printWord);
}

List<string> ProcessAll(List<string> words)
{
    var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

    List<string> result = words;
    foreach (var stringsProcessor in stringsProcessors)
    {
        result = stringsProcessor.Process(result);
    }
    return result;
}

public class StringsProcessor
{
    public virtual List<string> Process(List<string> input)
    {
        List<string> output = new List<string>();

        foreach (string word in input)
        {
            //word.ToUpper();
            //word.Substring(0, word.Length / 2);
            output.Add(word);
        }
        return output;
    }
}

public class StringsUppercaseProcessor : StringsProcessor
{
    public override List<string> Process(List<string> input)
    {
        List<string> output = new List<string>();
        string wordUpper;
        foreach (string word in input)
        {
            wordUpper = word.ToUpper();
            //word.Substring(0, word.Length / 2);
            output.Add(wordUpper);
        }
        return output;
    }

}
public class StringsTrimmingProcessor :StringsProcessor
{
    public override List<string> Process(List<string> input)
    {
        List<string> output = new List<string>();
        string wordTrim;

        foreach (string word in input)
        {
            //word.ToUpper();
            wordTrim = word.Substring(0, word.Length / 2);
            output.Add(wordTrim);
        }
        return output;
    }

}


