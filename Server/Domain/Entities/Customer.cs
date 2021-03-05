using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Domain.Entities
{
	public class Customer
	{
		public string FirstName { get; init; }

		public string LastName { get; init; }

		public short Age { get; init; }
	}
}
