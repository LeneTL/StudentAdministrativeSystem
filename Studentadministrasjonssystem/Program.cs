namespace Studentadministrasjonssystem
{
    internal class Program
    {// I apologize for the mix of norwegian and english in this! bad practice, I know
        private static List<Student> students;
        private static List<Fag> subjects;
        private static List<Karakter> karakterer;
        static void Main()
        {
            students = new List<Student>
            {
                new Student(1, "Julie", 22, "Maritimt"),
                new Student(2, "Bob", 27, "Helse"),
            };
            subjects = new List<Fag>
            {
                new Fag(54, "Redstone", 100),
                new Fag(32, "Coral", 30),
                new Fag(84, "C#", 80),
                new Fag(75, "Kiropraktor", 10),
            };
            karakterer = new List<Karakter>
            {
                new Karakter(students[0], subjects[0], 6),
                new Karakter(students[0], subjects[2], 4),
                new Karakter(students[1], subjects[1], 3),
                new Karakter(students[1], subjects[3], 4),

            };

            SkrivUtAllInfo();
        }
        public static void SkrivUtAllInfo()
        {
            Console.WriteLine("Studenter:");
            Console.WriteLine("~~~~~~~~~~");
            //for (int i = 0; i < students.Count; i++)
            //{

            //    students[i].SkrivUtInfo();
            //    Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
            //}
            foreach (Student student in students)
            {
                student.SkrivUtInfo();
                Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");

            }

            Console.WriteLine("Fag:");
            Console.WriteLine("-----");
            foreach (Fag fag in subjects)
            {
                fag.SkrivUtInfo();
                Console.WriteLine("*--------------------------------*");
            }

            Console.WriteLine("Karakter:");
            Console.WriteLine("^v^v^v^v^v");
            foreach (Karakter karakter in karakterer)
            {
                karakter.SkrivUtInfo();
                Console.WriteLine("*^v^v^v^v^v^v^v^v^v^v^v^v^v^v^v^v^*");
            }
        }
    }
}
