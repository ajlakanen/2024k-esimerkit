using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Luento 17, suurimman polun etsiminen.
/// </summary>
public class SuurinPolku
{
    public static void Main()
    {
        string[] luetutRivit = File.ReadAllLines("tree_simple.txt");
        int[,] arvot = new int[luetutRivit.Length, luetutRivit.Length];
        for (int i = 0; i < luetutRivit.Length; i++)
        {
            string[] rivi = luetutRivit[i].Split(' ');
            for (int j = 0; j < rivi.Length; j++)
            {
                arvot[i, j] = int.Parse(rivi[j]);
            }
        }
        
        int[,] arvot2 =
        {
            { 89, 0 , 0 ,  0 , 0  },
            { 70, 2 , 0 ,  0 , 0  },
            { 39, 49, 87,  0 , 0  },
            { 43, 93, 68,  64, 0  },
            { 87, 75, 69,  18, 44 },
        };
        // 89 + 70 + 49 + 93 + 75 = 376

        long ratkaisuja = 0;

        int maksimi = Maksimi(arvot, 0, 0, ref ratkaisuja);
        Console.WriteLine(maksimi);
        Console.WriteLine($"Ratkaisuja käytiin läpi {ratkaisuja} kpl.");

    }

    /// <summary>
    /// Etsitään alakolmiomatriisista sellainen luku joka antaa maksimisumman
    /// kuljettavalle reitille. Reitti lähtee vasemmalta ylhäältä ja sallitut kulkusuunnat
    /// ovat (a) suoraan alas tai (b) suoraan alas ja yksi pykälä oikealle.
    /// </summary>
    /// <param name="arvot"></param>
    /// <param name="rivi">Juurisolmun rivi-indeksi</param>
    /// <param name="sarake">Juurisolmun sarakeindeksi</param>
    /// <param name="ratkaisuja">Kuinka monta kertaa Maksimi-funktiota kutsutaan</param>
    /// <returns></returns>
    public static int Maksimi(int[,] arvot, int rivi, int sarake, ref long ratkaisuja)
    {
        ratkaisuja++;
        // 1. Perustapaus: Ollaan viimeisellä rivillä.
        if (rivi == arvot.GetLength(0) - 1) return arvot[rivi, sarake];
        // 2. Kaikki muut tapaukset 
        return arvot[rivi, sarake]
               + Math.Max(
                   Maksimi(arvot, rivi + 1, sarake, ref ratkaisuja),
                   Maksimi(arvot, rivi + 1, sarake + 1, ref ratkaisuja)
               );
    }
}