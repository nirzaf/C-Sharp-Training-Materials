
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

    foreach (char t in s)
    {
        if (t == '(')
        {
            OpenBrancket++;
        }
        else if (t == ')')
        {
            CloseBrancket++;
        }
    }

    return OpenBrancket >= CloseBrancket ? OpenBrancket - CloseBrancket : CloseBrancket - OpenBrancket;
}