// Remove Duplicates from Sorted Array
class Remove_Duplicate
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 3, 4, 4, 5, 5 };
        int slow = 0;

        for (int fast = 1; fast < arr.Length; fast++)
        {
            if (arr[fast] != arr[slow])
            {
                slow++;
                arr[slow] = arr[fast];

            }
        }
        int uniquecount = slow + 1;

        for (int i = 0; i < uniquecount; i++)
        {
            Console.Write(arr[i]);

        }

    }

}

// ⏱ Complexity

// Time: O(n)

// Space: O(1)(in -place)

// ⚠️ Small Note(Interview Tip)

// ⚠️ Ye solution sirf sorted array ke liye valid hai.
// Agar unsorted ho → pehle sort ya HashSet use karna padega.