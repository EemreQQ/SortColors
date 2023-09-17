public class Solution
{
    public void SortColors(params int[] nums)
    {
        if (nums.Length == 1) Console.Write(nums[0]);
        else
        {
            int b = 0;
            int value = 0;
            int a = 0;
            List<int> list = new List<int>();
            while (value < 3)
            {
                a = Array.FindIndex(nums, b, x => x == value);
                if (a == -1) { value++; a = 0; b = 0; continue; }
                b = a + 1;
                list.Add(nums[a]);
            }
            Array.Copy(list.ToArray(), 0, nums, 0, nums.Length);
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
        }
    }
}
