using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Domain.Entities
{
	public class Car
	{
		public string Model { get; init; }

		public string Manufacturer { get; init; }

		public int Year { get; init; }
	}
}
