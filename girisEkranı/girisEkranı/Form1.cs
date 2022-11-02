using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girisEkranı
{
    public partial class Form1 : Form
    {
        private string username;
        private string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = usernameTxt.Text;
            password = passwordTxt.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            }
            else if (username == "hafize" && password == "h123")
            {
                MessageBox.Show("Giriş işlemi başarılı");
            }
            else
                MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz!");
        }
    }
}
