using System;

/// @author Antti-Jussi Lakanen
/// @version 23.01.2024
/// <summary>
/// Luento 5, funktiot.
/// </summary>
public class AliohjelmaEsimerkkeja
{
    /// <summary>
    /// Kutsutaan funktioita.
    /// </summary>
    public static void Main()
    {
        // 1. Parametriton void-aliohjelma.
        TulostaKissa();
        TulostaKoira();
        TulostaKoira();
        TulostaKissa();
        
        // 2. Parametrillinen void-aliohjelma.
        // Nämä kaksi kutsua unohtui näyttää luennolla
        Tulosta("Kissa");
        Tulosta("Koira");

        // 3. Parametriton, arvon palauttava funktio
        int luku = AnnaLukuViisi();
        Console.WriteLine(luku);

        string munNimi = PalautaMunNimi();
        Console.WriteLine(munNimi + ", " + munNimi);

        // 4. Parametrillinen, arvon palauttava funktio
        double saatuLuku = Identiteetti(4.9);
        Console.WriteLine(saatuLuku);

        int kerrottuLuku = KerroKahdella(3);
        Console.WriteLine(kerrottuLuku);
        int kerrottuLuku2 = KerroKahdella(8);
        Console.WriteLine(kerrottuLuku2);
        
        // Funktion palauttamaa arvoa ei ole pakko tallettaa muuttujaan. 
        // Arvo voidaan esimerkiksi tulostaa suoraan ruudulle.
        Console.WriteLine("Luku 19 kerrottuna kahdella " + KerroKahdella(19));

        double summa = -1 + 2.0 + 3.55;
        double summa2 = Summa(-1, 2.0, 3.55);
        Console.WriteLine($"Laskimme summa-muuttujaan summan \"manuaalisesti\": {summa}");
        Console.WriteLine("Summan arvo funktiokutsun avulla: " + summa2);

        double keskiarvo = Keskiarvo(5, 8);
        Console.WriteLine(keskiarvo);

        Console.WriteLine($"Painoindeksisi on {BMI(1.83, 75.0)}");
        double bmi = BMI(1.83, 75.0);
        Console.WriteLine($"Painoindeksi (muuttujaan tallennettuna) {bmi}");

        double kanta = 5.0; // "Oikeassa" ohjelmassa nämä arvot saadaan jostain muualta
        double korkeus = 8.5;
        // argumenttina annettavan muuttuja VOI OLLA mutta sen EI TARVITSE olla saman niminen kuin parametrimuuttujan (rivillä 54)
        double kolmionPintaAla = KolmionAla(kanta, korkeus);
        Console.WriteLine($"Kolmion ala on {kolmionPintaAla}");
    }

    /// <summary>
    /// Kolmion pinta-ala
    /// </summary>
    /// <param name="kanta">Kolmion kanta</param>
    /// <param name="korkeus">Kolmion korkeus</param>
    /// <returns>Kolmion pinta-ala</returns>
    public static double KolmionAla(double kanta, double korkeus)
    {
        return kanta * korkeus / 2;
    }
    
    /// <summary>
    /// Painoindeksi eli BMI. 
    /// </summary>
    /// <param name="pituusMetreina">Pituus metreinä.</param>
    /// <param name="painoKg">Paino kilogrammoina.</param>
    /// <returns>Painoindeksi.</returns>
    public static double BMI(double pituusMetreina, double painoKg)
    {
        double bmi = painoKg / (pituusMetreina * pituusMetreina);
        return bmi;
    }
    
    /// <summary>
    /// Kahden luvun keskiarvo.
    /// </summary>
    /// <param name="luku1">Ensimmäinen luku</param>
    /// <param name="luku2">Toinen luku</param>
    /// <returns>Keskiarvo</returns>
    public static double Keskiarvo(int luku1, int luku2)
    {
        // jaettaessa int-luku int-luvulla
        // (siis: sekä osoittaja että nimittäjä ovat int-tyyppisiä)
        // niin myös jakolaskun lopputulos on int-tyyppinen
        // return (luku1 + luku2) / 2;
        
        // Kun edes toinen jakolaskun operandeista
        // on double-tyyppinen, niin jakolaskun lopputulos
        // on myös double-tyyppinen. 
        return (luku1 + luku2) / 2.0;
    }
    
    /// <summary>
    /// Laske kolmen luvun summa
    /// </summary>
    /// <param name="luku1">Luku 1</param>
    /// <param name="luku2">Luku 2</param>
    /// <param name="luku3">Luku 3</param>
    /// <returns>Summa</returns>
    public static double Summa(double luku1, double luku2, double luku3)
    {
        double summa = luku1 + luku2 + luku3;
        return summa;
        // tai lyhyesti
        // return luku1 + luku2 + luku3;
    }

    /// <summary>
    /// Kertoo parametrina saadun luvun kahdella.
    /// </summary>
    /// <param name="luku">Luku</param>
    /// <returns>Luku * 2</returns>
    public static int KerroKahdella(int luku)
    {
        int tulos = luku * 2;
        return tulos; 
    }

    /// <summary>
    /// Identiteettifunktio, ts. palauttaa aina saamansa parametrin arvon.
    /// </summary>
    /// <param name="luku">Arvo.</param>
    /// <returns>Arvo itsessään.</returns>
    public static double Identiteetti(double luku)
    {
        return luku;
    }
    
    /// <summary>
    /// Palauttaa nimeni
    /// </summary>
    /// <returns>Nimi</returns>
    public static string PalautaMunNimi()
    {
        // return "Antti-Jussi Lakanen";
        string etunimi = "Antti-Jussi";
        string sukunimi = "Lakanen";
        return etunimi + " " + sukunimi;
    }
    
    /// <summary>
    /// Palauttaa luvun viisi.
    /// </summary>
    /// <returns>5</returns>
    public static int AnnaLukuViisi()
    {
        // tässä voisi tehdä jotain "logiikkaa"
        return 2+3;
    }
    

    /// <summary>
    /// Tulosta parametrina saatu teksti. 
    /// </summary>
    /// <param name="tulostettavaTeksti">Tulostettava teksti.</param>
    public static void Tulosta(string tulostettavaTeksti)
    {
        Console.WriteLine(tulostettavaTeksti);
    }
    
    /// <summary>
    /// Tulostaa "kissa".
    /// </summary>
    public static void TulostaKissa()
    {
        Console.WriteLine("Kissa");
    }
    
    /// <summary>
    /// Tulostaa "koira".
    /// </summary>
    public static void TulostaKoira()
    {
        Console.WriteLine("Koira");
    }
}