using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Circle
    {
        static public double GetLong(double r)
        {
            return r * 2 * Math.PI;
        }
        static public double GetSquare(double r)
        {
            return r * r * Math.PI;
        }
        static public string GetConfirm(double r, double x, double y)
        {
            if (Math.Sqrt(x * x + y * y) <= r)
            {
                return "принадлежит кругу";
            }
            else
            {
                return "не принадлежит кругу";
            }
        }
    }
}
