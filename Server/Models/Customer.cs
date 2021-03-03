using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
	public class Customer
	{
		public int Id { get; init; }

		public string FirstName { get; init; }

		public string LastName { get; init; }

		public short Age { get; init; }
	}
}
