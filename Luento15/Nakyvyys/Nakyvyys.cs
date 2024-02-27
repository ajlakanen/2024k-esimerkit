using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 15
///  - Paikallinen muuttuja
///  - Muuttujien näkyvyys
///  - Lohko
///  - Staattinen muuttuja
///  - Parametrin välitys
/// </summary>
public class Nakyvyys
{
    // vain harvinaisia erityistilanteita varten
    public static int munMuuttuja = 3;

    public static void Main()
    {
        int luku = 9; // Näkyy vain pääohjelmassa
        munMuuttuja++;
        Console.WriteLine(munMuuttuja);
        A();
        Console.WriteLine(munMuuttuja);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"Moikka whilesta: {i}");
                i++;
            }
        }

        int[] luvut = { 9, 7, 11 };
        
        // Oletetaan niin että haluamme käsitellä tätä tietoa
        // aliohjelmassa/funktiossa.

        // Tietoja voidaan käsitellä C#:ssa ainakin seuraavilla
        // tavoilla: 
        // 1. Muutetaan parametrina saatua asiaa, josta seuraa
        // sivuvaikutuksia
        // Tästä esimerkkinä on taulukon sisällön muuttaminen
        // aliohjelmassa
        MuutaPaikkoja(luvut, 2, 1);
        
        // 2. Ei muuteta parametrina saatua tietoa, vaan
        // luodaan uusi tieto ja palautetaan se. 
        // (Tätä voidaan kutsua "funktionaaliseksi" lähestymistavaksi.)
        List<int> luvutLista = new List<int>() { 9, 7, 11 };
        List<int> uusiLista = MuutaPaikkoja(luvutLista, 2, 1);

        int luku3 = 3;
        Console.WriteLine(luku3);
        MuutaLukua(luku3);
        Console.WriteLine(luku3);
    }

    public static void MuutaLukua(int munLuku)
    {
        munLuku = 5;
    }
    
    public static List<int> MuutaPaikkoja(List<int> lista, int a, int b)
    {
        List<int> uusiLista = new List<int>(lista);
        int vaihdettava1 = uusiLista[a];
        int vaihdettava2 = uusiLista[b];
        // Tämä EI aiheuta sivuvaikutusta
        // Ts. toimimme vain paikallisten muuttujien avulla.
        // Pääohjelmassa ei tapahdu mitään "odottamatonta" muutosta. 
        uusiLista[b] = vaihdettava1;
        uusiLista[a] = vaihdettava2;
        return uusiLista;
    }
    
    /// <summary>
    /// Aliohjelma, joka muuttaa parametrina saamaansa tietoa. 
    /// </summary>
    /// <param name="luvut">Taulukko lukuja</param>
    /// <param name="a">Paikka a</param>
    /// <param name="b">Paikka b</param>
    public static void MuutaPaikkoja(int[] luvut, int a, int b)
    {
        int vaihdettava1 = luvut[a];
        int vaihdettava2 = luvut[b];
        // Tämä aiheuttaa sivuvaikutuksen:
        luvut[b] = vaihdettava1;
        luvut[a] = vaihdettava2;

    }
    
    public static void A()
    {
        // luku++; // Tämä ei onnistu, koska luku on paikallinen Mainissa
        munMuuttuja++;
    }
}