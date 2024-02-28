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
        // negatiivistenPituus = MontakoNegatiivista2(new int[] { -1, -2, 0, -2, -1, -5, 1, 2, -3 });
        // Console.WriteLine(negatiivistenPituus);
    }
}