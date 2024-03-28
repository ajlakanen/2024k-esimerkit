# Yhteenveto Ohjelmointi 1 -kurssin asioista

Tässä dokumentissa käydään läpi Ohjelmointi 1 -kurssin keskeisiä asioita. Dokumentti on tarkoitettu kertaukseksi ja apuvälineeksi kurssin jälkeiseen ohjelmointiin. Dokumentti ei ole täydellinen, eikä se sisällä kaikkea kurssilla käytyä asiaa. Esimerkit ovat valikoituja, ja kattavat vain osan kurssin aiheista.

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

Kääntämisen yhteydessä ohjelmakoodi tarkistetaan virheiden varalta.
Jos koodissa on virheitä, kääntäminen ei onnistu eikä ohjelmaa voi ajaa. Virheet on korjattava ennen uutta kääntämistä.

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

Huomaa, että oliotietotyypit (esim. `int[]`) ovat viitepohjaisia muuttujia, joten niitä ei voi määritellä `const`-avainsanalla.

## Sijoitus

**Sijoitus.** Muuttujan arvoa voidaan muuttaa sijoituslauseella. Sijoitus tapahtuu aina oikealta vasemmalle.

```csharp
int a = 5;
int b = 3;
int summa = a + b;
```

## Aliohjelmat

**Tarkoitus.** Aliohjelmat ovat ohjelman osia, jotka suorittavat tietyn tehtävän. Aliohjelmat helpottavat ohjelman rakentamista pienistä palasista, sekä ohjelman ylläpitoa. Aliohjelma voi ottaa vastaan tietoa parametreina, ja se voi palauttaa arvon.

**Parametrit ja paluuarvo.** Tämä aliohjelma laskee kahden luvun summan ja palauttaa sen. Aliohjelma ottaa vastaan kaksi parametria ja palauttaa näiden parametrien arvojen summan.

```csharp
public static int LaskeSumma(int a, int b)
{
    return a + b;
}
```

**Kutsuminen.** Aliohjelmaa kutsutaan kirjoittamalla aliohjelman nimi ja sulkujen sisään _argumentit_, joita haluamme antaa aliohjelmalle.

```csharp
int summa = LaskeSumma(3, 5);
Console.WriteLine(summa); // Tulostaa 8
```

Aliohjelma voi myös olla ilman paluuarvoa. Tällöin se määritetään `void`-tyyppiseksi.

```csharp
public static void Tervehdys()
{
    Console.WriteLine("Moikka!");
}
```

## Muuttujien näkyvyys

Muuttuja _näkyy_ vain siinä lohkossa, jossa se on määritelty. Lohko voi olla esimerkiksi aliohjelma, luokka tai silmukka.

```csharp
public static void Main()
{
    int a = 5; // a näkyy vain Main-aliohjelmassa
    Console.WriteLine(a); // Tulostaa 5
}

public static void Tervehdys()
{
    Console.WriteLine(a); // Ei toimi, koska a ei näy tässä aliohjelmassa
}
```

Myöskään aliohjelmien parametrimuuttujat eivät näy kyseisen aliohjelman ulkopuolella.

```csharp
public static void Main()
{
    int luku = 5;
    Tervehdys(luku); // luku-muuttujan arvo välitetään aliohjelmalle
}

public static void Tervehdys(int a)
{
    Console.WriteLine(a); // Tulostaa 5
}

public static void ToinenAliohjelma()
{
    Console.WriteLine(a); // Ei toimi, koska a ei näy tässä aliohjelmassa
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

**Vertailuoperaattorit.** Ehtolauseissa käytetään vertailuoperaattoreita (tai _loogisia operaattoreita_), jotka vertailevat kahta arvoa ja palauttavat totuusarvon.

**switch-case**-rakenteella voidaan vertailla yhtä muuttujan arvoa useaan eri arvoon.

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

1.  Merkkijonojen pilkkominen
    a. String.Split
1.  Järjestämisalgoritmi
    a. Valmiit järjestysalgoritmit
1.  Rekursio
1.  Dynaamiset tietorakenteet

## Debuggaus

## Oliotietotyypit

3. Kommentointi ja dokumentointi
4. Algoritmit
   a. Algoritminen ajattelu
   b. Tarkentaminen
   c. Yleistäminen
   d. Algoritmin kirjoittaminen ja suunnittelu
5. Kirjastot
6. Aliohjelmat
   a. Kutsuminen
   b. Kirjoittaminen
   c. Aliohjelmat, metodit, funktiot
7. Muuttujat
   a. Muuttujan määrittely
   b. C#:n alkeistietotyypit
   c. Nimeäminen
   d. Arvon asettaminen muuttujaan
   e. Näkyvyys
   f. Vakiot
   g. Aritmeettiset lausekkeet
8. Oliotietotyypit
   a. Mitä oliot ovat
   b. Luominen
   c. Oliotietotyypit vs alkeistietotyypit
   d. Metodin kutsuminen
   e. Olion tuhoaminen, roskienkeruu
   f. Olioluokkien dokumentaatio ?
9. Aliohjelman paluuarvo
10. Visual Studion tehokas käyttö
    a. Visual Studion asentaminen ja käynnistäminen
    b. Jypeli-kirjaston tuominen omaan projektiin, Jypeli-projektimallin käyttäminen
    c. Debuggaus
    d. Syntaksivirheiden etsintä
    e. Koodin täydennystyökalut ja koodimallit
11. Merkkijonot
    a. String, metodeja
    b. Muokattavat merkkijonot
12. Ehtolauseet
    a. if-rakenne, if-else
    b. Vertailuoperaattorit
    c. Loogiset operaatiot
    d. else-if
    e. switch-case
13. Taulukot
    a. Luominen
    b. Alkioon viittaaminen
    c. Moniulotteiset taulukot
14. Toistorakenteet
    a. while
    b. do-while
    c. for
    d. for-each
    e. Sisäkkäiset silmukat
    f. break- ja continue -lauseet
    g. "ikuinen silmukka"
15. Merkkijonojen pilkkominen
    a. String.Split
16. Järjestämisalgoritmi
    a. Valmiit järjestysalgoritmit
17. Rekursio
18. Dynaamiset tietorakenteet
19. Poikkeukset
20. Lukujen esitys tietokoneessa
21. ASCII-koodi

```

```
