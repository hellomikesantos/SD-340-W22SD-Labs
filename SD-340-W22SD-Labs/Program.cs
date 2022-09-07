StringDelegate del = new StringDelegate(PrintWords);
Console.WriteLine(del("flask", 3));

del = RemoveLastLetters;
Console.WriteLine(del("water", 2));

string PrintWords(string wordArg, int numArg)
{
    for (int i = 0; i < numArg - 1; i++)
    {
        Console.WriteLine(wordArg);
    }
    return wordArg;
}

string RemoveLastLetters(string wordArg, int numArg)
{
    return wordArg.Remove(wordArg.Length - numArg);
}

delegate string StringDelegate(string wordArg, int numArg);