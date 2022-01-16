using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class AddressManagement : Form
    {
        public AddressManagement()
        {
            InitializeComponent();
        }
        AddressManager manager = new AddressManager();
        CustomerManager customer = new CustomerManager();
        private void AddressManagement_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvAdresler.DataSource = manager.GetAll();
            cbCustomers.DataSource = customer.GetAll();
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOpenAddress.Text))
            {
                var sonuc = manager.Add(new Address
                {
                    CreateDate = DateTime.Now,
                    CustomerId = (int)cbCustomers.SelectedValue,
                    OpenAddress = txtOpenAddress.Text,
                    Title = txtTitle.Text
                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Başarıyla Eklendi!");
                }
            }
            else MessageBox.Show("Adres Giriniz!");
        }
    }
}
