using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Manual_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string _x = "2.22";
            bool y = _x.All(char.IsDigit);
            Console.WriteLine(y);
        }
        
        //List<string> myList = new List<string>();

        //static void Main(string[] args)
        //{

        //int i = 1;
        //List<string> hello = new List<string> { "h", "e", "l", "l", "o" };
        //Console.WriteLine(hello.Count);
        //Console.WriteLine(hello[4]);
        //hello[i - 1] = "5";
        //hello[i + 1] = "5";
        //hello.RemoveAt(i + 3);
        //hello.RemoveAt(i + 2);
        //hello.RemoveAt(i);            
        //foreach (string item in hello)
        //{
        //    Console.WriteLine(item);
        //}



        //List<string> hello = new List<string> { "h", "e", "l", "24233", "o", "h", "e", "l", "l", "o" };
        //double number = 0;
        //if (hello[3].All(char.IsDigit))
        //{
        //    number = double.Parse(hello[3]);
        //}
        //number += 5;
        //Console.WriteLine(number);


        //string a = "-5";
        //int y = int.Parse(a);
        //int x = y;
        //x = x + 5;
        //Console.WriteLine(x);
        //Console.WriteLine(y);


        //List <string> hello = new List<string> { "h","e","l","l","o","h","e","l","l","o" };
        //foreach(string item in hello)
        //{
        //    Console.WriteLine(item);
        //}            
        //int z = -2;
        //for (int i = 0; i < hello.Count; i++)
        //{                
        //    if (hello[i] == "l")
        //    {
        //        if (z + 1 == i)
        //        {
        //            hello[z] = "+";
        //            hello.RemoveAt(i);
        //        }
        //        z = i;
        //    }
        //}
        //foreach (string item in hello)
        //{
        //    Console.WriteLine(item);
        //}


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
        //  }
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
