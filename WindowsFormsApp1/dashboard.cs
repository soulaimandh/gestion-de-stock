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
    public partial class dashboard : UserControl
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=minip;UID=root;PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            load_dash();
        }
        public void load_dash()
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT SUM(Totale) FROM commande WHERE Date BETWEEN '" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd") + "'; ", conn);
            MySqlDataReader sR = cmd.ExecuteReader();
            if (sR.Read())
            {
                if (sR[0].ToString() == "")
                {
                    label5.Text = "0 Dh";
                }
                else
                {
                    label5.Text = sR[0].ToString() + " Dh";
                }
                
            }
            sR.Close();
            cmd = new MySqlCommand("SELECT count(Reference) from produit;", conn);
            sR = cmd.ExecuteReader();
            if (sR.Read())
            {
                if (sR[0].ToString() == "")
                {
                    label13.Text = "0";
                }
                else
                {
                    label13.Text = sR[0].ToString();
                }

            }
            conn.Close();
        }
    }
}
