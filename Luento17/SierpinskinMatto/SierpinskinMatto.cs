using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

namespace SierpinskinMatto;

/// <summary>
/// Luento 17, Sierpinskin matto.
/// </summary>
public class SierpinskinMattoEsimerkki : PhysicsGame
{
    public override void Begin()
    {
        SetWindowSize(1920, 1080);
        Level.Size = new Vector(1920, 1080);
        CenterWindow();
        SierpinskinMatto(0, 0, 200.0);
        Camera.ZoomToAllObjects(100);
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }

    public void SierpinskinMatto(double x, double y, double sivunPituus)
    {
        // 1. perustapaus (tai -tapaukset)
        if (sivunPituus < 2.0) return;
        
        // 2. kaikki muut tapaukset
        GameObject nelio = new GameObject(sivunPituus, sivunPituus);
        nelio.Position = new Vector(x, y);
        nelio.Color = RandomGen.NextColor();
        Add(nelio);
        
        // Rekursiiviset kutsut
        // Ylärivi
        SierpinskinMatto(x - sivunPituus, y + sivunPituus, sivunPituus / 3);
        SierpinskinMatto(x, y + sivunPituus, sivunPituus / 3);
        SierpinskinMatto(x + sivunPituus, y + sivunPituus, sivunPituus / 3);
        
        // Keskirivi
        SierpinskinMatto(x - sivunPituus, y, sivunPituus / 3);
        SierpinskinMatto(x + sivunPituus, y, sivunPituus / 3);
        
        // Alarivi
        SierpinskinMatto(x - sivunPituus, y - sivunPituus, sivunPituus / 3);
        SierpinskinMatto(x, y - sivunPituus, sivunPituus / 3);
        SierpinskinMatto(x + sivunPituus, y - sivunPituus, sivunPituus / 3);
    }
}