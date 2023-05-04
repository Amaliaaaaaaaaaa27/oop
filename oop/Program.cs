// calculam volumul unui dulap 
//  
using OOP;
using System;

namespace Csharp
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va rugam sa setati dimensiunile unui dulap dorit");

            Console.WriteLine("Introduce ti lungimea = ");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce ti latimea = ");
            int latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce ti inaltimea = ");
            int inaltime = int.Parse(Console.ReadLine());

            //facem instanta dupa constructor 

            DULAP dulap = new DULAP(lungime, latime, inaltime);

            dulap.Tipareste();

            Console.WriteLine($"Volumul dulapului ales cu dimensiunile lungime {lungime} cm , latima {latime} cm si inaltimea de  {inaltime} cm = {dulap.VolumDulap} cm cubi   ");
        }

       
    }  
}



