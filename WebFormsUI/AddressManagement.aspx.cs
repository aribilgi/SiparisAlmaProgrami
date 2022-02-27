using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsUI
{
    public partial class AddressManagement : System.Web.UI.Page
    {
        AddressManager manager = new AddressManager();
        CustomerManager customer = new CustomerManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvAdresler.DataSource = manager.GetAll();
            dgvAdresler.DataBind(); // web tarafında verilerin grid view a yüklenmesi için bu metodu da eklememiz gerekli!
            cbCustomers.DataSource = customer.GetAll();
            cbCustomers.DataBind(); // ekrandaki drop down liste müşterileri doldur
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}