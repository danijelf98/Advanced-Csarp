namespace Lambda2.ClassProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 3, Name = "Adam", LastName = "Addamic", StudentStatus = false },
                new Student() { Id = 2, Name = "Jordan", LastName = "Jordanic" },
                new Student() { Id = 4, Name = "Bellix", LastName = "Bellixov", StudentStatus = false, Predavac = true },
                new Student() { Id = 5, Name = "Goran", LastName = "Goranov", StudentStatus = false },
                new Student() { Id = 1, Name = "Zeba", LastName = "Zebaric", Predavac = true }
            };

            // Makes an ascending order of students by their name
            var orderedStudentsByName = students.OrderBy(student => student.Name);

            Console.WriteLine("Students are: ");
            foreach (var student in orderedStudentsByName)
            {
                Console.WriteLine(student.Id + " " + student.Name + " " + student.LastName + " " + student.StudentStatus);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Selects studnets by their initials
            var selectByInitials = students.Select(y => new
            {
                Id = y.Id,
                NameLetter = y.Name[0],
                LastNameLetter = y.LastName[0],
                Initials = $"{y.Name[0]}.{y.LastName[0]}"
            });
            Console.WriteLine("Students initials:");
            foreach (var student in selectByInitials)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Selects all students who are also professors

            var selectProfessors = students
                .Where(prof => prof.Predavac)
                .Select(student => new Professor
                {
                    Id = student.Id,
                    Name = student.Name,
                    LastName = student.LastName

                }).ToList();

            Console.WriteLine("Professors:");
            foreach (var professors in selectProfessors)
            {
                Console.Write(professors.Id + " " + professors.Name + " " + professors.LastName);
                Console.WriteLine();
      
            }
            Console.WriteLine();
            Console.WriteLine();

            //Only active students
            var activeStudents = students.Where(student => student.StudentStatus == true);
            foreach (Student active in activeStudents)
            {
                Console.WriteLine(active.Id + " " + active.Name + " " + active.LastName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
