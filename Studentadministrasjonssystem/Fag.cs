using System;
using System.Collections.Generic;
using System.Text;

namespace Studentadministrasjonssystem
{
    internal class Fag
    {
        private int FagKode { get; set; }
        private string FagNavn { get; set; }
        private int AntallStudiepoeng { get; set; }

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
