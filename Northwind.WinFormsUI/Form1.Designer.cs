namespace Northwind.WinFormsUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.gbxProductName = new System.Windows.Forms.GroupBox();
			this.tbxProduct = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbxCategory = new System.Windows.Forms.GroupBox();
			this.cmbCatgory = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbxProductAdd = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbCategoryAdd = new System.Windows.Forms.ComboBox();
			this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
			this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
			this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
			this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
			this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
			this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
			this.cmbUpdateCategoryId = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.gbxProductName.SuspendLayout();
			this.gbxCategory.SuspendLayout();
			this.gbxProductAdd.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvProducts
			// 
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Location = new System.Drawing.Point(22, 123);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RowHeadersWidth = 51;
			this.dgvProducts.RowTemplate.Height = 24;
			this.dgvProducts.Size = new System.Drawing.Size(1007, 217);
			this.dgvProducts.TabIndex = 0;
			this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
			// 
			// gbxProductName
			// 
			this.gbxProductName.Controls.Add(this.tbxProduct);
			this.gbxProductName.Controls.Add(this.label2);
			this.gbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbxProductName.ForeColor = System.Drawing.Color.Red;
			this.gbxProductName.Location = new System.Drawing.Point(531, 12);
			this.gbxProductName.Name = "gbxProductName";
			this.gbxProductName.Size = new System.Drawing.Size(484, 105);
			this.gbxProductName.TabIndex = 1;
			this.gbxProductName.TabStop = false;
			this.gbxProductName.Text = "Ürün İsmine Göre Arama";
			// 
			// tbxProduct
			// 
			this.tbxProduct.Location = new System.Drawing.Point(129, 42);
			this.tbxProduct.Name = "tbxProduct";
			this.tbxProduct.Size = new System.Drawing.Size(278, 28);
			this.tbxProduct.TabIndex = 3;
			this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ürün Adı";
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.cmbCatgory);
			this.gbxCategory.Controls.Add(this.label1);
			this.gbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbxCategory.ForeColor = System.Drawing.Color.Blue;
			this.gbxCategory.Location = new System.Drawing.Point(12, 12);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Size = new System.Drawing.Size(476, 105);
			this.gbxCategory.TabIndex = 2;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "Kategoriye Göre Arama";
			// 
			// cmbCatgory
			// 
			this.cmbCatgory.FormattingEnabled = true;
			this.cmbCatgory.Location = new System.Drawing.Point(181, 35);
			this.cmbCatgory.Name = "cmbCatgory";
			this.cmbCatgory.Size = new System.Drawing.Size(262, 30);
			this.cmbCatgory.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori";
			// 
			// gbxProductAdd
			// 
			this.gbxProductAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.gbxProductAdd.Controls.Add(this.btnAdd);
			this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
			this.gbxProductAdd.Controls.Add(this.tbxUnitsInStockAdd);
			this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
			this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
			this.gbxProductAdd.Controls.Add(this.cmbCategoryAdd);
			this.gbxProductAdd.Controls.Add(this.label7);
			this.gbxProductAdd.Controls.Add(this.label6);
			this.gbxProductAdd.Controls.Add(this.label5);
			this.gbxProductAdd.Controls.Add(this.label4);
			this.gbxProductAdd.Controls.Add(this.label3);
			this.gbxProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbxProductAdd.Location = new System.Drawing.Point(22, 377);
			this.gbxProductAdd.Name = "gbxProductAdd";
			this.gbxProductAdd.Size = new System.Drawing.Size(715, 168);
			this.gbxProductAdd.TabIndex = 3;
			this.gbxProductAdd.TabStop = false;
			this.gbxProductAdd.Text = "Yeni Ürün Ekle";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Ürün Adı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Kategori";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Birim Fiyatı";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(362, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "Birim Adet";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(362, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 20);
			this.label7.TabIndex = 4;
			this.label7.Text = "Stok Adet";
			// 
			// cmbCategoryAdd
			// 
			this.cmbCategoryAdd.FormattingEnabled = true;
			this.cmbCategoryAdd.Location = new System.Drawing.Point(106, 58);
			this.cmbCategoryAdd.Name = "cmbCategoryAdd";
			this.cmbCategoryAdd.Size = new System.Drawing.Size(210, 28);
			this.cmbCategoryAdd.TabIndex = 5;
			// 
			// tbxProductNameAdd
			// 
			this.tbxProductNameAdd.Location = new System.Drawing.Point(106, 21);
			this.tbxProductNameAdd.Name = "tbxProductNameAdd";
			this.tbxProductNameAdd.Size = new System.Drawing.Size(210, 26);
			this.tbxProductNameAdd.TabIndex = 6;
			// 
			// tbxUnitPriceAdd
			// 
			this.tbxUnitPriceAdd.Location = new System.Drawing.Point(106, 99);
			this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
			this.tbxUnitPriceAdd.Size = new System.Drawing.Size(210, 26);
			this.tbxUnitPriceAdd.TabIndex = 7;
			// 
			// tbxUnitsInStockAdd
			// 
			this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(470, 15);
			this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
			this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(119, 26);
			this.tbxUnitsInStockAdd.TabIndex = 8;
			// 
			// tbxQuantityPerUnitAdd
			// 
			this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(470, 63);
			this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
			this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(119, 26);
			this.tbxQuantityPerUnitAdd.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(367, 125);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(145, 37);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.tbxUpdateQuantityPerUnit);
			this.groupBox1.Controls.Add(this.tbxUpdateUnitsInStock);
			this.groupBox1.Controls.Add(this.tbxUpdateUnitPrice);
			this.groupBox1.Controls.Add(this.tbxUpdateProductName);
			this.groupBox1.Controls.Add(this.cmbUpdateCategoryId);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(32, 566);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(694, 168);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ürün Güncelleme";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(367, 125);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(145, 37);
			this.btnUpdate.TabIndex = 10;
			this.btnUpdate.Text = "Gücelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxUpdateQuantityPerUnit
			// 
			this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(470, 63);
			this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
			this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(119, 26);
			this.tbxUpdateQuantityPerUnit.TabIndex = 9;
			// 
			// tbxUpdateUnitsInStock
			// 
			this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(470, 15);
			this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
			this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(119, 26);
			this.tbxUpdateUnitsInStock.TabIndex = 8;
			// 
			// tbxUpdateUnitPrice
			// 
			this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(106, 99);
			this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
			this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(210, 26);
			this.tbxUpdateUnitPrice.TabIndex = 7;
			// 
			// tbxUpdateProductName
			// 
			this.tbxUpdateProductName.Location = new System.Drawing.Point(106, 21);
			this.tbxUpdateProductName.Name = "tbxUpdateProductName";
			this.tbxUpdateProductName.Size = new System.Drawing.Size(210, 26);
			this.tbxUpdateProductName.TabIndex = 6;
			// 
			// cmbUpdateCategoryId
			// 
			this.cmbUpdateCategoryId.FormattingEnabled = true;
			this.cmbUpdateCategoryId.Location = new System.Drawing.Point(106, 58);
			this.cmbUpdateCategoryId.Name = "cmbUpdateCategoryId";
			this.cmbUpdateCategoryId.Size = new System.Drawing.Size(210, 28);
			this.cmbUpdateCategoryId.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(362, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 20);
			this.label8.TabIndex = 4;
			this.label8.Text = "Stok Adet";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(362, 66);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 20);
			this.label9.TabIndex = 3;
			this.label9.Text = "Birim Adet";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 99);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 20);
			this.label10.TabIndex = 2;
			this.label10.Text = "Birim Fiyatı";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 65);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 20);
			this.label11.TabIndex = 1;
			this.label11.Text = "Kategori";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 27);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(74, 20);
			this.label12.TabIndex = 0;
			this.label12.Text = "Ürün Adı";
			// 
			// btnRemove
			// 
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRemove.ForeColor = System.Drawing.Color.Red;
			this.btnRemove.Location = new System.Drawing.Point(843, 347);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(138, 44);
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "Kaydı Sil";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1027, 908);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxProductAdd);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.gbxProductName);
			this.Controls.Add(this.dgvProducts);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.gbxProductName.ResumeLayout(false);
			this.gbxProductName.PerformLayout();
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxProductAdd.ResumeLayout(false);
			this.gbxProductAdd.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProducts;
		private System.Windows.Forms.GroupBox gbxProductName;
		private System.Windows.Forms.TextBox tbxProduct;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbxCategory;
		private System.Windows.Forms.ComboBox cmbCatgory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbxProductAdd;
		private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
		private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
		private System.Windows.Forms.TextBox tbxUnitPriceAdd;
		private System.Windows.Forms.TextBox tbxProductNameAdd;
		private System.Windows.Forms.ComboBox cmbCategoryAdd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
		private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
		private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
		private System.Windows.Forms.TextBox tbxUpdateProductName;
		private System.Windows.Forms.ComboBox cmbUpdateCategoryId;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnRemove;
	}
}

