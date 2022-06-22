
Console.WriteLine(GetMin("))((  )"));

Console.WriteLine(DoIt(5)); 

static int DoIt(int x)
{
    x += 1;
    Console.WriteLine(x);
    return x;
}

//Get the number parenthesis required to to have balanced parenthesis
static int GetMin(string s)
{
    int openBracket = 0;
    int closeBracket = 0;

    foreach (char t in s)
    {
        if (t == '(')
        {
            openBracket++;
        }
        else if (t == ')')
        {
            closeBracket++;
        }
    }

    return openBracket >= closeBracket ? openBracket - closeBracket : closeBracket - openBracket;
}