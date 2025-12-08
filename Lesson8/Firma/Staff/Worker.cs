using Firma.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Staff
{
    internal class Worker : IJobTitle
    {

        public string GetJobTitle()
        {
            string worker = "Worker";
            Console.WriteLine(worker);
            return worker;
        }
    }
}
