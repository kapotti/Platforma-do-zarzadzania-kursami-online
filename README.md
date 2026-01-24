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

### 4. Struktura danych

1.  **Category (Kategoria):** Służy do grupowania kursów. Relacja jeden-do-wielu (1:N) z kursami.
2.  **Course (Kurs):** Główna encja systemu zawierająca tytuł, opis, cenę oraz klucze obce.
3.  **Lesson (Lekcja):** Szczegółowe materiały dydaktyczne (treść, URL do wideo) przypisane do konkretnego kursu (1:N).
4.  **Użytkownicy (IdentityUser):** System ról i zabezpieczeń dostępu.

### 5. Instrukcja uruchomienia
1. Otwórz projekt w Visual Studio 2022.
2. W **Package Manager Console** wykonaj komendę: `Update-Database`.
3. Uruchom aplikację (F5).
4. **Dane testowe:** : zarejestruj się losowymi danymi, a nastepnie zaloguj
