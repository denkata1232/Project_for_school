namespace switch_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            List<int> list = pseudoList(n);
            Console.WriteLine(String.Join(" ", list));
            int mover = list[m - 1];
            list[m - 1] = m * m;
            list.Add(mover);
            Console.WriteLine(String.Join(" ", list));
        }
        static List<int> pseudoList(int n)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Random num = new Random();
                list.Add(num.Next(1, 1000));
            }
            return list;
        }
    }
}
