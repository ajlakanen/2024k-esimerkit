using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 8, tyyppimuunnoksista.
/// </summary>
public class Tyyppimuunnokset
{
    /// <summary>
    /// Kokeillaan tyyppimuunnoksia.
    /// </summary>
    public static void Main()
    {
        int a = 3;
        // a = "Antti-Jussi";
        double b = a;
        Console.WriteLine(b);
        // int c = b;
        int d = 'A';
        Console.WriteLine(d);
        d++;
        Console.WriteLine(d); // Tämä on nyt int-arvoinen luku 66
        // char e = d;
        // bool f = 0;

        double g = 3.5;
        int f = (int)g;

        char h = (char)d;
        Console.WriteLine(h);
        // short i = (short)12346789;

        bool j = false;
        int k = 0;

        // Console.WriteLine(j == k);
        
    }
}