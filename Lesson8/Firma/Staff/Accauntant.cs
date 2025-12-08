using Firma.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Staff
{
    internal class Accauntant : IJobTitle
    {
        public string GetJobTitle()
        {
            string accauntant = "Accauntant";
            Console.WriteLine(accauntant);
            return accauntant;
        }
    }
}
