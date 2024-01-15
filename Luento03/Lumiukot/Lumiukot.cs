using Jypeli;

namespace Lumiukot;


/// @author Antti-Jussi Lakanen
/// @version 2024
/// 
/// <summary>
/// Lumiukot aliohjelman avulla. 
/// </summary>
public class Lumiukot : PhysicsGame
{
    /// <summary>
    /// Tee yksi pallo
    /// </summary>
    /// <param name="x">Keskikohdan x-koordinaatti</param>
    /// <param name="y">Keskikohdan y-koordinaatti</param>
    /// <param name="koko">Koko</param>
    /// <param name="vari">Väri</param>
    public void TeePallo(double x, double y, double koko, Color vari)
    {
        GameObject pallo = new GameObject(koko, koko);
        pallo.Shape = Shape.Ellipse;
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
    /// <param name="vari">Pään väri.</param>
    public void TeeLumiukko(double x, double y, Color vari)
    {
        double koko = 150;
        double uusiX = x;
        double uusiY = y;
        TeePallo(uusiX, uusiY, koko, vari);

        uusiY = uusiY + koko / 2; // ensin alapallon puolikkaan koon verran ylöspäin
        koko = koko / 2; // keskipallon koko
        uusiY = uusiY + koko / 2; // keskipallon puolikkaan verran ylöspäin        
        TeePallo(uusiX, uusiY, koko, vari);
        
        uusiY = uusiY + koko / 2; // ensin keskipallon puolikkaan koon verran ylöspäin
        koko = koko / 2; // yläpallon  koko
        uusiY = uusiY + koko / 2; // yläpallon puolikkaan verran ylöspäin        
        TeePallo(uusiX, uusiY, koko, vari);
        
    }

    
    /// <summary>
    /// Piirretään lumiukot ja luodaan niihin tarvittavat oliot.
    /// </summary>
    public override void Begin()
    {
        Level.Background.Color = Color.Black;
        TeeLumiukko(-100, 100, Color.Pink);
        TeeLumiukko(100, -50, Color.Yellow);
        TeeLumiukko(300, -100, Color.Pink);
        TeeLumiukko(-200, 100, Color.Yellow);
        TeeLumiukko(0, 0, Color.Gray);
        // TeeLumiukko(0, 0); // Aliohjelman kuormittaminen, tämä tehdään huomenna

        PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }
}