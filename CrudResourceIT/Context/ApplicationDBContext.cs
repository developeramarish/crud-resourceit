using CrudResourceIT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CrudResourceIT.Context
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext() : base("DefaultString")
		{

		}

		public DbSet<User> Users { get; set; }

		public DbSet<Detail> Details { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			modelBuilder.Properties().Where(p => p.Name == "Id").Configure(p => p.IsKey());

			modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

			modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
		}
	}
}