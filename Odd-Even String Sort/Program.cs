using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_String_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Char> nieparzyste = new List<char>();
            List<Char> parzyste = new List<Char>();
            Console.WriteLine("Give string");
            string s = Console.ReadLine();
            char[]s_array = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    parzyste.Add (s_array[i]);
                }
                else
                {
                    nieparzyste.Add(s_array[i]);
                }
            }
            Console.WriteLine(new string(parzyste.ToArray()) + " " + new string(nieparzyste.ToArray()));
            Console.ReadKey();
        }
    }
}
