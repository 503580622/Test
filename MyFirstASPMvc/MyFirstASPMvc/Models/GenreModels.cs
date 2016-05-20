using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstASPMvc.Models
{
	public class Genre
	{
		public virtual int GenreId { get; set; }
		public virtual string name { get; set; }
		public virtual string Description { get; set; }
		public virtual List<Album> Albums { get; set; }
	}
}
