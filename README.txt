IRF Projekt 
Rajzolós játék

Kötelező tételek:
0. Adatbázis 2 táblával: Játékosok és választható színek
1. Beolvasás adatbázisból: felhasználónév és jelszó megadásával a játék elején a játékosok beolvasása, szín választásakor az RGB beolvasása
2. Írás CSV-be: a játékosok eredményeinek kiírása
3. Kifejtett setter ág: SavedPlayer.cs osztály a meglévő játékosokból és ebben a koruk alapján az AgeGroup/Korcsoport meghatározása

4. Graphics osztály használata: A program lényege, hogy két játékos rajzol egy rajzfelületre, a program pedig betölt véletlenszerűen három .bmp kép közül egyet, amin egy-egy vonal van, amit a játékosok nem látnak. Az első körben az kap pontot, aki úgy rajzol a felületre, hogy nem érinti ennek a .bmp képnek a vonalát. Ha egyik játékos sem érinti, akkor az első kör után ez a kép törlődik és az új vonalakkal játszanak tovább. A játékosok pontokat gyűjthetnek, és a játék addig tart, amíg valaki meg nem érinti az egyik vonalat: az első vonalat, a sajátját, vagy a másik játékosét. 


Plusz funkciók:
5. Adatbázisba írás: új játékosok is regisztrálhatnak a játék előtt
6. Diagram: Top 5 játékos megjelenítése tortadiagramon
