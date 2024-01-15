using System;

/// @author Omanimi
/// @version 15.01.2024
/// <summary>
/// Tulostetaan tekstiä aliohjelmissa
/// </summary>
public class TulostaTietoja
{
    /// <summary>
    /// Tietojen tulostusaliohjelmia
    /// </summary>
    public static void Main()
    {
        // TulostaAnttiJussinTiedot();
        // TulostaVesanTiedot();
        // TulostaAnttiJussinTiedot();

        string vesa = "Vesa Lappalainen\nVanhempi yliopistolehtori\nAuditorio 3";
        string anttijussi = "Antti-Jussi Lakanen\nYliopistonlehtori\nEtästudio";
        
        // TulostaHenkilo("Vesa Lappalainen\nVanhempi yliopistolehtori\nAuditorio 3");
        // TulostaHenkilo("Antti-Jussi Lakanen\nYliopistonlehtori\nEtästudio");
        // TulostaHenkilo("Antti-Jussi Lakanen\nYliopistonlehtori\nEtästudio");
        TulostaHenkilo(vesa);
        TulostaHenkilo(anttijussi);
    }

    public static void TulostaHenkilo(string teksti)
    {
        Console.WriteLine("===");
        Console.WriteLine(teksti);
        Console.WriteLine("===");
    }
    
    public static void TulostaVesanTiedot()
    {
        Console.WriteLine("Vesa Lappalainen");
        Console.WriteLine("Vanhempi yliopistonlehtori");
        Console.WriteLine("Auditorio 3");
    }
    
    public static void TulostaAnttiJussinTiedot()
    {
        Console.WriteLine("Antti-Jussi Lakanen");
        Console.WriteLine("Yliopistonlehtori");
        Console.WriteLine("Etästudio");
    }
    
}