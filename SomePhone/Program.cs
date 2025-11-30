using SomePhone.MyClasses;

namespace SomePhone
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone(68484846, "Apple");
            phone1.ReceiveCall("Jim");
            phone1.GetNumber(8465215);

            Phone phone2 = new Phone(65468468, "Sumsung");
            phone2.ReceiveCall("Piter");
            phone2.GetNumber(6325387);

            Phone phone3 = new Phone(68468562, "Nokia", 458);
            phone3.ReceiveCall("Chloe");
            phone3.GetNumber(505189799);

            Phone phone4 = new Phone();
            phone4.ReceiveCall("Emma", 6855286);
            phone4.SendMessage(43241231, 34297976, 68468469);

        }
    }
}
