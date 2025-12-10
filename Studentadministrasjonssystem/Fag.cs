using System;
using System.Collections.Generic;
using System.Text;

namespace Studentadministrasjonssystem
{
    internal class Fag
    {
        public int FagKode { get; set; }
        public string FagNavn { get; set; }
        public int AntallStudiepoeng { get; set; }

        public Fag(int fagkode, string fagnavn, int antallStudiepoeng)
        {
            FagKode = fagkode;
            FagNavn = fagnavn;
            AntallStudiepoeng = antallStudiepoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {FagKode}\nFagnavn: {FagNavn}\nStudiepoeng: {AntallStudiepoeng}");
        }
    }
}
