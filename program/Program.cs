
int CalculateElementsNewSrings (string [] strings)
{
    int i = 0;
    int count = 0;
    while (i < strings.Length)
    {
        if (strings[i].Length < 4)
        {
            count++;
        }
        i++;
    }
    return count;
}

string [] CreateNewStrings (string [] strings, int count)
{
    string [] newStrings = new string [count];
    int i = 0;
    int j = 0;
    while (i < strings.Length)
    {
        if (strings[i].Length < 4)
        {
            newStrings[j] = strings[i];
            j++;
        }
        i++;
    }
    return newStrings;
}

string[] start = ["Hello", "2", "world", ":-)"];
string[] finish = CreateNewStrings(start, CalculateElementsNewSrings(start));
Console.WriteLine("[" + string.Join(", ", finish) + "]");