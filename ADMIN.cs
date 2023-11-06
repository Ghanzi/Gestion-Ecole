using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_ecole
{
    public partial class ADMIN : Form
    {
        public ADMIN()
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

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            LOGIN LOGIN1 = new LOGIN();
            LOGIN1.Show();
            this.Hide();
        }

        private void add_simple_user_Click(object sender, EventArgs e)
        {
            ADD_SIMPLE_USER ADD_SIMPLE_USER1 = new ADD_SIMPLE_USER();
            ADD_SIMPLE_USER1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
