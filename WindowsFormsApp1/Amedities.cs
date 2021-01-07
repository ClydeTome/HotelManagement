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

namespace WindowsFormsApp1
{
    public partial class Amedities : Form
    {
        public Amedities()
        {
            InitializeComponent();
            ListyView();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 mainform = new Form2();
            mainform.Show();
        }
        void ListyView()
        {
        
            SqlCommand comm2 = new SqlCommand("select * from Amedities", conn);
            DataSet dataset2 = new DataSet();
            SqlDataAdapter sda2 = new SqlDataAdapter(comm2);
            sda2.Fill(dataset2);
            amedGrid1.DataSource = dataset2.Tables[0];
            amedGrid1.RowTemplate.Height = 25;
            amedGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
