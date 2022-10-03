



var str = "(2+[3-12]*{8/3})";


Console.WriteLine(Validator(str));


static bool Validator(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return true;
    }


    Stack<char> brackets = new Stack<char>();

    foreach (var c in input)
    {
        if (c == '[' || c == '{' || c == '(')
            brackets.Push(c);
        else if (c == ']' || c == '}' || c == ')')
        {
            if (brackets.Count == 0)
                return false;

            char open = brackets.Pop();

            if (open != opposite(c))
                return false;
        }
    }

    if (brackets.Count > 0)
        return false;

    return true;
}

static char opposite(char c)
{
    switch (c)
    {
        case '}':
            return '{';
            break;
        case ']':
            return '[';
            break;
        case ')':
            return '(';
            break;
        default:
            return c;

    }

}
