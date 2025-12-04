using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorTest.MyClasses
{
    public class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello!!!");
        }

        private int Age;

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }
        
        
    }
}
