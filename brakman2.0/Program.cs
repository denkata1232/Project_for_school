namespace brakman2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brakman = pseudoList();
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(" ", brakman));
            brakman.Sort();
            brakman = brakman.Distinct().ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < brakman.Count; i++)
            {
                bool flag = true;
                for (int j = 0; j < result.Count; j++)
                {
                    if (brakman[i] <= result[j] + m)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    result.Add(brakman[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
        static List<int> pseudoList()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Random num = new Random();
                list.Add(num.Next(0, 101));
            }
            return list;
        }
    }
}
