using KuisPertemuan14.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan14
{
    public partial class Form1 : Form
    {
        Admi admin = new Admi();
        public Form1()
        {
            admin = new Admi();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtEmail.Text=="")||(txtKataSandi.Text==""))
            {
                MessageBox.Show("Nedd login data ", "wrong login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string  email= txtEmail.Text;
                string kata_sandi = txtKataSandi.Text;
                DataTable dt = admin.getlist(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM admin Where email = '"+email+"'AND kata_sandi ='"+kata_sandi+"'"));
                /*if(dt.rows.Count>0)
                {
                    form2 dt = new form2();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Eror");
                }*/
            }
        }
    }
}
