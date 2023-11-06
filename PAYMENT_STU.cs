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
    public partial class PAYMENT_STU : Form
    {
        public PAYMENT_STU()
        {
            InitializeComponent();
        }

        private void professeur_Click(object sender, EventArgs e)
        {
            PROFESSORS PROFESSORS1 = new PROFESSORS();
            PROFESSORS1.Show();
            this.Hide();
        }

        private void students_Click(object sender, EventArgs e)
        {
            STUDENTS STUDENTS1 = new STUDENTS();
            STUDENTS1.Show();
            this.Hide();
        }

        private void school_Click(object sender, EventArgs e)
        {
            SCHOOL SCHOOL1 = new SCHOOL();
            SCHOOL1.Show();
            this.Hide();
        }

        private void classes_Click(object sender, EventArgs e)
        {
            CLASSES CLASSES1 = new CLASSES();
            CLASSES1.Show();
            this.Hide();
        }

        private void faculty_Click(object sender, EventArgs e)
        {
            FACULTY FACULTY1 = new FACULTY();
            FACULTY1.Show();
            this.Hide();
        }

        private void add_simple_user_Click(object sender, EventArgs e)
        {
            ADD_SIMPLE_USER ADD_SIMPLE_USER1 = new ADD_SIMPLE_USER();
            ADD_SIMPLE_USER1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("select * from Reglement_Etd");
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("insert into Reglement_Etd values (@ID_PAY,@amount,@settlement_day,@ID_ETD)");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_PAY", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@amount", textBox2.Text);
            cmd.Parameters.AddWithValue("@settlement_day", DateTime.Parse(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@ID_ETD", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully saved", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("delete Reglement_Etd where id_reglement=@ID_PAY");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_PAY", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully deleted", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void update_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("update Reglement_Etd set Montant_regler=@amount, Date_reglement=@settlement_day, NumETD#=@ID_ETD where id_reglement=@ID_PAY");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_PAY", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@amount", textBox2.Text);
            cmd.Parameters.AddWithValue("@settlement_day", DateTime.Parse(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@ID_ETD", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully updated", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void search_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("select * from Reglement_Etd where NumETD#=@ID_ETD");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID_ETD", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void PAYMENT_STU_Load(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("select * from Reglement_Etd");
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
