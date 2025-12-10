namespace Studentadministrasjonssystem
{
    internal class Program
    {
        private static List<Student> students;
        private static List<Fag> subjects;
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

            SkrivUtAllInfo();
        }
        public static void SkrivUtAllInfo()
        {
            Console.WriteLine("Studenter:");
            Console.WriteLine("~~~~~~~~~~");
            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
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
        }
    }
}
