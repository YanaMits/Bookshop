using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class Order
	{
		public int customerID { get; set; }
		public DateTime date { get; set; }
		public List<OrderItem> items { get; private set; }
		public Order( int customerID, DateTime date)
		{
			this.customerID = customerID;
			this.date = date;
			items = new List<OrderItem>();
		}
	}

}
