using System.Text;

string PrintWords(string wordArg, int numArg)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < numArg; i++)
    {
        sb.Append(wordArg);
    }
    return sb.ToString();
};

string RemoveLastLetters(string wordArg, int numArg)
{
    return wordArg.Remove(wordArg.Length - numArg);
};

StringDelegate del = new StringDelegate(PrintWords);
Console.WriteLine(del("flask", 3));

del = RemoveLastLetters;
Console.WriteLine(del("water", 2));

delegate string StringDelegate(string wordArg, int numArg);