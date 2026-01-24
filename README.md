Zarządzanie Kursami Online

Projekt zaliczeniowy wykonany w technologii ASP.NET Core MVC (.NET 8).

### 1. Wymagania techniczne
* **Framework:** ASP.NET Core MVC
* **Baza danych:** SQL Server (Entity Framework Core)
* **Uwierzytelnianie:** Microsoft Identity

### 2. Struktura Danych
Aplikacja posiada 4 powiązane encje:
* **Category** (Kategoria) - Relacja 1:N z Kursami.
* **Course** (Kurs) - Główna encja systemu.
* **Lesson** (Lekcja) - Relacja 1:N z Kursami (jeden kurs ma wiele lekcji).
* **IdentityUser** (Użytkownik) - System kont i profili.

### 3. Funkcjonalności
* **CRUD API** Dostępne pod adresem `/api/CoursesApi`.
* **Formularze z walidacją:** System posiada 3 autorskie formularze (Kategorie, Kursy, Lekcje) z pełną walidacją po stronie serwera i klienta.
* **Autoryzacja**

### 4. Przegląd Techniczny Plików

### 4.1. Modele Danych (`/Models`)
* **`Course.cs`**: Definiuje właściwości kursu oraz relacje klucza obcego do Kategorii. Zawiera atrybuty walidacyjne `[Required]` i `[Range]`.
* **`Category.cs`**: Model kategorii umożliwiający logiczne grupowanie zasobów.
* **`Lesson.cs`**: Reprezentuje pojedynczą jednostkę edukacyjną z polem `Content` oraz relacją do klasy `Course`.

### 4.2. Kontrolery (`/Controllers`)
* **`CoursesController.cs`**: Obsługuje pełną logikę CRUD dla kursów.
* **`LessonsController.cs`**: Zarządza lekcjami i ich powiązaniem z kursami za pomocą listy rozwijanej (dropdown).
* **`CoursesApiController.cs`**: Realizacja wymagania 6d. Zwraca dane w uniwersalnym formacie JSON bez warstwy HTML.

### 4.3. Widoki (`/Views`)
* **`Index.cshtml`**: Widoki tabelaryczne ze spolszczonymi etykietami.
* **`Create/Edit.cshtml`**: Formularze wykorzystujące **Tag Helpers** do automatycznej generacji kodu i obsługi walidacji.
* **`_Layout.cshtml`**: Główny szablon aplikacji z nawigacją i spójnym wyglądem (Bootstrap).

### 4.4. Tożsamość i Bezpieczeństwo (`/Areas/Identity`)
* Zawiera spolszczone widoki i logikę rejestracji (`Register.cshtml.cs`) oraz zarządzania profilem (`Manage/Index.cshtml.cs`)


### . Instrukcja uruchomienia
1. Otwórz projekt w Visual Studio 2022.
2. W **Package Manager Console** wykonaj komendę: `Update-Database`.
3. Uruchom aplikację (F5).
4. **Dane testowe:** : zarejestruj się losowymi danymi, a nastepnie zaloguj
