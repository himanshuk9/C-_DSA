using System.Text;

bool Palindrome(string s)
{
    StringBuilder stt = new StringBuilder();

    for (int i = s.Length - 1; i >= 0; i--)
    {
        stt.Append(s[i]);
    }

    return s == stt.ToString();
}

string s = "mam";
Console.WriteLine(Palindrome(s));
