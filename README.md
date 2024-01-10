# Ohjelmointi 1 (2023 kevät), luennolla käsitellyt esimerkit

Tämä tietovarasto sisältää luennoilla tehdyt esimerkkiohjelmien koodit. Esimerkkejä on saatettu täydentää luennon jälkeen esimerkiksi dokumentaatioiden osalta.

## Kuinka aloitan

Avaa komentorivi, kuten Git Bash, Pääte tai vastaava. Tee tietokoneellesi uusi kansio, johon haluat tämän tietovaraston ladata. Käytä kansion luomiseen `mkdir`-komentoa. Siirry sitten tuohon kansioon käyttäen `cd`-komentoja.

Anna sitten komento

```
git clone https://gitlab.jyu.fi/tie/ohj1/2023k/esimerkit.git .
```

## Uusien esimerkkien lataaminen

Opintojakson edetessä opettaja lähettää lisää esimerkkejä tähän varastoon. Saat uudet esimerkit itsellesi antamalla esimerkkikansion juuressa komennon

```
git pull
```

Mikäli olet itse tehnyt muutoksia esimerkkikoodeihin, ja opettaja on muokannut samoja tiedostoja, on mahdollista, että Git-ympäristö tuottaa konfliktin. Jos haluat ylikirjoittaa omat muutoksesi opettajan tekemillä muutoksilla (ts. sinun tekemäsi muutokset tuhotaan) anna seuraavat kaksi komentoa.

```
git fetch --all
git reset --hard origin/master
```

**Varoitus**: Näiden komentojen seurauksena kaikki tähän varastoon tekemäsi muutokset tuhotaan. Mikäli olet tehnyt muutoksia, ota tiedostoista varmuuskopio.

## Luentojen taltioinnit

Luentotaltiointeja pääset seuraamaan [kurssin Youtube-kanavalla](https://www.youtube.com/playlist?list=PLHD9Pwp62utlc3jDn932DiFnA61qOFN3Q).
