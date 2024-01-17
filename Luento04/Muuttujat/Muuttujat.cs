using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Antti-Jussi Lakanen
/// @version 2024
/// <summary>
/// Luento 4, muuttujat.
/// </summary>
public class Muuttujat
{
    /// <summary>
    /// Luodaan muuttujia ja muutellaan niiden arvoja. 
    /// </summary>
    public static void Main()
    {
        int luku = 3;
        Console.WriteLine(luku);
        luku = 4;
        Console.WriteLine(luku);
        
        int a = 3 + 5;
        Console.WriteLine(a);

        a = 3 * 5 + 6 - 2;
        Console.WriteLine(a);

        double b = 1.5; 
        
        // a = 2 + 1.5; //  // tämä ei ole int-tyyppinen lauseke, joten tästä aiheutuu käännösvirhe!

        a = 5;
        a = a * 5;
        Console.WriteLine(a);

        b = b + 1; // Tämä onnistuu, koska lopputulemana on double-tyyppinen arvo
        Console.WriteLine(b);

        b = a + b; // 25 + 2.5 = 27.5
        Console.WriteLine(b);

        const int MUN_IKA = 41;
        Console.WriteLine(MUN_IKA);
        // MUN_IKA = 42; // Vakiota ei voi muuttaa

        int eka = 1;
        int toka = 2;
        int temp = toka;
        toka = eka; // sekä ekassa että tokassa on 1
        eka = temp; // ekaan laitetaan 2
        Console.WriteLine("Eka: " + eka);
        Console.WriteLine("Toka: " + toka);

        // eka.ToString(); // Tämä huomiona siitä, että myös int-tyyppisellä muuttujalla on "toimintoja" (ohjelmointitermeillä metodeja)

        int munIka = 41;
        // munIka = munIka + 1;
        // `++` on arvoa muuttava operaattori, eli "toisenlainen" sijoitusoperaattori
        munIka++;
        Console.WriteLine(munIka);
        munIka--;
        Console.WriteLine(munIka);
        munIka--;
        Console.WriteLine(munIka);
        // Tämä tekee saman asiak kuin munIka = munIka - 1; 

        int munLuku = 5;
        munLuku = munLuku / 3;
        // Kokonaislukujen jakolaskun yhteydessä voi
        // tapahtua desimaaliosan leikkautuminen pois!
        // Tätä täytyy varoa!
        Console.WriteLine(munLuku);

        // Tieto voi tulla myös "ulkoa" syötteenä, tässä tapauksessa
        // käyttäjän näppäimistöltä. Syöte voidaan tallentaa
        // muuttujaan. 
        string syote = Console.ReadLine();
        Console.WriteLine(syote);
        Console.WriteLine(syote.Length);
    }
}