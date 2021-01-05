using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterRoom rg = new RegisterRoom();
            rg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Amedities amed = new Amedities();
            amed.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 login = new Form1();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomRates rr = new RoomRates();
            rr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult ex = MessageBox.Show("Are You Sure you want to Exit Application?","Warning",MessageBoxButtons.YesNo);
            if (ex == DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Check_In checkin = new Check_In();
            checkin.Show();
        }
    }
}
