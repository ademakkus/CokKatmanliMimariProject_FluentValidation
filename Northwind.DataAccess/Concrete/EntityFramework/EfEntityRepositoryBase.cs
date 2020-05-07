using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{
		public void Add(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var addedEntiy = context.Entry(entity);
				addedEntiy.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{

			using (TContext context = new TContext())
			{
				var deletedEntiy = context.Entry(entity);
				deletedEntiy.State = EntityState.Deleted;
				context.SaveChanges();
			}

		}

		public TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
		{
			using (TContext context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);

			}
		}
			public List<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
			{
				using (TContext context = new TContext())
				{

					return filter == null ?
							context.Set<TEntity>().ToList() :
						context.Set<TEntity>().Where(filter).ToList();
				}
			}

			public void Update(TEntity entity)
			{
			using (TContext context = new TContext())
			{
				var updatedEntiy = context.Entry(entity);
				updatedEntiy.State = EntityState.Modified;
				context.SaveChanges();
			}



		}
		

		
	}
}
