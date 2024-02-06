using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Antti-Jussi Lakanen
/// @version 2024
/// <summary>
/// Luento 9, debuggaus
/// </summary>
public class Debuggaus
{
    /// <summary>
    /// Harjoitellaan debuggausta
    /// </summary>
    public static void Main()
    {
        double pertinRahat = 100.0;
        double korkokerroin = 1.07;

        // Silmukan tarkoitus on tässä "simuloida" vuosien kulumista
        // 10 vuotta tässä tapauksessa
        for (int i = 0; i < 10; i++)
        {
            pertinRahat = Sijoitus(pertinRahat, korkokerroin);
            // pertinRahat = Kulutus(pertinRahat, 6.90);
            Console.WriteLine($"Vuoden {i} lopuksi Pertillä on {pertinRahat} rahaa.");
        }
    }

    public static double Kulutus(double paaoma, double kulutettavaSumma)
    {
        return paaoma - kulutettavaSumma;
    }
    
    public static double Sijoitus(double paaoma, double korkokerroin)
    {
        return paaoma * korkokerroin;
    }
}