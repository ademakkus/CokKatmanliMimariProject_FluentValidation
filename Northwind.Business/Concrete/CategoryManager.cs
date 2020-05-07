using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private ICategoryDAL _categoryDAL;

		public CategoryManager(EfCategoryDAL categoryDAL)
		{
			_categoryDAL = categoryDAL;
		}

		public List<Category> GetAll()
		{
			return _categoryDAL.GetAll();
		}
	}
}
