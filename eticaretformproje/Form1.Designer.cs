namespace eticaretformproje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_loginpass = new System.Windows.Forms.TextBox();
            this.txt_loginuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dbsil = new System.Windows.Forms.Button();
            this.btn_dbolustur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_register);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.txt_loginpass);
            this.groupBox1.Controls.Add(this.txt_loginuser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGİN PANEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hesabınız yoksa yeni bir kayıt oluşturabilirsiniz";
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.SystemColors.Control;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_register.Location = new System.Drawing.Point(15, 173);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(289, 39);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "KAYIT OL ";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click_1);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Control;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Location = new System.Drawing.Point(15, 99);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(289, 40);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "GİRİŞ";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // txt_loginpass
            // 
            this.txt_loginpass.Location = new System.Drawing.Point(102, 69);
            this.txt_loginpass.Name = "txt_loginpass";
            this.txt_loginpass.PasswordChar = '*';
            this.txt_loginpass.Size = new System.Drawing.Size(202, 20);
            this.txt_loginpass.TabIndex = 3;
            // 
            // txt_loginuser
            // 
            this.txt_loginuser.Location = new System.Drawing.Point(102, 37);
            this.txt_loginuser.Name = "txt_loginuser";
            this.txt_loginuser.Size = new System.Drawing.Size(202, 20);
            this.txt_loginuser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME :";
            // 
            // btn_dbsil
            // 
            this.btn_dbsil.BackColor = System.Drawing.Color.Firebrick;
            this.btn_dbsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dbsil.Location = new System.Drawing.Point(194, 290);
            this.btn_dbsil.Name = "btn_dbsil";
            this.btn_dbsil.Size = new System.Drawing.Size(158, 37);
            this.btn_dbsil.TabIndex = 4;
            this.btn_dbsil.Text = "DB Sil";
            this.btn_dbsil.UseVisualStyleBackColor = false;
            this.btn_dbsil.Click += new System.EventHandler(this.btn_dbsil_Click);
            // 
            // btn_dbolustur
            // 
            this.btn_dbolustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_dbolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dbolustur.Location = new System.Drawing.Point(30, 292);
            this.btn_dbolustur.Name = "btn_dbolustur";
            this.btn_dbolustur.Size = new System.Drawing.Size(158, 35);
            this.btn_dbolustur.TabIndex = 3;
            this.btn_dbolustur.Text = "DB Oluştur";
            this.btn_dbolustur.UseVisualStyleBackColor = false;
            this.btn_dbolustur.Click += new System.EventHandler(this.btn_dbolustur_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(30, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÜRÜNLERİ LİSTELE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(383, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_dbsil);
            this.Controls.Add(this.btn_dbolustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_loginpass;
        private System.Windows.Forms.TextBox txt_loginuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dbsil;
        private System.Windows.Forms.Button btn_dbolustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

