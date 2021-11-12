using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class Customer
	{
		public int customerID { get; set; }
		public string telephon { get; set; }
	
		public List<Order> orders { get; private set; }

		public Customer(int customerID, string telephon)
		{
			this.customerID = customerID;
			this.telephon = telephon;

			this.orders = new List<Order>();
		}
	}
}
