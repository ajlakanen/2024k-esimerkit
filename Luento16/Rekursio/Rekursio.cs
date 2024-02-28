using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 16. Rekursio.
/// </summary>
public class Rekursio
{
    /// <summary>
    /// Kutsut ja alustukset
    /// </summary>
    public static void Main()
    {
        // Kertoma(n) = 1, n = 0
        // Kertoma(n) = n * Kertoma(n-1), kun n > 0
        // 5 * 4 * 3 * 2 * 1 = 120
        int kertoma = Kertoma(5);
        Console.WriteLine(kertoma);

        List<int> luvut = new List<int>() { 3, 5, 7, -5, 2, -100, 9, 91, 1, 0, 5, -1 };
        int summa = Summa(luvut);
        Console.WriteLine(summa);

        int summa2 = SummaR(luvut);
        Console.WriteLine(summa2);
        int minimi = Minimi(luvut);
        Console.WriteLine(minimi);
        minimi = MinimiR(luvut);
        Console.WriteLine(minimi);

        int fibo = Fibonacci(10);
        // Lukujonon ensimmäiset luvut ovat
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
        Console.WriteLine(fibo);
    }

    /// <summary>
    /// Fibonaccin luku. 
    /// F(n) = 0               , kun n = 0
    ///      = 1               , kun n = 1
    ///      = F(n-1) + F(n-2) , kun n > 1
    /// Lukujonon ensimmäiset luvut ovat
    /// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
    /// </summary>
    /// <returns>Fibonaccin luku.</returns>
    public static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    /// <summary>
    /// Listan pienin luku käyttäen rekursiota. 
    /// </summary>
    /// <param name="luvut">Luvut.</param>
    /// <returns>Pienin luku.</returns>
    public static int MinimiR(List<int> luvut)
    {
        // Perustapaus
        if (luvut.Count == 1) return luvut[0];
        // Kaikki muut tapaukset (meillä on väh. 2 alkiota)
        int eka = luvut[0];
        List<int> loput = luvut.GetRange(1, luvut.Count - 1);
        // Kaikkein pienin alkio on 1. eka, tai 2. loppujen alkioiden minimi
        int pienempi = Math.Min(eka, MinimiR(loput));
        return pienempi;
        // Rekursiiviset kutsut "manuaalisesti kirjoitettuna": 
        // MinimiR(3, 5, 7, 2, 9)
        // Pienempi(3, (MinimiR(5, 7, 2, 9))
        // Pienempi(3, (Pienempi(5, MinimiR(7, 2, 9)))
        // ... (Täydennä!)
    }

    /// <summary>
    /// Listan pienin luku käyttäen silmukkaa.
    /// </summary>
    /// <param name="luvut">Luvut.</param>
    /// <returns>Pienin luku.</returns>
    public static int Minimi(List<int> luvut)
    {
        int minimi = luvut[0];
        for (int i = 1; i < luvut.Count; i++)
        {
            if (luvut[i] < minimi)
            {
                minimi = luvut[i];
            }
        }

        return minimi;
    }

    /// <summary>
    /// Listan lukujen summa käyttäen rekursiota. 
    /// </summary>
    /// <param name="luvut">Luvut.</param>
    /// <returns>Summa.</returns>
    public static int SummaR(List<int> luvut)
    {
        // Perustapaus? 
        if (luvut.Count == 0) return 0;
        // Muut tapaukset:
        // Ensimmäinen alkio + Loppulistan summa
        // Huom! Tiedämme, että listan pituus on väh. 1
        int eka = luvut[0];
        // jos olisi lista {3, 1, 7}
        // alla oleva lause antaisi meille { 1, 7 }
        List<int> loput = luvut.GetRange(1, luvut.Count - 1);
        return eka + SummaR(loput);
        // SummaR({3, 5, 7, 2, 9})
        // 3 + SummaR({ 5, 7, 2, 9})
        // 3 + 5 + SummaR({7, 2, 9})
        // 3 + 5 + 7 + SummaR({2, 9})
        // 3 + 5 + 7 + 2 + SummaR({9})
        // 3 + 5 + 7 + 2 + 9 + SummaR({})
        // 3 + 5 + 7 + 2 + 9 + 0
        // 3 + 5 + 7 + 2 + 9
        // 3 + 5 + 7 + 11
        // 3 + 5 + 18
        // 3 + 23
        // 26
    }

    /// <summary>
    /// Listan lukujen summa käyttäen silmukkaa.. 
    /// </summary>
    /// <param name="luvut">Luvut.</param>
    /// <returns>Summa.</returns>
    public static int Summa(List<int> luvut)
    {
        int summa = 0;
        foreach (int luku in luvut)
        {
            summa += luku;
        }

        return summa;
    }

    /// <summary>
    /// Kertoma käyttäen rekursiota.
    /// </summary>
    /// <param name="n">Luku, josta kertoma otetaan.</param>
    /// <returns>Luvun kertoma.</returns>
    public static int Kertoma(int n)
    {
        if (n == 0) return 1;
        return n * Kertoma(n - 1);
    }
}