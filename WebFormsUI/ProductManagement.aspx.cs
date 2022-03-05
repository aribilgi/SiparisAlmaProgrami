using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entities;

namespace WebFormsUI
{
    public partial class ProductManagement : System.Web.UI.Page
    {
        ProductManager manager = new ProductManager();
        CategoryManager category = new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvUrunler.DataSource = manager.GetAll();
            dgvUrunler.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) & !string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                var sonuc = manager.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbKategoriler.SelectedValue),
                    CreateDate = DateTime.Now,
                    Description = txtDescription.Text,
                    IsActive = cbIsActive.Checked,
                    Name = txtName.Text,
                    Price = Convert.ToDecimal(txtPrice.Text.Trim()), // Trim metodu textbox a girilen değerin önündeki ve sonundaki boşlukları kaldırır
                    Stock = Convert.ToInt32(txtStock.Text.Trim())
                });
                if (sonuc > 0)
                {
                    Response.Redirect("ProductManagement.aspx");
                }
            }
            else Response.Write("<script>alert('Ürün Adı ve Fiyatı Boş Geçilemez!')</script>");
        }
    }
}