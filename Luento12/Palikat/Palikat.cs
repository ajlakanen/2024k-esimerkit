using Jypeli;

namespace Luento12;

/// @author Antti-Jussi Lakanen
/// @version 2024
/// 
/// <summary>
/// Palikat-peli.
/// Tämän ohjelman idea on demonstroida oman olioluokan tekemistä
/// ja perintää. 
/// </summary>
public class Palikat : PhysicsGame
{
    public override void Begin()
    {
        
        Level.Size = new Vector(1920, 1080);
        SetWindowSize(1920, 1080);
        Level.Background.Color = Color.DarkAzure;
        Level.CreateBorders();
        CenterWindow();

        PhysicsObject pelaaja = new PhysicsObject(60, 60, Shape.Circle);
        Add(pelaaja);

        for (int i = 0; i < 20; i++)
        {
            Color[] varit = { Color.Red, Color.Yellow, Color.Green };
            Palikka palikka = new Palikka(50, 50, varit);
            palikka.Position = RandomGen.NextVector(Level.BoundingRect);
            // Törmäystapahtumat Jypelissä: 
            // https://tim.jyu.fi/view/kurssit/jypeli/tapahtumat/tormaykset
            AddCollisionHandler<PhysicsObject, Palikka>(pelaaja, palikka, TormattiinPalikkaan);
            Add(palikka);
        }

        for (int i = 0; i < 10; i++)
        {
            Color[] varit = { Color.Black, Color.White };
            Palikka ympyra = new Palikka(50, 50, varit);
            ympyra.Shape = Shape.Circle;
            ympyra.Position = RandomGen.NextVector(Level.BoundingRect);
            AddCollisionHandler<PhysicsObject, Palikka>(pelaaja, ympyra, TormattiinPalikkaan);
            Add(ympyra);
        }

        for (int i = 0; i < 5; i++)
        {
            FancyPalikka liikkumaton = new FancyPalikka(100, 100);
            liikkumaton.MakeStatic();
            liikkumaton.Position = RandomGen.NextVector(Level.BoundingRect);
            AddCollisionHandler<PhysicsObject, Palikka>(pelaaja, liikkumaton, TormattiinPalikkaan);
            // Vaihtoehto B törmäysten estämiseksi loppuanimaation alkamisen jälkeen. 
            // Ks. FancyPalikka.cs
            // fancy.Tuhotaan += delegate () {
            //     RemoveCollisionHandlers(pelaaja, fancy);
            // };
            Add(liikkumaton);
        }
        
        #region Kontrollit

        Keyboard.Listen(Key.Up, ButtonState.Down, Liikuta, "Liikuta pelaajaa ylös", pelaaja,
            new Vector(0, 2000));
        Keyboard.Listen(Key.Down, ButtonState.Down, Liikuta, "Liikuta pelaajaa alas", pelaaja,
            new Vector(0, -2000));
        Keyboard.Listen(Key.Left, ButtonState.Down, Liikuta, "Liikuta pelaajaa vasemmalle", pelaaja,
            new Vector(-2000, 0));
        Keyboard.Listen(Key.Right, ButtonState.Down, Liikuta, "Liikuta pelaajaa oikealle", pelaaja,
            new Vector(2000, 0));
        PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");

        #endregion
    }

    /// <summary>
    /// Törmätään palikkaan
    /// </summary>
    /// <param name="tormaaja">Törmääjä</param>
    /// <param name="kohde">Kohdepalikka</param>
    public void TormattiinPalikkaan(PhysicsObject tormaaja, Palikka kohde)
    {
        // MessageDisplay.Add("Törmättiin");
        kohde.OtaVastaanOsuma();
        
        // Ei lähdetä oikeasti tekemään näin!
        // if (kohde.Color == Color.Red)
        // {
        //     kohde.Color = Color.Yellow;
        // }
        // else if (kohde.Color == Color.Yellow)
        // {
        //     kohde.Color = Color.Green;
        // }
        // else if (kohde.Color == Color.Green)
        // {
        //     kohde.Destroy();
        // }
    }

    /// <summary>
    /// Liikuttaa fysiikkaoliota.
    /// </summary>
    /// <param name="liikuteltava">Liikutetava</param>
    /// <param name="suunta">Suunta</param>
    public void Liikuta(PhysicsObject liikuteltava, Vector suunta)
    {
        liikuteltava.Push(suunta);
    }
}