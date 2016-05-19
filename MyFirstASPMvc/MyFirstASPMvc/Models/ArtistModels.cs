using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstASPMvc.Models
{
	class Artist
	{
		public virtual int ArtistId { get; set; }
		public virtual string name { get; set; }
	}
}
