using System;

namespace Elaimet;

/// <summary>
/// Eläin. Toimii yliluokkana
/// Kissa-, Koira- ja Marsu-luokille,
/// jotka siis perivät sekä Nimen, Rodun, 
/// että Aantele-toiminnon.
/// </summary>
public class Elain
{
    /// <summary>
    /// Nimi
    /// </summary>
    public string Nimi;

    /// <summary>
    /// Rotu
    /// </summary>
    public string Rotu;
    
    /// <summary>
    /// ID-numero (tämä lisättiin lopuksi)
    /// </summary>
    public string ID;

    /// <summary>
    /// Eläin
    /// </summary>
    /// <param name="nimi">Nimi</param>
    public Elain(string nimi)
    {
        Nimi = nimi;
    }

    /// <summary>
    /// Ääntelymetodi. Tämä toimii ns. oletusmetodina
    /// niissä tapauksissa, kun perivissä luokissa ei ole 
    /// oletustoteutusta _ylikirjoittavaa_ toteutusta. 
    /// </summary>
    public virtual void Aantele()
    {
        Console.WriteLine("Olen eläin nimeltä " + Nimi);
    }
}