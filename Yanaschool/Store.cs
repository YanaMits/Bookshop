using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanaschool
{
	class Store
	{
		private List<PrivateCustomer> privateCustomers = new List<PrivateCustomer>()
		{
			new PrivateCustomer("Jon","Don", 1, "+(46)567867892"),
			new PrivateCustomer("Joel","Ben", 2, "+(46)768767892"),
			new PrivateCustomer("Tom","Dizer", 3, "+(46)987867892"),
			new PrivateCustomer("Ola","Done", 4, "+(46)457867892"),
			new PrivateCustomer("Paula","Doller", 5, "+(46)717867892"),
			new PrivateCustomer("Peter","Sthal", 6, "+(46)937867892"),
		};

		private List<BuisnesCustomer> buisnesCustomers = new List<BuisnesCustomer>()
		{
			new BuisnesCustomer("Biltema", 11, "+(46)937867892"),
			new BuisnesCustomer("Sony", 12, "+(46)657867892"),
			new BuisnesCustomer("Tower", 13, "+(46)237867892"),
			new BuisnesCustomer("JimBim", 14, "+(46)717867892"),
		};

		private List<Book> books = new List<Book>()
		{
			new Book("Millions years ago","A.Duma","345gh87"),
			new Book("Hobbits", "J.R.Tolkien","375gh81"),
			new Book("Hurry Potter","J.Rowling","1245gh81"),
			new Book("Idiot","F.Dostoevsky","312gh87"),
			new Book("War and Peace","L.Tolstoy","435gh87"),
		};

		public void Visit()
		{
			Console.WriteLine("You are welcome to our store!");

			var nameFound = false;
			Customer currentCustomer = null;
			while (!nameFound)
			{
				Console.WriteLine("Please, write your name: ");
				var name = Console.ReadLine();

				currentCustomer = GetCustomer(name);
				if (currentCustomer == null)
				{
					Console.WriteLine("Name is not found");
				}
				else
				{
					nameFound = true;
				}
			}


			var done = false;
			while (done == false)
			{
				Console.WriteLine();
				Console.WriteLine("Please, choose one of the next options: Books, Orders, New order, Quit");
				var option = Console.ReadLine();
				switch (option)
				{
					case "Books":
						PrintBooks();
						break;
					case "Orders":
						PrintOrders(currentCustomer);
						break;

					case "New order":
						CreateNewOrder(currentCustomer);
						break;

					case "Quit":
						done = true;
						Console.WriteLine("Goodbye!");
						break;
					default:
						Console.WriteLine("Oops... Please, try again");
						break;
				}

			}

		}

		private void CreateNewOrder(Customer currentCustomer)
		{
			var order = new Order(currentCustomer.customerID, DateTime.Now);
			currentCustomer.orders.Add(order);

			var done = false;
			while (!done)
			{
				Console.WriteLine("Please, input ISBN number");
				var isbn = Console.ReadLine();
				var book = GetBook(isbn);
				if (book == null)
				{
					Console.WriteLine("Sorry. ISBN is not found");
					continue;
				}

				Console.WriteLine("Input amount");
				var amountString = Console.ReadLine();
				var amount = 0;
				try
				{
					amount = Int16.Parse(amountString);
				}
				catch
				{
					Console.WriteLine("Sorry. Ammount is not correct");
					continue;
				}

				var item = new OrderItem(book, amount);
				order.items.Add(item);

				var correctAnswer = false;
				while (!correctAnswer)
				{
					Console.WriteLine("Do you want to add one more book? (yes/no)");
					var answer = Console.ReadLine();
					if (answer == "yes")
					{
						correctAnswer = true;
					}
					else if (answer == "no")
					{
						return;
					}
					else
					{
						Console.WriteLine("Sorry?");
					}
				}

			}
		}



		private void PrintOrders(Customer currentCustomer)
		{
			Console.WriteLine("Here is your order list");
			foreach (var order in currentCustomer.orders)
			{
				Console.WriteLine("Order on " + order.date);
				foreach (var item in order.items)
				{
					Console.WriteLine("  " + item.book.name + " " + item.amount);
				}
			}
		}

		private Customer RegisterNewCustomer(string name)
		{
			throw new NotImplementedException();
		}

		private void PrintBooks()
		{
			Console.WriteLine("Here are our books:");
			foreach (var book in books)
			{
				Console.WriteLine(book.name + " " + book.author + " " + book.isbn);
			}
		}
		private Book GetBook(string isbn)
		{
			foreach (var book in books)
			{
				if (book.isbn == isbn)
				{
					return book;
				}
			}
			return null;
		}

		private Customer GetCustomer(string name)
		{
			foreach (var customer in privateCustomers)
			{
				if (customer.firstName + " " + customer.lastName == name)
				{
					return customer;
				}
			}

			foreach (var customer in buisnesCustomers)
			{
				if (customer.companyName == name)
				{
					return customer;
				}
			}
			return null;
		}
	}
}
