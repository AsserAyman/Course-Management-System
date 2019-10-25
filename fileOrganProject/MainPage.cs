using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using amrhany;

namespace fileOrganProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_login f1 = new admin_login();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Read f1 = new Read();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            For1 f1 = new For1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit f1 = new Edit();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

     
    }
}
