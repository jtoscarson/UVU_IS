using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MvcMusicStoreDbInitializer : DropCreateDatabaseAlways<MvcMusicStoreDb>
    {
        protected override void Seed(MvcMusicStoreDb context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Artists.Add(new Artist { Name = "Pink Floyd" });
            context.Artists.Add(new Artist { Name = "The Beatles" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
        }
    }
}