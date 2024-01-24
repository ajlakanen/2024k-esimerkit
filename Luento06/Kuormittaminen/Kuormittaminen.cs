using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Kuormittaminen
{

    public static void TulostaNimiJaIka(string nimi, string ika)
    {
        Console.WriteLine($"Henkilön nimi: {nimi}");
        Console.WriteLine($"Henkilön ikä: {ika}");
    }

    public static void TulostaNimiJaIka(string nimi)
    {
        // Copy-pastetusta ei tarvita: 
        // Console.WriteLine($"Henkilön nimi: {nimi}");
        // Console.WriteLine($"Henkilön ikä: [Ikää ei syötetty]");
        
        // Vaan voimme kutsua "erikoistuneempaa" aliohjelmaa,
        // jolle välitämme argumenttina saadut parametrit
        // (tässä tapauksessa vain yhden parametrin)
        // ja lisäksi ikä-parametrin kiinteänä merkkijonona
        TulostaNimiJaIka(nimi, "[Ikää ei syötetty]");
    }
    
    public static void Main()
    {
        TulostaNimiJaIka("Antti-Jussi Lakanen", "41");
        TulostaNimiJaIka("Pekka Puupää");
    }
}