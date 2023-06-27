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
    public partial class Fcategorie : Form
    {
        categorie x;
        public Fcategorie(categorie x)
        {
            this.x = x;
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO minip.categorie (Labelle) VALUES ('" + Nombox.Text + "')", conn);
            cmd.ExecuteReader();
            x.Load_categorie();
            this.Close();
        }

        private void Fcategorie_Load(object sender, EventArgs e)
        {

        }
    }
}
