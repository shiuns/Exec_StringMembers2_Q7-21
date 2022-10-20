using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Exec_StringMembers2_Q7__21_謝孟勳
{
    //計算兩數之和,並只呈現小數二位數
    internal class Program
    {
        static void Main(string[] args)
        {
            double d1 = 0.687867;
            double d2 = 0.88;
            double sum = (d1 + d2);
            Console.WriteLine(sum.ToString("0.00")); 
        }
    }
}
