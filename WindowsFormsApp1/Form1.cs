using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        BindingSource bsourse;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox4.PasswordChar = '*';            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * from admin WHERE username='" + guna2TextBox3.Text + "' AND password='" + guna2TextBox4.Text + "';", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                this.Hide();
                new Form2().Show();
                
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect, essayez à nouveau!");
            }
            //if (guna2TextBox3.Text == "" && guna2TextBox4.Text == "")
            //{
            //    new Form2().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("the user name or password you entered is incorrect, try again");
            //    guna2TextBox3.Clear();
            //    guna2TextBox4.Clear();
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
