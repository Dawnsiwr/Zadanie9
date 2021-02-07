using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie9
{
    static class ExtensionMethod
    {
        public static void InformacjeOKanale(this Kanal kanal)
        {
            Console.WriteLine("Kanał: " + kanal.Nazwa);
            Console.WriteLine("Ilość wszystkich wyświetleń: " + kanal.LicznikWyswietlen);
            Console.WriteLine("Ilość subskrypcji: "+ kanal.LicznikSubskrypcji);
        }
    }
}
