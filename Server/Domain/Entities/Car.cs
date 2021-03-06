﻿namespace Server.Domain.Entities
{
	public record Car
	{
		public string Model { get; init; }

		public string Color { get; init; }

		public string Manufacturer { get; init; }

		public int Year { get; init; }

		public decimal Price { get; init; }
	}
}