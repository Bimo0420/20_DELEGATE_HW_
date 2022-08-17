using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1    //В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:

//-       метод получает входным параметром переменную типа double;

//-       метод возвращает значение типа double, которое является результатом вычисления.



//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:

//-       длину окружности по формуле D = 2 * π * R;

//-       площадь круга по формуле S = π* R²;

//-       объем шара.Формула V = 4 / 3 * π * R³.
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            double rad = 15;

            MyDelegate myDelegate = L;  //один из вариантов. второй в лекции по практическому заданию
            double l = myDelegate(rad);

            myDelegate = S;
            double s = myDelegate(rad);

            myDelegate = V;
            double v = myDelegate(rad);

            Console.WriteLine($"Длина= {l} Площадь = {s} Объём = {v}");
            Console.ReadKey();
        }
        static double L(double r)
        {

            return (double)2 * Math.PI * r;
        }
        static double S(double r)
        {

            return (double)Math.PI * r * r;
        }
        static double V(double r)
        {

            return (double)4 * Math.PI * r * r * r / 3;
        }
    }
}
