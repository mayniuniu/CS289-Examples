using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入 Pokemon 名字:");
            string name = Console.ReadLine();
            Console.Write("請輸入 Pokemon 身高(ft):");
            string Height = Console.ReadLine();
            Console.Write("請輸入 Pokemon 體重(lbs):");
            string Weight = Console.ReadLine();
            Console.WriteLine("Pokemon {0}: 身高 {1} ft, 體重 {2} lbs.", name, Height, Weight);
        }
    }
}