using System;

namespace Zadanie9
{
    internal class Uzytkownik
    {
        public string Nazwa { get; set; }
        public int Id { get; set; }

        public Uzytkownik(string  nazwa, int  id)
        {
            Nazwa = nazwa;
            Id = id;
        }

        public event EventHandler Subskrypcja;

        protected virtual void OnSubskrypcja(object o, EventArgs e)
        {

            Console.WriteLine("Użytkownik: " + Id + " | " + Nazwa + " otrzymał powiadomienie o nowym filmie\n");
        }

        public void SubskrybujKanal(Kanal kanal)
        {
            kanal.OpublikowanoFilm += this.OnSubskrypcja;
            kanal.LicznikSubskrypcji++;
        }

    }
}