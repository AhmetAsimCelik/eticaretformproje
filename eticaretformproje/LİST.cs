using eticaretformproje.Classlar;
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
    public partial class LİST : Form
    {
        public LİST()
        {
            InitializeComponent();
        }

        private void LİST_Load(object sender, EventArgs e)
        {
           
            using (Context context = new Context())
            {


                foreach (var item in context.Products)
                {
                    ListViewItem l = new ListViewItem();

                   
                    
                    l.Text = item.ProductName;
                    l.SubItems.Add(item.UnitPrice);
                    l.SubItems.Add(item.UnitStock);
                    l.SubItems.Add(item.BrandID);
                    l.SubItems.Add(item.AddDate);
                    lstview_all.Items.Add(l);



                }
                foreach (var item in context.Brands)
                {
                    ListViewItem l = new ListViewItem();

                    l.Text = item.BrandName;
                    l.SubItems.Add(item.BrandID);
                    listview_brands.Items.Add(l);



                }
                foreach (var item in context.Categorys)
                {
                    ListViewItem l = new ListViewItem();

                    l.Text = item.CategoryName;
                    l.SubItems.Add(item.CategoryID);
                    listview_category.Items.Add(l);


                }


            }
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
