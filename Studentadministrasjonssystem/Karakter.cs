using System;
using System.Collections.Generic;
using System.Text;

namespace Studentadministrasjonssystem
{
    internal class Karakter
    {
        public Student Student { get; set; }
        public Fag Fag { get; set; }
        public int Karakterverdi { get; set; }

        public Karakter(Student student, Fag fag, int karakterverdi)
        {
            Student = student;
            Fag = fag;
            Karakterverdi = karakterverdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {Student.Name}, \nFag: {Fag.FagNavn}, \nKarakterverdi: {Karakterverdi}");

        }
    }
}