namespace min_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = pseudoList();
            int min = list.Min();
            double avr = list.Average();
            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine(min);
            Console.WriteLine($"{avr:f2}");
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
