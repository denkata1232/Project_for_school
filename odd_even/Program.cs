namespace odd_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = pseudoList();
            Console.WriteLine(String.Join(" ",list));
            list.Sort();
            List<int> even = list.Where(x => x % 2 == 0).ToList();
            List<int> odd = list.Where(x => x % 2 != 0).ToList();
            List<int> result = even.Concat(odd).ToList();
            Console.WriteLine(String.Join(" ",result));
        }
        static List<int> pseudoList()
        {
            int n = int.Parse(Console.ReadLine());
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
