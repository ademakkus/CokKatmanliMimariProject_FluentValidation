using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinFormsUI
{
	public partial class Form1 : Form
	{

		private IProductService _productService;
		private ICategoryService _categoryService;
		public Form1()
		{
			InitializeComponent();
			_productService = new ProductManager(new EfProductDAL());
			_categoryService = new CategoryManager(new EfCategoryDAL());

		}



		private void Form1_Load(object sender, EventArgs e)
		{
			LoadProducts();
			LoadCategories();
		}

		private void LoadCategories()
		{
			cmbCatgory.DataSource = _categoryService.GetAll();
			cmbCatgory.DisplayMember = "CategoryName";
			cmbCatgory.ValueMember = "CategoryId";

			cmbCategoryAdd.DataSource = _categoryService.GetAll();
			cmbCategoryAdd.DisplayMember = "CategoryName";
			cmbCategoryAdd.ValueMember = "CategoryId";

			cmbUpdateCategoryId.DataSource = _categoryService.GetAll();
			cmbUpdateCategoryId.DisplayMember = "CategoryName";
			cmbUpdateCategoryId.ValueMember = "CategoryId";

		}

		private void LoadProducts()
		{
			dgvProducts.DataSource = _productService.GetAll();
		}

		private void tbxProduct_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(tbxProduct.Text))
			{
				dgvProducts.DataSource = _productService.GetProductsByName(tbxProduct.Text);
			}
			else
			{
				LoadProducts();

			}


		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{

				_productService.Add(new Product

				{
					CategoryId = Convert.ToInt32(cmbCategoryAdd.SelectedValue),
					ProductName = tbxProductNameAdd.Text,
					QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
					UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
					UnitsInStock = Convert.ToInt16(tbxUnitsInStockAdd.Text)


				});
				MessageBox.Show("Ürün başarıyla kaydedildi.", "Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadProducts();
			}
			catch (Exception exc)
			{

				MessageBox.Show(exc.Message,"Ekleme Hata Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			try
			{
				_productService.Update(new Product
				{
					ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value),
					CategoryId = Convert.ToInt32(cmbUpdateCategoryId.SelectedValue),
					ProductName = tbxUpdateProductName.Text,
					QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
					UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
					UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text)


				});
				MessageBox.Show("Ürün başarıyla güncellendi..", "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadProducts();
			}
			catch (Exception exc)
			{

				MessageBox.Show(exc.Message,"Güncelleme Hata Mesajı");
			}
		}

		private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = dgvProducts.CurrentRow;
						
			tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
			cmbUpdateCategoryId.SelectedValue = row.Cells[2].Value.ToString();
			tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
			tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
			tbxUpdateUnitsInStock.Text = row.Cells[5].Value.ToString();

	
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{

			try
			{
				_productService.Delete(new Product
				{
					ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value)
				});

				MessageBox.Show("Ürün silindi.", "Ürün Silme İşlemi");
				LoadProducts();
			}
			catch (Exception exp)
			{

				MessageBox.Show(exp.Message,"Silme Hatası");
			}
			
		
		}
	}
}
