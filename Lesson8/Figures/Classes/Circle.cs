using Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Classes
{
    internal class Circle : Shape, IGetNameOfShape, IGetRadius
    {
        public double GetRadius()
        {
            Console.Write("Enter the radius of circle: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            return Radius;
        }
        public override void GetPerimeter()
        {
            Radius = GetRadius();
            if (Radius <= 0)
            {
                Console.WriteLine("Radius must be a positive number.");
                return;
            }
            else
            {
                Perimeter = 2 * Pi * Radius;
                Console.WriteLine($"Perimeter of the circle: {Perimeter}");
            }
        }

        public override void GetSquare()
        {
            Radius = GetRadius();
            if (Radius <= 0)
            {
                Console.WriteLine("Radius must be a positive number.");
                return;
            }
            else
            {
                Square = Pi * Radius * Radius;
                Console.WriteLine($"Square of the circle: {Square}");
            }
        }

        public string GetNameOfShape()
        {
            return "circle";
        }
    }
}
