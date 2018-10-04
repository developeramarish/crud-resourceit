using System;
namespace CrudResourceIT.Domain.Entities
{
	public abstract class BaseEntity
	{
		public Guid Id { get; set; } = Guid.NewGuid();
	}
}