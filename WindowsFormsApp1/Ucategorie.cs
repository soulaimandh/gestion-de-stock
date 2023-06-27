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
    public partial class Ucategorie : Form
    {
        categorie x;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmdda;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public Ucategorie(categorie x)
        {
            this.x = x;
            InitializeComponent();
        }

        private void Ucategorie_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmdda = new MySqlCommand("SELECT * FROM categorie WHERE ID_Categorie='" + x.label1.Text + "';", conn);
            MySqlDataReader sR = cmdda.ExecuteReader();
            if (sR.Read())
            {
                guna2TextBox1.Text = sR[0].ToString();
                guna2TextBox2.Text = sR[1].ToString();               
            }
            conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmdda = new MySqlCommand("UPDATE categorie SET Labelle='" + guna2TextBox2.Text + "' WHERE ID_Categorie='"+x.label1.Text+"';", conn);
            cmdda.ExecuteReader();
            conn.Close();
            this.Close();
            x.Load_categorie();
        }
    }
}
