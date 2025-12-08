using Firma.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Firma.Staff
{
    internal class Director : IJobTitle
    {
        public string GetJobTitle()
        {
            string director = "Director";
            Console.WriteLine(director);
            return director;
        }
        
    }
}
