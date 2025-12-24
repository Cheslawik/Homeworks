using lesson11.Classes;

namespace lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new ComparablePair<int, int>(6, 6);
            var q = new ComparablePair<int, int>(7, 7);
            int result = p.CompareTo(q);
            if (result > 0)
            {
                Console.WriteLine("Second is less than first");
            }
            else if (result < 0)
            {
                Console.WriteLine("Second is greater than first");
            }
            else
            {
                Console.WriteLine("Second is equal to first");
            }
            //Console.WriteLine(result);
        }
    }
}

