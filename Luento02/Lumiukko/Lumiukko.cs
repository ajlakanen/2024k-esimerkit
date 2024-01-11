using Jypeli;

namespace Lumiukko;

/// @author Antti-Jussi Lakanen
/// @version 10.01.2024
/// 
/// <summary>
/// Ensimmäinen graafinen ohjelmani.
/// </summary>
public class Lumiukko : PhysicsGame
{
    /// <summary>
    /// Piirretään lumiukot ja luodaan niihin tarvittavat oliot.
    /// </summary>
    public override void Begin()
    {
        PhysicsObject pallo = new PhysicsObject(350, 350);
        pallo.Shape = Shape.Circle;
        pallo.Color = Color.DarkAzure;
        pallo.X = -100;
        Add(pallo);
        
        PhysicsObject pallo2 = new PhysicsObject(pallo.Width/2, pallo.Height/2);
        pallo2.Shape = Shape.Circle;
        pallo2.Color = Color.HotPink;
        pallo2.Y = pallo.Y + pallo.Height/2 + pallo2.Height/2;
        Add(pallo2);

        PhysicsObject pallo3 = new PhysicsObject(pallo2.Width/2, pallo2.Height/2);
        pallo3.Shape = Shape.Circle;
        pallo3.Color = Color.DarkBrown;
        pallo3.Y = pallo2.Y + pallo2.Height/2 + pallo3.Height/2;
        Add(pallo3);

        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }
}