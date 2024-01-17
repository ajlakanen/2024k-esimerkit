using Jypeli;

namespace Lumiukot;

/// @author Antti-Jussi Lakanen
/// @version 2024
/// 
/// <summary>
/// Lumiukko aliohjelmien avulla. Myös pallo tehdään nyt omassa aliohjelmassa.
/// </summary>
public class Lumiukot : PhysicsGame
{
    /// <summary>
    /// Tekee yhden pallon
    /// </summary>
    /// <param name="x">Pallon keskipisteen x</param>
    /// <param name="y">Pallon keskipisteen y</param>
    /// <param name="koko">Koko</param>
    /// <param name="vari">Väri</param>
    public void TeePallo(double x, double y, double koko, Color vari)
    {
        PhysicsObject pallo = new PhysicsObject(koko, koko);
        pallo.Shape = Shape.Circle;
        pallo.Color = vari;
        pallo.X = x;
        pallo.Y = y;
        Add(pallo);
    }

    /// <summary>
    /// Tekee yhden lumiukon pelialueelle.
    /// </summary>
    /// <param name="x">Lumiukon alapallon keskikohta (X-koordinaatti).</param>
    /// <param name="y">Lumiukon alapallon keskikohta (Y-koordinaatti).</param>
    /// <param name="koko">Alapallon koko.</param>
    public void TeeLumiukko(double x, double y, double koko)
    {
        double uusiX = x;
        double uusiY = y;
        double pallonKoko = koko;

        TeePallo(uusiX, uusiY, pallonKoko, Color.Green);

        uusiY = uusiY + pallonKoko / 2; // ensin alapallon puolikkaan koon verran ylöspäin
        pallonKoko = pallonKoko / 2; // keskipallon koko
        uusiY = uusiY + pallonKoko / 2; // keskipallon puolikkaan verran ylöspäin 

        TeePallo(uusiX, uusiY, pallonKoko, Color.Yellow);

        uusiY = uusiY + pallonKoko / 2; // ensin keskipallon puolikkaan koon verran ylöspäin
        pallonKoko = pallonKoko / 2; // yläpallon koko
        uusiY = uusiY + pallonKoko / 2; // yläpallon koon puolikkaan verran ylöspäin 

        TeePallo(uusiX, uusiY, pallonKoko, Color.Red);
    }

    /// <summary>
    /// Piirretään lumiukot ja luodaan niihin tarvittavat oliot.
    /// </summary>
    public override void Begin()
    {
        TeeLumiukko(100, -100, 350);
        Camera.ZoomToLevel(100);
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }
}