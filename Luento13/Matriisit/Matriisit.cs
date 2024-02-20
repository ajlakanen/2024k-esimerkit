using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 13, matriisit.
/// </summary>
public class Matriisit
{
    /// <summary>
    /// Luodaan matriiseja ja tehdään niille jekkuja.
    /// </summary>
    public static void Main()
    {
        int[,] taulukko2D = { { 1, 2 }, { -1, 4 }, { 5, 6 }, { 0, 100 } };
        Console.WriteLine(taulukko2D[2, 1]); // tulostaa 6
        taulukko2D[3, 0] = 99;
        Console.WriteLine(taulukko2D[3, 0]);
        
        // Tästä ei tule käännösvirhettä,
        // vaan kyseessä on ajonaikainen virhe,
        // joka "löytyy" vasta käytettäessä ohjelmaa.
        // taulukko2D[3, 2] = 101;
        
        // taulukko2D[1, 2] = "Antti-Jussi";

        // "Tavallinen", 1-ulotteinen taulukko
        string[] kaverit = new string[3];
        kaverit[0] = "Antti-Jussi Lakanen";
        kaverit[1] = "Vesa Tapani Lappalainen";
        kaverit[2] = "Jonne Itkonen";

        // Kaksiulotteinen taulukko, jossa ensimmäisessä sarakkeessa
        // on henkilön sukunimi, ja toisessa sarakkeessa etunimi/etunimet
        string[,] kaverit2D = new string[3, 2];
        kaverit2D[0, 0] = "Lakanen";
        kaverit2D[0, 1] = "Antti-Jussi";
        kaverit2D[1, 0] = "Lappalainen";
        kaverit2D[1, 1] = "Vesa Tapani";
        kaverit2D[2, 0] = "Itkonen";
        kaverit2D[2, 1] = "Jonne";
        
        Console.WriteLine("Kaikki alkiot perättäisille riveille tulostettuna:");
        foreach (string alkio in kaverit2D)
        {
            Console.WriteLine(alkio);
        }

        int alkioidenLkm = kaverit2D.Length;
        Console.WriteLine($"kaverit2D-taulukossa on {alkioidenLkm} alkiota.");
        
        // "Pystysuuntainen" pituus voidaan kysyä GetLength(0)-metodilla
        int rivienMaara = kaverit2D.GetLength(0);
        Console.WriteLine($"kaverit2D-matriisissa on {rivienMaara} henkilöä.");

        // "Vaakasuuntainen" pituus voidaan kysyä vastaavasti GetLength(1)
        int sarakkeidenMaara = kaverit2D.GetLength(1);
        Console.WriteLine($"kaverit2D-matriisissa on tallennettuna kullekin henkilölle {sarakkeidenMaara} nimeä.");

        Console.WriteLine("---");
        Console.WriteLine("Tulostetaan alkiot siten että sukunimi ja etunimi/etunimet on samalla rivillä. " +
                          "Tämä ei onnistu foreach-silmukan avulla.");
        TulostaTaulukko(kaverit2D);

        Console.WriteLine("Haluamme kuitenkin tulostaa kaikki nimet, ei pelkästään ensimmäistä etunimeä.");
        string[,] kaverit2D_v2 = new string[3, 3];
        kaverit2D_v2[0, 0] = "Lakanen";
        kaverit2D_v2[0, 1] = "Antti-Jussi";
        kaverit2D_v2[0, 2] = "";
        kaverit2D_v2[1, 0] = "Lappalainen";
        kaverit2D_v2[1, 1] = "Vesa";
        kaverit2D_v2[1, 2] = "Tapani";
        kaverit2D_v2[2, 0] = "Itkonen";
        kaverit2D_v2[2, 1] = "Jonne";
        kaverit2D_v2[2, 2] = "";
        TulostaTaulukko2(kaverit2D_v2);
    }

    /// <summary>
    /// Tulostetaan alkiot siten että sukunimi ja etunimi on samalla rivillä. 
    /// Tämä ei onnistu foreach-silmukan avulla.
    /// </summary>
    /// <param name="taulukko">Tulostettava taulukko</param>
    public static void TulostaTaulukko2(string[,] taulukko)
    {
        int riveja = taulukko.GetLength(0);
        int sarakkeita = taulukko.GetLength(1);
        
        // Taulukkoa pitäisi käydä alaspäin niin kauan kuin rivejä on
        // |
        // |
        // v
        
        // ja jokaisella rivillä käydä läpi jokainen sarake, niin kauan kuin sarakkeita on
        // ------>

        for (int i = 0; i < riveja; i++)
        {
            for (int j = 0; j < sarakkeita; j++)
            {
                Console.Write(taulukko[i, j] + " ");
            }
            // Tässä kohtaa olemme käyneet läpi yhden rivin kaikki sarakkeet
            Console.WriteLine();
        }
    }
    
    /// <summary>
    /// Tulostetaan alkiot siten että sukunimi ja etunimi on samalla rivillä.
    /// Tämä ei onnistu foreach-silmukan avulla, koska foreach ei "tiedä" missä kohti riviä ollaan menossa.
    /// Huom! Olettaa, että jokaisella rivillä on täsmälleen kaksi saraketta!
    /// </summary>
    /// <param name="taulukko">Tulostettava taulukko</param>
    public static void TulostaTaulukko(string[,] taulukko)
    {
        int riveja = taulukko.GetLength(0);

        // Toistetaan niin kauan kuin taulukossa on rivejä
        for (int i = 0; i < riveja; i++)
        {
            // Tulostetaan jokaiselta riviltä kumpikin sarake
            Console.WriteLine(taulukko[i, 0] + " " + taulukko[i, 1]);    
            // Silmukan seurauksena "pellin alla" tapahtuu siis tällainen
            // tulostus:
            // Console.WriteLine(taulukko[0, 0] + " " + taulukko[0, 1]);
            // Console.WriteLine(taulukko[1, 0] + " " + taulukko[1, 1]);
            // Console.WriteLine(taulukko[2, 0] + " " + taulukko[2, 1]);
            // ...
        }
    }
    
     /// <summary>
    /// Millä rivillä etsittävä alkio ensimmäisen kerran sijaitsee.
    /// </summary>
    /// <param name="matriisi">Aineisto</param>
    /// <param name="etsittavaLuku">Etsittävä luku</param>
    /// <returns>Rivin indeksi</returns>
    /// <example>
    /// <pre name="test">
    /// int[,] luvut = new int[,] { { 1, 2 }, { 3, 4 } , { 1, 4 } };
    /// MillaRivilla(luvut, 1) === 0;
    /// MillaRivilla(luvut, 3) === 1;
    /// MillaRivilla(luvut, 9) === -1;
    /// </pre>
    /// </example>
    public static int MillaRivilla(int[,] matriisi, int etsittavaLuku)
    {
        int riveja = matriisi.GetLength(0);
        int sarakkeita = matriisi.GetLength(1);

        // muuttuja i on se joka "tietää" millä rivillä
        // kulloinkin olemme menossa
        for (int i = 0; i < riveja; i++)
        {
            // muuttuja j "tietää" missä sarakkeessa
            // olemme kulloinkin menossa
            for (int j = 0; j < sarakkeita; j++)
            {
                if (matriisi[i, j] == etsittavaLuku)
                {
                    return i;
                }
            }
        }
        return -1;
    }

    /// <summary>
    /// Taulukko jossa on satunnaisia lukuja.
    /// </summary>
    /// <param name="rivienmaara">Rivien määrä</param>
    /// <param name="sarakemaara">Sarakkeiden määrä</param>
    /// <param name="minimi">Arvottavien lukujen minimi</param>
    /// <param name="maksimi">Arvottavien lukujen maksimi (eksklusiivinen)</param>
    /// <returns></returns>
    public static int[,] TeeTaulukko(int rivienmaara, int sarakemaara, int minimi, int maksimi)
    {
        int[,] taulukko = new int[rivienmaara, sarakemaara];
        Random r = new Random();

        // Ulompi silmukka käy läpi kaikki rivit
        for (int i = 0; i < taulukko.GetLength(0); i++)
        {
            // Sisempi silmukka käy läpi jokaisen sarakkeen
            for (int j = 0; j < taulukko.GetLength(1); j++)
            {
                taulukko[i, j] = r.Next(minimi, maksimi);
            }
        }
        return taulukko;
    }

    /// <summary>
    /// Palauttaa taulukon merkkijonona niin, että alkioiden välissä on erotin.
    /// </summary>
    /// <param name="luvut">Taulukko josta tehdään merkkijono</param>
    /// <param name="sarakeErotin">Jono, jolla rivin alkiot erotetaan toisistaan</param>
    /// <param name="riviErotin">Jono, jolla rivit erotetaan toisistaan</param>
    /// <param name="riviformaatti">C# tyylinen formaattojono, jolla yksi rivi käsitellään.
    /// Jos formaattijonossa ei ole lainkaan {-merkkiä, käytetään jonoa sellaisenaan rivien
    /// erottomina
    /// </param>
    /// <example>
    /// <pre name="test">
    ///  int[,] luvut = {{1,2,3}, {4,5,6}, {7,8,9}};
    ///  Jonoksi(luvut) === "1 2 3\n4 5 6\n7 8 9";
    ///  Jonoksi(luvut," ",",") === "1 2 3,4 5 6,7 8 9";
    ///  Jonoksi(luvut,":","|","[ {0} ]") === "[ 1:2:3 ]|[ 4:5:6 ]|[ 7:8:9 ]";
    /// </pre>
    /// </example>
    public static String Jonoksi(int[,] luvut, string sarakeErotin = " ",
        string riviErotin = "\n", string riviformaatti = "{0}")
    {
        StringBuilder tulos = new StringBuilder();
        String rivivali = "";
        for (int iy = 0; iy < luvut.GetLength(0); iy++)
        {
            String vali = "";
            StringBuilder rivi = new StringBuilder();
            for (int ix = 0; ix < luvut.GetLength(1); ix++)
            {
                rivi.Append(vali + luvut[iy, ix]);
                vali = sarakeErotin;
            }
            tulos.Append(rivivali + String.Format(riviformaatti, rivi));
            rivivali = riviErotin;
        }
        return tulos.ToString();
    }
}