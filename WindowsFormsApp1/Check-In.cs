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
    public partial class Check_In : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");
        public Check_In()
        {
            InitializeComponent();
            FillCombo();
            DataGridUno();
        }
        int adult = 0;
        int child = 0;
        
      
        void FillCombo()
        {

            string query = "SELECT RoomType FROM RegisterRoomTable";
            SqlCommand cmddb = new SqlCommand(query, conn);
            SqlDataReader mreader;
            try
            {
                conn.Open();
                mreader = cmddb.ExecuteReader();
                while (mreader.Read())
                {
                    string SRType = mreader["RoomType"].ToString();
                    txtcombo1.Items.Add(SRType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        void DataGridUno()
        {
            SqlCommand comm = new SqlCommand("select * from CHECKIN", conn);
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            sda.Fill(dataset);
            checkingrid.DataSource = dataset.Tables[0];
            checkingrid.RowTemplate.Height = 20;
            checkingrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void button1_Click(object sender, EventArgs e)
        {
           

            string insertQuery = "INSERT INTO CHECKIN VALUES ('" + textBox2.Text.Trim() + "','"
               + txtcombo1.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + txtAdults.Text.Trim() + "','" + txtChildren.Text.Trim() + "','" + dateTimePicker1.Text + "','" +
               dateTimePicker2.Text + "','" + txtTotal.Text.Trim() + "');";
            
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            DataGridUno();

            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 mainform = new Form2();
            mainform.Show();
        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {
            /**
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT RoomID from RegisterRoomTable where RoomType =@RoomType", conn);
            cmd.Parameters.AddWithValue("@RoomType", int.Parse(txtRoomNumber.Text));
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                txtRoomNumber.Text = da.GetValue(0).ToString();

            }
            conn.Close();
    **/
        }

        private void txtcombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            string sqlQuery = "SELECT * FROM RegisterRoomTable WHERE RoomType = '" + txtcombo1.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, conn);
            conn.Open();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                string Tname = (string)dr["RoomID"].ToString();
                textBox1.Text = Tname;
               
            }
            conn.Close();

        }

        private void bttnSubAdult_Click(object sender, EventArgs e)
        {
            
            if(adult != 0)
            {
                adult--;
                txtAdults.Text = adult.ToString();
            }
            else
            {
                MessageBox.Show("cannot have below zero");
            }
        }

        private void bttnAddAdult_Click(object sender, EventArgs e)
        {
            adult++;
            txtAdults.Text = adult.ToString();

        }

        private void bttnAddChildren_Click(object sender, EventArgs e)
        {
            child++;
            txtChildren.Text = child.ToString();
        }

        private void bttnSubChildren_Click(object sender, EventArgs e)
        {
            if (child != 0)
            {
                child--;
                txtChildren.Text = child.ToString();
            }
            else
            {
                MessageBox.Show("cannot have below zero");
            }
        }
    }
}
