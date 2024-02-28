using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 16, esimerkkejä funktion toteutusstrategioista.
/// </summary>
public class MontakoLukua
{
    /// <summary>
    /// Alustukset ja kutsut
    /// </summary>
    public static void Main()
    {
        int negatiivistenPituus = MontakoNegatiivista(new int[] { -1, -2, 0, -2, -1, -5, 1, 2, -3 });
        Console.WriteLine(negatiivistenPituus);
        negatiivistenPituus = MontakoNegatiivista2(new int[] { -1, -2, 0, -2, -1, -5, 1, 2, -3 });
        Console.WriteLine(negatiivistenPituus);
    }

    /// <summary>
    /// Mikä on pisin perättäisten negatiivisten lukujen jonon pituus.
    /// Tämä toteutus tehdään listojen avulla. 
    /// </summary>
    /// <param name="luvut">Luvut</param>
    /// <returns>Negatiivisten lukujen pisin pituus</returns>
    /// <example>
    /// <pre name="test">
    /// MontakoNegatiivista2(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3 }) === 3;
    /// MontakoNegatiivista2(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3, -4, -5, -6 })  === 4;
    /// MontakoNegatiivista2(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3, -4, -5, -6, -6 })  === 5;
    /// MontakoNegatiivista2(new int[] { 0, 1, 2 }) === 0;
    /// MontakoNegatiivista2(new int[] { 0, -1, 2 }) === 1;
    /// MontakoNegatiivista2(new int[] { -1, 1, -2 }) === 1;
    /// MontakoNegatiivista2(new int[] { -1, -2, -1, -3, -2, 0, -1, 2}) === 5;
    /// MontakoNegatiivista2(new int[] { }) === 0;
    /// MontakoNegatiivista2(new int[] {-1, -1, -1 }) === 3;
    /// </pre>
    /// </example>
    public static int MontakoNegatiivista2(int[] luvut)
    {
        // 1. Tehdään lista listoista; kukin pikku listoista
        // koostuu pelkästään alkuperäisen aineiston perättäisistä
        // negatiivista luvuista.
        //  -1, -2, 0, -2, -1, -5, 1, 2, -3
        // {{-1, -2}, {-2, -1, -5}, {-3}}
        List<List<int>> negatiivistenListat = new List<List<int>>();
        List<int> negaListaNyt = new List<int>();
        for (int i = 0; i < luvut.Length; i++)
        {
            // Jos kohdataan ei-negatiivinen luku,
            // niin lisätään negaListaNyt tuohon "ison" listan
            // joukon jatkoksi
            // ja tyhjennetään negaListaNyt-lista
            if (luvut[i] >= 0)
            {
                negatiivistenListat.Add(negaListaNyt);
                negaListaNyt = new List<int>();
            }
            else // Negatiivinen luku kohdattu
            {
                negaListaNyt.Add(luvut[i]);
            }
        }
        negatiivistenListat.Add(negaListaNyt);
        // 2. Katsotaan mikä pikkulistoista (eli "negatiivistenListat" alkioista)
        // on pisin, ja palautetaan sitten se pituus. 
        int pisin = 0;
        foreach (List<int> negat in negatiivistenListat)
        {
            if (negat.Count > pisin) pisin = negat.Count;
            // pisin = Math.Max(pisin, negat.Count);
        }
        return pisin;
    }
    
    /// <summary>
    /// Mikä on pisin perättäisten negatiivisten lukujen jonon pituus.
    /// </summary>
    /// <param name="luvut">Luvut</param>
    /// <returns>Negatiivisten lukujen pisin pituus</returns>
    /// <example>
    /// <pre name="test">
    /// MontakoNegatiivista(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3 }) === 3;
    /// MontakoNegatiivista(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3, -4, -5, -6 })  === 4;
    /// MontakoNegatiivista(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3, -4, -5, -6, -6 })  === 5;
    /// MontakoNegatiivista(new int[] { 0, 1, 2 }) === 0;
    /// MontakoNegatiivista(new int[] { 0, -1, 2 }) === 1;
    /// MontakoNegatiivista(new int[] { -1, 1, -2 }) === 1;
    /// MontakoNegatiivista(new int[] { -1, -2, -1, -3, -2, 0, -1, 2}) === 5;
    /// MontakoNegatiivista(new int[] { }) === 0;
    /// MontakoNegatiivista(new int[] {-1, -1, -1 }) === 3;
    /// </pre>
    /// </example>
    public static int MontakoNegatiivista(int[] luvut)
    {
        int pisinJono = 0;
        int nykyinenJono = 0;
        foreach (int luku in luvut)
        {
            // Onko nykyinen alkio negatiivinen?
            // Jos on, kasvatetaan nykyisen jonon pituutta
            if (luku < 0)
            {
                nykyinenJono++;
                pisinJono = Math.Max(pisinJono, nykyinenJono);
            }
            // Jos ei ole, 
            // 1. tutkitaan onko nykyinen jono pisin
            // ja tarvittaessa korvataan pisimmän jonon pituus. 
            // 2. Sitten nollataan nykyisen jonon pituus.
            else
            {
                // if (nykyinenJono > pisinJono) pisinJono = nykyinenJono;
                pisinJono = Math.Max(pisinJono, nykyinenJono);
                nykyinenJono = 0;
            }
        }
        
        return pisinJono; 
    }
}