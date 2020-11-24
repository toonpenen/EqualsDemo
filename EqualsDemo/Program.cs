using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = 15;

            Console.WriteLine(x==y);
            Console.WriteLine(x.Equals(y));
        }
    }
}
