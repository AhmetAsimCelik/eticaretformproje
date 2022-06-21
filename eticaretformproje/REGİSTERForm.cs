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
    public partial class REGİSTERForm : Form
    {
        static Context con = new Context();
        public REGİSTERForm()
        {
            InitializeComponent();
        }
        
       
       

        private void btn_userregister_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_name.Text) && !string.IsNullOrEmpty(txt_surname.Text) && !string.IsNullOrEmpty(txt_password.Text) && !string.IsNullOrEmpty(txt_password.Text) && !string.IsNullOrEmpty(txt_email.Text) && !string.IsNullOrEmpty(txt_phone.Text))
            {
                User u = new User();
                u.ID = Guid.NewGuid();
                u.Name = txt_name.Text;
                u.SurName = txt_surname.Text;
                u.UserName = txt_username.Text;
                u.password = txt_password.Text;
                u.EMail = txt_email.Text;
                u.PhoneNumber = txt_phone.Text;
                u.AddDate = DateTime.Now;
                int sonuc = Execute.addusers(u);

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    MessageBox.Show("Ana Menüye Dönüp Hesabınıza Giriş Yapabilirsiniz");

                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!!");

                }

                txt_name.Clear();
                txt_surname.Clear();
                txt_username.Clear();
                txt_password.Clear();
                txt_email.Clear();
                txt_phone.Clear();

            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz");
            }



        }

        private void btn_olusturusers_Click_1(object sender, EventArgs e)
        {
            int fdsayisi = Convert.ToInt32(txt_fakeusers.Text);

            for (int i = 0; i < fdsayisi; i++)
            {
                User u = new User();
                u.ID = Guid.NewGuid();               
                u.Name = FakeData.NameData.GetFirstName();
                u.SurName = FakeData.NameData.GetSurname();
                u.UserName = FakeData.NameData.GetFemaleFirstName();
                u.password = Convert.ToString(FakeData.NumberData.GetNumber());
                u.EMail = FakeData.NetworkData.GetEmail();
                u.PhoneNumber = Convert.ToString(FakeData.NumberData.GetNumber());
                u.AddDate = DateTime.Now;

                Execute.addusers(u);
                
                

            }
            MessageBox.Show("Fake Kullanıcılar Oluşturuldu..");



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void REGİSTERForm_Load(object sender, EventArgs e)
        {

        }
    }
}
