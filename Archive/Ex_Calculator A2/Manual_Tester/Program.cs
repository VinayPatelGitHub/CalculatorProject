using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Manual_Tester
{
    class Program
    {
        List<string> myList = new List<string>();
               
        static void Main(string[] args)
        {
            string a = "-5";
            int y = int.Parse(a);
            int x = y;
            x = x + 5;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //string data = "454245+";
            //string num = data.Remove(data.Length - 1);
            //char opp = data[data.Length - 1];
            //int code = char.ConvertToUtf32(opp,opp);            
            //Console.WriteLine(num);
            //Console.WriteLine(opp);
            //Console.WriteLine(code);

            //MYLIST(data);
            //Console.WriteLine(myList);


            //List<string> myList = new List<string> { };
            //Console.WriteLine(myList.Count);
        }
        //public void MYLIST(string words)
        //{
        //    MYList().Add(words);
        //}
        //public List<string> MYList()
        //{
        //    return myList;
        //}
    }
}
