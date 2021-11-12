using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class PrivateCustomer: Customer
	{
		public string firstName { get; set; }
		public string lastName { get; set; }

		public PrivateCustomer(string firstName, string lastName, int customerID, string telephon) : base(customerID, telephon)

		{
			this.firstName = firstName;
			this.lastName = lastName;
		}
	}
}
