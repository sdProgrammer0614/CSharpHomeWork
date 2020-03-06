using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    public interface IShape
    {
        double Area { get; }    //面积属性
        bool IsValid();         //判断形状是否合法
        void GetInfo();         //输出相关信息
    }

    class Rectangle: IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            if(!IsValid())
                Console.Write("Invalid input! ");
        }

        public double Area
        {
            get => IsValid() ? width * height : -1;
        }

        public bool IsValid()
        {
            return width > 0 && height > 0;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Rectangle: width = {width}, height = {height}, area = {Area}");
        }
    }

    class Square: IShape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;

            if (!IsValid())
                Console.Write("Invalid input! ");
        }

        public double Area
        {
            get => IsValid() ? side * side : -1;
        }

        public bool IsValid()
        {
            return side > 0;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Square: side = {side}, area = {Area}");
        }
    }

    class Triangle: IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (!IsValid())
                Console.Write("Invalid input! ");
        }

        public double Area
        {
            get
            {
                if (IsValid())
                {
                    //海伦公式
                    double p = (a + b + c) / 2;
                    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return S;
                }
                else
                    return -1;
            }
        }

        public bool IsValid()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Triangle: a = {a}, b = {b}, c = {c}, area = {Area}");
        }
    }

    class Factory
    {
        public static IShape GetProduct(string args, params double[] length)
        {
            IShape shape = null;
            switch(args)
            {
                case "Rectangle":
                    shape = new Rectangle(length[0], length[1]);
                    break;
                case "Square":
                    shape = new Square(length[0]);
                    break;
                case "Triangle":
                    shape = new Triangle(length[0], length[1], length[2]);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            return shape;
        }
    }

    public class Client
    {
        public static void Main(String[] args)
        {
            Random rnd = new Random();
            IShape shape = null;
            double totalArea = 0;

            for (int i = 0; i < 10; i++) 
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        shape = Factory.GetProduct("Rectangle", new double[] { 10 * rnd.NextDouble(), 10 * rnd.NextDouble() });
                        break;
                    case 1:
                        shape = Factory.GetProduct("Square", new double[] { 10 * rnd.NextDouble() });
                        break;
                    case 2:
                        shape = Factory.GetProduct("Triangle", new double[] { 10 * rnd.NextDouble(), 10 * rnd.NextDouble(), 10 * rnd.NextDouble() });
                        break;
                    default:
                        break;
                }

                shape.GetInfo();
                if (shape.IsValid())
                    totalArea += shape.Area;
            }
            Console.WriteLine($"Total area is {totalArea}");
        }
    }
}
