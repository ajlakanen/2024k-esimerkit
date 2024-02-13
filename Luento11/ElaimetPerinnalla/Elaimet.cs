using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Elaimet;

/// @author Antti-Jussi Lakanen
/// @version 2024
/// 
/// <summary>
/// Eläimet perinnällä.
/// Toimikoon tämä johdantona olio-ohjelmointiin.
/// Tämä on "pääluokka", josta ohjelma käynnistetään ja toimii
/// ikään kuin käyttöliittymänä.
/// </summary>
public class Elaimet
{
    /// <summary>
    /// Pääohjelmassa luodaan eläinoliot ja muutetaan 
    /// niiden arvoja ja kutsutaan metodeja.
    /// </summary>
    public static void Main()
    {
        Koira moppi = new Koira("Moppi", 15.5);
        Console.WriteLine($"{moppi.Nimi} painaa {moppi.Paino} kg.");
        moppi.Paino = 10.25;
        moppi.Rotu = "Coton de Tulear";
        moppi.ID = "1";
        Console.WriteLine($"{moppi.Nimi} ({moppi.ID}) painaa {moppi.Paino} kg.");
        moppi.Aantele();
        
        Koira rekku = new Koira("Rekku", 20.5);
        rekku.Rotu = "Saksanpaimenkoira";
        Console.WriteLine($"{rekku.Nimi} ({rekku.Rotu}) painaa {rekku.Paino} kg.");
        rekku.Aantele();

        Kissa nauku = new Kissa("Nauku");
        nauku.Rotu = "Siamilainen";
        nauku.HannanPituus = 30;
        Console.WriteLine($"Kissa nimeltään {nauku.Nimi} on rodultaan {nauku.Rotu} ja sen hännän pituus on {nauku.HannanPituus}");
        nauku.Aantele();

        Marsu nuppu = new Marsu("Nuppu");
        nuppu.Rotu = "Pallo";
        nuppu.Aantele();
        nuppu.JuokseJuoksupyorassa(100);
        // nuppu.jaljellaOlevienKierrostenLkm = 1000;
        Console.WriteLine($"Onko {nuppu.Nimi} vielä elossa? {nuppu.OnkoElossa}");
        for (int i = 0; i < 5; i++)
        {
            nuppu.JuokseJuoksupyorassa(100);
        }

        Console.WriteLine($"Onko {nuppu.Nimi} vielä elossa? {nuppu.OnkoElossa}");

        Elain[] elaimet = { moppi, rekku, nauku, nuppu };
        Console.WriteLine(elaimet.Length);
        for (int i = 0; i < elaimet.Length; i++)
        {
            Console.WriteLine($"{elaimet[i].Nimi}, {elaimet[i].Rotu}");
        }
    }
}