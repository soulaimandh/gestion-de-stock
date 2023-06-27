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
    public partial class categorie : UserControl
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmdda;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public categorie()
        {
            InitializeComponent();
        }

        private void categorie_Load(object sender, EventArgs e)
        {
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = false;
            Load_categorie();
        }
        public void Load_categorie()
        {
            guna2DataGridView1.Rows.Clear();
            cmdda = new MySqlCommand("SELECT * FROM categorie;", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmdda;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0], row[1]);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            cmdda = new MySqlCommand("SELECT * FROM minip.Categorie where labelle like'" + textBox1.Text + "%'", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmdda;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0], row[1]);
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
            Fcategorie x = new Fcategorie(this);
            x.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM minip.Categorie", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bsourse = new BindingSource();
            bsourse.DataSource = dt;
            guna2DataGridView1.DataSource = bsourse;
            adapter.Update(dt);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ikd = guna2DataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                label1.Text = ikd.ToString();
                guna2Button1.Enabled = true;
                guna2Button2.Enabled = true;
            }
            catch(Exception ex)
            {

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmdda = new MySqlCommand("DELETE FROM categorie WHERE ID_Categorie ='" + label1.Text + "';", conn);
            cmdda.ExecuteReader();
            conn.Close();
            Load_categorie();
            //produit kl = new produit();
            produit.instance.load_data();
            //kl.load_data();
            //kl.guna2DataGridView1.Rows.Clear();
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Ucategorie x = new Ucategorie(this);
            x.Show();
        }
    }
}
