using System;

namespace Elaimet;

/// <summary>
/// Koira, joka on peritty eläimestä.
/// </summary>
public class Koira : Elain
{
    /// <summary>
    /// Paino
    /// </summary>
    public double Paino;

    /// <summary>
    /// Koira. (Tämä on tapa "konstruoida" uusi koira-olio. Käytetään nimiä
    /// konstruktori tai rakentaja.) Konstruktori kutsuu (nimi parametrina)
    /// Eläin-luokan konstruktoria base-avainsanaa käyttäen.
    /// </summary>
    /// <param name="nimi">Nimi</param>
    /// <param name="paino">Paino</param>
    public Koira(string nimi, double paino) : base(nimi)
    {
        Paino = paino;
    }

    /// <summary>
    /// Koira haukkuu.
    /// </summary>
    public override void Aantele()
    {
        Console.WriteLine($"Hau hau, sanoo {Nimi}");
    }
}