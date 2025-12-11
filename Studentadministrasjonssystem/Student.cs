using System;
using System.Collections.Generic;
using System.Text;

namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudyProgram { get; set; }

        public List<Fag> Fag { get; set; }


        public Student(int studentId, string name, int age, string studyProgram, List<Fag> fag)
        {
            StudentID = studentId;
            Name = name;
            Age = age;
            StudyProgram = studyProgram;
            Fag = fag;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"StudentId: {StudentID} \nNavn: {Name} \nAlder: {Age}\nStudieProgram: {StudyProgram} \nFag:");

            foreach (var fag in Fag)
            {
                Console.WriteLine(" " + fag.FagNavn);
            }
        }
    }
}
