using Linq_13._Join.Model;

namespace Linq_13._Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Linq Join 2 list

            IList<string> numbers = new List<string>()
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six"
            };
            IList<string> numbers2 = new List<string>()
            {
                "two",
                "ten",
                "eleven",
                "six",
                "four",
                "thirteen"
            };

            Console.WriteLine("Linq Join example: ");

            var matching_nums = numbers.Join(numbers2,
                str1 => str1,
                str2 => str2,
                (str1, str2) => str2);

            foreach (var num in matching_nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            #endregion

            #region Join 2 classes

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

            //Lambda Join:

            var inner_join = people.Join(
                courses,
                person => person.CourseId,
                course => course.Id,
                (person, course) => new
                {
                    Name = person.FullName,
                    Course = course.Name,
                    CourseId = course.Id,
                });

            Console.WriteLine("Lambda inner join: ");

            foreach (var result in inner_join)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();

            //Linq Join

            var inner_join_Linq = from p in people
                                  join c in courses
                                  on p.CourseId equals c.Id
                                  select new
                                  {
                                      Name = p.FullName,
                                      Course = c.Name,
                                      CourseId = c.Id
                                  };

            Console.WriteLine("Linq inner join: ");

            foreach (var result in inner_join)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();

            #endregion
        }
    }
}
