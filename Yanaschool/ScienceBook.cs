using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class ScienceBook: Book
	{
		public string theme { get; set;  }
		public int age { get; set; }
		public ScienceBook(string theme, int age, string name, string author, string isbn): base(name, author, isbn)
		{
			this.theme = theme;
			this.age = age;
		}

	}
}
