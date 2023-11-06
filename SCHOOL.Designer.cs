namespace projet_ecole
{
    partial class SCHOOL
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
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_simple_user = new System.Windows.Forms.Button();
            this.professeur = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.RIB = new System.Windows.Forms.Label();
            this.website = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.the_logo = new System.Windows.Forms.PictureBox();
            this.Browse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.the_logo)).BeginInit();
            this.SuspendLayout();
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
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.add_simple_user);
            this.panel2.Controls.Add(this.professeur);
            this.panel2.Controls.Add(this.students);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.faculty);
            this.panel2.Controls.Add(this.classes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(146, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 97);
            this.panel2.TabIndex = 119;
            // 
            // add_simple_user
            // 
            this.add_simple_user.Location = new System.Drawing.Point(461, 50);
            this.add_simple_user.Name = "add_simple_user";
            this.add_simple_user.Size = new System.Drawing.Size(135, 41);
            this.add_simple_user.TabIndex = 29;
            this.add_simple_user.Text = "add simple user";
            this.add_simple_user.UseVisualStyleBackColor = true;
            this.add_simple_user.Click += new System.EventHandler(this.add_simple_user_Click);
            // 
            // professeur
            // 
            this.professeur.Location = new System.Drawing.Point(6, 3);
            this.professeur.Name = "professeur";
            this.professeur.Size = new System.Drawing.Size(135, 41);
            this.professeur.TabIndex = 23;
            this.professeur.Text = "professors";
            this.professeur.UseVisualStyleBackColor = true;
            this.professeur.Click += new System.EventHandler(this.professeur_Click);
            // 
            // students
            // 
            this.students.Location = new System.Drawing.Point(225, 3);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(135, 41);
            this.students.TabIndex = 26;
            this.students.Text = "students";
            this.students.UseVisualStyleBackColor = true;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "school";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // faculty
            // 
            this.faculty.Location = new System.Drawing.Point(225, 50);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(135, 41);
            this.faculty.TabIndex = 28;
            this.faculty.Text = "faculty";
            this.faculty.UseVisualStyleBackColor = true;
            this.faculty.Click += new System.EventHandler(this.faculty_Click);
            // 
            // classes
            // 
            this.classes.Location = new System.Drawing.Point(6, 50);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(135, 41);
            this.classes.TabIndex = 24;
            this.classes.Text = "classes";
            this.classes.UseVisualStyleBackColor = true;
            this.classes.Click += new System.EventHandler(this.classes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projet_ecole.Properties.Resources.img_154434;
            this.pictureBox2.Location = new System.Drawing.Point(152, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 116;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 115;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 157);
            this.dataGridView1.TabIndex = 114;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 310);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(119, 32);
            this.search.TabIndex = 113;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 231);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 32);
            this.update.TabIndex = 112;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(12, 269);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(119, 32);
            this.delete.TabIndex = 111;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Location = new System.Drawing.Point(711, 127);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(31, 13);
            this.Logo.TabIndex = 109;
            this.Logo.Text = "Logo";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(529, 127);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(38, 13);
            this.adress.TabIndex = 108;
            this.adress.Text = "adress";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(353, 127);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 107;
            this.name.Text = "name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 450);
            this.panel1.TabIndex = 105;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 190);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 32);
            this.add.TabIndex = 110;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(186, 127);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 106;
            this.ID.Text = "ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(495, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 126;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(152, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 20);
            this.textBox5.TabIndex = 125;
            // 
            // RIB
            // 
            this.RIB.AutoSize = true;
            this.RIB.Location = new System.Drawing.Point(711, 210);
            this.RIB.Name = "RIB";
            this.RIB.Size = new System.Drawing.Size(25, 13);
            this.RIB.TabIndex = 124;
            this.RIB.Text = "RIB";
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Location = new System.Drawing.Point(529, 210);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(43, 13);
            this.website.TabIndex = 123;
            this.website.Text = "website";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(351, 210);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(31, 13);
            this.email.TabIndex = 122;
            this.email.Text = "email";
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Location = new System.Drawing.Point(186, 210);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(42, 13);
            this.phone_number.TabIndex = 121;
            this.phone_number.Text = "number";
            this.phone_number.Click += new System.EventHandler(this.phone_number_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(321, 243);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 20);
            this.textBox6.TabIndex = 127;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(495, 243);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(111, 20);
            this.textBox7.TabIndex = 128;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(677, 243);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(111, 20);
            this.textBox8.TabIndex = 129;
            // 
            // the_logo
            // 
            this.the_logo.Location = new System.Drawing.Point(677, 148);
            this.the_logo.Name = "the_logo";
            this.the_logo.Size = new System.Drawing.Size(111, 59);
            this.the_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.the_logo.TabIndex = 130;
            this.the_logo.TabStop = false;
            this.the_logo.Click += new System.EventHandler(this.the_logo_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(613, 148);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(58, 59);
            this.Browse.TabIndex = 131;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // SCHOOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.the_logo);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.RIB);
            this.Controls.Add(this.website);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ID);
            this.Name = "SCHOOL";
            this.Text = "SCHOOL";
            this.Load += new System.EventHandler(this.SCHOOL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.the_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_simple_user;
        private System.Windows.Forms.Button professeur;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button faculty;
        private System.Windows.Forms.Button classes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label RIB;
        private System.Windows.Forms.Label website;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.PictureBox the_logo;
        private System.Windows.Forms.Button Browse;
    }
}