int a = 0;
int b = 1;
int n = 10;
int c;
Console.Write(a + " " + b + " ");
for (int i = 2; i < n; i++)
{
    c = a + b;
    Console.Write(c + " ");
    a = b;
    b = c;

}