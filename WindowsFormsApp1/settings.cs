using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class settings : UserControl
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmdda;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            load_settings();
        }
        public void load_settings()
        {
            conn.Open();
            cmdda = new MySqlCommand("SELECT * FROM admin;", conn);
            MySqlDataReader sR = cmdda.ExecuteReader();
            if (sR.Read())
            {
                guna2TextBox1.Text = sR[1].ToString();
                MemoryStream ms = new MemoryStream((byte[])sR[3]);
                guna2CirclePictureBox1.Image = Image.FromStream(ms);
            }
            conn.Close();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.Image = Image.FromFile(openFileDialog.FileName);                
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            MemoryStream ms = new MemoryStream();
            guna2CirclePictureBox1.Image.Save(ms, guna2CirclePictureBox1.Image.RawFormat);
            byte[] data = ms.ToArray();
            if (guna2TextBox3.Text == guna2TextBox4.Text)
            {
                conn.Open();
                cmdda = new MySqlCommand("UPDATE admin SET username=@username,password=@password,avatar=@data;", conn);
                cmdda.Parameters.Add("@username", MySqlDbType.Text);
                cmdda.Parameters.Add("@password", MySqlDbType.Text);
                cmdda.Parameters.Add("@data", MySqlDbType.Blob);
                cmdda.Parameters["@username"].Value = guna2TextBox1.Text;
                cmdda.Parameters["@password"].Value = guna2TextBox3.Text;
                cmdda.Parameters["@data"].Value = data;
                cmdda.ExecuteNonQuery();
                conn.Close();
                load_settings();
                Form2.instance.avatar_load();
            }
            else
            {
                MessageBox.Show("Le mot de passe et le mot de passe de confirmation doivent être identiques!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
