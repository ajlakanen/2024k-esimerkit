using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Antti-Jussi Lakanen
/// @version 2024
/// <summary>
/// Luento 7. Merkkijonot
/// </summary>
public class Merkkijonoja
{
    /// <summary>
    /// Merkkijonojen määrittelyä ja tulostuksia. 
    /// </summary>
    public static void Main()
    {
        string jono;
        jono = "Aaa"; // Lainausmerkit
        jono = "Aaa" + "Bbb"; // + -operaattorilla voidaan yhdistää merkkijonoja toisiinsa.
        Console.WriteLine(jono);
        jono = Console.ReadLine();
        int pituus = jono.Length;
        Console.WriteLine($"Annoit merkkijonon, jonka pituus on {pituus}");

        string jonoIsona = jono.ToUpper();
        Console.WriteLine($"Jono {jono} isona on {jonoIsona}");

        string jonoPienena = jono.ToLower();
        Console.WriteLine($"Jono {jono} isona on {jonoPienena}");

        string toinenJono = "Pekka Puupää";

        // 012345678901
        // Pekka Puupää
        
        // Paikkanumeroa kutsutaan indeksiksi
        // Esimerkiksi:
        // indeksissä numero 2 on merkki 'k'
        
        Console.WriteLine(toinenJono[2]);
        
        // Paikassa 2 olevan merkin tyyppi on char
        char indeksinKaksiMerkki = toinenJono[2];

        // Tutkitaan, missä indeksissä 'a'-merkki
        // ensimmäisen kerran esiintyy
        int paikka = toinenJono.IndexOf('a');
        Console.WriteLine($"Jonossa {toinenJono} merkki 'a' esiintyy ensimmäisen kerran paikassa {paikka}.");

        toinenJono = Console.ReadLine();
        Console.Write("Etsittävä merkki > ");
        string etsittavaMerkkiMerkkijonona = Console.ReadLine();
        // Otetaan käyttäjän antamasta syötteestä aivan ensimmäinen merkki
        char etsittavaMerkki = etsittavaMerkkiMerkkijonona[0];
        // Etsitään jonosta ensimmäinen esiintyä siitä merkistä
        // jonka käyttäjä antoi
        paikka = toinenJono.IndexOf(etsittavaMerkki);
        
        // Console.WriteLine($"Jonossa {toinenJono} merkki {etsittavaMerkki} esiintyy ensimmäisen kerran paikassa {paikka}.");
        if (paikka == -1)
        {
            Console.WriteLine($"Merkkiä {etsittavaMerkki} ei löydy!");
        }
        else
        {
            Console.WriteLine($"Merkki {etsittavaMerkki} sijaitsee paikassa {paikka}");
        }
    }
}