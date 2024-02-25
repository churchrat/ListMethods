namespace Bombichki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombichki = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bombichki[0])
                {
                    int startIndex = Math.Max(0, i - bombichki[1]);
                    int endIndex = Math.Min(nums.Count - 1, i + bombichki[1]);

                    for (int j = endIndex; j >= startIndex; j--)
                    {
                        nums.RemoveAt(j);
                    }
                    // tozi cikul e pedal!!!
                    i = startIndex - 1;
                }
            }
            int sum = 0;
            for (int i = 0;i < nums.Count;i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}

