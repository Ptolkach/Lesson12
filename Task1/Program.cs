using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите величину радиуса и координаты точки (x,y)");
            double r = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double longCircle = Circle.GetLong(r);
            double square = Circle.GetSquare(r);
            string conf = Circle.GetConfirm(r, x, y);

            Console.WriteLine($"Длина окружности: {longCircle:f2}\nПлощадь круга: {square:f2}\nПринадлженость точки: {conf}");
            Console.ReadLine();
        }
    }
}
