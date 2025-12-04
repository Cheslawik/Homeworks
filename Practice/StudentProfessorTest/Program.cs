using StudentProfessorTest.MyClasses;

namespace StudentProfessorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();
            Teacher teacher = new Teacher();

            person.Greet();

            Console.WriteLine("");

            student.Study();
            student.SetAge(20);
            student.Greet();
            student.ShowAge();

            Console.WriteLine("");

            teacher.SetAge(55);
            teacher.Greet();
            teacher.Explain();
        }
    }
}
