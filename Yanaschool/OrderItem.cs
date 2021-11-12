using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class OrderItem
	{
		public Book book { get; set; }
		public int amount { get; set; }
		public OrderItem(Book book, int amount)
		{
			this.book = book;
			this.amount = amount;
		}
	}
}
