using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using Northwind.Business.Utilties;
using Northwind.Business.ValidationRules.FluentValidation;
using FluentValidation;

namespace Northwind.Business.Concrete
{
public	class ProductManager:IProductService
	{


		//EfProductDAL _productDAL = new EfProductDAL();
		private IProductDAL _productDAL;

		public ProductManager(IProductDAL productDAL)
		{
			_productDAL = productDAL;
		}

		public void Add(Product product)
		{
			//ProductValidator productValidator = new ProductValidator();
			//var result = productValidator.Validate(product);
			//if (result.Errors.Count>0)
			//{
			//	throw new ValidationException(result.Errors);
			//}
		ValidationTool.Validate(new ProductValidator(), product);
			_productDAL.Add(product);
		}

		public void Delete(Product product)
		{
			try
			{
				_productDAL.Delete(product);
			}
			catch (DbUpdateException)
			{

				throw new Exception("Bu ürünü silemezsiniz.");
			}
		
		}

		public List<Product> GetAll()
		{
			//Business katmanı kodlar buraya
			
			return _productDAL.GetAll();
		}

		public List<Product> GetProductsByCategory(int categoryId)
		{
			return _productDAL.GetAll(p => p.CategoryId == categoryId);
		}

		public List<Product> GetProductsByName(string productName)
		{
			return _productDAL.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
		}

		public void Update(Product product)
		{

			ValidationTool.Validate(new ProductValidator(), product);
			_productDAL.Update(product);
		}
	}
}
