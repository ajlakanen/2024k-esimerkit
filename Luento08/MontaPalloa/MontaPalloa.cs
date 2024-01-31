using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

namespace MontaPalloa;

/// @author Omanimi
/// @version 31.01.2024
/// <summary>
/// 
/// </summary>
public class MontaPalloa : PhysicsGame
{
    public override void Begin()
    {
        // laskuri-muuttuja, joka meillä pitää kirjaa
        // monistetusta määrästä
        int i = 0;
        while (i < 20) // ehto, jonka ollessa totta, tehdään "runko-osa"
        { // runko-osa alkaa tästä
            PhysicsObject pallo = new PhysicsObject(40, 40, Shape.Circle);
            pallo.Width = RandomGen.NextDouble(20, 40);
            pallo.Height = RandomGen.NextDouble(20, 40);
            pallo.Position = RandomGen.NextVector(Level.BoundingRect); // Annetaan pallolle satunnainen sijtainti kuitenkin niin, että se on pelialueen sisällä.
            pallo.Color = RandomGen.NextColor();
            Add(pallo);
            i++; // Lisäyslauseke, joka muuttaa "laskurimuutujan" arvoa
        } // päättyy tähän        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");

        // for-silmukan "määrittelyriville"
        // kirjoitetaan 
        // 1. laskurimuuttujan alustus, 2. toistoehto, että 3. lisäyslauseke
        for (int j = 0; j < 20; j++)
        {
            PhysicsObject nelio = new PhysicsObject(50, 50, Shape.Rectangle);
            nelio.Position = RandomGen.NextVector(Level.BoundingRect); // Annetaan pallolle satunnainen sijtainti kuitenkin niin, että se on pelialueen sisällä.
            Add(nelio);
        }
        
        Gravity = new Vector(0, -1000);
        Level.CreateBorders();
    }
}