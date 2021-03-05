using GraphQL.Types;
using Server.Domain.Entities;

namespace Server.Schemas
{
	public class CustomerSchema : ObjectGraphType<Customer>
	{
		public CustomerSchema()
		{
			Name = nameof(Customer);

			Field(customer => customer.Register).Description("Customer's register");
			Field(customer => customer.FirstName).Description("Customer's First Name");
			Field(customer => customer.LastName).Description("Customer's Last Name");
			Field(customer => customer.Age).Description("Customer's Age");
		}
	}
}
