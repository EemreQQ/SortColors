public class Solution
{
    public void SortColors(params int[] nums)
    {
        // red,white,blue
        //  0     1     2 şeklinde sıralansın
        // 1<=n<=300
        // Sort olmadan çözülmesini istiyor
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
            nums = list.ToArray();
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
        }
    }
}