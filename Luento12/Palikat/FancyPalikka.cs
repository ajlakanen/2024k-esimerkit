using System;
using Jypeli;

namespace Luento12;

/// <summary>
/// Nätisti tuhoutuva palikka
/// </summary>
public class FancyPalikka : Palikka
{
    /// <summary>
    /// Törmäysten estämisen animaation alkamisen jälkeen voisi estää myös näin:
    /// Lisätään oliolle Tuhotaan-tapahtuma. Lisätään sittten peliluokan puolella
    /// tapahtumankäsitteelijä, jossa poistetaan kaikki törmäyskäsittelijät.
    /// </summary>
    public event Action Tuhotaan;
    
    /// <summary>
    /// FancyPalikka, jolla on vakiovärit: pinkki, vihreä, musta.
    /// </summary>
    /// <param name="leveys">Leveys</param>
    /// <param name="korkeus">Korkeus</param>
    public FancyPalikka(double leveys, double korkeus)
        : base(leveys, korkeus, new Color[] { Color.Pink, Color.SeaGreen, Color.Charcoal, Color.Black })
    {
        
    }

    /// <summary>
    /// Tuhoa olio.
    /// </summary>
    public override void TuhoaPalikka()
    {
        // Törmäysten poistaminen:
        // Vaihtoehto A törmäysten käsittelijöiden poistamiseksi tuhoutumisen yhteydessä. 
        // Tässä this Game.Instance on peliolio, ja this on tämä FancyPalikka-olio itse.
        ((PhysicsGame)Game.Instance).RemoveCollisionHandlers(null, this);

        // Seuraavassa on siis idea, että pienennettään
        // oliota 0.1 sekunnin välein 5 kertaa, ja vasta sitten kutsutaan
        // kantaluokan TuhoaPalikka-aliohjelmaa.
        const double AIKA_ASKEL_SEK = 0.1; // Minkä ajan välein oliota pienennetään.
        const int PIENENNYSASKELIA = 5; // Kuinka monta kertaa pienennetään oliota ennen sen tuhoamista.

        for (int i = 1; i <= PIENENNYSASKELIA; i++)
        {
            Timer.SingleShot( i* AIKA_ASKEL_SEK, delegate()
            {
                this.Width /= 2;
                this.Height /= 2;
            });
        }
        Timer.SingleShot(AIKA_ASKEL_SEK * (PIENENNYSASKELIA + 1), base.TuhoaPalikka);
    }

    /// <summary>
    /// Tämä metodi lisättiin luennon jälkeen ja liittyy vaihtoehtoon B.  
    /// Tapahtuu, kun palikka on tuhoutumassa (pienemisanimaatio alkaa).
    /// Tämä liittyy luokan muuttujana olevaan Tuhotaan-tapahtumaan.
    /// </summary>
    public void OnTuhotaan()
    {
        if (this.Tuhotaan != null)
        {
            this.Tuhotaan();
        }
    }

}