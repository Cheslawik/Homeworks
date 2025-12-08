using Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Classes
{
    internal class Triangle : Shape, IGetNameOfShape, IGetLength, IGetWidth, IGetHeight
    {
        public double GetLength()
        {
            Console.WriteLine("Enter side A: ");
            Length = Convert.ToDouble(Console.ReadLine());
            return Length;
        }

        public double GetWidth()
        {
            Console.WriteLine("Enter side B: ");
            Width = Convert.ToDouble(Console.ReadLine());
            return Width;
        }

        public double GetHeight()
        {
            Console.WriteLine("Enter side C: ");
            Height = Convert.ToDouble(Console.ReadLine());
            return Height;
        }
        
        public override void GetPerimeter()
        {
            Length = GetLength();
            Width = GetWidth();
            Height = GetHeight();
            if (Length <= 0 || Width <= 0 || Height <= 0)
            {
                Console.WriteLine("All sides must be positive numbers.");
                return;
            }
            else
            {
                Perimeter = Length + Width + Height;
                Console.WriteLine($"Perimeter of the triangle: {Perimeter}");
            }            
        }              

        public override void GetSquare()
        {
            Length = GetLength();
            Width = GetWidth();
            Height = GetHeight();
            if (Length <= 0 || Width <= 0 || Height <= 0)
            {
                Console.WriteLine("All sides must be positive numbers.");
                return;
            }
            else
            {
                double s = (Length + Width + Height) / 2;
                Square = Math.Sqrt(s * (s - Length) * (s - Width) * (s - Height));
                Console.WriteLine($"Square of the triangle: {Square}");
            }
        }

        public string GetNameOfShape()
        {
            return "triangle";
        }
    }
}
