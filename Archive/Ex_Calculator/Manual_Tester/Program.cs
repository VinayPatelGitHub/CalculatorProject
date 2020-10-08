using System;

namespace Manual_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "454245+";
            string num = data.Remove(data.Length - 1);
            char opp = data[data.Length - 1];
            Console.WriteLine(num);
            Console.WriteLine(opp);
        }
    }
}
