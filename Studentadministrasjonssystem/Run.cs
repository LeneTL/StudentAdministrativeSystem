using System;
using System.Collections.Generic;
using System.Text;

namespace Studentadministrasjonssystem
{
    internal class Run
    {
        public List<Student> students;
        public List<Fag> subjects;
        public List<Karakter> karakterer;
        public void Main()
        {
            subjects = new List<Fag>
            {
                new Fag(54, "Redstone", 100),
                new Fag(32, "Coral", 30),
                new Fag(84, "C#", 80),
                new Fag(75, "Kiropraktor", 10),
            };
            students = new List<Student>
            {
                new Student(1, "Julie", 22, "Maritimt", new List<Fag> {subjects[0],subjects[2]}),
                new Student(2, "Bob", 27, "Helse", new List<Fag> {subjects[1],subjects[3]}),
            };
            karakterer = new List<Karakter>
            {
                new Karakter(students[0], subjects[0], 6),
                new Karakter(students[0], subjects[2], 4),
                new Karakter(students[1], subjects[1], 3),
                new Karakter(students[1], subjects[3], 4),

            };

            foreach (var student in students)
            {
                foreach (var karakter in karakterer)
                {
                    if (student.StudentID == karakter.Student.StudentID)
                    {

                        student.LeggTilKarakter(karakter);
                    }
                }
            }


            SkrivUtAllInfo();
        }
        public void SkrivUtAllInfo()
        {
            Console.WriteLine("Studenter:");
            Console.WriteLine("~~~~~~~~~~");
            foreach (Student student in students)
            {
                student.SkrivUtInfo();
                Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*\n");

            }

            Console.WriteLine("Fag:");
            Console.WriteLine("-----");
            foreach (Fag fag in subjects)
            {
                fag.SkrivUtInfo();
                Console.WriteLine("*--------------------------------*\n");
            }

            //Console.WriteLine("Karakter:");
            //Console.WriteLine("----____----");
            //foreach (Karakter karakter in karakterer)
            //{
            //    karakter.SkrivUtInfo();
            //    Console.WriteLine("*____----____----____----____----*\n");
            //}
        }
    }
}

