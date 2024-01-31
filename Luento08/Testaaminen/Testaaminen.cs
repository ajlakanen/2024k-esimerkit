using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

/// <summary>
/// Luento 8.
/// (1) Testaaminen
/// (2) char-int- ja int-char-tyyppimuunnokset.
/// (3) double-lukujen vertaaminen toisiinsa testauksen yhteydessä.
/// </summary>
public class Testaaminen
{
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        string jono = Monista('A');
        Console.WriteLine(jono);

        double jaettu = JaaKolmella(3.0);
        Console.WriteLine(jaettu);
    }

    /// <summary>
    /// Jaa annettu luku kolmella. 
    /// </summary>
    /// <param name="jaettava">Luku</param>
    /// <returns>Luku jaettuna kolmella</returns>
    /// <example>
    /// <pre name="test">
    /// JaaKolmella(3.0) ~~~ 1.0;
    /// JaaKolmella(10.0) ~~~ 3.333333;
    /// JaaKolmella(0.3) ~~~ 0.1;
    /// // Liukulukuja ei _yleensä_ pidä verrata toisiinsa
    /// // kahdella on-yhtäsuurta-merkillä. 
    /// JaaKolmella(1.0) ~~~ 0.3333333;
    /// </pre>
    /// </example>
    public static double JaaKolmella(double jaettava)
    {
        return jaettava / 3;
    }
    
    
    /// <summary>
    /// Monistaa annetun merkin kolmen
    /// merkin mittaiseksi merkkijonoksi.
    /// </summary>
    /// <param name="monistettava">Monistettava merkki.</param>
    /// <returns>Monistetuista merkeistä koostuva jono.</returns>
    /// <example>
    /// <pre name="test">
    /// Monista('a') === "aaa";
    /// Monista('b') === "bbb";
    /// Monista(' ') === "   ";
    /// Monista('A') === "AAA";
    /// // Tyhjää merkkiä ei voi monistaa. Tämä aiheuttaisi käännösvirheen. 
    /// // Monista('') === "";
    /// </pre>
    /// </example>
    public static string Monista(char monistettava)
    {
        // return monistettava.ToString() + monistettava.ToString() + monistettava.ToString();
        // return "" + monistettava + monistettava + monistettava;
        return $"{monistettava}{monistettava}{monistettava}";
    }
}