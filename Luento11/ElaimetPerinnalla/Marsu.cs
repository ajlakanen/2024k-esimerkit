using System;

namespace Elaimet;


/// <summary>
/// Marsu. Peritty Eläin-luokasta.
/// </summary>
public class Marsu : Elain
{
    /// <summary>
    /// Marsun elämäpisteet
    /// </summary>
    private int jaljellaOlevienKierrostenLkm = 1000;
    
    /// <summary>
    /// Onko marsu elossa.
    /// HUOMAUTUS: Tämä on julkinen, jolloin kuka tahansa muu pystyisi
    /// asettamaan marsun kuoliaaksi. Tämä ei tietenkään ole toivottavaa,
    /// koska marsun pitäisi kuolla silloin ja vain silloin kun se on
    /// juossut liikaa juoksupyörässä.
    /// Oikeampi tapa olisi sanoa
    /// public bool OnkoElossa { get; private set; }
    /// jolloin sijoittaminen voisi tapahtua vain tästä luokasta käsin. 
    /// </summary>
    public bool OnkoElossa = true;
    
    /// <summary>
    /// Marsu. Konstruktori kutsuu vastaavaa (nimi parametrina) Eläin-luokan 
    /// konstruktoria base-avainsanaa käyttäen. Niinpä tämän konstruktorin 
    /// toteutus jää tyhjäksi.
    /// </summary>
    /// <param name="nimi">Nimi</param>
    public Marsu(string nimi) : base(nimi)
    {
    }

    /// <summary>
    /// Marsu juoksee juoksupyörässä. Jos marsu on juossut liikaa niin
    /// se on goodbye. 
    /// </summary>
    /// <param name="kierroksia">Montako kierrosta marsu juoksee.</param>
    public void JuokseJuoksupyorassa(int kierroksia)
    {
        jaljellaOlevienKierrostenLkm -= kierroksia;
        if (jaljellaOlevienKierrostenLkm < 0) OnkoElossa = false;
    }
}