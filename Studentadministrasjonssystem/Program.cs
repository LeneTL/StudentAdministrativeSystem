namespace Studentadministrasjonssystem
{
    internal class Program
    {
        private static List<Student> students;
        static void Main()
        {
            students = new List<Student>
            {
                new Student(1, "Julie", 22, "Maritimt"),
                new Student(2, "Bob", 27, "Helse"),
            };

            SkrivUtAllInfo();
        }
        public static void SkrivUtAllInfo()
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].SkrivUtInfo();
            }


        }
    }
}
