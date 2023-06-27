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
    public partial class Cmd_produit : Form
    {
        Fcommande x;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Cmd_produit(Fcommande x)
        {
            this.x = x;
            InitializeComponent();
        }

        private void Cmd_produit_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM produit WHERE reference='" + x.label12.Text + "';", conn);
            MySqlDataReader sR = cmd.ExecuteReader();
            if (sR.Read())
            {
                label2.Text = sR[0].ToString();
                label4.Text = sR[1].ToString();
                label6.Text = sR[2].ToString();
                label8.Text = sR[3].ToString();
                label10.Text = sR[4].ToString();
            }
            conn.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //guna2TextBox2.Text = Convert.ToInt32(guna2TextBox1.Text).ToString() * Convert.ToInt32(label8.Text);
            Console.WriteLine(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(label8.Text);
                textBox2.Text = total.ToString();
            }
            catch (Exception ex) { }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            x.guna2DataGridView3.Rows.Add(label2.Text,label4.Text,textBox1.Text,label8.Text,textBox2.Text);
            int qtte = Convert.ToInt32(label10.Text) - Convert.ToInt32(textBox1.Text);
            conn.Open();
            cmd = new MySqlCommand("UPDATE produit SET Qte_total="+ qtte.ToString()+" WHERE reference='"+label2.Text+"';", conn);
            cmd.ExecuteReader();
            conn.Close();
            this.Close();
        }
    }
}
