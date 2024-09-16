using Microsoft.EntityFrameworkCore;
using ProjektTablica.Data;

namespace ProjektTablica.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjektTablicaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProjektTablicaContext>>()))
            {
                if (context.Ogloszenie.Any())
                {
                    return;   
                }
                context.Ogloszenie.AddRange(
                    new Ogloszenie
                    {
                        Tytul = "Sprzedam rower górski – stan idealny",
                        Tresc = "Mam do sprzedania rower górski marki Kross, model 2022. Stan idealny, używany sporadycznie. Dodatkowo dodaję kask i uchwyt na bidon. Cena: 1 200 zł. Kontakt: 123-456-789.",
                        Data = DateTime.Parse("2024-09-12 12:20")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Zatrudnię opiekunkę do dziecka – Warszawa",
                        Tresc = "Szukam doświadczonej opiekunki do 2-letniego dziecka. Praca od poniedziałku do piątku, w godzinach 8:00-16:00. Oferuję atrakcyjne wynagrodzenie i miłą atmosferę. Kontakt: opiekawawa@gmail.com.",
                        Data = DateTime.Parse("2024-09-13 13:30")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Korepetycje z matematyki – poziom szkoły średniej\r\n\r\n",
                        Tresc = "Nauczyciel z wieloletnim doświadczeniem oferuje korepetycje z matematyki dla uczniów szkół średnich. Przygotowanie do matury, pomoc w bieżących zadaniach. Cena: 50 zł/h. Kontakt: 789-123-456",
                        Data = DateTime.Parse("2024-09-14 14:40")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Do wynajęcia mieszkanie 2-pokojowe – Kraków",
                        Tresc = "Wynajmę komfortowe mieszkanie 2-pokojowe w centrum Krakowa, blisko komunikacji miejskiej. Powierzchnia 45 m², w pełni umeblowane. Cena: 2 500 zł/miesiąc. Tel.: 555-666-777.",
                        Data = DateTime.Parse("2024-09-15 15:20")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Sprzedam stół z krzesłami – zestaw drewniany",
                        Tresc = "Oferuję solidny, drewniany stół z sześcioma krzesłami. Stan bardzo dobry, minimalne ślady użytkowania. Idealny do jadalni. Cena: 900 zł. Kontakt: meble2023@wp.pl.",
                        Data = DateTime.Parse("2024-09-16 16:20")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Nauka języka angielskiego online – różne poziomy",
                        Tresc = "Lektor z wieloletnim doświadczeniem oferuje lekcje angielskiego online. Zajęcia dostosowane do potrzeb ucznia, od poziomu podstawowego po zaawansowany. Cena: 60 zł/h. Kontakt: 888-777-666.",
                        Data = DateTime.Parse("2024-09-11 11:10")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Poszukiwany stolarz do montażu mebli",
                        Tresc = "Szukam stolarza do wykonania i montażu mebli kuchennych na wymiar. Praca od zaraz, atrakcyjne wynagrodzenie. Kontakt: stolarz.krakow@onet.pl.",
                        Data = DateTime.Parse("2024-09-10 10:00")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Wynajmę garaż – Poznań, os. Piastowskie",
                        Tresc = "Do wynajęcia garaż murowany, z dostępem do prądu, w okolicy osiedla Piastowskiego w Poznaniu. Cena: 300 zł/miesiąc. Kontakt: 987-654-321.",
                        Data = DateTime.Parse("2024-09-9 9:20")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Przyjmę książki do biblioteki społecznej",
                        Tresc = "Poszukuję książek w dobrym stanie do rozbudowy biblioteki społecznej. Jeśli masz niepotrzebne książki i chcesz je przekazać, skontaktuj się: biblioteka@community.pl.",
                        Data = DateTime.Parse("2024-09-8 8:20")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Zgubiono portfel – centrum Gdańska",
                        Tresc = "W dniu 15 września zgubiłem czarny portfel w centrum Gdańska. Znajdowały się w nim dokumenty na nazwisko Kowalski. Dla znalazcy nagroda! Tel.: 666-555-444.",
                        Data = DateTime.Parse("2024-09-7 7:20")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Sprzedam samochód Opel Astra – 2015",
                        Tresc = "Sprzedam Opla Astrę, rocznik 2015, przebieg 120 000 km, diesel, w bardzo dobrym stanie. Regularnie serwisowany, bezwypadkowy. Cena: 29 000 zł. Kontakt: autoastrasprzedam@wp.pl.",
                        Data = DateTime.Parse("2024-09-16 23:50")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Szukam współlokatora – Wrocław, blisko centrum",
                        Tresc = "Poszukuję współlokatora do wynajmowanego mieszkania. Mieszkanie 3-pokojowe, pełne wyposażenie, 10 minut od centrum. Cena: 1 000 zł + opłaty. Tel.: 444-333-222.",
                        Data = DateTime.Parse("2024-09-16 6:20")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Oferuję usługi sprzątające – Katowice",
                        Tresc = "Doświadczona pani sprzątająca oferuje swoje usługi w domach i biurach. Mycie okien, odkurzanie, sprzątanie po remoncie. Ceny ustalane indywidualnie. Tel.: 321-654-987.",
                        Data = DateTime.Parse("2024-09-13 20:20")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Sprzedam używany laptop Lenovo",
                        Tresc = "Na sprzedaż laptop Lenovo, model IdeaPad 320, używany, ale w dobrym stanie. 8 GB RAM, 256 GB SSD, Windows 10. Cena: 1 000 zł. Kontakt: lenovo@tablica.pl.\"",
                        Data = DateTime.Parse("2024-09-6 23:55")
                    },
                    new Ogloszenie
                    {
                        Tytul = "Kwiaty na zamówienie – bukiety na każdą okazję",
                        Tresc = "Florystka z wieloletnim doświadczeniem oferuje bukiety na każdą okazję: śluby, urodziny, rocznice. Indywidualne zamówienia, dowóz na terenie miasta. Tel.: 123-789-456.",
                        Data = DateTime.Parse("2024-09-6 11:20")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
