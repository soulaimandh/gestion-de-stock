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
    public partial class Fcommande : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        commande y;
        public Fcommande(commande y)
        {
            this.y = y;
            InitializeComponent();
            guna2DateTimePicker1.Value = DateTime.Now;
        }

        private void Fcommande_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT produit.Reference,produit.Labelle,produit.prix_HT,categorie.Labelle FROM produit,categorie WHERE produit.ID_Categorie=categorie.ID_Categorie;", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0], row[1], row[3], row[2]);
            }
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ikd = guna2DataGridView1.Rows[e.RowIndex].Cells["Réference"].FormattedValue.ToString();
            label12.Text = ikd.ToString();
            Cmd_produit x = new Cmd_produit(this);
            x.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Cmd_client x = new Cmd_client(this);
            x.Show();
        }

        private void guna2DataGridView3_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int S=0;
            foreach(DataGridViewRow row in guna2DataGridView3.Rows)
            {
                S +=  Convert.ToInt32(row.Cells[4].Value);
            }
            guna2TextBox6.Text = S.ToString();            
            float ttc = Convert.ToInt32(S) + Convert.ToInt32(S) * Convert.ToInt32(guna2TextBox7.Text)/100;
            ttc = ttc - Convert.ToInt32(ttc) * Convert.ToInt32(guna2TextBox5.Text) / 100;
            guna2TextBox8.Text = ttc.ToString();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(guna2DateTimePicker1.Value.ToString("yyyy-MM-dd"));
            conn.Open();
            try
            {
                cmd = new MySqlCommand("INSERT INTO Commande(ID_Client,Date,Remise,TVA,Totale) VALUES ('" + guna2TextBox1.Text + "', '" + guna2DateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + guna2TextBox5.Text + "','" + guna2TextBox7.Text + "','" + guna2TextBox8.Text + "')", conn);
                cmd.ExecuteNonQuery();
                y.load_data();
                cmd = new MySqlCommand("SELECT ID_Commande from commande ORDER BY ID_Commande DESC LIMIT 1;", conn);
                MySqlDataReader sR = cmd.ExecuteReader();
                int idc = 1;
                if (sR.Read())
                {
                    idc = Convert.ToInt32(sR[0]);
                }
                sR.Close();
                Console.WriteLine(idc);
                foreach (DataGridViewRow row in guna2DataGridView3.Rows)
                {
                    Console.WriteLine("INSERT INTO Quantite(ID_Commande,Reference,Qte_commande) VALUES ('" + idc.ToString() + "', '" + row.Cells[0].Value.ToString() + "', '" + row.Cells[2].Value.ToString() + "');");
                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO Quantite(ID_Commande,Reference,Qte_commande) VALUES ('" + idc.ToString() + "', '" + row.Cells[0].Value.ToString() + "', '" + row.Cells[2].Value.ToString()+ "');", conn);
                    
                    cmd1.ExecuteNonQuery();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Veuillez remplir tout les champs!","Erreur");
            }
            conn.Close();
        }
    }
}
