using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class ClassicBook: Book
	{
		public string genre{ get; set; }

		public ClassicBook(string genre, string name, string author, string isbn): base(name, author, isbn)
		{
			this.genre = genre;
		}

	}
}
