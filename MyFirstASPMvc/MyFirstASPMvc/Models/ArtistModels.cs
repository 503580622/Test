using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstASPMvc.Models
{
	public class Artist
	{
		public virtual int ArtistId { get; set; }
		public virtual string name { get; set; }
	}
}
