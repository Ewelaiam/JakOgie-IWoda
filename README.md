# Jak Ogień i Woda

Gra stanowi modyfikację popularnej gry “Ogień i woda”. Gracz ma na celu zebranie jak największej liczby monet, omijając przeszkody z ognia, wody i skał.

## Silnik
Gra została zbudowana na silniku Unity (2022.3.22f1) Intel. Jest to trójwymiarowa gra z graficznymi elementami zbudowanymi za pomocą Blendera.


## Ekrany

### Ekran startowy

<img width="648" alt="Screenshot 2024-05-30 at 19 32 29" src="https://github.com/Ewelaiam/Jak-Ogien-i-Woda/assets/61901509/37c42615-a512-4d3f-9787-0966bea297cc">

Jest to pierwszy ekran, który pojawia się po uruchomieniu gry. Umożliwia on rozpoczęcie nowej rozgrywki lub wyjście z gry.

## Gra
### Opis
Gra "Jak ogień i woda" to modyfikacja popularnej gry "Ogień i woda". Celem gracza, który porusza się kulą wody w perspektywie trzeciej osoby, jest zebranie jak największej liczby monet, jednocześnie omijając przeszkody takie jak ogień, woda i skały. Gra rozpoczyna się na ekranie startowym, z którego można rozpocząć nową rozgrywkę lub wyjść z gry.
Podczas gry w lewym górnym rogu ekranu znajduje się licznik zebranych monet. Po zebraniu pięciu monet gracz wygrywa, a w przypadku kontaktu z przeszkodą gra kończy się i pojawia się ekran końca gry z opcją restartu. Przeszkody, takie jak kamienie, jeziora i ogniska, zostały utworzone za pomocą programu Blender. Monety są rozmieszczone w miejscach wymagających ryzyka, co motywuje gracza do podejmowania wyzwań.
Poruszanie się w grze odbywa się za pomocą klawiszy strzałek do przodu i na boki oraz klawisza spacji do skakania. Gra posiada system nieskończonego labiryntu, który dynamicznie dodaje nowe sekcje drogi, co utrzymuje iluzję nieskończonego biegu. 

### Wygląd
Gra jest zrealizowana w perspektywie trzeciej osoby. Postacią, którą porusza się gracz, jest kula wody. W lewym górnym rogu ekranu jest widoczny licznik zebranych monet.

<img width="600" alt="Screenshot 2024-06-03 at 22 22 51" src="https://github.com/Ewelaiam/Jak-Ogien-i-Woda/assets/61901509/a674bc1a-ffdf-4b72-b82e-c94eb15dc2f5">

Po zebraniu oczekiwanych pięciu monet pojawia się komunikat o wygranej:

<img width="597" alt="Screenshot 2024-06-03 at 22 23 06" src="https://github.com/Ewelaiam/Jak-Ogien-i-Woda/assets/61901509/88994c86-f69c-4f96-9f89-7e7bc1d022e1">

W momencie kontaktu z przeszkodą gracz przegrywa i pojawia się ekran:

<img width="598" alt="Screenshot 2024-06-03 at 22 23 22" src="https://github.com/Ewelaiam/Jak-Ogien-i-Woda/assets/61901509/b8a5e281-187c-4826-a0b5-f5a5c5d9ed7f">

Po kliknięciu opcji “Restart game” gracz powraca na początek toru, a jego wynik zostaje wyzerowany.


## Przeszkody:

Przeszkody w grze zostały utworzone za pomocą programu Blender.

### Kamień
<img width="338" alt="Screenshot 2024-05-30 at 19 22 43" src="https://github.com/Ewelaiam/Jak-Ogien-i-Woda/assets/61901509/778848c9-aec8-485c-afce-57a8fecb93a4">

Po zetknięciu postaci z obiektem, następuje koniec gry.


### Jezioro
<img width="339" alt="Screenshot 2024-05-30 at 19 25 10" src="https://github.com/Ewelaiam/Jak-Ogien-i-Woda/assets/61901509/607768b5-7e97-4c21-895e-2bcfc2989f40">

Wejście postaci do jeziora skutkuje jej zatonięciem i gra ulega końcowi.

### Ognisko
<img width="251" alt="Screenshot 2024-05-30 at 19 26 10" src="https://github.com/Ewelaiam/Jak-Ogien-i-Woda/assets/61901509/39ee6f38-f657-4c47-8468-53266cc4b068">


Po wejściu postaci do ogniska, spala się, co kończy grę.

## Punkty

<img width="402" alt="Screenshot 2024-05-30 at 19 38 16" src="https://github.com/Ewelaiam/Jak-Ogien-i-Woda/assets/61901509/7fe152d0-592a-46a1-a034-0a2174a9295d">

Punkty, które poprawiają wynik gracza, można zwiększać poprzez zbieranie monet pojawiających się na planszy. W większości przypadków pojawiają się w miejscach, gdzie łatwo można wpaść w przeszkodę. Są one nagrodą za podjęte ryzyko. 

## Poruszanie się
W grze można poruszać się do przodu (strzałka w górę) i na boki (strzałka w bok). Po podniesieniu klawisza postać zatrzymuje się. Dodatkowo postać może skakać (spacja). Nie ma możliwości ruchu do tyłu.

## Nieskończony labirynt
Nieskończony labirynt działa poprzez dynamiczne dodawanie nowych sekcji drogi, gdy gracz zbliża się do końca aktualnej sekcji. System ten składa się z dwóch głównych komponentów: RoadManager oraz SectionTrigger.
RoadManager: Ten skrypt zarządza wszystkimi sekcjami drogi w grze. Na początku, inicjalizuje początkową sekcję drogi. Gdy ich liczba przekroczy określoną wartość (w tym przypadku 3), najstarsza sekcja jest usuwana, co zapobiega nadmiernemu zużyciu pamięci i zasobów. RoadManager przechowuje aktualne sekcje w liście i dodaje nowe sekcje na końcu ostatniej istniejącej, tworząc efekt nieskończoności.
SectionTrigger: Ten skrypt jest przypisany do niewidocznego obiektu kolidującego, umieszczonego na początku każdej sekcji. Gdy gracz wejdzie w obszar kolizji tego obiektu, SectionTrigger informuje RoadManager, aby dodał nową sekcję drogi. Dzięki temu labirynt dynamicznie się rozszerza, utrzymując iluzję nieskończoności, podczas gdy gracz przemieszcza się do przodu.
Cały mechanizm zapewnia płynne przejścia między kolejnymi sekcjami, bez konieczności przesuwania gracza automatycznie, co daje graczowi pełną kontrolę nad ruchem postaci w labiryncie.




