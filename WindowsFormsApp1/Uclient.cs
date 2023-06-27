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
    public partial class Uclient : Form
    {
        client x;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmdda;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public Uclient(client x)
        {
            this.x = x;
            InitializeComponent();
        }

        private void Uclient_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmdda = new MySqlCommand("SELECT * FROM client WHERE ID_Client='" + x.label1.Text + "';", conn);
            MySqlDataReader sR = cmdda.ExecuteReader();
            if (sR.Read())
            {
                guna2TextBox1.Text = sR[1].ToString();
                guna2TextBox2.Text = sR[2].ToString();
                guna2TextBox3.Text = sR[3].ToString();
                guna2TextBox4.Text = sR[4].ToString();
                guna2TextBox5.Text = sR[5].ToString();
            }
            conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmdda = new MySqlCommand("UPDATE client SET Nom='" + guna2TextBox1.Text + "',Prenom='" + guna2TextBox2.Text + "',Adresse='" + guna2TextBox3.Text + "',Email='" + guna2TextBox4.Text + "',Telephone='"+ guna2TextBox5.Text+ "' WHERE ID_Client='" + x.label1.Text + "';", conn);           
            cmdda.ExecuteReader();
            conn.Close();
            this.Close();
            x.Load_client();
        }
    }
}
