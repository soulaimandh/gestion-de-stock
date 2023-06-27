using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class commande : UserControl
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public commande()
        {
            InitializeComponent();
        }        
        private void commande_Load(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM minip.Commande", conn);
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //BindingSource bsourse = new BindingSource();
            //bsourse.DataSource = dt;
            //guna2DataGridView1.DataSource = bsourse;
            //adapter.Update(dt);
            load_data();
        }
        public void load_data()
        {
            guna2DataGridView1.Rows.Clear();
            cmd = new MySqlCommand("SELECT * FROM commande;", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                //Date x = row[2];
                //conn
                DateTime dt2 = Convert.ToDateTime(row[2]);
                guna2DataGridView1.Rows.Add(row[0], row[1], dt2.ToString("dd/MM/yyyy"), row[3], row[4], row[5]);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM minip.Commande where nom like'" + textBox1.Text + "%'", conn);
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //BindingSource bsourse = new BindingSource();
            //bsourse.DataSource = dt;
            //guna2DataGridView1.DataSource = bsourse;
            //adapter.Update(dt);

            guna2DataGridView1.Rows.Clear();
            cmd = new MySqlCommand("SELECT * FROM Commande where ID_Commande like'" + textBox1.Text + "%'", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                DateTime dt2 = Convert.ToDateTime(row[2]);
                guna2DataGridView1.Rows.Add(row[0], row[1], dt2.ToString("dd/MM/yyyy"), row[3], row[4], row[5]);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Place Holder text...")
            {
                textBox1.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fcommande x = new Fcommande(this);
            x.Show();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID_commande = guna2DataGridView1.Rows[e.RowIndex].Cells["ID_commande"].FormattedValue.ToString();
            string ID_client = guna2DataGridView1.Rows[e.RowIndex].Cells["ID_client"].FormattedValue.ToString();
            
            label1.Text = ID_commande.ToString();
            label2.Text = ID_client.ToString();
            guna2Button1.Enabled = true;
            guna2Button2.Enabled = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("DELETE FROM commande WHERE ID_Commande ='" + label1.Text + "';", conn);
            cmd.ExecuteReader();
            conn.Close();
            load_data();
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            details x = new details(this);
            x.Show();
            //cmd = new MySqlCommand("SELECT* FROM quantite WHERE ID_Commande = '"+label1.Text+"';", conn);
            //adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine(row[1]);
            //}
        }
    }
}
