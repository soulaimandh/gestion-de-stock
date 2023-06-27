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
    public partial class Fclient : Form
    {
        client x;
        public Fclient(client x)
        {
            this.x = x;
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO minip.CLIENT (Nom, Prenom, Adresse, Email, Telephone) VALUES ('" + guna2TextBox1.Text + "', '" + guna2TextBox2.Text + "', '" + guna2TextBox3.Text + "', '" + guna2TextBox4.Text + "','"+ guna2TextBox5.Text+ "')", conn);
            cmd.ExecuteReader();
            x.Load_client();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fclient_Load(object sender, EventArgs e)
        {

        }
    }
}
