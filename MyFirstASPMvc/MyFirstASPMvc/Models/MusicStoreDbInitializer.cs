using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyFirstASPMvc.Models
{
	public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MusicStoreDB>
	{
		protected override void Seed(MusicStoreDB context)
		{
			context.Artists.Add(new Artist { name = "Al Di Meola" });
			context.Genres.Add(new Genre { name = "Jazz" });
			context.Albums.Add(new Album
			{
				Artist = new Artist { name = "Rush" },
				Genre = new Genre { name = "Rock" },
				Price = 9.99m,
				Title = "Caravan",
				AlbumArtUrl = "http://www.baidu.com"
			});
			base.Seed(context);
		}
	}
}
