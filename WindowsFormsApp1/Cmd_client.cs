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
    public partial class Cmd_client : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        BindingSource bsourse;
        Fcommande x;
        public Cmd_client(Fcommande x)
        {
            this.x = x;
            InitializeComponent();
        }

        private void Cmd_client_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT * FROM client;", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0],row[1], row[2], row[3], row[4], row[5]);
            }
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(guna2DataGridView1.Rows[e.RowIndex].Cells["ID_Client"].FormattedValue.ToString());
            //x.guna2TextBox1.Text = "d";
            x.guna2TextBox1.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["ID_Client"].FormattedValue.ToString();
            x.guna2TextBox2.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Nom"].FormattedValue.ToString();
            x.guna2TextBox9.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Prénom"].FormattedValue.ToString();
            x.guna2TextBox4.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            x.guna2TextBox10.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Adresse"].FormattedValue.ToString();
            x.guna2TextBox3.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Téléphone"].FormattedValue.ToString();
            this.Close();
        }
    }
}
