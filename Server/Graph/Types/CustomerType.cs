using GraphQL.Types;
using Server.Domain.Entities;

namespace Server.Graph.Schemas
{
	public class CustomerType : ObjectGraphType<Customer>
	{
		public CustomerType()
		{
			Name = nameof(Customer);

			Field(customer => customer.Register).Description("Customer's register");
			Field(customer => customer.FirstName).Description("Customer's First Name");
			Field(customer => customer.LastName).Description("Customer's Last Name");
			Field(customer => customer.Age).Description("Customer's Age");
		}
	}
}