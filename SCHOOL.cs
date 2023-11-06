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
using System.IO;

namespace projet_ecole
{
    public partial class SCHOOL : Form
    {
        public SCHOOL()
        {
            InitializeComponent();
        }

        private void phone_number_Click(object sender, EventArgs e) // reste vide
        {

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

        private void button1_Click(object sender, EventArgs e) //school
        {
            //reste vide
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

        private void add_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader Reader = new BinaryReader(Stream);
            images = Reader.ReadBytes((int) Stream.Length);
            conn.Open();
            string sql = string.Format("insert into Ecole values ("+textBox1.Text+ ",'" + textBox2.Text + "','" + textBox3.Text + "',@images," + textBox5.Text + ",'" + textBox6.Text + "','" + textBox7.Text + "'," + textBox8.Text + ")");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully saved", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void update_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader Reader = new BinaryReader(Stream);
            images = Reader.ReadBytes((int)Stream.Length);
            conn.Open();
            string sql = string.Format("update Ecole set nom_Ecole='" + textBox2.Text + "', adresse_Ecole='" + textBox3.Text + "', logo_Ecole=@images, Numero_telEcole=" + textBox5.Text + ", email_Ecole='" + textBox6.Text + "', site_web_Ecole='" + textBox7.Text + "', RIB_Ecole="+ textBox8.Text +" where ID_Ecole="+textBox1.Text+"");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully updated", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("delete Ecole where ID_Ecole=@ID");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully deleted", "information field", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void search_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("select * from Ecole where ID_Ecole=@ID");
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
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

        private void SCHOOL_Load(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            conn.Open();
            string sql = string.Format("select * from Ecole");
            SqlCommand cmd = new SqlCommand(sql, conn);
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
            string sql = string.Format("select * from Ecole");
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void the_logo_Click(object sender, EventArgs e)// reste vide
        {
            
        }
        
        
        string imgLocation = "";
        //SqlCommand cmd;
        private void Browse_Click(object sender, EventArgs e)
        {
            string DB = "Data Source=DESKTOP-SRGINA2;Initial Catalog=ecole;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DB);
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgLocation = OpenFileDialog1.FileName.ToString();
                the_logo.ImageLocation=imgLocation;
            }
        }
    }
}
