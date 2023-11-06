namespace projet_ecole
{
    partial class PAYMENT_STU_SU
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.exit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.ID_ETD = new System.Windows.Forms.Label();
            this.settlement_day = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_pay = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.students = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 120;
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
            this.search.Location = new System.Drawing.Point(677, 232);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 32);
            this.search.TabIndex = 113;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(494, 232);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 32);
            this.update.TabIndex = 112;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(677, 191);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 32);
            this.delete.TabIndex = 111;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ID_ETD
            // 
            this.ID_ETD.AutoSize = true;
            this.ID_ETD.Location = new System.Drawing.Point(346, 216);
            this.ID_ETD.Name = "ID_ETD";
            this.ID_ETD.Size = new System.Drawing.Size(46, 13);
            this.ID_ETD.TabIndex = 109;
            this.ID_ETD.Text = "ID_ETD";
            // 
            // settlement_day
            // 
            this.settlement_day.AutoSize = true;
            this.settlement_day.Location = new System.Drawing.Point(170, 216);
            this.settlement_day.Name = "settlement_day";
            this.settlement_day.Size = new System.Drawing.Size(75, 13);
            this.settlement_day.TabIndex = 108;
            this.settlement_day.Text = "settlement day";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(351, 127);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(42, 13);
            this.amount.TabIndex = 107;
            this.amount.Text = "amount";
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
            this.panel1.TabIndex = 105;
            // 
            // ID_pay
            // 
            this.ID_pay.AutoSize = true;
            this.ID_pay.Location = new System.Drawing.Point(186, 127);
            this.ID_pay.Name = "ID_pay";
            this.ID_pay.Size = new System.Drawing.Size(41, 13);
            this.ID_pay.TabIndex = 106;
            this.ID_pay.Text = "ID_pay";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(321, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 117;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(494, 191);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(111, 32);
            this.add.TabIndex = 110;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.panel2.Controls.Add(this.students);
            this.panel2.Controls.Add(this.faculty);
            this.panel2.Controls.Add(this.classes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(146, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 97);
            this.panel2.TabIndex = 121;
            // 
            // students
            // 
            this.students.Location = new System.Drawing.Point(507, 27);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(135, 41);
            this.students.TabIndex = 26;
            this.students.Text = "students";
            this.students.UseVisualStyleBackColor = true;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // faculty
            // 
            this.faculty.Location = new System.Drawing.Point(6, 27);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(135, 41);
            this.faculty.TabIndex = 28;
            this.faculty.Text = "faculty";
            this.faculty.UseVisualStyleBackColor = true;
            this.faculty.Click += new System.EventHandler(this.faculty_Click);
            // 
            // classes
            // 
            this.classes.Location = new System.Drawing.Point(248, 27);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(135, 41);
            this.classes.TabIndex = 24;
            this.classes.Text = "classes";
            this.classes.UseVisualStyleBackColor = true;
            this.classes.Click += new System.EventHandler(this.classes_Click);
            // 
            // PAYMENT_STU_SU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.ID_ETD);
            this.Controls.Add(this.settlement_day);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ID_pay);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.add);
            this.Name = "PAYMENT_STU_SU";
            this.Text = "PAYMENT_STU_SU";
            this.Load += new System.EventHandler(this.PAYMENT_STU_SU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label ID_ETD;
        private System.Windows.Forms.Label settlement_day;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ID_pay;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button faculty;
        private System.Windows.Forms.Button classes;
    }
}