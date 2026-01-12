int n = 12345;
int count = 0;
if (n == 0)
{
    count = 1;
}
while (n != 0)
{
    int last = n % 10;
    count++;
    n = n / 10;

}
Console.WriteLine(count);