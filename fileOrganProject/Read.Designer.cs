namespace fileOrganProject
{
    partial class Read
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Read));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.courseName,
            this.courseInstructor,
            this.noOfStudents});
            this.dataGridView1.Location = new System.Drawing.Point(431, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(504, 555);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CourseID
            // 
            this.CourseID.HeaderText = "Course ID";
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            // 
            // courseName
            // 
            this.courseName.HeaderText = "Course Name";
            this.courseName.Name = "courseName";
            this.courseName.ReadOnly = true;
            // 
            // courseInstructor
            // 
            this.courseInstructor.HeaderText = "Course Instructor";
            this.courseInstructor.Name = "courseInstructor";
            this.courseInstructor.ReadOnly = true;
            // 
            // noOfStudents
            // 
            this.noOfStudents.HeaderText = "Number Of Students";
            this.noOfStudents.Name = "noOfStudents";
            this.noOfStudents.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 179);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Read";
            this.Text = "read";
            this.Load += new System.EventHandler(this.Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseInstructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}