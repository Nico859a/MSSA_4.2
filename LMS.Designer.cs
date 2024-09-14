namespace Assignment4._2
{
    partial class LMS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_StudentID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_GPA = new System.Windows.Forms.TextBox();
            this.label_StudentID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_GPA = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(395, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Location = new System.Drawing.Point(171, 169);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.Size = new System.Drawing.Size(100, 20);
            this.textBox_StudentID.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(171, 195);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_GPA
            // 
            this.textBox_GPA.Location = new System.Drawing.Point(171, 221);
            this.textBox_GPA.Name = "textBox_GPA";
            this.textBox_GPA.Size = new System.Drawing.Size(100, 20);
            this.textBox_GPA.TabIndex = 3;
            // 
            // label_StudentID
            // 
            this.label_StudentID.AutoSize = true;
            this.label_StudentID.Location = new System.Drawing.Point(106, 169);
            this.label_StudentID.Name = "label_StudentID";
            this.label_StudentID.Size = new System.Drawing.Size(58, 13);
            this.label_StudentID.TabIndex = 4;
            this.label_StudentID.Text = "Student ID";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(90, 198);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(75, 13);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Student Name";
            // 
            // label_GPA
            // 
            this.label_GPA.AutoSize = true;
            this.label_GPA.Location = new System.Drawing.Point(135, 224);
            this.label_GPA.Name = "label_GPA";
            this.label_GPA.Size = new System.Drawing.Size(29, 13);
            this.label_GPA.TabIndex = 6;
            this.label_GPA.Text = "GPA";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Student ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 83;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "GPA";
            this.Column3.Name = "Column3";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(148, 273);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(229, 273);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(78, 23);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // LMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label_GPA);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_StudentID);
            this.Controls.Add(this.textBox_GPA);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_StudentID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LMS";
            this.Text = "LMS";
            this.Load += new System.EventHandler(this.LMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_StudentID;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_GPA;
        private System.Windows.Forms.Label label_StudentID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
    }
}