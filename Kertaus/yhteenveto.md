# Yhteenveto Ohjelmointi 1 -kurssin asioista

Tässä dokumentissa käydään läpi Ohjelmointi 1 -kurssin keskeiset asiat. Dokumentti on tarkoitettu kertaukseksi kurssin asioista ja apuvälineeksi kurssin jälkeiseen ohjelmointiin. Dokumentti ei ole täydellinen, eikä se sisällä kaikkea kurssilla käytyä asiaa.

## Lauseiden suorittaminen

Lauseet ovat ohjelman perusyksiköitä, jotka suoritetaan yksi kerrallaan. Lauseet voivat olla esimerkiksi muuttujan määrittelyjä, aliohjelmien kutsuja tai ehtolauseita.

Lause voi olla sellainen, joka näkyy ohjelman käyttäjälle, kuten tulostuslause. Lause voi myös muuttaa ohjelman tilaa, kuten muuttujan arvoa tai kutsua aliohjelmaa.

```csharp
Console.WriteLine("Hello, World!"); // Tulostaa näytölle tekstiä
int a = 3; // Muuttaa muuttujan a arvoa
a++; // Lisää muuttujan a arvoa yhdellä
```

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

Kääntäminen tarkoittaa ohjelmakoodin muuttamista konekielelle.
IDEssä (esim. Rider) kääntäminen tapahtuu klikkaamalla "Run" tai "Debug".

Kääntämisen jälkeen ohjelmaa voidaan ajaa IDEssä klikkaamalla "Run" tai "Debug" -nappia. Ohjelmaa voidaan ajaa myös komentoriviltä, esimerkiksi seuraavasti:

```bash
dotnet run
```

Kääntämisen yhteydessä ohjelmakoodi tarkistetaan virheiden varalta.
Jos koodissa on virheitä, kääntäminen ei onnistu eikä ohjelmaa voi ajaa. Virheet on korjattava ennen uutta kääntämistä.

Ohjelma on käännettävä aina koodin muuttamisen jälkeen, jotta muutokset tulevat voimaan.

## Koodin kommentointi ja dokumentointi

Koodiin voidaan lisätä kommentteja, jotka auttavat koodin ymmärtämisessä. Kommentit eivät vaikuta ohjelman toimintaan, vaan ovat ohjelmoijan apuvälineitä.

```csharp
// Kommentti yhdellä rivillä
/* Kommentti
usealla rivillä */
```

Dokumentointi tarkoittaa koodin selittämistä niin, että muutkin kuin koodin kirjoittaja ymmärtävät sen. Dokumentointi auttaa koodin ylläpitämisessä ja kehittämisessä.

Dokumentointiin käytetään esimerkiksi XML-kommentteja. Niiden sijainti on ennen dokumentoitavaa koodia, kuten aliohjelmaa tai luokkaa.

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

## Muuttujat

**Ohjelman tila määritellään muuttujiin.** Muuttujat ovat ohjelmassa käytettäviä arvoja, joiden arvoa ohjelmoija voi muuttaa ohjelman suorituksen aikana. Niinpä voidaan sanoa, että muuttuja on ohjelman tilassa oleva arvo, ja jos muuttujan arvoa muutetaan, muuttuu ohjelman tila.

**Muuttuja on määriteltävä (nimi, tyyppi) ennen käyttöä.** Muuttujan tyyppi määrittää, millaisia arvoja siihen voi tallentaa.

```csharp
int luku = 5; // luku-muuttujaan voi tallentaa kokonaislukuja
string nimi = "Maija"; // nimi-muuttujaan voi tallentaa merkkijonoja
bool onkoTosi = true; // onkoTosi-muuttujaan voi tallentaa totuusarvoja
```

**Sijoitus.** Muuttujan arvoa voidaan muuttaa sijoituslauseella. Sijoitus tapahtuu aina oikealta vasemmalle.

```csharp
int a = 5;
int b = 3;
int summa = a + b;
```

**Vakiot.** Vakio on luku-, merkkijono- tai totuusarvotyyppinen muuttuja, jonka arvo vakioidaan käännöksessä, eikä arvoa voi muuttaa ohjelman suorituksen aikana. Vakio määritellään `const`-avainsanalla. Vakion nimi kirjoitetaan suuraakkosilla (sanat erotellaan alaviivalla) tai vaihtoehtoisesti PascalCase-tyyliin.

```csharp
const int MONTAKO_VIHUA = 10; // all caps -tyyli
const string TervehdysSana = "Hei"; // PascalCase-tyyli
```

Huomaa, että oliotietotyypit (esim. `int[]`) ovat viitepohjaisia muuttujia, joten niitä ei voi määritellä `const`-avainsanalla.

**Näkyvyys.** Muuttuja _näkyy_ vain siinä lohkossa, jossa se on määritelty.

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
