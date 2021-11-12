using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class BuisnesCustomer: Customer
	{
		public string companyName { get; set; }
		public BuisnesCustomer(string companyName, int customerID, string telephon) : base(customerID, telephon)
		{
			this.companyName = companyName;
		}


		
	}
}
