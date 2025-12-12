int countvowel(string st)
{
    int count = 0;
    foreach (char x in st)
    {
        if (x == 'a' || x == 'i' || x == 'o' || x == 'e' || x == 'u')
        {
            count++;

        }

    }
    return count;

}

int res = countvowel("himanshu");
Console.WriteLine(res);