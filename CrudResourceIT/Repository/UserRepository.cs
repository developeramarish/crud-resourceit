using CrudResourceIT.Context;
using CrudResourceIT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudResourceIT.Repository
{
	public class UserRepository : IDisposable
	{
		protected ApplicationDBContext Db = new ApplicationDBContext();


		public void Add(User user)
		{
			Db.Set<User>().Add(user);
			Db.SaveChanges();
		}

		public User GetById(Guid id)
		{
			return Db.Set<User>().Include(u => u.Detail).Where(u => u.Id == id).FirstOrDefault();
		}

		public IEnumerable<User> GetAll()
		{
			return Db.Set<User>().Include(u => u.Detail).ToList();
		}

		public void Update(User user)
		{
			Db.Entry(user).State = EntityState.Modified;
			Db.SaveChanges();
		}

		public void Remove(User user)
		{
			Db.Set<User>().Remove(user);
			Db.SaveChanges();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}

	 
}