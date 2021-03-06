using Server.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Server.Domain
{
	public record Sale
	{
		public string Id { get; init; }

		public DateTime Date { get; init; }

		public Customer Customer { get; init; }

		public IEnumerable<Car> Cars { get; init; }
	}
}