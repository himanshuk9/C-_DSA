// reverse a no . 

int number = 12345;


int rev = 0;
while (number > 0)
{
    int last = number % 10;
    rev = rev * 10 + last;
    number = number / 10;

}
Console.WriteLine(rev);
