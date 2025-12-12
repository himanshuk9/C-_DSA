int[] arr = { 1, 2, 3, 4, 55 };

int left = 0;
int right = arr.Length - 1;

while (left < right)
{
    int temp = arr[left];
    arr[left] = arr[right];
    arr[right] = temp;
    left++;
    right--;
}

foreach (var item in arr)
{
    Console.Write(item + " ");
}


/*
we can do with Linq function ....

int[ ] rev = arr.Reverse.ToArray();
print by foreach loop

*/