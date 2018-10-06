
using System;

namespace CrudResourceIT.Domain.Entities
{
	public class User : BaseEntity
	{

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public Detail Detail { get; set; }

		public Guid IdDetails { get; set; }
	}
}