using System;

namespace Zadanie9
{
    public class Kanal
    {
        public string Nazwa{get;set;}
        public int Id { get; set; }
        public int LicznikWyswietlen { get; set; }
        public int LicznikSubskrypcji { get; set; }

        public Kanal(string  nazwa, int id)
        {
            Nazwa = nazwa;
            Id = id;
            LicznikWyswietlen = 0;
        }

        public void WyswietlFilm(int id)
        {
            LicznikWyswietlen++;
        }
        
        public void OpublikujFilm()
        {
            OnOpublikowanoFilm();
        }

        public event EventHandler OpublikowanoFilm;

        protected virtual void OnOpublikowanoFilm()
        {
            if (OpublikowanoFilm != null)
                OpublikowanoFilm(this , EventArgs.Empty);
            
        }

    }
}