using System;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double r);

        static void Main(string[] args)
        {        

            Console.WriteLine("Введите радиус");
            double radius= Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = Length;         
            Console.WriteLine("Длина окружности: {0:f2}", myDelegate?.Invoke(radius));
          
            myDelegate = Square;
            Console.WriteLine("Площадь круга: {0:f2}", myDelegate?.Invoke(radius));
         
            myDelegate = Volume;
            Console.WriteLine("Объём шара: {0:f2}", myDelegate?.Invoke(radius));
            Console.ReadKey();
            
        }

       static double Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        static double Square(double radius)
        {
            return Math.PI * Math.Pow(radius,2);
        }

        static double Volume(double radius)
        {
            return (4/3)*Math.PI * Math.Pow(radius, 3); ;
        }
    }
}
