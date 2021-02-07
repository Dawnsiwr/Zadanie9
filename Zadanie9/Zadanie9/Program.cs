using System;
using System.Collections.Generic;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "test";
            List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();
            Kanal kanal = new Kanal("Programowanie w C#", 1);
            for(int i=0;i<10;i++)
            {
                uzytkownicy.Add(new Uzytkownik((name + i), i));
            }

           foreach(var uzytkownik in uzytkownicy)
            {
                uzytkownik.SubskrybujKanal(kanal);
                kanal.WyswietlFilm(1);
                kanal.WyswietlFilm(2);

            }

            kanal.OpublikujFilm();

            kanal.InformacjeOKanale();

            

        }
    }
}
