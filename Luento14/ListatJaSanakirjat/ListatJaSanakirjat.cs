using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 14. Listat ja sanakirjat. 
/// </summary>
public class ListatJaSanakirjat
{
    /// <summary>
    /// Alustuksia ja kokeiluja.
    /// </summary>
    public static void Main()
    {
        #region Taulukon pituutta ei voi ylittää

        string[] opiskelijat = { "Antti-Jussi", "Vesa", "Jonne" };
        // Uusi opiskelija "Ari"
        // opiskelijat[3] = "Ari";

        // Periaatteessa voisimme luoda uuden, pidemmän taulukon, 
        // johon kopioimme aikaisemmat opiskelijat. Tätä _ei_ kannata
        // itse tehdä.
        string[] uudetOpiskelijat = new string[opiskelijat.Length * 2];
        for (int i = 0; i < opiskelijat.Length; i++)
        {
            uudetOpiskelijat[i] = opiskelijat[i];
        }
        uudetOpiskelijat[3] = "Ari";
        uudetOpiskelijat[4] = "Ville";
        #endregion

        #region String-lista

        // Luodaan lista, joka voi sisältää vain string-tyyppisiä
        // alkioita
        List<string> opiskelijaLista = new List<string>();
        opiskelijaLista.Add("Antti-Jussi");
        opiskelijaLista.Add("Vesa");
        opiskelijaLista.Add("Jonne");
        opiskelijaLista.Add("Ari");
        opiskelijaLista.Add("Ville");
        opiskelijaLista.Insert(0, "Tuomo");
        Console.WriteLine(opiskelijaLista[2]);
        opiskelijaLista[2] = "Paavo";
        Console.WriteLine(opiskelijaLista[2]);
        #endregion

        #region Listan Remove-metodi

        // Remove poistaa JA palauttaa tiedon poistettiinko jotakin
        opiskelijaLista.Remove("Antti-Jussi");
        bool poistettiinko = opiskelijaLista.Remove("Annemari");
        poistettiinko = opiskelijaLista.Remove("Jonne");
        if (poistettiinko)
        {
            Console.WriteLine("Alkio poistettiin");
        }

        #endregion

        #region Luennolle saapuvien nimet

        List<string> nimet = new List<string>();
        Console.WriteLine("Anna nimiä (pelkkä Enter lopettaa)");

        while (true)
        {
            Console.Write("> ");
            string jono = Console.ReadLine();
            if (jono == "") break;
            else nimet.Add(jono);
        }
        
        foreach (string nimi in nimet)
        {
            Console.WriteLine(nimi);
        }

        // Listan Count-ominaisuus antaa alkioiden määrän
        Console.WriteLine($"Luennolle saapui {nimet.Count} opiskelijaa.");
        if (nimet.Contains("Jukka-Pekka"))
        {
            Console.WriteLine("Jukka-Pekka tuli luennolle, hienoa J-P!!!");
        }
        else
        {
            Console.WriteLine("Jukka-Pekka nukkui pommmiin. Hylätty arvosana!");
        }
        #endregion

        #region Henkilötunnukset
        Dictionary<string, string> henkilot = new Dictionary<string, string>();
        henkilot.Add("123456-XXXX", "Antti-Jussi");
        Console.WriteLine(henkilot["123456-XXXX"]);
        henkilot.Add("123456-YYYY", "Pertti Keinonen");
        henkilot.Add("030480-ZZZZ", "Irmeli Leinonen");
        // henkilot.Add("123456-XXXX", "Kalle");
        
        // Sisältääkö sanakirja annetun avaimen
        if (henkilot.ContainsKey("123456-XXXX"))
        {
            Console.WriteLine("Tällainen henkilötunnus on jo olemassa, joten emme voi lisätä uutta alkiota tällä tunnuksella.");
        }
        #endregion

        #region Avain-arvoparien käsittely
        // Sanakirja koostuu alkioista, jotka ovat KeyValuePair-olioita.
        // Tällaiselta oliota voidaan kysyä niin avain kuin arvo. 
        foreach (KeyValuePair<string, string> henkilo in henkilot)
        {
            Console.WriteLine($"{henkilo.Key}: {henkilo.Value}");
        }
        #endregion

        #region Merkkien määrä -esimerkki

        // Toive: tämä sanakirja sisältäisi tiedot 
        // siitä, että kuinka monta kappaletta merkkejä on
        Dictionary<char, int> merkkienMaara = new Dictionary<char, int>();
        merkkienMaara.Add('b', 3);
        merkkienMaara['b'] = 4;
        merkkienMaara.Add('a', 0);
        merkkienMaara['a']++;
        merkkienMaara['a']++;
        merkkienMaara['a']++;
        merkkienMaara['a']++;
        merkkienMaara['a']++;
        merkkienMaara['a']++;
        merkkienMaara['a']++;

        // Taulukon kohdallakin voidaan kasvattaa tietyssä indeksissä
        // olevan alkion arvoa
        int[] taulukkoLuvut = { 2, 3, 1 };
        taulukkoLuvut[1]++;
        taulukkoLuvut[1]++;
        taulukkoLuvut[1]++;
        taulukkoLuvut[1]++;
        taulukkoLuvut[1]++;

        if (merkkienMaara.ContainsKey('a'))
        {
            merkkienMaara['a']++;
        }
        #endregion

        #region Henkilötunnusten syöttö -esimerkki

        Console.WriteLine("Anna henkilöiden tietoja (pelkkä Enter lopettaa)");
        while (true)
        {
            Console.Write("Anna henkilötunnus > ");
            string henkilotunnus = Console.ReadLine();
            if (henkilotunnus == "") break;
            // Jos henkilön henkilötunnus löytyy tietorakenteesta,
            // tulostetaan henkilön nimi.
            if (henkilot.ContainsKey(henkilotunnus))
            {
                // Tulosteataan henkilön nimi.
                Console.WriteLine(henkilot[henkilotunnus]);
            }
            // Jos henkilötunnusta ei löydy, niin lisätään
            // henkilön tiedot (henkilötunnus, nimi) tietorakenteeseen
            else
            {
                Console.WriteLine("Hakemaasi henkilötunnusta ei löytynyt, lisätään uusi.");
                Console.Write("Anna nimi > ");
                string nimi = Console.ReadLine();
                henkilot.Add(henkilotunnus, nimi);
                Console.WriteLine("Lisättiin henkilö tietorakenteeseen!");
            }
        }
        
        #endregion
    }
}