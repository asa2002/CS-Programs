using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the shape you want to calculate:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. mosalas");
            Console.WriteLine("4. zoozan");
            Console.WriteLine("5. Ellipse");
            Console.WriteLine("6. n zeli");
            Console.WriteLine("7. mostatile");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the radius of the circle: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(r);
                    Console.WriteLine("Area: " + circle.GetCalculateArea());
                    Console.WriteLine("Perimeter: " + circle.CalculatePerimeter());
                    break;
                case 2:
                    Console.Write("Enter the side length of the square: ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Square square = new Square(s);
                    Console.WriteLine("masahat: " + square.CalculateArea());
                    Console.WriteLine("mohit: " + square.CalculatePerimeter());
                    break;
                case 3:
                    Console.Write("Enter the SideA of the triangle: ");
                    double SideA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the SideB of the triangle: ");
                    double SideB = Convert.ToDouble(Console.ReadLine());
                    Triangle mosalas = new Triangle(SideA, SideB);
                    Console.WriteLine("masahat: " + mosalas.CalculateArea());
                    Console.WriteLine("mohit: " + mosalas.CalculatePerimeter());
                    break;
                case 4:
                    Console.Write("Enter the BaseA of the trapezoid: ");
                    double BaseA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the BaseB of the top base of the trapezoid: ");
                    double BaseB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the Height of the bottom base of the trapezoid: ");
                    double Height = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the side of side 1 of the trapezoid: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Trapezoid trapezoid = new Trapezoid(BaseA, BaseB, Height, side);
                    Console.WriteLine("Area: " + trapezoid.CalculateArea());
                    Console.WriteLine("Perimeter: " + trapezoid.CalculatePerimeter());
                    break;
                case 5:
                    Console.Write("Enter the MajorAxis the major axis of the ellipse: ");
                    double MajorAxis = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the MinorAxis of the minor axis of the ellipse: ");
                    double MinorAxis = Convert.ToDouble(Console.ReadLine());
                    Ellipse ellipse = new Ellipse(MajorAxis, MinorAxis);
                    Console.WriteLine("Area: " + ellipse.CalculateArea());
                    Console.WriteLine("Perimeter: " + ellipse.CalculatePerimeter());
                    break;
                case 6:
                    Console.Write("Enter the number of side1 of the polygon: ");
                    int side1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the number of side2 of the polygon: ");
                    int side2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the number of side3 of the polygon: ");
                    int side3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the number of side4 of the polygon: ");
                    int side4 = Convert.ToInt32(Console.ReadLine());
                    Polygon polygon = new Polygon(side1, side2, side3, side4);
                    Console.WriteLine("Area: " + polygon.CalculateArea());
                    Console.WriteLine("Perimeter: " + polygon.CalculatePerimeter());
                    break;
                case 7:
                    Console.Write("Enter the length of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(width, height);
                    Console.WriteLine("Area: " + rectangle.CalculateArea());
                    Console.WriteLine("Perimeter: " + rectangle.CalculatePerimeter());
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            Console.ReadKey();
        }

    }

    class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetCalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
    class Square
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculatePerimeter()
        {
            return 4 * Side;
        }

    }
    class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Triangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public double CalculateArea()
        {
            double s = (SideA * SideB) / 2;
            return s;
        }

        public double CalculatePerimeter()
        {
            return SideA + (2 * Math.Sqrt((SideB * SideB) + ((SideA / 2) * (SideA / 2))));
        }
    }
    class Trapezoid
    {
        public double BaseA { get; set; }
        public double BaseB { get; set; }
        public double Height { get; set; }
        public double Side { get; set; }

        public Trapezoid(double baseA, double baseB, double height, double side)
        {
            BaseA = baseA;
            BaseB = baseB;
            Height = height;
            Side = side;
        }

        public double CalculateArea()
        {
            return ((BaseA + BaseB) / 2) * Height;
        }

        public double CalculatePerimeter()
        {
            return BaseA + BaseB + (2 * Side);
        }
    }
    class Ellipse
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Ellipse(double majorAxis, double minorAxis)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }

        public double CalculateArea()
        {
            return Math.PI * MajorAxis * MinorAxis;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(MajorAxis, 2) + Math.Pow(MinorAxis, 2)) / 2);
        }
    }
    class Polygon
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Side4 { get; set; }

        public Polygon(double side1, double side2, double side3, double side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }

        public double CalculateArea()
        {

            double s = (Side1 + Side2 + Side3 + Side4) / 2;
            return Math.Sqrt((s - Side1) * (s - Side2) * (s - Side3) * (s - Side4));
        }

        public double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
    }
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return (2 * Width) + (2 * Height);
        }
    }

}
