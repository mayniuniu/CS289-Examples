using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入 Pokemon 名字:");
            string name = Console.ReadLine();
            Console.Write("請輸入 Pokemon 身高:");
            string Height = Console.ReadLine();
            Console.Write("請輸入 Pokemon 體重:");
            string Weight = Console.ReadLine();
            Console.WriteLine("Pokemon {0}: 身高{1}  體重{2}.", name, Height, Weight);
        }
    }
}
