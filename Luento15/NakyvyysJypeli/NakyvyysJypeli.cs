using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

namespace NakyvyysJypeli;

/// @author Omanimi
/// @version 27.02.2024
/// <summary>
/// 
/// </summary>
public class NakyvyysJypeli : PhysicsGame
{
    public override void Begin()
    {
        SetWindowSize(1920, 1080);
        CenterWindow();
        Level.Size = new Vector(1920, 1080);
        Level.CreateBorders();
        List<GameObject> pallot = new List<GameObject>();

        for (int i = 0; i < 50; i++)
        {
            LisaaPallo(pallot);
        }
       
        for (int i = 0; i < 50; i++)
        {
            GameObject pallo = TeePallo(Level.BoundingRect);
            Add(pallo);
            pallot.Add(pallo);
        }
        
        // Tämä tehtiin luennon jälkeen:
        // Lisäsimme yllä palloja listaan sen takia, että voimme käsitellä
        // palloja yhtenä kokonaisuutena. Luodaan tässä "pelaaja" (ts. 
        // hiirellä liikuteltava neliö), jota lähellä olevia palloja
        // värjäilemme valkoiseksi. 
        GameObject pelaaja = new GameObject(30, 30, Shape.Rectangle);
        pelaaja.Color = Color.Blue;
        Add(pelaaja);

        // Tehdään tässä hiiren liikkumisen kuuntelija, joka 
        // 1. värjää ensin kaikki pallot valkoiseksi
        // 2. ottaa talteen pelaajan sijainnin
        // 3. etsii ja värjää punaiseksi kaikki ne pallot jotka ovat <200 etäisyyden päässä pelaajasta.
        Mouse.ListenMovement(0.1, delegate()
        {
            foreach (GameObject pallo in pallot)
            {
                pallo.Color = Color.White;
            }
            pelaaja.Position = Mouse.PositionOnWorld;
            // Jätetään vapaaehtoiseksi kotitehtäväksi, kuinka tämä
            // tehtäisiin sivuvaikutuksettomaksi funktioksi.
            // Ts. alkuperäistä pallot-taulukkoa ei muuteta
            // vaan palautetaan täysin uusi taulukko, joka
            // sijoitetaan pallot-muuttujaan
            VarjaaLaheiset(pallot, pelaaja.Position, 200);
        }, null);

        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }

    /// <summary>
    /// Tekee yhden pallon satunnaiselle alueelle.
    /// Tehty pallo palautetaan funktiosta. 
    /// </summary>
    /// <param name="alue">Mille alueelle pallo tehdään</param>
    /// <returns>Pallo</returns>
    static GameObject TeePallo(BoundingRectangle alue)
    {
        GameObject pallo = new GameObject(30, 30, Shape.Circle);
        pallo.Position = RandomGen.NextVector(alue);
        // pallo.Color = Color.Red;
        return pallo;
    }
    
    /// <summary>
    /// TÄMÄ TEHTIIN LUENNON JÄLKEEN.
    /// Värjää alle maxEtaisyyden päässä oelvat pallot punaiseksi.
    /// Tämä aliohjelma on sivuvaikutuksellinen, koska se muuttaa
    /// pallot-listaa. Se myöskin muuttaa pallon väriä, joka on
    /// myöskin sivuvaikutus (vaikutuksen seuraukset näkyvät  käyttäjän ruudulla).
    /// </summary>
    /// <param name="pallot">Pallot</param>
    /// <param name="piste">Piste</param>
    /// <param name="maxEtaisyys">Max etäisyys jonka alle olevat pallot värjätään</param>
    public void VarjaaLaheiset(List<GameObject> pallot, Vector piste, double maxEtaisyys)
    {
        foreach (GameObject pallo in pallot)
        {
            if (Vector.Distance(pallo.Position, piste) < maxEtaisyys)
            {
                pallo.Color = Color.Red;
            }
        }
    }

    
    /// <summary>
    /// Lisää pallo näytölle ja pallot-listaan.
    /// </summary>
    /// <param name="pallot">Pallot-lista</param>
    void LisaaPallo(List<GameObject> pallot)
    {
        GameObject pallo = new GameObject(30, 30, Shape.Circle);
        pallo.Position = RandomGen.NextVector(Level.BoundingRect);
        pallo.Color = Color.White;
        Add(pallo); // 1. sivuvaikutus
        pallot.Add(pallo); // 2. sivuvaikutus
    }
}