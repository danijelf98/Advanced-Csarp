namespace Interface_1._Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor()
            {
                FirstName = "Professor Name",
                LastName = "Professor LastName",
                PIN = "123456789"
            };
            Student student = new Student()
            {
                FirstName = "Student Name",
                LastName = "Student LastName",
                PIN = "123456789"
            };
            Employee employee = new Employee()
            {
                FirstName = "Employee Name",
                LastName = "Employee LastName",
                PIN = "123456789"
            };

            ShowPerson(professor);
            ShowPerson(student);
            ShowPerson(employee);

            ShowEmployee(professor);
            ShowEmployee(employee);
        }
        static void ShowPerson(IPerson person)
        {
            Console.WriteLine("Personal details: ");
            Console.WriteLine();
            Console.WriteLine($"Name: {person.FirstName}");
            Console.WriteLine($"LastName: {person.LastName}");
            Console.WriteLine($"PIN: {person.PIN}");
            Console.WriteLine();
        }
        static void ShowEmployee(IEmployee employee)
        {
            Console.WriteLine("Employee information: ");
            employee.PrintSection();
            employee.PrintManager();
            Console.WriteLine();
        }
    }
}
