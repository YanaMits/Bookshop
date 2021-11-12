using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class Book
	{
		public string name { get; set; }
		public string author { get; set; }
		public string isbn { get; set; }

		public Book(string name, string author, string isbn)
		{
			this.name = name;
			this.author = author;
			this.isbn = isbn;
		}
	}

	
}
