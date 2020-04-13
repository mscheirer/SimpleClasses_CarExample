using System;
using System.Security.Principal;

namespace SimpleClasses_CarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Se creaza o instanta pentru clasa Masina prin care se realizeaza alocarea in memorie.
            Masina masinaMea = new Masina();

            // 3. SET the properties
            masinaMea.Fabricant = "Opel";
            masinaMea.Model = "Astra Bertone";
            masinaMea.AnFabricatie = 2001;
            masinaMea.Culoare = "Argintiu";

            // 4. GET the properties
            Console.WriteLine("{0} {1} {2} {3}", 
                masinaMea.Fabricant, 
                masinaMea.Model, 
                masinaMea.AnFabricatie, 
                masinaMea.Culoare) ;

            // 8.    -   // 6.
            // decimal valoare = PretDePiata(masinaMea);
            // Console.WriteLine("{0:C}", valoare);
            
            // 9. 
            Console.WriteLine("{00:C}", masinaMea.PretDePiata());


            Console.ReadLine();
        }

        /* 10 - nu mai e nevoie; e definit la pct 7, direct in clasa Masina
        private static decimal PretDePiata (Masina car)
        {
            // 5.
            decimal valoareMasina = 100.0M;
            // Tema: de luat pretul de pe un portal web

            return valoareMasina;

        }
    */
    }

    class Masina
    {
        // 1. Se definesc proprietatile (caracteristicile) clasei Masina - "pro + Tab + Tab"
        public string Fabricant { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public string Culoare { get; set; }

        /*  Definirea proprietatilor - varianta extinsa - propfull + Tab Tab
        private int myVar;

        public int AnFabricatie
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */

        // 7. 
        public decimal PretDePiata ()
        {
            decimal valoareMasina;
            if (AnFabricatie > 2000)
                valoareMasina = 2000;
            else
                valoareMasina = 100;

            return valoareMasina;
        }
    }
}
