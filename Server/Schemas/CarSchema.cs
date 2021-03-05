using GraphQL.Types;
using Server.Domain.Entities;

namespace Server.Schemas
{
	public class CarSchema : ObjectGraphType<Car>
	{
		public CarSchema()
		{
			Name = nameof(Car);

			Field(car => car.Model).Description("Model of Car");
			Field(car => car.Color).Description("Car's color");
			Field(car => car.Manufacturer).Description("Manufacturer of car");
			Field(car => car.Year).Description("Year of car");
			Field(car => car.Price).Description("Price of car");
		}
	}
}
