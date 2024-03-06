using System;
using System.Text;

/// <summary>
/// Luento 18. Kertaus.
/// </summary>
public class SiirraKirjaimet
{
    /// <summary>
    /// Muuttujien alustukset ja funktiokutsut. 
    /// </summary>
    public static void Main()
    {
        StringBuilder jono = new StringBuilder("Kolme miestä istuu saunassa.");
        string etsittavat = "aeiouyäö";
        int lkm = 3;
        string poistetut = SiirraMerkit(jono, etsittavat, lkm);
        Console.WriteLine($"Muuttunut aineisto: {jono}");
        Console.WriteLine($"Poistettiin seuraavat merkit: {poistetut}");

        #region Lisätietoa kiinnostuneille: Ratkaisu monikkoja käytämällä
        // Funktiosta voisi periaatteesa myös palautttaa
        // sekä poistetut merkit, että muuttuneen aineiston
        // ja jättää alkuperäisen aineiston koskemattomaksi
        // käyttämällä ns. tuple-tyyppiä (monikko-tyyppi)
        string jono2 = "Kolme miestä istuu saunassa.";
        string etsittavat2 = "aeiouyäö";
        int lkm2 = 3;
        
        // Tämä on ns. ValueTuple
        (string loydetyt, string uusiAineisto) = SiirraMerkit2(jono2, etsittavat2, lkm2);
        Console.WriteLine($"Uusi aineisto: {uusiAineisto}");
        Console.WriteLine($"Löydettiin seuraavat merkit: {loydetyt}");
        #endregion
    }

    /// <summary>
    /// Poistetaan aineistosta korkeintaan "merkkejaMax"-parametrin osoittama
    /// määrä joukon "aineisto" merkkejä. 
    /// </summary>
    /// <param name="aineisto">Mistä siirretään</param>
    /// <param name="siirrettavat">Mitä merkkejä siirretään</param>
    /// <param name="merkkejaMax">Kuinka monta korkeintaan siirretään.</param>
    /// <returns>Siirretyt merkit.</returns>
    /// <example>
    /// <pre name="test">
    /// StringBuilder jono = new StringBuilder("kissa istuu");
    /// SiirraMerkit(jono, "", 1) === ""; jono.ToString() === "kissa istuu";
    /// SiirraMerkit(jono, "xyz", 1) === ""; jono.ToString() === "kissa istuu";
    /// SiirraMerkit(jono, "i", 1) === "i"; jono.ToString() === "kssa istuu";
    /// SiirraMerkit(jono, "s", 2) === "ss"; jono.ToString() === "ka istuu";
    /// SiirraMerkit(jono, "aus", 3) === "asu"; jono.ToString() === "k itu";
    /// SiirraMerkit(jono, "iu", 3) === "iu"; jono.ToString() === "k t";
    /// SiirraMerkit(jono, " ", 3) === " "; jono.ToString() === "kt";
    /// SiirraMerkit(jono, "tk", 3) === "kt"; jono.ToString() === "";
    /// SiirraMerkit(jono, "tk", 3) === ""; jono.ToString() === "";
    /// </pre>
    /// </example>
    public static string SiirraMerkit(StringBuilder aineisto, string siirrettavat, int merkkejaMax)
    {
        int i = 0;
        // int lkm = 0;
        StringBuilder tulos = new StringBuilder();
        // Kumpikin näistä ehdoista pitää olla voimassa,
        // jotta silmukan runko-osaa suoritetaan
        while (i < aineisto.Length && tulos.Length < merkkejaMax)
        {
            char merkki = aineisto[i];
            // Löytyykö merkki siirrettävien merkkien joukosta?
            // if (siirrettavat.IndexOf(merkki) >= 0)
            if (siirrettavat.Contains(merkki))
            {
                // 1. poista merkki aineistosta
                aineisto.Remove(i, 1);
                // 2. lisätään merkki tulosjonoon
                tulos.Append(merkki);
                // HUOMAUTUS! Tätä muuttujaa ei itse asiassa tarvita, joten tämän muuttujan voi poistaa. 
                // 3. lukumäärä-muuttujan kasvattaminen, ts. pitää kirjaa siitä, kuinka monta "sopivaa" merkkiä olemme jo löytäneet
                // lkm++;
            }
            else i++;
        }

        return tulos.ToString();
    }


    /// <summary>
    /// LISÄTIETOA KIINNOSTUNEILLE:
    /// Tässä versiossa ei muuteta parametrina saatua aineistoa, vaan
    /// palautetaan uusi aineisto sekä löydetyt merkit käyttäen ns. monikko-rakennetta.
    /// </summary>
    /// <param name="aineisto">Tutkittava aineisto</param>
    /// <param name="etsittavat">Merkit, joita etsitään</param>
    /// <param name="merkkejaMax">Kuinka monta korkeintaan etsitään.</param>
    /// <returns>Löydetyt merkit sekä aineisto, josta löydetyt merkit on poistettu.</returns>
    /// <example>
    /// <pre name="test">
    /// string aineisto = "kissa istuu";
    /// (string loydetyt, string uusiAineisto) = new ValueTuple<string, string>();
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(aineisto, "", 1); loydetyt === ""; uusiAineisto === "kissa istuu";
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(uusiAineisto, "xyz", 1); loydetyt === ""; uusiAineisto === "kissa istuu";
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(uusiAineisto, "i", 1); loydetyt === "i"; uusiAineisto === "kssa istuu";
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(uusiAineisto, "s", 2); loydetyt === "ss"; uusiAineisto === "ka istuu";
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(uusiAineisto, "aus", 3); loydetyt === "asu"; uusiAineisto === "k itu";
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(uusiAineisto, "iu", 3); loydetyt === "iu"; uusiAineisto === "k t";
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(uusiAineisto, " ", 3); loydetyt === " "; uusiAineisto === "kt";
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(uusiAineisto, "tk", 3); loydetyt === "kt"; uusiAineisto === "";
    /// (loydetyt, uusiAineisto) = SiirraMerkit2(uusiAineisto, "tk", 3); loydetyt === ""; uusiAineisto === "";
    /// </pre>
    /// </example>
    public static (string loydetyt, string uusiAineisto) SiirraMerkit2(string aineisto, string etsittavat,
        int merkkejaMax)
    {
        int i = 0;
        StringBuilder uusiAineisto = new StringBuilder(aineisto);
        StringBuilder poistetut = new StringBuilder();
        // Kumpikin näistä ehdoista pitää olla voimassa,
        // jotta silmukan runko-osaa suoritetaan
        while (i < uusiAineisto.Length && poistetut.Length < merkkejaMax)
        {
            char merkki = uusiAineisto[i];
            // Löytyykö merkki siirrettävien merkkien joukosta?
            // if (siirrettavat.IndexOf(merkki) >= 0)
            if (etsittavat.Contains(merkki))
            {
                uusiAineisto.Remove(i, 1);
                poistetut.Append(merkki);
            }
            else i++;
        }

        return (poistetut.ToString(), uusiAineisto.ToString());
    }
}