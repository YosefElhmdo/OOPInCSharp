using static Classlib.Program;

namespace Classlib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Employee();
            foreach (Employee i in Employee.list)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.BaseSalary);
            }
        }
    }

}