int maxsubbarysum(int[] arr)
{
    int maxsofar = arr[0];
    int currentsum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        currentsum = Math.Max(arr[i], currentsum + arr[i]);
        maxsofar = Math.Max(maxsofar, currentsum);

    }
    return maxsofar;
}

int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
Console.Write(maxsubbarysum(arr));