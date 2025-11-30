using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SomePhone.MyClasses
{
    public class Phone
    {
        public int number;
        public string model;
        public float weight;

        public Phone(int number, string model, float weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public Phone(int number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone()
        {
        }

        public Phone(int number, string model, int weight) : this(number, model)
        {
            this.weight = weight;
        }



        //public void RandomNumber()
        //{
        //    Random rand = new Random();
        //    number = rand.Next(1000000, 9999999);
        //}

        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"\nIncoming call from {callerName}");
        }

        public void ReceiveCall(string callerName, int number)
        {
            Console.WriteLine($"\nIncoming call from {callerName}, number: {number}");
        }

        public void GetNumber(int number)
        {
            Console.WriteLine($"Number is - {number}");
        }

        public void SendMessage(params int[] numbers)
        {
            Console.WriteLine("\nSending massage to following numbers: ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
