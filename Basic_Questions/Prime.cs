using System.Data;

bool primecheck(int x)
{
    if (x < 2)
    {
        return false;
    }

    else if (x == 2)
    {
        return true;
    }

    for (int i = 2; i < x * x; i++)
    {
        if (i % 2 == 0)
        {
            return false;

        }

    }

    return true;
}

Console.WriteLine(primecheck(1) ? "Prime Number" : "Not Prime");