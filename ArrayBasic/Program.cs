using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[] { "Snehal", "Nikita", "Swapnil", "Raj", "Pooja" , "Aditi" , "Siddhi" , "Anvi" , "Viraj" };
            string[] str1 = new string[] { "Pankaj", "Sagar", "Pratik" , "Nikhil" , "Komal" , "Neha"  };

            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            Array.Sort(str);
            Console.WriteLine("----After Sort-----");
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(str);
            Console.WriteLine("----After Reverse-----");
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            Array.Copy(str, 2, str1, 2, 3);
            Console.WriteLine("----Copy-----");
            foreach (var item in str1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
