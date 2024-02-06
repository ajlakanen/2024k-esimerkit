using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Antti-Jussi Lakanen
/// @version 2024
/// 
/// <summary>
/// Luento 9, while ja do-while
/// </summary>
public class Silmukat
{
    /// <summary>
    /// Silmukat 
    /// </summary>
    public static void Main()
    {
        // while-silmukkarakenne soveltuu hyvin tilanteisiin, 
        // joissa toistojen määrä ei ole ennalta tiukasti kiinnitetty.
        double kerrottava = 1.0;
        int kierroksia = 0;
        while (kerrottava <= 1000)
        {
            kerrottava = kerrottava * 1.1;
            kierroksia++;
        }

        Console.WriteLine($"Luku on: {kerrottava}");
        Console.WriteLine($"Tehtiin {kierroksia} kierrosta.");
        
        // Hallittu ikuinen silmukka
        string syote = "";
        while (true)
        {            
            Console.Write("Anna syöte > ");
            syote = Console.ReadLine();
            if (syote == "Jypeli") break;
        }

        Console.WriteLine("Annoit oikean salasanan!");
        
        // Lopuksi vielä do-while-rakenne.
        // do-osa tehdään aina vähintän yhden kerran.
        int laskuriDoWhile = 0;
        do
        {
            Console.WriteLine(laskuriDoWhile);
            laskuriDoWhile++;
        } while (laskuriDoWhile < 0);
    }
}