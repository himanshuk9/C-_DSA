// Array sorting checking 

int[] arr = { 1, 2, 3, 4, 5, 7 };

bool checksorting(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            return false;
        }
    }
    return true;
}

Console.Write(checksorting(arr) ? "yes sorted h " : "not bhai");