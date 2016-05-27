﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstASPMvc.Models
{
	public class Album
	{
		public virtual int AlbumId { get; set; }
		[DisplayName("Genre")]
		public virtual int GenreId { get; set; }
		public virtual int ArtistId { get; set; }
		public virtual string Title { get; set; }
		public virtual decimal Price { get; set; }
		public virtual string AlbumArtUrl { get; set; }
		public virtual Genre Genre { get; set; }
		public virtual Artist Artist  { get; set; }
	}
}
