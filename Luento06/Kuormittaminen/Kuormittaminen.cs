using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 6.
/// Kokeillaan aliohjelman kuormittamista.
/// </summary>
public class Kuormittaminen
{

    /// <summary>
    /// Tulosta henkilön nimi ja ikä
    /// </summary>
    /// <param name="nimi">Nimi</param>
    /// <param name="ika">Ikä</param>
    /// <returns></returns>
    public static void TulostaNimiJaIka(string nimi, string ika)
    {
        Console.WriteLine($"Henkilön nimi: {nimi}");
        Console.WriteLine($"Henkilön ikä: {ika}");
    }

    /// <summary>
    /// Tulosta henkilön nimi. Lisäksi tulostetaan,
    /// että ikää ei syötetty.
    /// </summary>
    /// <param name="nimi"></param>
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
    
    /// <summary>
    /// Kokeillaan kutsua kuormitettuja aliohjelmia.
    /// </summary>
    public static void Main()
    {
        TulostaNimiJaIka("Antti-Jussi Lakanen", "41");
        TulostaNimiJaIka("Pekka Puupää");
    }
}