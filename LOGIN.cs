using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projet_ecole
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("SELECT username,password,type FROM LOGIN", textBox1.Text, textBox2.Text);
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool test=false;
            while (reader.Read())
            {
                if (reader.GetString(0)==textBox1.Text && reader.GetString(1) == textBox2.Text)
                {
                    test = true;
                    if (reader.GetBoolean(2) == false)
                    {
                        ADMIN ADMIN1 = new ADMIN();
                        ADMIN1.Show();
                        this.Hide();
                    }
                    else
                    {
                        SIMPLE_USER SIMPLE_USER1 = new SIMPLE_USER();
                        SIMPLE_USER1.Show();
                        this.Hide();
                    }
                }
                
            }
            reader.Close();
            if (!test)
            {
                MessageBox.Show("erreur", "information field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
