# Lab3 - Mateusz Śliwka
### Opis zadania
Zadanie domowe Lab3 z kursu C# Kredek polegało na rozbudowaniu realizowanej od pierwszego zadania domowego aplikacji - gry ŁapButle. W wersji trzeciej dodano połączenie z bazą danych. Obecnie baza danych wykorzystywana jest do prowadzenia zestawienia wyników. Po ukończeniu rozgrywki każdy może zapisać swój wynik do bazy danych pod zadanym pseudonimem. Oprócz tego można modyfikować zapisane rekordy (dla bezpieczeństwa można modyfikować tylko pseudonimy graczy) lub je usuwać. Nad rankingiem wyświetla się również historia rozgrywki w formie tabeli w której każdy wiersz to oddzielna akcja w grze. Największa trudność stworzyło zsynchronizowanie słuchacza zmiany zawartości tabeli z obsługą operacji UPDATE oraz DELETE w bazie danych. Zadane założenia projektowe zostały spełnione.