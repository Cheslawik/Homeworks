using Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Classes
{
    internal class Rectangle : Shape, IGetNameOfShape, IGetLength, IGetWidth
    {
        public double GetLength()
        {
            Console.WriteLine("Enter length: ");
            Length = Convert.ToDouble(Console.ReadLine());
            return Length;
        }

        public double GetWidth()
        {
            Console.WriteLine("Enter width: ");
            Width = Convert.ToDouble(Console.ReadLine());
            return Width;
        }

        public override void GetPerimeter()
        {
            Length = GetLength();
            Width = GetWidth();
            if (Length <= 0 || Width <= 0)
            {
                Console.WriteLine("Length and width must be positive numbers.");
                return;
            }
            else
            {
                Perimeter = 2 * (Length + Width);
                Console.WriteLine($"Perimeter of the rectangle: {Perimeter}");
            }
        }

        public override void GetSquare()
        {
            Length = GetLength();
            Width = GetWidth();
            if (Length <= 0 || Width <= 0)
            {
                Console.WriteLine("Length and width must be positive numbers.");
                return;
            }
            else
            {
                Square = Length * Width;
                Console.WriteLine($"Square of the rectangle: {Square}");
            }
        }

        public string GetNameOfShape()
        {
            return "rectangle";
        }        
    }
}
