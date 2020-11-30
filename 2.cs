using System;

namespace ConsoleApp22
{
    class Rectangle
    {
        private double side1, side2, perimeter, area;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public Rectangle() { }

        public double AreaCalculator(double side1, double side2)
        {
            area = side1 * side2;
            return area;
        }

        public double PerimeterCalculator(double side1, double side2)
        {
            perimeter = (side1 + side2) * 2;
            return perimeter;
        }

        public double Area { get { return area; } }
        public double Perimeter { get { return perimeter; } }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();

            Console.Write("Введите длину прямоугольника -> ");
            string x = Console.ReadLine();
            double side1 = Int32.Parse(x);

            Console.Write("Введите ширину прямоугольника -> ");
            string y = Console.ReadLine();
            double side2 = Int32.Parse(y);

            rectangle.AreaCalculator(side1, side2);
            rectangle.PerimeterCalculator(side1, side2);
            Console.WriteLine("Площадь = {0}", rectangle.Area);
            Console.WriteLine("Периметр = {0}", rectangle.Perimeter);

        }
    }

}