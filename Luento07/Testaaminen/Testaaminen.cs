using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Antti-Jussi Lakanen
/// @version 2024
/// 
/// <summary>
/// Comtest-testien harjoittelua.
/// </summary>
public class Testaaminen
{
    /// <summary>
    /// "Tulostus"-testejä, joiden oikeellisuutta ei voi automaattisesti tutkia. 
    /// </summary>
    public static void Main()
    {
        #region Summa-funktion "tulostustestaus" 
        // Ts. katsotaan silmämääräisesti näyttääkö tulos oikealta.
        Console.WriteLine(Summa(1, 3));
        Console.WriteLine(Summa(0, -1));
        #endregion

        #region Summa-funktion tuloksen vertailu Mainissa 
        // Ts. Katsotaan palauttaako tekemämme vertailut True.
        // Tässä esimerkin vuoksi ensimmäinen on True (testi menee läpi),
        // ja jälkimmäinen False (testi ei mene läpi). 
        Console.WriteLine(7 == Summa(2, 5)); // True 
        Console.WriteLine(1 == Summa(0, -1)); // False
        bool vertailu2 = -2 == Summa(-1, -1);
        Console.WriteLine(vertailu2);
        #endregion

        // TODO: Jätetään tämä hieman myöhäisemmäksi. 
        // bool onkoKolmionAla = KolmionAla(5, 8) == 20.0;
    }

    /// <summary>
    /// Kahden luvun summa
    /// </summary>
    /// <param name="a">Luku 1</param>
    /// <param name="b">Luku 2</param>
    /// <returns>Summa</returns>
    /// <example>
    /// <pre name="test">
    /// Summa(1, 4) === 5;
    /// Summa(1, 3) === 4;
    /// Summa(-1, -1) === -2;
    /// </pre>
    /// </example>
    public static int Summa(int a, int b)
    {
        return a + b;
    }

    
    
    /// <summary>
    /// Kolmion pinta-ala
    /// </summary>
    /// <param name="kanta">Kanta</param>
    /// <param name="korkeus">Korkeus</param>
    /// <returns>Kolmion ala</returns>
    /// <example>
    /// <pre name="test">
    /// KolmionAla(5, 8) === 20.0;
    /// KolmionAla(7, 3) === 10.5; 
    /// KolmionAla(7.5, 3.5) === 13.125;
    /// KolmionAla(0.0, 0.0) === 0.0;
    /// KolmionAla(-1.0, 1.0) === -0.5;
    /// </pre>
    /// </example>
    public static double KolmionAla(double kanta, double korkeus)
    {
        return kanta * korkeus / 2.0;
    }
    
    // public static ...
}    

