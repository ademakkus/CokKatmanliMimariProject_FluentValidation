using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
	public class EfProductDAL : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDAL
	{

		//public List<Product> GetAll()
		//{
		//	using(NorthwindContext context=new NorthwindContext())
		//	{
		//		return context.Products.ToList();
		//	}	

		//}
		//public Product Get(int id)
		//{

		//	using (NorthwindContext context = new NorthwindContext())
		//	{
		//		return context.Products.SingleOrDefault(p => p.ProductId == id);
		//	}
		//}
		//public void Add(Product product)
		//{
		//	using (NorthwindContext context = new NorthwindContext())
		//	{
		//		context.Products.Add(product);

		//		context.SaveChanges();
		//	}

		//}

		//public void Update(Product product)
		//{
		//	using (NorthwindContext context = new NorthwindContext())
		//	{

		//	}
		//}
		//public void Delete(Product product)
		//{
		//	using (NorthwindContext context = new NorthwindContext())
		//	{

		//	}

		//}

		//public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
		//{
		//	throw new NotImplementedException();
		//}

		//public Product Get(Expression<Func<Product, bool>> filter)
		//{
		//	throw new NotImplementedException();
		//}
		//}
	}
}
