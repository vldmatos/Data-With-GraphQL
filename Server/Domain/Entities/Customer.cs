using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Domain.Entities
{
	public record Customer
	{
		public string Register { get; init; }

		public string FirstName { get; init; }

		public string LastName { get; init; }

		public short Age { get; init; }
	}
}
