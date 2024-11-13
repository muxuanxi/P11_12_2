using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P11_12_2
{
    internal class Distance
    {
        private double tiem;
        private double x;
        public Distance() { }

        
        public Distance(double x, double tiem)
        {
            this.x = x;
            this.tiem = tiem;
            Console.WriteLine("总距离为："+x * tiem);
        }

        public double suduFun(double x, double y)
        {
           
            return x * y;
        }
          public double GetTime()
            {
                return tiem;
            }

           public double GetX()
            {
                return x;
            }
        public void SetX(double x) {
            this.x = x;
        }
        public void SetTime(double tiem)
        {
            this.tiem = tiem;
        }

    }
}
