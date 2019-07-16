/*
Moje proste Ui postarałem się troszkę scentralicować żeby jak największa ilość informacji mogła być przechwytywana i zapisywana w jak najmniejszej ilości miejs

dlatego wszystkie stałe elementy takie jak Lista skilli i innne listy które powinny być mieć takie same elementy dla wszystkich kart
przechowuje w Scriptable Objecie "PageObj" do którego inspektora dodałem pare przycisków żeby Pan Designer mógł szybko dodać jakiś skill bez grzebania w kodzie

Reszte informacji które każda karta powinna mieć indywidualnie ustalane wrzuciłem do adekwatnie i konsekwentnie nazwanego SO Infoso
Z tego obiektu można zmienić karcie postaci poziomy skilli i traitów i statów, poziom bohatera. Tak żeby Pan programista nie musiał się szperać po całym Juaju i miał wszystko pod ręką

Zmiany w poziomach updatują się przy każdej zmianie
A te poważniejsze czyli w PageObj trzeba potwierdzić przyciskiem "Update card" w Skrypcie "Page" na scenie dodanym do rodzica całego ui "Rpg ui"

Dziękuję za uwagę :>

PS: Z racji że to dopiero prototym updatowanie karty nie będzie działało jeśli UI będzie prefabem więc trzeba go zunpackować



 */