namespace projet_ecole
{
    partial class SIMPLE_USER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.students = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // students
            // 
            this.students.Location = new System.Drawing.Point(507, 27);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(135, 41);
            this.students.TabIndex = 26;
            this.students.Text = "students";
            this.students.UseVisualStyleBackColor = true;
            this.students.Click += new System.EventHandler(this.students_Click_1);
            // 
            // faculty
            // 
            this.faculty.Location = new System.Drawing.Point(6, 27);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(135, 41);
            this.faculty.TabIndex = 28;
            this.faculty.Text = "faculty";
            this.faculty.UseVisualStyleBackColor = true;
            this.faculty.Click += new System.EventHandler(this.faculty_Click_1);
            // 
            // classes
            // 
            this.classes.Location = new System.Drawing.Point(248, 27);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(135, 41);
            this.classes.TabIndex = 24;
            this.classes.Text = "classes";
            this.classes.UseVisualStyleBackColor = true;
            this.classes.Click += new System.EventHandler(this.classes_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.students);
            this.panel2.Controls.Add(this.faculty);
            this.panel2.Controls.Add(this.classes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(146, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 97);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 450);
            this.panel1.TabIndex = 33;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.IndianRed;
            this.exit.Location = new System.Drawing.Point(12, 381);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(119, 57);
            this.exit.TabIndex = 32;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projet_ecole.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projet_ecole.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(205, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(537, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // SIMPLE_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "SIMPLE_USER";
            this.Text = "SIMPLE_USER";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button faculty;
        private System.Windows.Forms.Button classes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}