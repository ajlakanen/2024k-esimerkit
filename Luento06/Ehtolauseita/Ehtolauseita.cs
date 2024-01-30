using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Omanimi
/// @version 24.01.2024
/// <summary>
/// Luento 6.
/// Ehtolauseita.
/// </summary>
public class Ehtolauseita
{
    /// <summary>
    /// Ehtolauseita.
    /// </summary>
    public static void Main()
    {
        #region Esimerkki1: Salasanan syöttäminen
        // Sivuhuomio: Älä koskaan oikeasti kirjoita salasanoja
        // tai muitakaan salaisuuksia koodiin tällä tavalla!
        string salasana = "Jypeli";
        Console.Write("Anna salasana > ");
        string syotettySalasana = Console.ReadLine();

        // kaksi on-yhtäkuin-merkkiä on C#:ssa vertailuoperaattori
        // Tässä vertaillaan siis merkkijonojen sisältöjä toisiinsa.
        // Huomaa, että tämä vertailu ei päde kaikissa ohj.kielissä.
        if (salasana == syotettySalasana)
        {
            // jos syötetty syöte on sama kuin salasana
            // niin tämä lohko toteutetaan
            Console.WriteLine("Salasana on oikein!");
        }
        else
        {
            // Toteutuu siinä tilanteessa, että 
            // if-ehto ei ollutkaan totta
            Console.WriteLine("Salasana on väärin!");
        }

        #endregion

        #region Esimerkki2: if-elseif-else

        // Rajapyykit: >=140 -> ABC
        //             >=120 mutta alle < 140 -> A, mutta EI BC
        //             < 120 -> ei pääse mihinkään.
        
        double henkilonPituus = 215.0;

        if (henkilonPituus >= 140.0)
        {
            Console.WriteLine("Pääset kaikkiin laitteisiin A, B ja C!");
        }
        else if (henkilonPituus >= 120) // Henkilön pituus on 120--139.9999
        {
            // Jos päädymme tänne lohkoon, voimme olla varmoja siitä, 
            // että henkilön pituus on alle 140 cm. 
            Console.WriteLine("Pääset laitteeseen A, mutta et B etkä C.");
        }
        else if (henkilonPituus >= 100)
        {
            Console.WriteLine("Pääset possujunaan ja syömään hattaraa, mutta et valitettavasti muualle :).");
        }
        else
        {
            Console.WriteLine("Et valitettavasti pääse mihinkään laitteeseen :-(");
        }

        #endregion

        #region Esimerkki3: Useita perättäisiä if-lauseita.

        Console.Write("Anna ikä > ");
        string syote = Console.ReadLine();
        //int ika = syote; // Tämä ei onnistu!
        int ika = int.Parse(syote); // Kokonaisluku täytyy "parsia" (eli muuttaa) käyttäjän antamasta syötteestä.  

        // Eri mallisia syötteitä voitaisiin parsia seuraavasti
        // double.Parse(syote) // syöte sisältäisi desimaaliluvun
        // bool.Parse(syote) // False tai True

        // Jos henkilö on yli 18-vuotias
        // "Voit hakea ajokorttia"
        if (ika > 18)
        {
            Console.WriteLine("Voit hakea ajokorttia");
        }

        // Jos henkilö on yli 45-vuotias
        // Käy lääkärissä tarkistuttamassa näkösi
        if (ika > 45)
        {
            Console.WriteLine("Käy lääkärissä tarkistuttamassa näkösi!");
        }

        if (ika > 60)
        {
            Console.WriteLine("Käy lääkäärintarkastuksessa");
        }
        #endregion
    }
}