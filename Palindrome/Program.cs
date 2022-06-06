
Console.WriteLine(getMin("))((  )"));

static int DoIt(int x)
{
    x += 1;
    Console.WriteLine(x);
    return x;
}

//Get the number parenthesis required to to have balanced parenthesis
static int getMin(string s)
{
    int OpenBrancket = 0;
    int CloseBrancket = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
        {
            OpenBrancket++;
        }
        else if (s[i] == ')')
        {
            CloseBrancket++;
        }
    }

    return OpenBrancket >= CloseBrancket ? OpenBrancket - CloseBrancket : CloseBrancket - OpenBrancket;
}