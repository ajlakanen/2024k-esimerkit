using System;
using System.Diagnostics;
using System.Text;

/// <summary>
/// Luento 13, StringBuilder-merkkijono.
/// Vertaillaan ja ajastetaan string- ja StringBuilder-olioiden muokkausta. 
/// </summary>
public class MuokattavatMerkkijonot
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Antti-Jussi");
        // sb += "Lakanen";
        Console.WriteLine(sb);

        string s = "Antti";
        s += "-";
        s += "Jussi";
        s += " ";
        s += "Lakanen";

        string jono1 = "a";
        StringBuilder jono2 = new StringBuilder("a");

        const int MONTAKO = 100000;
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < MONTAKO; i++)
        {
            jono1 = jono1 + "a" + i;
            // "aa0" ensimmäisen kierroksen suorittamisen jälkeen
            // "aa0a1" toisen kierroksen jälkeen
            // "aa0a1a2" ...
        }
        sw.Stop();
        double ms = sw.Elapsed.TotalMilliseconds;
        Console.WriteLine("string-olioilla tähän meni aikaa: " + ms + " millisekuntia.");

        sw = Stopwatch.StartNew();
        for (int i = 0; i < MONTAKO; i++)
        {
            jono2.Append("a");
            jono2.Append(i);
        }
        sw.Stop();
        ms = sw.Elapsed.TotalMilliseconds;
        Console.WriteLine("StringBuilder-oliolla tähän meni aikaa: " + ms + " millisekuntia.");
    }
}