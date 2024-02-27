string GetLettersFromStr(string s)
{
    string Letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            Letters = Letters + e;
        }
    }
    return Letters;
}

string str = Console.ReadLine();
string result = GetLettersFromStr(str);
Console.WriteLine(result);