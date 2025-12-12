using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudyProgram { get; set; }
        public List<Fag> Fag { get; set; }
        public List<Karakter> Karakter { get; set; }


        public Student(int studentId, string name, int age, string studyProgram, List<Fag> fag)
        {
            StudentID = studentId;
            Name = name;
            Age = age;
            StudyProgram = studyProgram;
            Fag = fag;
            Karakter = new List<Karakter>();
        }
        public void LeggTilKarakter(Karakter karakter)
        {
            Karakter.Add(karakter);
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"StudentId: {StudentID}");
            Console.WriteLine($"Navn: {Name}");
            Console.WriteLine($"Alder: {Age}");
            Console.WriteLine($"StudieProgram: {StudyProgram}");
            Console.WriteLine($"Fag:  Karakter:");

            foreach (var karakter in Karakter)
            {
                Console.WriteLine(karakter.Fag.FagNavn + "  -  "+ karakter.Karakterverdi);
            }

            Console.WriteLine($"Gjennomsnitt: {GjennomsnittsKarakter()}");
            Console.WriteLine($"StudiePoeng: {Studiepoeng()}");

        }

        public decimal GjennomsnittsKarakter()
        {
            int sum = 0;
            foreach (var karakter in Karakter)
            {
                sum += karakter.Karakterverdi;
            }
            decimal gjennomsnitt = (decimal)sum / Karakter.Count;
            return gjennomsnitt;
        }

        public int Studiepoeng()
        {
            int studiepoeng = 0;
            foreach (var subjects in Fag)
            {
                studiepoeng += subjects.AntallStudiepoeng;
            }
            return studiepoeng;
        }
        
    }
}
