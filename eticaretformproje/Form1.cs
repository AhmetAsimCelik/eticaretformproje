using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaretformproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btn_register_Click_1(object sender, EventArgs e)
        {
            REGİSTERForm rgf = new REGİSTERForm();
            rgf.Show();
            this.Hide();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {

            Execute.giriskontrol(txt_loginuser.Text, txt_loginpass.Text);
            this.Hide();
        }

        private void btn_dbolustur_Click(object sender, EventArgs e)
        {
            Execute.DBOlustur();
            MessageBox.Show("Database Oluşturuldu.");
        }

        private void btn_dbsil_Click(object sender, EventArgs e)
        {
            Execute.DBSil();
            MessageBox.Show("Database Silindi.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LİST L = new LİST();
            L.Show();
            this.Hide();
        }
    }
}
