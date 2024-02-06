using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Antti-Jussi Lakanen
/// @version 06.02.2024
/// <summary>
/// Luento 9, taulukot.
/// </summary>
public class Taulukot
{
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        // Alla useita "samaan asiaan" 
        // liittyviä muuttujia
        int luento1 = 200;
        int luento2 = 180;
        int luento3 = 100;
        int luento4 = 50;
        int luento5 = 57;

        int summa = luento1 + luento2 + luento3 + luento4 + luento5;
        double keskiarvo = summa / 5.0;
        Console.WriteLine($"Luennoille osallistui keskimäärin {keskiarvo} opiskelijaa.");
        
        // Luvut voidaan sijoittaa taulukkoon.
        int[] luentojenOsallistujat = { 200, 180, 100, 50, 57 };
        int summa2 = luentojenOsallistujat[0]
                     + luentojenOsallistujat[1]
                     + luentojenOsallistujat[2]
                     + luentojenOsallistujat[3]
                     + luentojenOsallistujat[4];
        double keskiarvo2 = summa2 * 1.0 / luentojenOsallistujat.Length;
        Console.WriteLine($"Luennoille osallistui keskimäärin {keskiarvo2} opiskelijaa.");

        // Yritetään laittaa taulukkoon "kuudes" luento ja sille osallistujamäärä 20
        // luentojenOsallistujat[5] = 20;
        
        int summa3 = 0;
        // Taulukon läpikäymiseen voidaan hyödyntää silmukkaa.
        // Käymme läpi taulukkoa alkaen indeksistä 0, ja päättyen indeksiin "Length"
        for (int i = 0; i < luentojenOsallistujat.Length; i++)
        {
            // Console.WriteLine($"Paikassa {i} on luku: {luentojenOsallistujat[i]}");
            summa3 += luentojenOsallistujat[i];
        }
        
        double keskiarvo3 = summa3 * 1.0 / luentojenOsallistujat.Length;
        Console.WriteLine(summa3);
        Console.WriteLine($"Luennoilla oli keskimäärin {keskiarvo3} opiskelijoita.");
        
        // Taulukon luontitapa nro 1 
        string[] henkilot = new string[5];
        henkilot[0] = "Antti-Jussi";
        henkilot[1] = "Jonne";
        henkilot[2] = "Vesa";
        henkilot[3] = "Tuomo";
        // Viides alkio jäisi nyt "null"-arvoon.

        int[] luvut = new int[] { 3, 5, 2, 9 };
        // luvut[4] = 10; // Menisi jo taulukon ulkopuolelle, eikä ole siten mahdollista 

    }
}