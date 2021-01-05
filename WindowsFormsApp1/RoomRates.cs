using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class RoomRates : Form
    {
        public RoomRates()
        {
            InitializeComponent();
            listyview();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 mainform = new Form2();
            mainform.Show();
        }
        void listyview()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM RegisterRoomTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            DataTable dt;
            dt = ds.Tables["Table"];
            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                RRLV1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                RRLV1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                RRLV1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                RRLV1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }
        private void RoomRates_Load(object sender, EventArgs e)
        {
            RRLV1.GridLines = true;
            RRLV1.View = View.Details;

            RRLV1.Columns.Add("RoomID", 150);
            RRLV1.Columns.Add("RoomName", 150);
            RRLV1.Columns.Add("RoomType", 150);
            RRLV1.Columns.Add("RoomRate", 150);
        }

        private void RRLV1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
