using P11_12_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_12_2
{

    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        double x = 10100;

      
        double time = 2;
        Distance s1 = new Distance();

        s1.SetTime(time);
        s1.SetX(x);
        Console.WriteLine("距离为："+s1.suduFun(x, time));


        Distance s2 = new Distance(10000,2);


        Console.ReadKey();
        }

       
    }
