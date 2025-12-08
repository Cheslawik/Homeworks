using Figures.Classes;

namespace Figures
{
    public class Program
    {
        static void Main(string[] args)
        {            
            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("\nWelcome to this program!\n");

                Console.WriteLine("1. Rectangle Perimeter");
                Console.WriteLine("2. Rectangle Square");
                Console.WriteLine("3. Circle Perimeter");
                Console.WriteLine("4. Circle Square");
                Console.WriteLine("5. Triangle Perimeter");
                Console.WriteLine("6. Triangle Square");
                Console.WriteLine("\n0. Exit");

                Console.Write("\nChoose the operation: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        isTrue = false;
                        break;
                    case "1":
                        Rectangle rectanglePerimeter = new Rectangle();
                        rectanglePerimeter.GetPerimeter();
                        break;
                    case "2":
                        Rectangle rectangleSquare = new Rectangle();
                        rectangleSquare.GetSquare();
                        break;
                    case "3":
                        Circle circlePerimeter = new Circle();
                        circlePerimeter.GetPerimeter();
                        break;
                    case "4":
                        Circle circleSquare = new Circle();
                        circleSquare.GetSquare();
                        break;
                    case "5":
                        Triangle trianglePerimeter = new Triangle();
                        trianglePerimeter.GetPerimeter();
                        break;
                    case "6":
                        Triangle triangleSquare = new Triangle();
                        triangleSquare.GetSquare();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }

        }
    }
}

