# Yhteenveto Ohjelmointi 1 -kurssin asioista

Tässä dokumentissa käydään läpi Ohjelmointi 1 -kurssin keskeisiä asioita. Dokumentti on tarkoitettu kertaukseksi ja toisaalta apuvälineeksi kurssin jälkeiseen ohjelmointiin. Dokumentti ei ole täydellinen, eikä se sisällä kaikkea kurssilla käytyä asiaa. Esimerkit ovat valikoituja, ja kattavat vain osan kurssin aiheista. Koko kurssimateriaali on luettavissa [ Ohjelmointi 1 -kurssin monisteesta](https://tim.jyu.fi/view/kurssit/tie/ohj1/yleinen) sekä
[monisteen täydennyksistä](https://tim.jyu.fi/view/kurssit/tie/ohj1/materiaali/monisteenTaydennykset).

Jos löydät tästä dokumentista virheitä tai haluat antaa parannusehdotuksen, [tee ns. issue tähän repoon](https://gitlab.jyu.fi/tie/ohj1/2024k/esimerkit/-/issues/new?issuable_template=kertaus).

## Lauseiden suorittaminen

Lauseet ovat ohjelman perusyksiköitä, jotka suoritetaan yksi kerrallaan. Lause voi olla esimerkiksi muuttujan määrittely, aliohjelman kutsu, ehto- tai toistolause.

Lauseella voi olla käyttäjälle näkyviä vaikutuksia, kuten ruudulla näkyvä tulostus tai kappaleen lisääminen pelikentälle.

```csharp
Console.WriteLine("Hello, World!"); // Tulostaa näytölle tekstiä
PhysicsObject pallo = new PhysicsObject(10, 10); // Luo uuden fysiikkaolion
Add(pallo); // Lisää olion pelikentälle
```

Lauseella voi olla myös "näkymätön" vaikutus, kuten muuttujan tilan muuttuminen.

```csharp
int a = 3; // Muuttaa muuttujan a arvoa
a++; // Lisää muuttujan a arvoa yhdellä
```

## Ohjelman suoritusjärjestys

Ohjelma suoritetaan ylhäältä alas, vasemmalta oikealle. Ohjelman suoritus alkaa `Main`-aliohjelmasta, joka on ohjelman pääohjelma. Pääohjelma voi kutsua muita aliohjelmia, jotka voivat kutsua muita aliohjelmia jne.

## Ohjelman rakenne

C#-kielessä lauseet kirjoitetaan luokkarakenteen sisään. Luokka voi sisältää aliohjelmia. Ohjelman suoritus alkaa `Main`-aliohjelmasta, jota kutsutaan myös _pääohjelmaksi_.

Alla oleva sovellus koostuu yhdestä luokasta, joka sisältää pääohjelman ja yhden aliohjelman (`Tervehdys`).

```csharp
public class Sovellus
{
  public static void Main()
  {
      // Ohjelman suoritus alkaa Main-aliohjelmasta
      // Tässä kutsutaan Tervehdys-aliohjelmaa kaksi kertaa
      Tervehdys();
      Tervehdys();
  }

  public static void Tervehdys()
  {
     Console.WriteLine("Tervehdys!");
  }
}
```

## C#-ohjelman kääntäminen ja ajaminen

**Kääntäminen** tarkoittaa ohjelmoijan kirjoittaman ohjelmakoodin muuttamista tietokoneelle suoritettavaksi ohjelmaksi, konekielelle. IDEssä (esim. Rider) kääntäminen tapahtuu klikkaamalla "Run" tai "Debug".

Kääntämisen jälkeen ohjelmaa voidaan ajaa IDEssä klikkaamalla "Run" tai "Debug" -nappia. Ohjelmaa voidaan ajaa myös komentoriviltä, esimerkiksi seuraavasti:

```bash
dotnet run
```

Ohjelma on käännettävä aina koodin muuttamisen jälkeen, jotta muutokset tulevat voimaan.

## Käännösvirheet

Kääntämisen yhteydessä ohjelmakoodi tarkistetaan virheiden varalta. Jos koodissa on virheitä, kääntäminen ei onnistu eikä ohjelmaa voi ajaa. Virheet on korjattava ennen uutta kääntämistä.

## Koodin kommentointi ja dokumentointi

Koodiin voidaan lisätä kommentteja, jotka auttavat koodin ymmärtämisessä. Kommentit eivät vaikuta ohjelman toimintaan.

```csharp
// Kommentti yhdellä rivillä
/* Kommentti
usealla rivillä */
```

Dokumentointi auttaa koodin ylläpitämisessä ja kehittämisessä. Dokumentoinnin avulla muutkin kuin koodin kirjoittaja ymmärtävät sen.

Dokumentointiin käytetään XML-muotoisia kommentteja (esim. `<summary>...</summary>`). Dokumentaatiokommenttien sijainti on ennen dokumentoitavaa koodia, kuten aliohjelmaa tai luokkaa.

```csharp
/// <summary>
/// Tämä aliohjelma tervehtii käyttäjää.
/// </summary>
public static void Tervehdys()
{
    Console.WriteLine("Tervehdys!");
}
```

Alla olevissa esimerkeissä dokumentaatiokommentit on jätetty pois tilan säästämiseksi.

## Muuttujat ja vakiot

**Ohjelman tila määritellään muuttujiin.** Muuttujat ovat ohjelmassa käytettäviä arvoja, joiden arvoa ohjelmoija voi muuttaa ohjelman suorituksen aikana. Niinpä voidaan sanoa, että muuttuja on ohjelman tilassa oleva arvo, ja jos muuttujan arvoa muutetaan, muuttuu ohjelman tila.

**Muuttuja on määriteltävä (nimi, tyyppi) ennen käyttöä.** Muuttujan tyyppi määrittää, millaisia arvoja siihen voi tallentaa.

```csharp
int luku = 5; // luku-muuttujaan voi tallentaa kokonaislukuja
string nimi = "Maija"; // nimi-muuttujaan voi tallentaa merkkijonoja
bool onkoTosi = true; // onkoTosi-muuttujaan voi tallentaa totuusarvoja
```

**Vakiot.** Vakio on luku-, merkkijono- tai totuusarvotyyppinen muuttuja, jonka arvo vakioidaan käännöksessä, eikä arvoa voi muuttaa ohjelman suorituksen aikana. Vakio määritellään `const`-avainsanalla. Vakion nimi kirjoitetaan suuraakkosilla (sanat erotellaan alaviivalla) tai vaihtoehtoisesti PascalCase-tyyliin.

```csharp
const int MONTAKO_VIHUA = 10; // all caps -tyyli
const string TervehdysSana = "Hei"; // PascalCase-tyyli
```

Huomaa, että oliotietotyypit (esim. `int[]`) ovat viitepohjaisia muuttujia, joten niitä ei voi määritellä `const`-avainsanalla. On olemassa muuttumattomia oliotietotyyppejä (esimerkiksi `ImmutableArray`), mutta emme käsittele niitä tällä kurssilla, joskin `string`-tyyppi tekee tähän poikkeuksen.

## Sijoitus

**Sijoitus.** Muuttujan arvoa voidaan muuttaa sijoituslauseella. Sijoitus tapahtuu aina oikealta vasemmalle.

```csharp
int a = 5;
int b = 3;
int summa = a + b;
```

Myös jotkin operaattorit voivat tehdä sijoituksen.

```csharp
int a = 5;
a += 3; // a = a + 3
a++; // a = a + 1
```

## Aliohjelmat

**Tarkoitus.** Aliohjelmat ovat ohjelman osia, jotka suorittavat tietyn tehtävän. Aliohjelmat helpottavat ohjelman rakentamista pienistä palasista, sekä ohjelman ylläpitoa. Aliohjelma voi ottaa vastaan tietoa parametreina, ja se voi palauttaa arvon.

**Parametrit ja paluuarvo.** Tämä aliohjelma laskee kahden luvun summan ja palauttaa sen. Aliohjelma ottaa vastaan kaksi parametria ja palauttaa näiden parametrien arvojen summan.

```csharp
public static int Summa(int a, int b)
{
    return a + b;
}
```

**Kutsuminen.** Aliohjelmaa kutsutaan kirjoittamalla aliohjelman nimi ja sulkujen sisään _argumentit_, joita haluamme antaa aliohjelmalle.

```csharp
int summa = Summa(3, 5);
Console.WriteLine(summa); // Tulostaa 8
```

Jos aliohjelma määritetään `void`-tyyppiseksi, se ei palauta arvoa, ts. siinä ei ole `return`-lauseita.

```csharp
public static void Tervehdys()
{
    Console.WriteLine("Moikka!");
}
```

Jos aliohjelman paluuarvon tyyppi on määritelty, aliohjelmassa tulee olla vähintään yksi `return`-lause. Alla oleva koodi aiheuttaisi käännösvirheen.

```csharp
public static int Summa(int a, int b)
{
    Console.WriteLine(a + b);
    // Käännösvirhe: "not all code paths return a value"
}
```

## Muuttujien näkyvyys

Muuttuja _näkyy_ vain siinä lohkossa, jossa se on määritelty. Lohko voi olla esimerkiksi aliohjelma, luokka tai silmukka.

```csharp
public static void Main()
{
    int a = 5; // a näkyy vain Main-aliohjelmassa
    Console.WriteLine(a);
}

public static void Tervehdys()
{
    Console.WriteLine(a); // Ei toimi, koska a ei näy tässä aliohjelmassa
    // Käännösvirhe: "The name 'a' does not exist in the current context"
}
```

Aliohjelmien parametrimuuttujat ovat aliohjelman paikallisia muuttujia, joten ne eivät näy kyseisen aliohjelman ulkopuolella.

```csharp
public static void Main()
{
    int luku = 5;
    Tervehdys(luku); // luku-muuttujan arvo välitetään aliohjelmalle
}

public static void Tervehdys(int a)
{
    Console.WriteLine(a);
}

public static void ToinenAliohjelma()
{
    Console.WriteLine(a); // a _ei_ näy tässä aliohjelmassa
}
```

Näkyvyys, lisätietoa: [Muuttujien näkyvyys](https://tim.jyu.fi/view/kurssit/tie/ohj1/materiaali/MuuttujienNakyvyys)

## Merkkijonot

**Merkkijono** (`string`) sisältää `char`-merkkejä. Merkkijonoja käytetään esimerkiksi tekstien käsittelyyn ja tulostamiseen.

Merkkijonon sisäinen esitysmuoto on taulukko (ks. [Taulukot](#taulukot)), joten merkkijonon _n_:s merkki saadaan käyttäen hakasulkunotaatiota.

```csharp
string nimi = "Maija";
char ensimmainenKirjain = nimi[0]; // merkki 'M'
```

**Merkkijonojen yhdistäminen.** Merkkijonoja voidaan yhdistää `+`-operaattorilla tai _interpoloinnilla_, jossa merkkijonon sisään kirjoitetaan muuttujan nimi.

```csharp
string etunimi = "Maija";
string sukunimi = "Mallikas";
// Yhdistetään etunimi ja sukunimi
string kokonimi = etunimi + " " + sukunimi; // "Maija Mallikas"
// Interpolointi
string tervehdys = $"Hei, {kokonimi}!"; // "Hei, Maija Mallikas!"
```

**Muokattava merkkijono**, `StringBuilder`, on tehokkaampi tapa käsitellä merkkijonoja, jotka muuttuvat usein. `StringBuilder`-luokkaa käytetään, kun merkkijonoa muokataan usein, koska `string`-tyyppi on muuttumaton.

## Ehtolauseet

**Ehtolauseet** ovat rakenteita, jotka suorittavat tiettyjä lauseita, jos jokin ehto on voimassa. Koodin suoritusta voidaan ohjata ehtolauseilla.

**Vertailuoperaattorit.** Ehtolauseissa käytetään _vertailuoperaattoreita_ (tai _loogisia operaattoreita_), jotka vertailevat kahta arvoa ja palauttavat totuusarvon.

```csharp
int a = 5;
int b = 3;
if (a > b)
{
    Console.WriteLine("a on suurempi kuin b");
}
```

**switch-case**-rakenteella voidaan vertailla muuttujia `if-else`-lauseiden tavoin, mutta hieman vähemmällä kirjoittamisella.

```csharp
int luku = 47;
switch (luku)
{
   case < 50:
      Console.WriteLine("Luku on pienempi kuin 50");
      break;
   case > 50:
      Console.WriteLine("Luku on suurempi kuin 50");
      break;
   default:
      Console.WriteLine("Luku on 50");
      break;
}
```

## Toistorakenteet

**Toistorakenteilla** voidaan toistaa ohjelman suoritusta niin kauan kuin jokin ehto on voimassa.

Toistorakenteita ovat `while`, `do-while`, `for`, `for-each` ja `foreach`.

Tulostetaan luvut 1-10 käyttäen `while`-silmukkaa.

```csharp
int i = 1;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}
```

For-silmukka:

```csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
```

For-silmukkaan kuuluu osat alustus (yllä `int i = 1`), toistoehto (`i <= 10`), päivitys (`i++`) ja runko-osa (aaltosulkeiden rajaama osa). Mikä tahansa näistä osista voi olla tyhjä, mutta puolipisteet on silti kirjoitettava.

**For-each**-silmukkaa käytetään silmukointiin taulukoissa ja kokoelmissa. For-each-silmukkaa käytetään, kun halutaan käydä läpi kaikki taulukon tai kokoelman alkiot.

```csharp
int[] luvut = { 7, 3, 1, -5, 9};
foreach (int luku in luvut)
{
    Console.WriteLine(luku);
}
```

Silmukoita voi kirjoittaa myös sisäkkäin.

```csharp
for (int i = 1; i < 5; i++)
{
    for (int j = 2; j < 8; j++)
    {
        // Tulostetaan kaikki mahdolliset
        // i:n ja j:n muodostamien parien arvot
        Console.WriteLine($"{i}, {j}");
    }
}
```

Tarvittaessa `break`-lauseella voidaan lopettaa silmukka ja siirtyä silmukan jälkeiseen koodiin. Toisaalta
`continue`-lauseella voidaan tarvittaessa päättää silmukan kierros.

```csharp
// Tulostetaan luvut 1, 2, 3, 4, 6, 7. Luku 5 jätetään välistä,
// ja luvun 8 kohdalla silmukka lopetetaan.
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue; // Siirrytään seuraavaan kierrokseen
    }
    if (i == 8)
    {
        break; // Lopetetaan silmukan suoritus
    }
    Console.WriteLine(i);
}
```

## Taulukot

_Taulukko_ on järjestetty joukko yhden tyyppisiä asioita. Taulukko luodaan määrittelemällä taulukon tyyppi ja koko.

```csharp
int[] luvut = new int[5]; // Luodaan taulukko, jossa on 5 kokonaislukua
```

Taulukon koko on kiinteä, eikä sitä voi muuttaa.

Vaihtoehtoisesti taulukon voi alustaa määrittelyn yhteydessä.

```csharp
int[] luvut = { 7, 5, 9, 1, 2 };
```

Taulukossa olevia asioita kutsutaan _alkioiksi_. Yksittäiseen alkioon viitataan hakasulkujen ja paikkaluvun, eli indeksin avulla. Taulukon ensimmäinen alkio on indeksissä 0.

```csharp
luvut[0] = 7;
luvut[1] = 5;
luvut[2] = 9;
luvut[3] = 1;
luvut[4] = 2;

// Tulostetaan taulukon kolmas alkio, ts. indeksissä 2 oleva luku
Console.WriteLine(luvut[2]); // Tulostaa 9
```

**Taulukon pituus** saadaan `Length`-ominaisuudella.

Taulukoita käsitellään usein silmukan avulla. Lasketaan äskeisen taulukon lukujen summa.

```csharp
int summa = 0;
for (int i = 0; i < luvut.Length; i++)
{
      summa += luvut[i];
}
Console.WriteLine(summa); // Tulostaa 24
```

**Moniulotteiset taulukot.** Taulukossa voi olla useampi kuin yksi ulottuvuus. Tällä kurssilla rajoitumme kahden ulottuvuuden taulukoihin, joita kutsutaan myös _matriiseiksi_.

```csharp
// Kolmen rivin ja kahden sarakkeen taulukko
int[,] taulukko = new int[3, 2];

// Alustetaan taulukko
taulukko[0, 0] = 1;
taulukko[0, 1] = 2;
taulukko[1, 0] = 3;
taulukko[1, 1] = 4;
taulukko[2, 0] = 5;
taulukko[2, 1] = 6;
```

Matriisin rivien ja sarakkeiden määrä saadaan `GetLength`-metodilla.

```csharp
int rivit = taulukko.GetLength(0); // 3
int sarakkeet = taulukko.GetLength(1); // 2
```

## Lista

**Lista** on dynaaminen tietorakenne, joka voi kasvaa ja kutistua tarpeen mukaan. Listan koko ei ole kiinteä, toisin kuin taulukon.

Listan voi luoda määrittelemällä listan tyyppi ja alustamalla sen.

```csharp
List<int> luvut = new List<int>();
```

Listaan voi lisätä alkioita `Add`-metodilla.

```csharp
luvut.Add(5);
luvut.Add(7);
```

Listan alkioihin viitataan indeksillä, kuten taulukossa. Listan koko saadaan `Count`-ominaisuudella.

```csharp
int koko = luvut.Count; // 2
```

## Sanakirja

**Sanakirja** on tietorakenne, joka koostuu avain-arvo -pareista. Sanakirjaan voi tallentaa arvoja avaimen perusteella. Sanakirja luodaan määrittelemällä avaimen ja arvon tyypit.

```csharp
Dictionary<string, int> sanakirja = new Dictionary<string, int>();
```

Sanakirjaan lisätään avain-arvo-pareja `Add`-metodilla.

```csharp
sanakirja.Add("Autoja", 3);
sanakirja.Add("Polkupyöriä", 2);
sanakirja.Add("Moottoripyöriä", 7);
```

Sanakirjan arvoihin viitataan avaimen avulla.

```csharp
int autoja = sanakirja["Autoja"];
Console.WriteLine(autoja); // 3
```

Sanakirjan alkiot voidaan käydä läpi `foreach`-silmukalla.

```csharp
foreach (KeyValuePair<string, int> pari in sanakirja)
{
    Console.WriteLine($"{pari.Key}: {pari.Value}");
}
```

## Merkkijonojen pilkkominen

Merkkijonoja voidaan pilkkoa `Split`-metodilla. Metodi palauttaa taulukon, jossa on alkuperäisen merkkijonon osat.

```csharp
string teksti = "Maija,Matti,Anna";
string[] nimet = teksti.Split(',');
foreach (string nimi in nimet)
{
    Console.WriteLine(nimi);
}
```

## Rekursio

**Rekursio** on ohjelmointitekniikka, jossa aliohjelma kutsuu itseään. Rekursiivinen aliohjelma koostuu kahdesta osasta: _perustapaus_ ja _rekursiivinen tapaus_.

Perustapaus on tilanne, jossa rekursiivinen aliohjelma ei kutsu itseään. Rekursiivinen tapaus on tilanne, jossa rekursiivinen aliohjelma kutsuu itseään.

Esimerkki rekursiivisesta aliohjelmasta, joka laskee luvun kertoman.

```csharp
public static int Kertoma(int n)
{
    if (n == 0)
    {
        return 1; // Perustapaus
    }
    else
    {
        return n * Kertoma(n - 1); // Rekursiivinen tapaus
    }
}
```

## Debuggaus

**Debuggaus** on ohjelman suorituksen tarkastelua ja virheiden etsimistä. Ohjelmaa voidaan ajaa _debug-tilassa_, jolloin ohjelmaa voidaan suorittaa askel askeleelta ja tarkastella ohjelman tilaa. Debuggaus auttaa virheiden etsimisessä ja ohjelman toiminnan ymmärtämisessä.

Varmista, että osaat käyttää debuggaustyökaluja, kuten

- keskeytyskohdat,
- step over,
- step into,
- step out,
- muuttujien tarkastelu ja muokkaus,
- watch-ikkuna,
- kutsupino,
- koodin ajon jatkaminen,
- koodin ajon pysäyttäminen.

## Oliotietotyypit

**Oliotietotyypit** ovat tietotyyppejä, jotka koostuvat _olion ominaisuuksista_ ja _metodeista_. Oliotietotyyppejä käytetään monimutkaisten tietorakenteiden ja toimintojen toteuttamiseen.

Tällä kurssilla ei luoda uusia oliotietotyyppejä, vaan käytetään valmiita oliotietotyyppejä, kuten `string`, `List`, `PhysicsObject`, jne. ja niiden ominaisuuksia ja metodeja, kuten `Length`, `Add`, `Remove`, jne.

Oliotietotyypit ovat _viitepohjaisia_, eli muuttujat eivät sisällä suoraan arvoa, vaan viittauksen muistissa olevaan olioon. Jos oliomuuttuja annetaan aliohjelmalle argumenttina, tällaisen muuttujan arvo voi muuttua aliohjelman suorituksen aikana.

```csharp
List<int> luvut = new List<int>();
// luvut-listan pituus on tällä hetkellä 0.
// Annetaan luvut-lista argumenttina aliohjelmalle.
LisaaLukuja(luvut);
Console.WriteLine(luvut.Count); // Tulostaa 3

public static void LisaaLukuja(List<int> luvut)
{
   // Tämä muuttaa luvut-listan sisältöä, ja muutos näkyy myös kutsujalle
   luvut.Add(4);
   luvut.Add(2);
   luvut.Add(1);
}
```

Omien oliotietotyyppien luomiseen tarvitaan _luokka_. Luokka määrittelee oliotietotyypin ominaisuudet ja metodit. Omiin oliotietotyyppeihin palataan myöhemmillä kursseilla.

## Poikkeukset

**Poikkeukset** ovat ohjelman suorituksen aikana tapahtuvia virhetilanteita. Poikkeukset voivat johtua esimerkiksi virheellisestä syötteestä, tiedostojen puuttumisesta tai muusta odottamattomasta tilanteesta.

Poikkeuksia voidaan käsitellä `try-catch`-rakenteella. `try`-lohkossa suoritetaan koodi, joka saattaa aiheuttaa poikkeuksen. Jos poikkeus tapahtuu, suoritus siirtyy `catch`-lohkoon.

## Tiedostojen käsittely

**Tiedostojen käsittely** tarkoittaa tiedostojen lukemista ja kirjoittamista ohjelmasta.

Tiedostoon kirjoittaminen:

```csharp
using System.IO;
string tiedostonimi = "tiedosto.txt";
string teksti = "Moi!";
File.WriteAllText(tiedostonimi, teksti);
```

Tiedoston lukeminen:

```csharp
using System;
using System.IO;
string tiedostonimi = "tiedosto.txt";
// Luetaan kaikki tiedoston rivit string-taulukkoon
string[] rivit = File.ReadAllLines(tiedostonimi);

// Tulostetaan kaikki rivit
foreach (string rivi in rivit)
{
    Console.WriteLine(rivi);
}
```

## Lukujen esitys tietokoneessa

Tietokoneen muistiin tallennetaan lukuja kaksijärjestelmässä eli ns. _binäärimuodossa_. Tietokoneen muisti koostuu biteistä, jotka voivat olla joko 0 tai 1. On hyvä ymmärtää, miten lukuja esitetään tietokoneessa, jotta voi ymmärtää, miten lukuja käsitellään ohjelmoinnissa.

Esimerkiksi luku 7 on 8-bittisessä binäärimuodossa `00000111`. Negatiivinen luku -7 voidaan esittää kahden komplementin avulla: `11111001`. Luvun 7 kohdalla kahden komplementti saadaan laskemalla seuraavasti

```
7 = 00000111
// Käänteisluku
~7 = 11111000
// Lisätään 1
~7 + 1 = 11111001
```

Tosiasiassa 8-bittisiä lukuja käytetään harvoin, ja useimmiten käytetään 32-bittisiä (C#:ssa `int`) tai 64-bittisiä (`long`) lukuja. Vastaava ajatus pätee kuitenkin myös näihin suurempibittisiin lukuihin.

Desimaaliluvut esitetään tietokoneessa _liukulukuna_ IEEE 754 -standardin mukaisesti. Liukuluvut voivat olla myös _erikoisarvoja_, kuten `NaN` (Not a Number) ja `Infinity`. Liukuluvut ovat likiarvoja, vaikkakin käytännössä jotkin niistä ovat tarkkoja arvoja (kuten luku 1.0).

Esimerkiksi lukua 0.1 ei voida esittää täsmällisesti liukulukuna, koska kaksiarvoisessa järjestelmässä 0.1 on äärettömän pitkä desimaaliluku.

## ASCII-koodi

**ASCII-koodi** on merkkien ja numeroiden esitystapa tietokoneessa. ASCII-koodi määrittää, miten merkit ja numerot esitetään binäärimuodossa. ASCII-koodi on 7-bittinen, ja se sisältää 128 eri merkkiä.

Esimerkiksi kirjain 'A' on ASCII-koodissa 65, 'B' on 66 jne.

ASCII-koodi on käytännössä vanhentunut, ja nykyisin käytetään yleisesti _Unicode_-standardia, joka sisältää kaikki maailman kirjoitusjärjestelmät. Ohjelmakoodin kirjoittamisessa käytetään kuitenkin edelleen ASCII-merkkejä, joskin Unicode-merkit ovat sallittuja monissa ohjelmointikielissä. ASCII-merkit ovat yhteensopivia Unicode-merkkien kanssa, koska ASCII-merkit ovat Unicode-merkkien alkuosajoukko.

Unicode-merkkien määrä on valtava verrattuna ASCII-koodiin: niitä on yli miljoona. Unicode-merkit esitetään yleensä 16-järjestelmän lukuna, eli ns. heksadesimaalina, kuten `U+0041` (luku 65, eli kirjain 'A').
