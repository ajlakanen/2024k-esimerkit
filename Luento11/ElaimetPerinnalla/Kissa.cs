using System;

namespace Elaimet;

/// <summary>
/// Kissa, peritty eläimestä.
/// </summary>
public class Kissa : Elain
{

    /// <summary>
    /// Hännän pituus
    /// </summary>
    public int HannanPituus;
    
    /// <summary>
    /// Kissa. Konstruktori kutsuu vastaavaa (nimi parametrina) Eläin-luokan 
    /// konstruktoria base-avainsanaa käyttäen. Niinpä tämän konstruktorin toteutus jää tyhjäksi.
    /// </summary>
    /// <param name="nimi">Kissan nimi.</param>
    public Kissa(string nimi) : base(nimi)
    {
    }
    
    /// <summary>
    /// Kissa miukuu.
    /// </summary>
    public override void Aantele()
    {
        Console.WriteLine($"Miu mau, sanoo {Nimi}");
    }
}