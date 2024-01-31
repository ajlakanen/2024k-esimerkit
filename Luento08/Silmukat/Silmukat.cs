using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 8, silmukat.
/// </summary>
public class Silmukat
{
    /// <summary>
    /// Luento 8, silmukat.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Tulostusta while-silmukan avulla");
        
        // Tulostetaan luvut 0..9
        // i-muuttuja toimii "laskurina"
        int i = 0;
        while (i < 10) // toistoehto, jonka ollessa voimassa silmukan runko-osa suoritetaan
        { // runko-osaksi kutsutaan aaltosulkeiden rajaamaa aluetta
            Console.WriteLine(i);
            i++;
        }

        i = 0;
        while (i < 10) // 0..9
        {
            Console.WriteLine(i * 2);
            i++;
        }
        
        // Laskuri-muuttuja voi olla minkä niminne vain, esim j
        Console.WriteLine("Käytetään laskuri-muuttujan nimenä nyt j:tä");
        int j = 0;
        while (j < 10)
        {
            Console.WriteLine(j);
            // Nämä kolme asiaa tekevät tässä täysin saman asian. 
            // j++;
            // j = j + 1;
            j += 1;
        }
        
        // Tällä kerralla lähdetäänkin isosta luvusta
        int k = 13;
        while (k > -5)
        {
            Console.WriteLine(k);
            k--;
            k--;
        }
        
        // Kertaus ++ -operaattorin käyttämisestä: 
        // k++; // lisäys suoritetaan k arvon käyttämisen jälkeen
        // ++k; // lisäys suoritetaan ENNEN arvon käyttämistä
        Console.WriteLine("Kokeillaan vielä ++ -operaattoria");
        int luku = 3;
        Console.WriteLine(luku);   // 3
        Console.WriteLine(luku++); // Mitä tulostuu? // 3
        Console.WriteLine(luku);   // Mitä tulostuu? // 4
        Console.WriteLine(++luku); // Mitä tulostuu? // 5
        Console.WriteLine(luku);   // Mitä tulostuu? // 5
        
        // Sitten for-silmukka: 
        Console.WriteLine("Otetaan seuraavaksi for-silmukka:");
        
        // for-silmukan yleinen rakenne:
        // for (ALUSTUS/ALUSTUKSET; TOISTOEHTO; LOPETUSTOIMET)
        // {
        //    // runko-osa
        // }
        
        for (int m = 0; m < 5; m++)
        {
            Console.WriteLine("Tulostusta forilla: " + m);
        }
        Console.WriteLine("====");

        // Tehdään vastaava 13, 11, 9, ... tulostus forilla
        for (int m = 15; m > -5; m -= 2)
        {
            Console.WriteLine(m);
        }
        
        // Alustus-kohdassa voidaan määritellä useita muuttujia
        for (int paiva = 0, kissat = 13; paiva < 5; paiva++, kissat += 2)
        {
            Console.WriteLine($"Päivänä {paiva} meillä on {kissat} kissaa");
        }
        
        // For-silmukalla voidaan tehdä jopa ikuinen silmukka
        for (int l = 0; true; l++)
        {
            Console.WriteLine($"Ikuinen silmukka on nyt menossa kohdssa {l}");
        }       
    }
}