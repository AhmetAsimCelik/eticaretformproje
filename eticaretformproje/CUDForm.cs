using eticaretformproje.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaretformproje
{
    public partial class CUDForm : Form
    {
        static Context con = new Context();
        

        public CUDForm()
        {
            InitializeComponent();
        }
        

        private void btn_addcategory_Click(object sender, EventArgs e)
        {

            try
            {

                if (!string.IsNullOrEmpty(txt_catıd.Text) && !string.IsNullOrEmpty(txt_catname.Text) && !string.IsNullOrEmpty(txt_catdesc.Text))
                {

                    Category c = new Category();

                    c.CategoryID = txt_catıd.Text;
                    c.CategoryName = txt_catname.Text;
                    c.Description = txt_catdesc.Text;
                    c.AddDate = DateTime.Now.ToString();
                    c.UpdateDate = null;
                    Execute.addcategory(c);
                    MessageBox.Show("Kayıt Başarılı");
                    txt_catıd.Text = "";
                    txt_catname.Text = "";
                    txt_catdesc.Text = "";
                    ListViewItem list = new ListViewItem();

                    list.Text = c.CategoryID;
                    list.SubItems.Add(c.CategoryName);
                    list.SubItems.Add(c.Description);
                    lstview_category.Items.Add(list);
                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurun!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("CID 'yi Kontrol Edip Tekrar Deneyiniz.Sayfa Yenileniyor!");                
                CUDForm cf = new CUDForm();
                cf.Show();
                this.Hide();
                


            }




            #region trycatch
            //try
            //{

            //    if (txt_catıd.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Kategori ID Giriniz!");

            //    }
            //    else if (txt_catname.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Kategori Adı Giriniz!");
            //    }
            //    else if (txt_catdesc.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Kategori Tanımı Giriniz!");
            //    }
            //    else
            //    {
            //        Execute.addcategory(c);
            //        MessageBox.Show("Kayıt Başarılı");
            //        txt_catıd.Text = "";
            //        txt_catname.Text = "";
            //        txt_catdesc.Text = "";
            //        ListViewItem list = new ListViewItem();

            //        list.Text = c.CategoryID;
            //        list.SubItems.Add(c.CategoryName);
            //        list.SubItems.Add(c.Description);
            //        lstview_category.Items.Add(list);

            //    }

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Girdiğiniz Bilgiler Hatalı!! Lütfen Destek Hattımızla İletişime Geçin");

            //}
            #endregion




        }

        private void btn_addbrand_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_brandıd.Text) && !string.IsNullOrEmpty(txt_brandname.Text) && !string.IsNullOrEmpty(txt_brandcountry.Text) && !string.IsNullOrEmpty(txt_brandcat.Text))
                {
                    Brand b = new Brand();

                    b.BrandName = txt_brandname.Text;
                    b.BrandID = txt_brandıd.Text;
                    b.Origin = txt_brandcountry.Text;
                    b.CategoryID = txt_brandcat.Text;
                    b.AddDate = DateTime.Now.ToString();
                    b.UpdateDate = null;
                    Execute.addbrand(b);
                    MessageBox.Show("Kayıt Başarılı");

                    ListViewItem list = new ListViewItem();

                    list.Text = b.BrandID;
                    list.SubItems.Add(b.BrandName);
                    list.SubItems.Add(b.Origin);
                    list.SubItems.Add(b.CategoryID);
                    lstview_brand.Items.Add(list);

                    txt_brandıd.Text = "";
                    txt_brandname.Text = "";
                    txt_brandcountry.Text = "";
                    txt_brandcat.Text = "";
                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurun");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CID veya BID'yi Kontrol Edip Tekrar Deneyiniz.Sayfa Yenileniyor!");
                CUDForm cf = new CUDForm();
                cf.Show();
                this.Hide();

            }
            




            #region trycatch
            //try
            //{
            //    if (txt_brandıd.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Brand ID Giriniz!");
            //    }
            //    else if (txt_brandname.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Marka Adı Giriniz!");
            //    }
            //    else if (txt_brandcountry.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Marka'nın Menşei'ni Giriniz!");
            //    }
            //    else if (txt_catıd.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Kategori ID Giriniz!");
            //    }
            //    else
            //    {
            //        Execute.addbrand(b);
            //        MessageBox.Show("Kayıt Başarılı");
            //        ListViewItem list = new ListViewItem();

            //        list.Text = b.BrandID;
            //        list.SubItems.Add(b.BrandName);
            //        list.SubItems.Add(b.CompanyCountry);
            //        list.SubItems.Add(b.CategoryID);
            //        lstview_category.Items.Add(list);
            //        txt_brandıd.Text = "";
            //        txt_brandname.Text = "";
            //        txt_brandcountry.Text = "";
            //        txt_brandcat.Text = "";



            //    }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Girdiğiniz CID veya BID Hatalı.Lütfen Kontrol Ediniz!!");
            //}
            #endregion
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_productıd.Text) && !string.IsNullOrEmpty(txt_productname.Text) && !string.IsNullOrEmpty(txt_productprice.Text) && !string.IsNullOrEmpty(txt_productstock.Text) && !string.IsNullOrEmpty(txt_productbrandıd.Text))
                {

                    Product p = new Product();

                    p.ProductName = txt_productname.Text;
                    p.ProductID = txt_productıd.Text;
                    p.UnitPrice = txt_productprice.Text;
                    p.UnitStock = txt_productstock.Text;
                    p.BrandID = txt_productbrandıd.Text;
                    p.AddDate = DateTime.Now.ToString();
                    p.UpdateDate = null;
                    Execute.addproduct(p);
                    MessageBox.Show("Kayıt Başarılı");

                    ListViewItem list = new ListViewItem();

                    list.Text = p.ProductID;
                    list.SubItems.Add(p.ProductName);
                    list.SubItems.Add(p.UnitPrice);
                    list.SubItems.Add(p.UnitStock);
                    list.SubItems.Add(p.BrandID);
                    ltsview_product.Items.Add(list);


                    txt_productıd.Text = "";
                    txt_productname.Text = "";
                    txt_productprice.Text = "";
                    txt_productstock.Text = "";
                    txt_productbrandıd.Text = "";

                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurunuz!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PID veya BID'yi Kontrol Edip Tekrar Deneyiniz.Sayfa Yenileniyor!");
                CUDForm cf = new CUDForm();
                cf.Show();
                this.Hide();
            }
           

            #region trycatch
            //try
            //{
            //    if (txt_productıd.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Product ID Giriniz!");
            //    }
            //    else if (txt_productname.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Product Adı Giriniz!");
            //    }
            //    else if (txt_productprice.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Ürünün Adet Fiyatını Giriniz!");
            //    }
            //    else if (txt_productstock.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Ürünün Stoğunu Giriniz!");
            //    }
            //    else if (txt_productbrandıd.Text == "")
            //    {
            //        MessageBox.Show("Lütfen Brand ID Giriniz!");
            //    }
            //    else
            //    {
            //        Execute.addproduct(p);
            //        MessageBox.Show("Kayıt Başarılı");
            //        ListViewItem list = new ListViewItem();

            //        list.Text = p.ProductID;
            //        list.SubItems.Add(p.ProductName);
            //        list.SubItems.Add(p.UnitPrice);
            //        list.SubItems.Add(p.UnitStock);
            //        list.SubItems.Add(p.BrandID);
            //        lstview_category.Items.Add(list);
            //        txt_productıd.Text = "";
            //        txt_productname.Text = "";
            //        txt_productprice.Text = "";
            //        txt_productstock.Text = "";
            //        txt_productbrandıd.Text = "";

            //    }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Girdiğiniz PID veya BID Hatalı.Lütfen Kontrol Ediniz!!");
            //}
            #endregion

            #region whiletrue
            //while (true)
            //{
            //    if (txt_productıd.Text == "" || txt_productname.Text == "" || txt_productprice.Text == "" || txt_productstock.Text == "" || txt_productbrandıd.Text == "")
            //    {
            //        if (txt_productıd.Text == "")
            //        {
            //            MessageBox.Show("Lütfen Product ID Giriniz!");
            //        }
            //        else
            //        {
            //            break;
            //        }
            //        if (txt_productname.Text == "")
            //        {
            //            MessageBox.Show("Lütfen Product Adı Giriniz!");
            //        }
            //        else
            //        {
            //            break;
            //        }
            //        if (txt_productprice.Text == "")
            //        {
            //            MessageBox.Show("Lütfen Ürünün Adet Fiyatını Giriniz!");
            //        }
            //        else
            //        {
            //            break;
            //        }
            //        if (txt_productstock.Text == "")
            //        {
            //            MessageBox.Show("Lütfen Ürünün Stoğunu Giriniz!");
            //        }
            //        else
            //        {
            //            break;
            //        }
            //        if (txt_productbrandıd.Text == "")
            //        {
            //            MessageBox.Show("Lütfen Brand ID Giriniz!");
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Execute.addproduct(p);
            //        MessageBox.Show("Kayıt Başarılı");

            //        ListViewItem list = new ListViewItem();

            //        list.Text = p.ProductID;
            //        list.SubItems.Add(p.ProductName);
            //        list.SubItems.Add(p.UnitPrice);
            //        list.SubItems.Add(p.UnitStock);
            //        list.SubItems.Add(p.BrandID);
            //        lstview_category.Items.Add(list);

            //        txt_productıd.Text = "";
            //        txt_productname.Text = "";
            //        txt_productprice.Text = "";
            //        txt_productstock.Text = "";
            //        txt_productbrandıd.Text = "";
            //        break;
            //    }

            //}
            #endregion
        }

        private void CUDForm_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {


                foreach (var item in context.Categorys)
                {
                    ListViewItem list = new ListViewItem();

                    list.Text = item.CategoryID;
                    list.SubItems.Add(item.CategoryName);
                    list.SubItems.Add(item.Description);
                    lstview_category.Items.Add(list);
                }


            }
            using (Context context = new Context())
            {


                foreach (var item in context.Brands)
                {
                    ListViewItem list = new ListViewItem();

                    list.Text = item.BrandID;
                    list.SubItems.Add(item.BrandName);
                    list.SubItems.Add(item.Origin);
                    list.SubItems.Add(item.CategoryID);
                    lstview_brand.Items.Add(list);
                }


            }
            using (Context context = new Context())
            {


                foreach (var item in context.Products)
                {
                    ListViewItem list = new ListViewItem();

                    list.Text = item.ProductID;
                    list.SubItems.Add(item.ProductName);
                    list.SubItems.Add(item.UnitPrice);
                    list.SubItems.Add(item.UnitStock);
                    list.SubItems.Add(item.BrandID);
                    ltsview_product.Items.Add(list);
                }


            }
        }

        private void lstview_category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (Context cont = new Context())
            {

                foreach (ListViewItem item in lstview_category.SelectedItems)
                {

                    txt_catıd.Text = item.Text.ToString();
                    txt_catname.Text = item.SubItems[1].Text;
                    txt_catdesc.Text = item.SubItems[2].Text;

                }

            }

        }

        private void lstview_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Context cont = new Context())
            {

                foreach (ListViewItem item in lstview_brand.SelectedItems)
                {

                    txt_brandıd.Text = item.Text.ToString();
                    txt_brandname.Text = item.SubItems[1].Text;
                    txt_brandcountry.Text = item.SubItems[2].Text;
                    txt_brandcat.Text = item.SubItems[3].Text;


                }

            }
        }

        private void ltsview_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Context cont = new Context())
            {

                foreach (ListViewItem item in ltsview_product.SelectedItems)
                {

                    txt_productıd.Text = item.Text.ToString();
                    txt_productname.Text = item.SubItems[1].Text;
                    txt_productprice.Text = item.SubItems[2].Text;
                    txt_productstock.Text = item.SubItems[3].Text;
                    txt_productbrandıd.Text = item.SubItems[4].Text;

                }

            }
        }

        private void btn_updatecategroy_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_catıd.Text) && !string.IsNullOrEmpty(txt_catname.Text) && !string.IsNullOrEmpty(txt_catdesc.Text))
                {
                    Category c = new Category();
                    string ıd = txt_catıd.Text;
                    var catguncel = con.Categorys.Where(x => x.CategoryID == ıd).FirstOrDefault();
                    catguncel.CategoryName = txt_catname.Text;
                    catguncel.Description = txt_catdesc.Text;
                    catguncel.UpdateDate = DateTime.Now.ToString();

                    con.SaveChanges();

                    MessageBox.Show("Kayıt Güncellendi");

                    txt_catıd.Text = "";
                    txt_catname.Text = "";
                    txt_catdesc.Text = "";
                    lstview_category.Items.Clear();

                    using (Context context = new Context())
                    {


                        foreach (var item in context.Categorys)
                        {
                            ListViewItem list = new ListViewItem();

                            list.Text = item.CategoryID;
                            list.SubItems.Add(item.CategoryName);
                            list.SubItems.Add(item.Description);
                            lstview_category.Items.Add(list);




                        }


                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurun!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CID Güncellenemez!.Sayfa Yenileniyor!");
                CUDForm cf = new CUDForm();
                cf.Show();
                this.Hide();

            }
            
           

        }

        private void btn_deletecategory_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           

            if (result == DialogResult.OK)
            {
                string ıd = txt_catıd.Text;
                var catsil = con.Categorys.Where(x => x.CategoryID == ıd).FirstOrDefault();

                con.Categorys.Remove(catsil);
                con.SaveChanges();

                
                    MessageBox.Show("Kayıt Silindi.");
                    lstview_category.Items.Clear();
                    using (Context context = new Context())
                    {


                        foreach (var item in context.Categorys)
                        {
                            ListViewItem list = new ListViewItem();

                            list.Text = item.CategoryID;
                            list.SubItems.Add(item.CategoryName);
                            list.SubItems.Add(item.Description);
                            lstview_category.Items.Add(list);




                        }


                    }
                

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi.");
            }
        }

        private void btn_updatebrand_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_brandıd.Text) && !string.IsNullOrEmpty(txt_brandname.Text) && !string.IsNullOrEmpty(txt_brandcountry.Text) && !string.IsNullOrEmpty(txt_brandcat.Text))
                {
                    string ıd = txt_brandıd.Text;
                    var brandguncel = con.Brands.Where(x => x.BrandID == ıd).FirstOrDefault();
                    brandguncel.BrandName = txt_brandname.Text;
                    brandguncel.Origin = txt_brandcountry.Text;
                    brandguncel.CategoryID = txt_brandcat.Text;
                    brandguncel.UpdateDate = DateTime.Now.ToString();

                    con.SaveChanges();
                    MessageBox.Show("Kayıt Güncellendi");

                    txt_brandıd.Text = "";
                    txt_brandname.Text = "";
                    txt_brandcountry.Text = "";
                    txt_brandcat.Text = "";
                    lstview_brand.Items.Clear();

                    using (Context context = new Context())
                    {


                        foreach (var item in context.Brands)
                        {
                            ListViewItem list = new ListViewItem();

                            list.Text = item.BrandID;
                            list.SubItems.Add(item.BrandName);
                            list.SubItems.Add(item.Origin);
                            list.SubItems.Add(item.CategoryID);
                            lstview_brand.Items.Add(list);
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurun");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("BID Güncellenemez!.Sayfa Yenileniyor!");
                CUDForm cf = new CUDForm();
                cf.Show();
                this.Hide();
            }
            
        }

        private void btn_deletebrand_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                string ıd = txt_brandıd.Text;
                var brandsil = con.Brands.Where(x => x.BrandID == ıd).FirstOrDefault();

                con.Brands.Remove(brandsil);
                con.SaveChanges();

                MessageBox.Show("Kayıt Silindi");
                lstview_brand.Items.Clear();
                using (Context context = new Context())
                {


                    foreach (var item in context.Brands)
                    {
                        ListViewItem list = new ListViewItem();

                        list.Text = item.BrandID;
                        list.SubItems.Add(item.BrandName);
                        list.SubItems.Add(item.Origin);
                        list.SubItems.Add(item.CategoryID);
                        lstview_brand.Items.Add(list);
                    }


                }

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi.");
            }
        }

        private void btn_updateproduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_productıd.Text) && !string.IsNullOrEmpty(txt_productname.Text) && !string.IsNullOrEmpty(txt_productprice.Text) && !string.IsNullOrEmpty(txt_productstock.Text) && !string.IsNullOrEmpty(txt_productbrandıd.Text))
                {
                    string ıd = txt_productıd.Text;
                    var productguncel = con.Products.Where(x => x.ProductID == ıd).FirstOrDefault();
                    productguncel.ProductName = txt_productname.Text;
                    productguncel.UnitPrice = txt_productprice.Text;
                    productguncel.UnitStock = txt_productstock.Text;
                    productguncel.BrandID = txt_productbrandıd.Text;
                    productguncel.UpdateDate = DateTime.Now.ToString();

                    con.SaveChanges();
                    MessageBox.Show("Kayıt Güncellendi");

                    txt_productıd.Text = "";
                    txt_productname.Text = "";
                    txt_productprice.Text = "";
                    txt_productstock.Text = "";
                    txt_productbrandıd.Text = "";

                    ltsview_product.Items.Clear();

                    using (Context context = new Context())
                    {


                        foreach (var item in context.Products)
                        {
                            ListViewItem list = new ListViewItem();

                            list.Text = item.ProductID;
                            list.SubItems.Add(item.ProductName);
                            list.SubItems.Add(item.UnitPrice);
                            list.SubItems.Add(item.UnitStock);
                            list.SubItems.Add(item.BrandID);
                            ltsview_product.Items.Add(list);
                        }


                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurunuz!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PID Güncellenemez!.Sayfa Yenileniyor!");
                CUDForm cf = new CUDForm();
                cf.Show();
                this.Hide();
            }
            
        }

        private void btn_deleteproduct_Click(object sender, EventArgs e)
        {

           
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                string ıd = txt_productıd.Text;
                var productsil = con.Products.Where(x => x.ProductID == ıd).FirstOrDefault();

                con.Products.Remove(productsil);
                con.SaveChanges();

                MessageBox.Show("Kayıt Silindi");
                ltsview_product.Items.Clear();
                using (Context context = new Context())
                {


                    foreach (var item in context.Products)
                    {
                        ListViewItem list = new ListViewItem();

                        list.Text = item.ProductID;
                        list.SubItems.Add(item.ProductName);
                        list.SubItems.Add(item.UnitPrice);
                        list.SubItems.Add(item.UnitStock);
                        list.SubItems.Add(item.BrandID);
                        ltsview_product.Items.Add(list);
                    }


                }
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
    
}
