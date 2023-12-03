using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assignment5.Data;
using System;
using System.Linq;

namespace Assignment5.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Assignment5Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<Assignment5Context>>()))
        {
            // Look for any Songs.
            if (context.Song.Any())
            {
                return;   // DB has been seeded
            }
            context.Song.AddRange(
                new Song
                {
                    Title = "BFG Division",
                    ReleaseDate = DateTime.Parse("2016-5-16"),
                    Artist = "Mick Gordon",
                    Genre = "Metal",
                    Price = 10.00M
                },
                new Song
                {
                    Title = "Best of You",
                    ReleaseDate = DateTime.Parse("2005-6-14"),
                    Artist = "Foo Fighters",
                    Genre = "Rock",
                    Price = 12.05M
                },
                new Song
                {
                    Title = "Don't Stop Believin'",
                    ReleaseDate = DateTime.Parse("1981-10-6"),
                    Artist = "Journey",
                    Genre = "Rock",
                    Price = 11.49M
                },
                new Song
                {
                    Title = "Runaway",
                    ReleaseDate = DateTime.Parse("2010-10-4"),
                    Artist = "Kanye West",
                    Genre = "Hip-Hop/Rap",
                    Price = 11.16M
                },
                new Song
                {
                    Title = "Mannish Boy",
                    ReleaseDate = DateTime.Parse("1977-1-1"),
                    Artist = "Muddy Waters",
                    Genre = "Blues",
                    Price = 8.98M
                },
                new Song
                {
                    Title = "Cross Road Blues",
                    ReleaseDate = DateTime.Parse("1937-1-1"),
                    Artist = "Robert Johnson",
                    Genre = "Blues",
                    Price = 7.51M
                },
                new Song
                {
                    Title = "The Thrill Is Gone",
                    ReleaseDate = DateTime.Parse("1969-12-5"),
                    Artist = "B.B. King",
                    Genre = "Blues",
                    Price = 6.99M
                },
                new Song
                {
                    Title = "All My Ex's Live In Texas",
                    ReleaseDate = DateTime.Parse("1987-1-1"),
                    Artist = "George Strait",
                    Genre = "Country",
                    Price = 9.36M
                },
                new Song
                {
                    Title = "9 to 5",
                    ReleaseDate = DateTime.Parse("1980-1-1"),
                    Artist = "Dolly Parton",
                    Genre = "Country",
                    Price = 9.05M
                },
                new Song
                {
                    Title = "Ring of Fire",
                    ReleaseDate = DateTime.Parse("1963-8-6"),
                    Artist = "Johnny Cash",
                    Genre = "Country",
                    Price = 14.57M
                },
                new Song
                {
                    Title = "Enjoy the Silence",
                    ReleaseDate = DateTime.Parse("1990-2-5"),
                    Artist = "Depeche Mode",
                    Genre = "Electronic/Dance",
                    Price = 8.81M
                },
                new Song
                {
                    Title = "West End Girls",
                    ReleaseDate = DateTime.Parse("1985-10-28"),
                    Artist = "Pet Shop Boys",
                    Genre = "Electronic/Dance",
                    Price = 13.76M
                },
                new Song
                {
                    Title = "Around The World",
                    ReleaseDate = DateTime.Parse("1997-4-1"),
                    Artist = "Daft Punk",
                    Genre = "Electronic/Dance",
                    Price = 13.91M
                },
                new Song
                {
                    Title = "Where Did You Sleep Last Night",
                    ReleaseDate = DateTime.Parse("1959-5-7"),
                    Artist = "Lead Belly",
                    Genre = "Folk",
                    Price = 12.24M
                },
                new Song
                {
                    Title = "Like a Rolling Stone",
                    ReleaseDate = DateTime.Parse("1965-8-3"),
                    Artist = "Bob Dylan",
                    Genre = "Folk",
                    Price = 10.91M
                },
                new Song
                {
                    Title = "Knockin' On Heaven's Door",
                    ReleaseDate = DateTime.Parse("1973-7-13"),
                    Artist = "Bob Dylan",
                    Genre = "Folk",
                    Price = 11.50M
                },
                new Song
                {
                    Title = "Hypnotize",
                    ReleaseDate = DateTime.Parse("1997-3-4"),
                    Artist = "The Notorious B.I.G.",
                    Genre = "Hip-Hop/Rap",
                    Price = 12.99M
                },
                new Song
                {
                    Title = "It Was a Good Day",
                    ReleaseDate = DateTime.Parse("1992-2-23"),
                    Artist = "Ice Cube",
                    Genre = "Hip-Hop/Rap",
                    Price = 7.58M
                },
                new Song
                {
                    Title = "Without Me",
                    ReleaseDate = DateTime.Parse("2002-10-15"),
                    Artist = "Eminem",
                    Genre = "Hip-Hop/Rap",
                    Price = 11.09M
                },
                new Song
                {
                    Title = "Caravan",
                    ReleaseDate = DateTime.Parse("1936-1-1"),
                    Artist = "Duke Ellington",
                    Genre = "Jazz",
                    Price = 10.00M
                },
                new Song
                {
                    Title = "My Funny Valentine",
                    ReleaseDate = DateTime.Parse("1965-2-23"),
                    Artist = "Miles Davis",
                    Genre = "Jazz",
                    Price = 9.70M
                },
                new Song
                {
                    Title = "What a Wonderful World",
                    ReleaseDate = DateTime.Parse("1967-9-1"),
                    Artist = "Louis Armstrong",
                    Genre = "Jazz",
                    Price = 8.88M
                },
                new Song
                {
                    Title = "1999",
                    ReleaseDate = DateTime.Parse("1982-10-27"),
                    Artist = "Prince",
                    Genre = "Pop",
                    Price = 19.99M
                },
                new Song
                {
                    Title = "Into the Groove",
                    ReleaseDate = DateTime.Parse("1985-7-15"),
                    Artist = "Madonna",
                    Genre = "Pop",
                    Price = 13.73M
                },
                new Song
                {
                    Title = "Thriller",
                    ReleaseDate = DateTime.Parse("1982-11-29"),
                    Artist = "Michael Jackson",
                    Genre = "Pop",
                    Price = 10.99M
                },
                new Song
                {
                    Title = "Ain't No Mountain High Enough",
                    ReleaseDate = DateTime.Parse("1967-4-20"),
                    Artist = "Marvin Gaye",
                    Genre = "R&B/Soul",
                    Price = 6.95M
                },
                new Song
                {
                    Title = "Superstition",
                    ReleaseDate = DateTime.Parse("1972-10-24"),
                    Artist = "Stevie Wonder",
                    Genre = "R&B/Soul",
                    Price = 13.64M
                },
                new Song
                {
                    Title = "Isn't She Lovely",
                    ReleaseDate = DateTime.Parse("1976-1-1"),
                    Artist = "Stevie Wonder",
                    Genre = "R&B/Soul",
                    Price = 10.18M
                },
                new Song
                {
                    Title = "I Can See Clearly Now",
                    ReleaseDate = DateTime.Parse("1972-6-23"),
                    Artist = "Johnny Nash",
                    Genre = "Reggae",
                    Price = 8.99M
                },
                new Song
                {
                    Title = "Three Little Birds",
                    ReleaseDate = DateTime.Parse("1980-9-12"),
                    Artist = "Bob Marley",
                    Genre = "Reggae",
                    Price = 6.89M
                },
                new Song
                {
                    Title = "Jamming",
                    ReleaseDate = DateTime.Parse("1977-6-3"),
                    Artist = "Bob Marley",
                    Genre = "Reggae",
                    Price = 8.34M
                },
                new Song
                {
                    Title = "Can't Help Falling in Love",
                    ReleaseDate = DateTime.Parse("1961-3-23"),
                    Artist = "Elvis Presley",
                    Genre = "Rock",
                    Price = 11.79M
                },
                new Song
                {
                    Title = "Johnny B. Goode",
                    ReleaseDate = DateTime.Parse("1958-3-31"),
                    Artist = "Chuck Berry",
                    Genre = "Rock",
                    Price = 10.05M
                },
                new Song
                {
                    Title = "Here Comes the Sun",
                    ReleaseDate = DateTime.Parse("1969-9-26"),
                    Artist = "The Beatles",
                    Genre = "Rock",
                    Price = 12.99M
                }
            );
            context.SaveChanges();
        }
    }
}
