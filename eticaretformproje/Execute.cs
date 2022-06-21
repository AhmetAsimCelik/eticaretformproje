using eticaretformproje.Classlar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaretformproje
{
    internal class Execute
    {

        static Context con = new Context();
        
        

        public static void DBOlustur()
        {
            if (!con.Database.Exists())
            {
                con.Database.Create();
            }
        }
        public static void DBSil()
        {
            if (con.Database.Exists())
            {
                con.Database.Delete();
            }
        }
        public static int addproduct(Product p)
        {
            int sonuc1 = 0;

            con.Products.Add(p);

            sonuc1 = con.SaveChanges();

            return sonuc1;
        }
        public static int addcategory(Category c)
        {
            int sonuc1 = 0;

            con.Categorys.Add(c);

            sonuc1 = con.SaveChanges();

            return sonuc1;
        }
        public static int addbrand(Brand b)
        {
            int sonuc1 = 0;

            con.Brands.Add(b);

            sonuc1 = con.SaveChanges();

            return sonuc1;
        }
        public static int addusers(User u)
        {
            int sonuc = 0;

            con.Users.Add(u);

            sonuc = con.SaveChanges();

            return sonuc;


        }
        public static void giriskontrol(string username, string password)
        {
            User findusers = con.Users.Where(x => x.UserName == username && x.password == password).FirstOrDefault();

            if (findusers != null)
            {
                MessageBox.Show($"Giriş Başarılı, Hoşgeldin {username} :)");
                CUDForm ff = new CUDForm();
                ff.Show();

            }
            else
            {
                MessageBox.Show($"Giriş Başarısız!!");
                Form1 f1 = new Form1();
                f1.Show();

            }


        }

      





    }
}
