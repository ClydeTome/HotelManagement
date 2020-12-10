﻿using System;
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
    public partial class RegisterRoom : Form
    {
        public RegisterRoom()
        {
            InitializeComponent();
            FillCombo();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");

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
                    regcb1.Items.Add(SRType);
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void RegisterRoom_Load(object sender, EventArgs e)
        {
            regview1.GridLines = true;
            regview1.View = View.Details;

            regview1.Columns.Add("RoomID", 150);
            regview1.Columns.Add("RoomName", 150);
            regview1.Columns.Add("RoomType", 150);
            regview1.Columns.Add("RoomRate", 150);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 mainform = new Form2();
            mainform.Show();
        }

        private void regbtn1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO RegisterRoomTable VALUES('" + regtxt1.Text.Trim() + "','" + regtxt2.Text.Trim() + "','" + regtxt3.Text.Trim() +
                "','"+regtxt4.Text+"');";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
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
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery ="TRUNCATE TABLE RegisterRoomTable;";
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
                    MessageBox.Show("All Data Deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            this.Dispose();
            RegisterRoom rg = new RegisterRoom();
            rg.Show();
        }

        private void regbtnref_Click(object sender, EventArgs e)
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
            for (i=0; i <=dt.Rows.Count-1;i++)
            {
                regview1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                regview1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                regview1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                regview1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }

        }
    }
}
