using Linq_15._Group_Join.Model;

namespace Linq_15._Group_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Id = 1, FullName = "Matt Nathan", CourseId = 1 },
                new Person { Id = 2, FullName = "Kevin Levis", CourseId = 2 },
                new Person { Id = 3, FullName = "George Harrison", CourseId = 1 },
                new Person { Id = 4, FullName = "Johnny Clarkson" , CourseId = 2},
                new Person { Id = 4, FullName = "Johnny Clarkson", CourseId = 3 },
                new Person { Id = 5, FullName = "Austin Dunham", CourseId = 4 },
                new Person { Id = 5, FullName = "Austin Dunham" },
            };

            List<Course> courses = new List<Course>()
            {
                new Course() { Id = 1, Name = "Course 1" },
                new Course() { Id = 2, Name = "Course 2" },
                new Course() { Id = 3, Name = "Course 3" },
                new Course() { Id = 4, Name = "Course 4" },
                new Course() { Id = 5, Name = "Course 5" },
            };

            //Lambda Group Join

            var group_inner_join = courses.GroupJoin(
                people,
                course => course.Id,
                person => person.CourseId, 
                (course, groupOfPeople) => new
                {
                    People = groupOfPeople,
                    CourseName = course.Name,
                    CourseId = course.Id,
                });

            foreach (var result in group_inner_join)
            {
                Console.WriteLine(result.CourseName);
                foreach (var item in result.People)
                {
                    Console.WriteLine(item.FullName);
                }
                Console.WriteLine();
            }

            //Linq GroupJoin
            var group_inner_join_Linq = from course in courses
                                        join person in people
                                        on course.Id equals person.CourseId
                                        into personGroup
                                        select new
                                        {
                                            Attendants = personGroup,
                                            CourseName = course.Name
                                        };

            Console.WriteLine("Linq Group Join:");
            foreach (var result in group_inner_join_Linq)
            {
                Console.WriteLine(result.CourseName);
                foreach (var item in result.Attendants)
                {
                    Console.WriteLine(item.FullName);
                }
                Console.WriteLine();
            }

        }
    }
}
