using Firma.Staff;

namespace Firma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            director.GetJobTitle();

            Accauntant accauntant = new Accauntant();
            accauntant.GetJobTitle();

            Worker worker = new Worker();
            worker.GetJobTitle();
        }
    }
}
