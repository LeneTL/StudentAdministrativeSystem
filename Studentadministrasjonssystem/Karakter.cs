using System;
using System.Collections.Generic;
using System.Text;

namespace Studentadministrasjonssystem
{
    internal class Karakter
    {
        private Student Student { get; set; }
        private Fag Fag { get; set; }
        private int Karakterverdi { get; set; }
      
        
        public void SkrivUtInfo()
        {
            Console.WriteLine();


        }
    }
}