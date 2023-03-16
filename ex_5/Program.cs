// Учитывая массив целых чисел nums и целое число target, верните индексы двух чисел так, чтобы они составляли в сумме target.
// Вы можете предположить, что каждый вход будет иметь ровно одно решение, и вы не можете использовать один и тот же элемент дважды.
// Вы можете вернуть ответ в любом порядке.
// https://leetcode.com/problems/two-sum/

Console.Clear();
int[] nums = new int[]{2, 7, 11, 15};
int target = 9;
for(int i = 0; i < nums.Length - 1; i++)
{
    
    for(int j = 1; j < nums.Length; j++)
    {
        
        if(nums[i] + nums[j] == target && i != j)
        {
            Console.WriteLine($"[{i}, {j}]");
        }
    }
}
