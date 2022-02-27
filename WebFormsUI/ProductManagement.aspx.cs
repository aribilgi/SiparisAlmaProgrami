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
    }
}