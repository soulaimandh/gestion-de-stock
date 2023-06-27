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
    public partial class produit : UserControl
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        BindingSource bsourse;
        public static produit instance;
        public produit()
        {
            InitializeComponent();
            instance = this;
        }

        private void produit_Load(object sender, EventArgs e)
        {
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = false;
            load_data();
        }
        public void load_data()
        {
            guna2DataGridView1.Rows.Clear();
            cmd = new MySqlCommand("SELECT produit.Reference,produit.Labelle,produit.prix_HT,produit.Qte_total,categorie.Labelle FROM produit,categorie WHERE produit.ID_Categorie=categorie.ID_Categorie;", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            cmd = new MySqlCommand("SELECT produit.Reference,produit.Labelle,produit.prix_HT,produit.Qte_total,categorie.Labelle FROM produit,categorie WHERE produit.ID_Categorie=categorie.ID_Categorie and produit.Labelle like '" + textBox1.Text + "%';", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Place Holder text...")
            {
                textBox1.Text = "";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Uproduit x = new Uproduit(this);
            x.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fproduit x = new Fproduit(this);
            x.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * FROM minip.PRODUIT", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            bsourse = new BindingSource();
            bsourse.DataSource = dt;
            guna2DataGridView1.DataSource = bsourse;
            adapter.Update(dt);
        }

        public void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ikd = guna2DataGridView1.Rows[e.RowIndex].Cells["Reference"].FormattedValue.ToString();
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
            cmd = new MySqlCommand("DELETE FROM produit WHERE Reference ='"+ label1.Text + "';", conn);
            cmd.ExecuteReader();
            conn.Close();
            load_data();
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = false;

            //MySqlConnection connk = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
            //MySqlCommand cmda = new MySqlCommand("SELECT * FROM minip.PRODUIT", conn);
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = cmda;
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //BindingSource bsourse = new BindingSource();
            //bsourse.DataSource = dt;
            //guna2DataGridView1.DataSource = bsourse;
            //adapter.Update(dt);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
        }
    }
}
