namespace sum_elem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = pseudoList();
            Console.WriteLine(String.Join(" ", list));
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list[i]++;
                }
                sum += list[i];
            }
            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine(sum);
        }
        static List<int> pseudoList()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Random num = new Random();
                list.Add(num.Next(1, 1001));
            }
            return list;
        }
    }
}
