// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// example = 3 0 1 2 5 4 8 6 7

public class Solution
{
  public int MaxChunksToSorted(int[] arr)
  {
    // As the array has only 0 to n-1 element, if we sort the array then each no will be placed at the same no index
    // example input - 2,0,1,4,3,5, after sort 0, 1, 2, 3, 4, 5, here as you can see each element value and their index are same after sorting because in ques it mentioned the input is in range 0 to n - 1
    // 2,0,1,4,3,5
    // after sort 2 will be placed at 2 index, and as we can not move 2 to any other index after sort so 1st partition would be at index 2
    // next 4 can be placed only at 4th index and not before , so another partition can be done at 4th index 

    // to calculate the partition count, will keep a max variable to store the max reach for a no

    int max = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      max = Math.Max(max, arr[i]);
      if (max == i) count++;
    }

    return count;
  }
}
