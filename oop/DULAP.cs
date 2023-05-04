using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//aceste campuri  lungime latime inaltime  sunt campuri publice sau private ?
// private  

namespace OOP
{
    class DULAP
    {
        // sunt private deoarece nu dorim sa fie modificate
        private readonly int lungime; // readonly = noi nu putem modifica lungimea din exterior 
        private readonly int latime;
        private readonly int inaltime;

        //constructorul
        //- o functie a clasei 
        // -numele functiei = numele clasei
        //-nu are tip returnat
        //-folosit pentru intializarea unor variabile
        //-poate primi parametri
        // intr un constructor folosim campuri care fara acestea nu ar avea sens obiectul si nu ar exista 
        // intotdeauna constructori sunt publici
        public DULAP(int lungime, int latime, int inaltime) // asamblam obiectul
        {
            this.lungime = lungime; // cand punem punct apelam la membri unei clase 

            this.latime = latime;

            this.inaltime = inaltime;

        }
        public void Tipareste() //metode = functii 
        {
            Console.WriteLine($"Dulapul are lungimea {lungime} cm ,latime {latime} cm ,inatlimea{inaltime} cm");

        }
        // daca folosim private la o metoda nu o mai putem apela in program.cs
        public int VolumDulap(int lungime, int latime, int inaltime) 
        {
            int calculeazaVolum = lungime * latime * inaltime;

            return calculeazaVolum;
        }

    }
}

