void maxfun(int[] arr, int len)
{
    int maxe = int.MinValue;
    int mine = int.MaxValue;

    foreach (int num in arr)
    {
        if (num > maxe)
        {
            maxe = num;
        }
        if (num < mine)
        {
            mine = num;
        }
    }

    Console.WriteLine("Max = " + maxe);
    Console.WriteLine("Min = " + mine);

    // optional (अगर return की ज़रूरत है)
}
