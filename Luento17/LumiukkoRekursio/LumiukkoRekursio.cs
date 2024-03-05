using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

namespace LumiukkoRekursio;

/// <summary>
/// Luento 17, rekursio. 
/// </summary>
public class LumiukkoRekursio : PhysicsGame
{
    /// <summary>
    /// Pienin piirrettävä pallon säde
    /// </summary>
    public const double MinSade = 20.0;

    /// <summary>
    /// Alustukset
    /// </summary>
    public override void Begin()
    {
        Lumiukko(0, 0, 200, Math.PI/2);
        Level.BackgroundColor = Color.DarkAzure;
        Camera.ZoomToAllObjects(100);
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }

    /// <summary>
    /// Lumiukkeli rekursiivisesti
    /// </summary>
    /// <param name="x">Pallon x</param>
    /// <param name="y">Pallon y</param>
    /// <param name="sade">Säde</param>
    /// <param name="suunta">Suunta</param>
    public void Lumiukko(double x, double y, double sade, double suunta)
    {
        if (sade < MinSade) return; 
        GameObject pallo = new GameObject(sade * 2, sade * 2, Shape.Circle);
        pallo.Position = new Vector(x, y);
        Add(pallo);
        double uusiSade = sade / 2;
        // double uusiX = x;
        // double uusiY = y + sade + uusiSade;
        double sivuun = Math.PI/8; 
        double uusiSuunta = suunta + sivuun;
        double uusiX = x + Math.Cos(uusiSuunta) * sade + Math.Cos(uusiSuunta) * uusiSade;
        double uusiY = y + Math.Sin(uusiSuunta) * sade + Math.Sin(uusiSuunta) * uusiSade;
        Lumiukko(uusiX, uusiY, uusiSade, uusiSuunta);
    }
}