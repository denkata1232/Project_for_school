namespace brakman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = pseudoList();
            string number = null;
            for (int i = 0; i < list.Count; i++)
            {
                number += list[i];
            }
            int num = int.Parse(number);
            Console.WriteLine(num);
            bool flag = true;
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    Console.Write($"{i} и {num / i};");
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("това число е ужасно просто");
            }
        }
        static List<int> pseudoList()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Random num = new Random();
                list.Add(num.Next(1, 9));
            }
            return list;
        }
        static void ligotiq()
        {
            Console.WriteLine("'NEJA E BsjkejreirjsfioejifhjefhulkefsduhgufehlusiefthluuienyehtuiuveehuvbiryuisefthuiludsefbyhuiuvlsetfdhuivtefbuhuierftyhkuivdlbeyfhutfiiudysehbtufvnuiscerhyutivluHNSYLEDfsyuuidvndhfifjoestnelnk\tnbothunnvysdti" +
                "eryinvtisnydtis;dtnopdshyviln;rsdNA KUDE DUSHATA MI DA BQGAAAAhhhAAAAAAAAA gecata tup i qde patlajanc♫¤♫♫:↑↓→←^#►↓%11K↓#.D;`▼▼3 ");
            List<int> divergenti = new List<int>();
        }

    }
}
