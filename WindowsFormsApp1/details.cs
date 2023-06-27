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
    public partial class details : Form
    {
        commande x;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public details(commande x)
        {
            this.x = x;
            InitializeComponent();
        }

        private void details_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT produit.Reference,produit.Labelle,produit.prix_HT,quantite.Qte_commande,produit.prix_HT*quantite.Qte_commande FROM quantite,produit,categorie WHERE produit.Reference=quantite.Reference AND produit.ID_Categorie=categorie.ID_Categorie AND quantite.ID_Commande='"+x.label1.Text+"';", conn);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            adapter.Fill(dt);            
            foreach (DataRow row in dt.Rows)
            {
                guna2DataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM client WHERE ID_Client='" + x.label2.Text + "';", conn);
            MySqlDataReader sR = cmd.ExecuteReader();
            if (sR.Read())
            {
                label2.Text = sR[0].ToString();
                label3.Text = sR[1].ToString();
                label5.Text = sR[2].ToString();
                label7.Text = sR[3].ToString();
                label9.Text = sR[4].ToString();
                label11.Text = sR[5].ToString();
            }
            sR.Close();
            MySqlCommand cmdd = new MySqlCommand("SELECT * FROM commande WHERE ID_Commande='" + x.label1.Text + "';", conn);
            MySqlDataReader sRr = cmdd.ExecuteReader();
            if (sRr.Read())
            {
                DateTime dt2 = Convert.ToDateTime(sRr[2]);
                label13.Text = sRr[0].ToString();
                label15.Text = dt2.ToString("dd/MM/yyyy");
                label17.Text = sRr[3].ToString()+"%";
                label19.Text = sRr[4].ToString() + "%";
                label21.Text = sRr[5].ToString()+" Dh";
            }
            conn.Close();
        }
    }
}
