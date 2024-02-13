using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Antti-Jussi Lakanen
/// @version 13.02.2024
/// 
/// <summary>
/// Luento 11.
/// </summary>
public class SilmukatJaTaulukot
{
    /// <summary>
    /// Luento 11.
    /// </summary>
    public static void Main()
    {
        // TODO: Tehdään 10 pituinen taulukko johon luvut 1..10
        int[] taulukko1 = new int[10];
        // taulukko1[0] = 1;
        // taulukko1[1] = 2;
        for (int i = 0; i < taulukko1.Length; i++)
        {
            taulukko1[i] = i + 1;
        }
        
        // TODO: Tulosta taulukko
        // Console.WriteLine(taulukko1);
        foreach (int t in taulukko1)
        {
            Console.WriteLine(t);
        }
        
        // TODO: Tehdään 7 pituinen taulukko johon luvut 7..1
        int[] taulukko2 = new int[7];
        for (int i = 0; i < taulukko2.Length; i++)
        {
            taulukko2[i] = taulukko2.Length - i;
        }

        // TODO: Taulukko funktion paluuarvona
        int[] taulukko3 = TeeTaulukko();
        
    }

    public static int[] TeeTaulukko()
    {
        int[] taulukko = new int[5];
        for (int i = 0; i < taulukko.Length; i++)
        {
            taulukko[i] = i + 1;
        }
        return taulukko;
    }
}
