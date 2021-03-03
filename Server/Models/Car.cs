using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
	public class Car
	{
		public int Id { get; init; }

		public string Model { get; init; }

		public string Manufacturer { get; init; }

		public int Year { get; init; }
	}
}
