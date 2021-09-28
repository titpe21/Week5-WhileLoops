using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!"
            //kui sisestatud PIN-kood on midagi muud, konsool kuvab "Vale PIn. Proovi uuesti."
            //tingumus 1. katsete arv on piiramatu
            //tingimus 2. kasutajal on kolm katset

            //boolean = true/false

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Hello world!");
                i = i + 1;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
