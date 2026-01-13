class Move_zeros
{

    static void Main()
    {
        int[] arr = { 0, 1, 2, 0, 4, 0, 6 };
        int slow = 0;
        for (int fast = 0; fast < arr.Length; fast++)
        {
            if (arr[fast] != 0)
            {
                int temp = arr[slow];
                arr[slow] = arr[fast];
                arr[fast] = temp;
                slow++;
            }
        }
        foreach (var x in arr)
        {
            Console.WriteLine(x);
        }


    }

}