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
    public partial class Fproduit : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        produit x;
        public Fproduit(produit x)
        {
            InitializeComponent();
            this.x = x;
        }

        private void Fproduit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("INSERT INTO minip.PRODUIT (Reference,Labelle, ID_Categorie, prix_HT,Qte_total) VALUES ('" + guna2TextBox1.Text + "', '" + guna2TextBox2.Text + "', '" + guna2TextBox3.Text + "','"+ guna2TextBox4.Text+ "','"+ guna2TextBox5.Text + "')", conn);
            cmd.ExecuteReader();
            conn.Close();
            x.load_data();
            this.Close();
        }
    }
}
