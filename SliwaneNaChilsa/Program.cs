namespace SliwaneNaChilsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> resultList = new List<int>();
            string[] lists = input.Split('|');
            for (int i = lists.Length - 1; i >= 0; i--)
            {
                string[] elements = lists[i].Split(' ');
                foreach (string element in elements)
                {
                    if (element.Length > 0)
                    {
                        resultList.Add(int.Parse(element));
                    }
                }
            }
            foreach (int number in resultList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
