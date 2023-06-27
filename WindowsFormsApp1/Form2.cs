using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmdda;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
            instance = this;
            panelnav.Height = dashboardbtn.Height;
            panelnav.Top = dashboardbtn.Top;
            panelnav.Left = dashboardbtn.Left;
            dashboard1.BringToFront();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            avatar_load();
        }
        public void avatar_load()
        {
            conn.Open();
            cmdda = new MySqlCommand("SELECT * FROM admin;", conn);
            MySqlDataReader sR = cmdda.ExecuteReader();
            if (sR.Read())
            {
                guna2Button1.Text = sR[1].ToString();
                MemoryStream ms = new MemoryStream((byte[])sR[3]);
                guna2CirclePictureBox1.Image = Image.FromStream(ms);
            }
            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void clientbtn_Click_1(object sender, EventArgs e)
        {
            panelnav.Height = clientbtn.Height;
            panelnav.Top = clientbtn.Top;
            clientbtn.BackColor = Color.FromArgb(46, 51, 73);
            client2.BringToFront();
        }

        private void produitbtn_Click(object sender, EventArgs e)
        {
            panelnav.Height = produitbtn.Height;
            panelnav.Top = produitbtn.Top;
            produitbtn.BackColor = Color.FromArgb(46, 51, 73);
            produit2.BringToFront();
        }

        private void categoriebtn_Click(object sender, EventArgs e)
        {
            panelnav.Height = categoriebtn.Height;
            panelnav.Top = categoriebtn.Top;
            categoriebtn.BackColor = Color.FromArgb(46, 51, 73);
            categorie2.BringToFront();
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            panelnav.Height = settingsbtn.Height;
            panelnav.Top = settingsbtn.Top;
            settingsbtn.BackColor = Color.FromArgb(46, 51, 73);
            settings2.BringToFront();
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            panelnav.Height = dashboardbtn.Height;
            panelnav.Top = dashboardbtn.Top;
            panelnav.Left = dashboardbtn.Left;
            dashboardbtn.BackColor = Color.FromArgb(46, 51, 73);
            dashboard1.BringToFront();
        }

        private void dashboardbtn_Leave(object sender, EventArgs e)
        {
            dashboardbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void clientbtn_Leave(object sender, EventArgs e)
        {
            clientbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void produitbtn_Leave(object sender, EventArgs e)
        {
            produitbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void categoriebtn_Leave(object sender, EventArgs e)
        {
            categoriebtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void settingsbtn_Leave(object sender, EventArgs e)
        {
            settingsbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void produit1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard1_Load_2(object sender, EventArgs e)
        {

        }

        private void settings1_Load(object sender, EventArgs e)
        {

        }

        private void produit1_Load_1(object sender, EventArgs e)
        {

        }

        private void dashboard2_Load(object sender, EventArgs e)
        {

        }

        private void panelnav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categorie1_Load(object sender, EventArgs e)
        {

        }

        private void client1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void commandebtn_Leave(object sender, EventArgs e)
        {

            commandebtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void commandebtn_Click(object sender, EventArgs e)
        {
            panelnav.Height = commandebtn.Height;
            panelnav.Top = commandebtn.Top;
            panelnav.Left = commandebtn.Left;
            commandebtn.BackColor = Color.FromArgb(46, 51, 73);
            commande1.BringToFront();
        }
    }
}
