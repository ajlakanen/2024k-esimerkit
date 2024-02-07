using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

/// @author Omanimi
/// @version 07.02.2024
/// <summary>
/// Luento 10. Taulukot
/// </summary>
public class Taulukot
{
    /// <summary>
    /// Vielä taulukoista
    /// </summary>
    public static void Main()
    {
        // TODO: On suositeltavaa, että taulukko sisältää toisiinsa loogisesti liittyviä asioita
        double[] lampotilat = { -1.0, 1.0, 2.0, -15.5, -14.5, -20.0, -30.0 };

        // TODO: Vrt. henkilön tiedot
        double[] henkilonTiedot = { 41.2, 183.0, 75.0, -10.0 };
        // Tähän tarkoitukseen paremmin sopivat luokat, tietueet tai monikot
        // Tällä tavalla tietojen tallentaminen ei ole suositeltavaa.

        // TODO: Taulukon alkioilla on kiinteä tyyppi, kuten muillakin muuttujilla
        // string[] henkilot = { "Antti-Jussi", "Jonne", "Tuomo", 4 };
        // int[] luvut = { 1, 2, 3, "Jono" };

        // TODO: Alkioiden vaihto (ns. swap)
        int[] luvut = { 1, 2, 3, 5, 2, -1, 2, 9, 1, 1, 2, 1, -1, 2, 5 };
        // Vaihdetaan ensimmäinen ja viimeinen alkio päikseen
        // luvut[0] = -1;
        // luvut-taulukon pituus saadaan pyytämällä
        // luvut.Length , tässä tapauksessa 8
        // niinpä vihoviimeinen alkio sijaitsee paikassa (indeksissä) 7
        // luvut.Length-1
        // luvut[luvut.Length - 1] = -1;
        int talteen = luvut[0];
        luvut[0] = luvut[luvut.Length - 1];
        // Uudessa C#:ssa onnistuu myös näin:
        // luvut[0] = luvut[^1];
        luvut[luvut.Length - 1] = talteen;
        // luvut[^1] = talteen;

        // TulostaJos(luvut, 1)
        TulostaJos(luvut, 1);
        
        // TODO: Negatiivisten summa
        double[] luvut2 = { -1.5, -2.0, 0, 2, 5, -3 };
        double summa = NegatiivistenSumma(luvut2);
        Console.WriteLine(summa);
        
        // TODO: Niiden merkkijonojen määrä, joista löytyy kirjain 'a'
        string[] nimet = { "Antti-Jussi", "Jonne", "Vesa", "Tuomo" };
        string[] nimet2 = { "Jonne", "Tuomo" };
        
    }

    public static double NegatiivistenSumma2(double[] luvut)
    {
        double summa = 0.0;
        for (int i = 0; i < luvut.Length; i++) 
        {
            // tutki onko alkion arvo negatiivinen?
            if (luvut[i] < 0)
            {
                // jos on, lisää arvo summaan
                summa += luvut[i];
            }
        }
        return summa;
    }
    
    public static double NegatiivistenSumma(double[] luvut)
    {
        double summa = 0.0;
        foreach (double luku in luvut)
        {
            // tutki onko alkion arvo negatiivinen?
            if (luku < 0)
            {
                // jos on, lisää arvo summaan
                summa += luku;
            }
        }
        return summa;
    }

    public static void TulostaJos(int[] luvut, int arvo)
    {
        // Käydään läpi jokainen alkio taulukosta "luvut"
        // Jos alkion arvo on täsmälleen "arvo"-parametrin arvo
        // Tulostetaan se

        foreach (int luku in luvut)
        {
            if (luku == arvo) // tässä voisi tietysti olla mikä tahansa totuusarvoinen lauseke
            {
                Console.WriteLine(luku);
            }
        }
    }
    
    /// <summary>
    /// Niiden merkkijonojen määrä, joista löytyy kirjain 'a'
    /// </summary>
    /// <param name="jonot"></param>
    /// <returns></returns>
    /// <example>
    /// <pre name="test">
    /// string[] jonot = { "Antti-Jussi", "Jonne", "Vesa", "Tuomo" };
    /// LoytyykoKirjainA(jonot) === 2;
    /// string[] jonot2 = { "Jonne", "Tuomo" };
    /// LoytyykoKirjainA(jonot2) === 0;
    /// string[] jonot3 = {  };
    /// LoytyykoKirjainA(jonot3) === 0;
    /// </pre>
    /// </example>
    public static int LoytyykoKirjainA(string[] jonot)
    {
        int laskuri = 0;
        // Käydään läpi jokainen merkkijono
        foreach (string jono in jonot)
        {
            // Jos jono sisältää kirjaimen 'a', niin lisätään laskuria yhdellä
            if (jono.Contains('a') || jono.Contains('A'))
            {
                laskuri++;
            }
        }
        
        return laskuri;
    }
}