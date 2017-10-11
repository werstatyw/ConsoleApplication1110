using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1110
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "";
            Random R = new Random();
            for (int i = 0; i < 6; i++)
            {
                int j = R.Next(0, 3);
                if (j == 0)
                {
                    g = R.Next(0, 10);
                    s += g;
                }
                else
                {
                    g = R.Next(0, 26);
                    g = g + 65;
                    char c1 = (char)g;
                    s += 
                                    }
            }
            Console.WriteLine("The End");
        }
    }
}
