using MySql.Data.MySqlClient;
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
    public partial class client : UserControl
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        BindingSource bsourse;
        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = false;
            Load_client();
           
            //MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM minip.CLIENT", conn);
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //BindingSource bsourse = new BindingSource();
            //bsourse.DataSource = dt;
            //guna2DataGridView1.DataSource = bsourse;
            //adapter.Update(dt);
        }
        public void Load_client()
        {
            guna2DataGridView1.Rows.Clear();
            cmd = new MySqlCommand("SELECT * FROM minip.CLIENT;", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4],row[5]);
            }
        }
        

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            cmd = new MySqlCommand("SELECT * FROM Client where nom like'" + textBox1.Text + "%'", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Place Holder text...")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fclient x = new Fclient(this);
            x.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Uclient x = new Uclient(this);
            x.Show();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ikd = guna2DataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
            label1.Text = ikd.ToString();
            guna2Button1.Enabled = true;
            guna2Button2.Enabled = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("DELETE FROM client WHERE ID_Client ='" + label1.Text + "';", conn);
            cmd.ExecuteReader();
            conn.Close();
            Load_client();
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = false;
        }
    }
}
