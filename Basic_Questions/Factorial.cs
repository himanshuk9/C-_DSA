
int factroial(int n)
{
    if (n <= 1)
    {
        return 1;

    }
    return n * factroial(n - 1);
}
int n = 5;
Console.WriteLine(factroial(n));