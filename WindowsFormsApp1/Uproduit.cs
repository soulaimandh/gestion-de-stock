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
    public partial class Uproduit : Form
    {
        produit x;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmdda;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public Uproduit(produit x)

        {
            InitializeComponent();
            this.x = x;
        }

        private void Uproduit_Load(object sender, EventArgs e)
        {
            cmdda = new MySqlCommand("SELECT * FROM categorie;", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmdda;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2ComboBox1.Items.Add(row[0].ToString());
            }


            conn.Open();
            cmdda = new MySqlCommand("SELECT * FROM produit WHERE reference='" + x.label1.Text + "';", conn);
            MySqlDataReader sR = cmdda.ExecuteReader();
            if (sR.Read())
            {
                guna2TextBox1.Text = sR[0].ToString();
                guna2TextBox2.Text = sR[1].ToString();
                guna2ComboBox1.SelectedItem = sR[2].ToString();
                guna2TextBox3.Text = sR[3].ToString();
                guna2TextBox4.Text = sR[4].ToString();
            }           
            conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmdda = new MySqlCommand("UPDATE produit SET Labelle='"+ guna2TextBox2.Text + "',ID_Categorie='"+ guna2ComboBox1.SelectedItem.ToString() + "',prix_HT='"+ guna2TextBox3.Text + "',Qte_total='"+ guna2TextBox4.Text + "' WHERE reference='"+guna2TextBox1.Text+"';", conn);
            cmdda.ExecuteReader();
            conn.Close();
            this.Close();
            x.load_data();
        }
    }
}
