using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmojiCharades.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();
            // See if there are any questions
            if (context.Questions.Any())
            {
                return;
            }

            // No Questions lets make some
            var questions = new Questions[]
            {
                new Questions(){Question = "Backstreet Boys",Tags = "band;", NSFW = false},
                new Questions(){Question = "The Women's Room",Tags = "book;", NSFW = false},
                new Questions(){Question = "Christian Bale",Tags = "actor;", NSFW = false},
                new Questions(){Question = "V for Vendetta",Tags = "movie;", NSFW = false},
                new Questions(){Question = "Iron Maiden – The Number Of The Beast",Tags = "song;", NSFW = false},
                new Questions(){Question = "The Name of the Rose",Tags = "book;", NSFW = false},
                new Questions(){Question = "How to Win Friends and Influence People",Tags = "book;", NSFW = false},
                new Questions(){Question = "Desperate Housewives",Tags = "tvshow;", NSFW = false},
                new Questions(){Question = "Babe Didrikson Zaharias",Tags = "athlete;", NSFW = false},
                new Questions(){Question = "Mark Wahlberg",Tags = "actor;", NSFW = false},
                new Questions(){Question = "WALL·E",Tags = "movie;", NSFW = false},
                new Questions(){Question = "John Lennon",Tags = "singer;", NSFW = false},
                new Questions(){Question = "The Seven Habits of Highly Effective People",Tags = "book", NSFW = false},
                new Questions(){Question = "Matt Damon",Tags = "actor;", NSFW = false},
                new Questions(){Question = "Sin City",Tags = "movie;", NSFW = false},
                new Questions(){Question = "Mistresses",Tags = "tvshow;", NSFW = false},
                new Questions(){Question = "The Girl With the Dragon Tatoo",Tags = "book;", NSFW = false},
                new Questions(){Question = "Dr. Dre – Nuthin’ But A ‘G’ Thang",Tags = "song;", NSFW = true},
                new Questions(){Question = "David Bowie – Sound And Vision",Tags = "song;", NSFW = false},
                new Questions(){Question = "War and Peace",Tags = "book;", NSFW = false},
                new Questions(){Question = "The Deer Hunter",Tags = "movie;", NSFW = false},
                new Questions(){Question = "Torchwood",Tags = "tvshow;", NSFW = false},
                new Questions(){Question = "Follow Your Heart",Tags = "book;", NSFW = false},
                new Questions(){Question = "Enter Sandman – Metallica",Tags = "song;", NSFW = false},
                new Questions(){Question = "Harry Potter and the Deathly Hallows",Tags = "book;", NSFW = false},
                new Questions(){Question = "Jennifer Aniston",Tags = "actor", NSFW = false},
            };

            context.Questions.AddRange(questions);
            context.SaveChanges();

        }
    }
}
