# RentACar

## --// **UPDATE 1.0.9.25.5.15 by Tasić** //--

### -- BUGOVI --
- (REŠENO) Bug gde se vozilo nije obrisalo prilikom brisanja
- (REŠENO) Memory leak prilikom otvaranja Info formi (VoziloInfo, RacunInfo)

### -- IZMENE I DODACI --
- (URAĐENO) .dll biblioteke prepakovane u jedan folder radi preglednosti build-a
- (URAĐENO) Ikonica programa dodata u build folder
- (URAĐENO) Uklonjene reference na Info forme u formama za listu vozila i računa

by Nikola Tasić, 15.05.2025. 15:26

## --// **UPDATE 1.0.8.25.5.15 by Tasić** //--

### -- BUGOVI --
- (REŠENO) Bug koji je menjao pogrešnu sliku na RačunInfo formi

### -- IZMENE I DODACI --
- (URAĐENO) Obrisani lokalni folderi sa slikama
- (URAĐENO) Dodat novi sistem učitavanja slika, od sad se slike učitavaju online iz Supabase storage bucket-a
- (URAĐENO) Izmenjen kod na svim formama gde se prikazuju slike kako bi bilo moguće povući ih iz storage bucket-a

by Nikola Tasić, 15.05.2025. 13:43

## --// **UPDATE 1.0.5.25.5.8 by Tasić** //--

### -- BUGOVI --
- (REŠENO) Dupliciranje prilikom searcha racuna - resenje: dodavanje search dugmeta
- (REŠENO) Korisnik koji je tek napravljen se ne ucitava dok se ne restartuje program
- (POZNAT BUG KOJI SE REŠAVA) Error sound effect prilikom pritiska dugmeta enter tokom prijavljivanja

### -- IZMENE I DODACI --
- (URAĐENO) Reorganizacija fajlova unutar projekta
- (URAĐENO) Search dugme na listi vozila i racuna
- (URAĐENO) Loading screen/povezivanje prilikom paljenja app i error ukoliko ne moze da se poveze na db
- (URAĐENO) Dodat loading screen prilikom učitavanja podataka nakon uspešnog logina
- (URAĐENO) Nakon svakog loading-a ostavljena sekunda "pauziranja" programa kako bi poruka mogla jasno da se pročita
- (URAĐENO) Dodatni parametri/filteri za search na obe liste
- (URAĐENO) Dodavanj "oko" ikonice na polje "stara lozinka" prilikom menjanja lozinke
- (URAĐENO) Dodati da se vozila i računi učitavaju tek kad se korisnik uloguje (uz formu za učitavanje)
- (URAĐENO) Dodata ikonica na .exe fajl programa
- (URAĐENO) Izbačeni svi nepotrebni NuGet paketi iz projekta

by Nikola Tasić, 08.05.2025. 15:55

## --// **UPDATE 1.0.4.25.5.6 by Tasić** //--

### -- IZMENE I DODACI --
- (URAĐENO) Rekonstrukcija rada i funkcionalnosti DatabaseHandler.cs klase
- (URAĐENO) Izmenjen način učitavanja podataka iz baze podataka
- (URAĐENO) SQLite sistemi su izbačeni iz programa
- (URAĐENO) Prelazak na Supabase postgreql za globalnu bazu podataka
- (URAĐENO) Izbačena opcija za backup databaze, ali je klasa ostavljena za buduću primenu

by Nikola Tasić, 06.05.2025. 17:48
