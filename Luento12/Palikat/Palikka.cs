using Jypeli;

namespace Luento12;

/// <summary>
/// Palikka. Tämän avulla tehdään palikoita
/// jotka "kestävät" useamman törmäyksen,
/// ja joihin törmäämällä palikan väri vaihtuu.
/// </summary>
public class Palikka : PhysicsObject
{
    /// <summary>
    /// Värikokoelma
    /// </summary>
    private Color[] _varit; // Yksityinen oliomuuttuja kirjoitetaan nykyisillä C# suosituksissa näin
    
    /// <summary>
    /// Montako osumaa palikka on ottanut.
    /// </summary>
    private int _osumat;
    
    /// <summary>
    /// Palikka
    /// </summary>
    /// <param name="leveys">Leveys</param>
    /// <param name="korkeus">Korkeus</param>
    /// <param name="varit">Värit</param>
    public Palikka(double leveys, double korkeus, Color[] varit) : base(leveys, korkeus)
    {
        _varit = varit;
        _osumat = 0;
        Color = varit[0];
    }

    /// <summary>
    /// Ottaa vastaan osuman:
    /// Vaihtaa värin seuraavaksi.
    /// Mikäli värejä ei enää ole, tuhotaan olio.
    /// </summary>
    public void OtaVastaanOsuma()
    {
        _osumat++;
        if (_osumat >= _varit.Length)
        {
            TuhoaPalikka();
        }
        else Color = _varit[_osumat];
    }
    
    /// <summary>
    /// Tuhoa palikka.
    /// </summary>
    public virtual void TuhoaPalikka()
    {
        this.Destroy();
    }
}