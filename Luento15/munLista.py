def muutaListaa(munLista):
    munLista[0] = 9


def muutaLukua(munLuku):
    munLuku = 5


lista = [1, 2, 3]
print(lista)
muutaListaa(lista)
# Lista on muuttunut, koska aliohjelmalle välitetään
# kutsussa lista-olion viite. Tällöin muutaListaa
# käsittelee tätä viitteenä saatua tietoa, ja muuttaa
# alkuperäisen listan sisältöä
print(lista)

luku = 3
print(luku)
muutaLukua(luku)
# Kokonaisluku ei muutu, koska aliohjelmalle välitetään
# kopio kokonaisluvusta, ei viitettä kuten listan
# tapauksessa
print(luku)
