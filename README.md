# Intro ASP.NET Core 8

### Prima Lezione:
* Impostazioni generali
* Creazione progetto vuoto: dotnet new web
* Trasformazione manuale in MVC: cartella Controllers
* Rudimenti sui Controller: HomeController, UsersController

### Seconda Lezione:
* Aggiunto views di base e semplice ciclo su stringhe
* Aggiunto modello UserModel referenziato nella view Index del controller Users

### Terza Lezione:
* Aggiunto le view di layout e utilizzato l'array associativo ViewData per la gestione del titolo delle pagine
* Integrato TagHelpers e Bootstrap (con CDN)

### Quarta Lezione:
* Aggiunta interfaccia IUsersService e implementazione UsersService
* Implementato dependency injection per IUsersService come Singleton in Program.cs
* Aggiunto view per dettagli utente
* Implementato cancellazione utente