using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

namespace PelottavaPeli;

/// <summary>
/// Luento 14, PelottavaPelio
/// </summary>
public class PelottavaPeli : PhysicsGame
{
    /// <summary>
    /// Pelaajan nopeus
    /// </summary>
    private const double NOPEUS = 200;
    
    /// <summary>
    /// Pelaajan hyppyvoima
    /// </summary>
    private const double HYPPYNOPEUS = 750;
    
    /// <summary>
    /// Pelialueen yhden ruudun koko
    /// </summary>
    private const int RUUDUN_KOKO = 40;

    /// <summary>
    /// Pelaaja
    /// </summary>
    private PlatformCharacter pelaaja1;

    private Image pelaajanKuva = LoadImage("ukkeli.png");
    private Image tahtiKuva = LoadImage("tahti.png");

    private Image vihunPanosKuva = LoadImage("panos");
    
    private SoundEffect maaliAani = LoadSoundEffect("maali.wav");

    /// <summary>
    /// Alustukset
    /// </summary>
    public override void Begin()
    {
        Gravity = new Vector(0, -1000);

        LuoKentta();
        LisaaNappaimet();

        Camera.Follow(pelaaja1);
        Camera.ZoomFactor = 1.2;
        Camera.StayInLevel = true;
        MasterVolume = 0.5;
    }

    /// <summary>
    /// Kentän luonti
    /// </summary>
    private void LuoKentta()
    {
        TileMap kentta = TileMap.FromLevelAsset("kentta1.txt");
        kentta.SetTileMethod('t', LisaaTaso, "lattia");
        kentta.SetTileMethod('x', LisaaTaso, "lattia");
        kentta.SetTileMethod('T', LisaaTaso, "taso");
        kentta.SetTileMethod('5', LuoVihu, 5);
        kentta.SetTileMethod('4', LuoVihu, 4);
        kentta.SetTileMethod('3', LuoVihu, 3);
        kentta.SetTileMethod('2', LuoVihu, 2);
        kentta.SetTileMethod('*', LisaaTahti);
        kentta.SetTileMethod('p', LisaaPelaaja);
        kentta.Execute(RUUDUN_KOKO, RUUDUN_KOKO);
        Level.CreateBorders();
        Level.Background.CreateGradient(Color.White, Color.SkyBlue);
    }

    /// <summary>
    /// Luo vihu
    /// </summary>
    /// <param name="paikka">Paikka</param>
    /// <param name="leveys">Leveys</param>
    /// <param name="korkeus">Korkeus</param>
    /// <param name="liikeMaara">Liikemäärä</param>
    public void LuoVihu(Vector paikka, double leveys, double korkeus, int liikeMaara)
    {
        PlatformCharacter vihu = new PlatformCharacter(leveys, korkeus)
        {
            Shape = Shape.Circle,
            Position = paikka,
            Image = LoadImage("vihu"),
            Tag = "vihu"
        };
        Add(vihu);
        
        PathFollowerBrain pfb = new PathFollowerBrain();
        List<Vector> reitti = new List<Vector>();
        reitti.Add(vihu.Position);
        Vector seuraavaPiste = vihu.Position + new Vector(liikeMaara *RUUDUN_KOKO, 0);
        reitti.Add(seuraavaPiste);
        pfb.Path = reitti;
        pfb.Loop = true;
        vihu.Brain = pfb; 
        
        // Ajastimen teko Jypelissä:
        // https://tim.jyu.fi/view/kurssit/jypeli/tapahtumat/ajastimet
        Timer heittoajastin = new Timer();
        heittoajastin.Interval = 2.0;
        heittoajastin.Timeout += delegate() { Heita(vihu, "pelaaja"); };
        heittoajastin.Start();

        // Destroyed-tapahtuma Jypelissä:
        // https://tim.jyu.fi/view/kurssit/jypeli/tapahtumat/muuttapahtumat
        vihu.Destroyed += heittoajastin.Stop;
    }

    /// <summary>
    /// Heitä kappale
    /// </summary>
    /// <param name="heittavaOlio">Heittävä olio</param>
    /// <param name="kohdeolionTunniste">Kohdeolion tägi</param>
    public void Heita(PhysicsObject heittavaOlio, string kohdeolionTunniste)
    {
        // MessageDisplay.Add("Heitetään joku kiva esine");
        PhysicsObject kappale = new PhysicsObject(15, 15, Shape.Circle);
        kappale.Hit(new Vector(80, 80));
        kappale.Image = vihunPanosKuva;
        kappale.Position = heittavaOlio.Position;
        kappale.Color = Color.DarkAzure;
        kappale.MaximumLifetime = TimeSpan.FromSeconds(1.5);
        AddCollisionHandler(kappale, kohdeolionTunniste, CollisionHandler.ExplodeBoth(100.0, true));
        Add(kappale);
    }
    
    /// <summary>
    /// Lisää taso
    /// </summary>
    /// <param name="paikka">Paikka</param>
    /// <param name="leveys">Leveys</param>
    /// <param name="korkeus">Korkeus</param>
    /// <param name="kuvanNimi">Kuvatiedoston nimi</param>
    private void LisaaTaso(Vector paikka, double leveys, double korkeus, string kuvanNimi)
    {
        PhysicsObject taso = PhysicsObject.CreateStaticObject(leveys, korkeus);
        taso.Position = paikka;
        taso.Image = LoadImage(kuvanNimi);
        taso.Color = Color.Green;
        Add(taso);
    }
    
    /// <summary>
    /// Lisää tähti
    /// </summary>
    /// <param name="paikka">Paikka</param>
    /// <param name="leveys">Leveys</param>
    /// <param name="korkeus">Korkeus</param>
    private void LisaaTahti(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject tahti = PhysicsObject.CreateStaticObject(leveys, korkeus);
        tahti.IgnoresCollisionResponse = true;
        tahti.Position = paikka;
        tahti.Image = tahtiKuva;
        tahti.Tag = "tahti";
        Add(tahti);
    }

    /// <summary>
    /// Lisää pelaaja
    /// </summary>
    /// <param name="paikka">Paikka</param>
    /// <param name="leveys">Leveys</param>
    /// <param name="korkeus">Korkeus</param>
    private void LisaaPelaaja(Vector paikka, double leveys, double korkeus)
    {
        pelaaja1 = new PlatformCharacter(leveys, korkeus);
        pelaaja1.Position = paikka;
        pelaaja1.Mass = 4.0;
        pelaaja1.Image = pelaajanKuva;
        pelaaja1.Tag = "pelaaja";
        AddCollisionHandler(pelaaja1, "tahti", TormaaTahteen);
        Add(pelaaja1);
    }

    /// <summary>
    /// Kontrollit
    /// </summary>
    private void LisaaNappaimet()
    {
        Keyboard.Listen(Key.F1, ButtonState.Pressed, ShowControlHelp, "Näytä ohjeet");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");

        Keyboard.Listen(Key.Left, ButtonState.Down, Liikuta, "Liikkuu vasemmalle", pelaaja1, -NOPEUS);
        Keyboard.Listen(Key.Right, ButtonState.Down, Liikuta, "Liikkuu vasemmalle", pelaaja1, NOPEUS);
        Keyboard.Listen(Key.Up, ButtonState.Pressed, Hyppaa, "Pelaaja hyppää", pelaaja1, HYPPYNOPEUS);
        Keyboard.Listen(Key.Space, ButtonState.Down, Heita, null, pelaaja1, "vihu");
    }

    private void Liikuta(PlatformCharacter hahmo, double nopeus)
    {
        hahmo.Walk(nopeus);
    }

    private void Hyppaa(PlatformCharacter hahmo, double nopeus)
    {
        hahmo.Jump(nopeus);
    }

    private void TormaaTahteen(PhysicsObject hahmo, PhysicsObject tahti)
    {
        maaliAani.Play();
        MessageDisplay.Add("Keräsit tähden!");
        tahti.Destroy();
    }
}