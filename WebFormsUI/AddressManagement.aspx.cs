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
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvAdresler.DataSource = manager.GetAll();
            dgvAdresler.DataBind(); // web tarafında verilerin grid view a yüklenmesi için bu metodu da eklememiz gerekli!
        }
    }
}