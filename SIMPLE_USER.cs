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
    public partial class SIMPLE_USER : Form
    {
        public SIMPLE_USER()
        {
            InitializeComponent();
        }

        private void faculty_Click(object sender, EventArgs e)
        {
            FACULTY FACULTY1 = new FACULTY();
            FACULTY1.Show();
            this.Hide();
        }

        private void classes_Click(object sender, EventArgs e)
        {
            CLASSES CLASSES1 = new CLASSES();
            CLASSES1.Show();
            this.Hide();
        }

        private void students_Click(object sender, EventArgs e)
        {
            STUDENTS STUDENTS1 = new STUDENTS();
            STUDENTS1.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void faculty_Click_1(object sender, EventArgs e)
        {
            FACULTY_SU FACULTY_SU1 = new FACULTY_SU();
            FACULTY_SU1.Show();
            this.Hide();
        }

        private void classes_Click_1(object sender, EventArgs e)
        {
            CLASSES_SU CLASSES_SU1 = new CLASSES_SU();
            CLASSES_SU1.Show();
            this.Hide();
        }

        private void students_Click_1(object sender, EventArgs e)
        {
            STUDENTS_SU STUDENTS_SU1 = new STUDENTS_SU();
            STUDENTS_SU1.Show();
            this.Hide();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            LOGIN LOGIN1 = new LOGIN();
            LOGIN1.Show();
            this.Hide();
        }
    }
}
