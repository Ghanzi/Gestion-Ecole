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
    public partial class STUDENTS_SU : Form
    {
        public STUDENTS_SU()
        {
            InitializeComponent();
        }

        private void faculty_Click(object sender, EventArgs e)
        {
            FACULTY_SU FACULTY_SU1 = new FACULTY_SU();
            FACULTY_SU1.Show();
            this.Hide();
        }

        private void classes_Click(object sender, EventArgs e)
        {
            CLASSES_SU CLASSES_SU1 = new CLASSES_SU();
            CLASSES_SU1.Show();
            this.Hide();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            PAYMENT_STU_SU PAYMENT_STU_SU1 = new PAYMENT_STU_SU();
            PAYMENT_STU_SU1.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("insert into Etudiant values (@ID,@last_name,@first_name,@date_of_birth,@sex,@NIC)");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
            cmd.Parameters.AddWithValue("@first_name", textBox3.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", DateTime.Parse(dateTimePicker2.Text));
            cmd.Parameters.AddWithValue("@sex", textBox5.Text);
            cmd.Parameters.AddWithValue("@NIC", textBox6.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully saved", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("delete Etudiant where Num_Etd=@ID");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully deleted", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void update_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("update Etudiant set Nom_Etd=@last_name, Prenom_Etd=@first_name, Date_Naissance=@date_of_birth, Sexe=@sex, CIN=@NIC where Num_Etd=@ID");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
            cmd.Parameters.AddWithValue("@first_name", textBox3.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", DateTime.Parse(dateTimePicker2.Text));
            cmd.Parameters.AddWithValue("@sex", textBox5.Text);
            cmd.Parameters.AddWithValue("@NIC", textBox6.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully updated", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void search_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("select * from Etudiant where Num_Etd=@ID");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("select * from Etudiant");
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void STUDENTS_SU_Load(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("select * from Etudiant");
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            LOGIN LOGIN1 = new LOGIN();
            LOGIN1.Show();
            this.Hide();
        }
    }
}
