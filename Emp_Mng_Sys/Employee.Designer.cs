namespace Emp_Mng_Sys
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpPos = new System.Windows.Forms.ComboBox();
            this.EmpEdu = new System.Windows.Forms.ComboBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.EmpId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empEduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myEmployeeDbDataSet = new Emp_Mng_Sys.MyEmployeeDbDataSet();
            this.tableTableAdapter = new Emp_Mng_Sys.MyEmployeeDbDataSetTableAdapters.TableTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEmployeeDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(14, 14);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(134, 130);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpPos);
            this.panel1.Controls.Add(this.EmpEdu);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.EmpId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 553);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmpPos
            // 
            this.EmpPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpPos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPos.FormattingEnabled = true;
            this.EmpPos.Items.AddRange(new object[] {
            "Manager",
            "Senior Developer",
            "Junior Developer",
            "Accountant"});
            this.EmpPos.Location = new System.Drawing.Point(22, 264);
            this.EmpPos.Name = "EmpPos";
            this.EmpPos.Size = new System.Drawing.Size(191, 29);
            this.EmpPos.TabIndex = 19;
            this.EmpPos.SelectedIndexChanged += new System.EventHandler(this.EmpPos_SelectedIndexChanged);
            // 
            // EmpEdu
            // 
            this.EmpEdu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpEdu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpEdu.FormattingEnabled = true;
            this.EmpEdu.Items.AddRange(new object[] {
            "Bsc",
            "BTech",
            "BBA",
            "MBA",
            "MsC"});
            this.EmpEdu.Location = new System.Drawing.Point(326, 264);
            this.EmpEdu.Name = "EmpEdu";
            this.EmpEdu.Size = new System.Drawing.Size(191, 29);
            this.EmpEdu.TabIndex = 18;
            // 
            // EmpName
            // 
            this.EmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.Location = new System.Drawing.Point(326, 107);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(191, 28);
            this.EmpName.TabIndex = 17;
            this.EmpName.TextChanged += new System.EventHandler(this.EmpName_TextChanged);
            // 
            // EmpId
            // 
            this.EmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpId.Location = new System.Drawing.Point(22, 107);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(191, 28);
            this.EmpId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Education Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(232, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Employee Position";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(1);
            this.label5.Size = new System.Drawing.Size(207, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Employee Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Magenta;
            this.button4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(22, 383);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(1);
            this.button4.Size = new System.Drawing.Size(115, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Magenta;
            this.button3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(177, 383);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(1);
            this.button3.Size = new System.Drawing.Size(115, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(163, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Magenta;
            this.button2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(335, 383);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(1);
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(488, 383);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(1);
            this.button1.Size = new System.Drawing.Size(115, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(232, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Manage Employee";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmpDGV
            // 
            this.EmpDGV.AllowUserToAddRows = false;
            this.EmpDGV.AllowUserToDeleteRows = false;
            this.EmpDGV.AllowUserToOrderColumns = true;
            this.EmpDGV.AllowUserToResizeColumns = false;
            this.EmpDGV.AllowUserToResizeRows = false;
            this.EmpDGV.AutoGenerateColumns = false;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empEduDataGridViewTextBoxColumn,
            this.empPosDataGridViewTextBoxColumn});
            this.EmpDGV.DataSource = this.tableBindingSource;
            this.EmpDGV.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmpDGV.EnableHeadersVisualStyles = false;
            this.EmpDGV.Location = new System.Drawing.Point(622, 0);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersWidth = 51;
            this.EmpDGV.RowTemplate.Height = 24;
            this.EmpDGV.Size = new System.Drawing.Size(694, 723);
            this.EmpDGV.TabIndex = 12;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // empEduDataGridViewTextBoxColumn
            // 
            this.empEduDataGridViewTextBoxColumn.DataPropertyName = "EmpEdu";
            this.empEduDataGridViewTextBoxColumn.HeaderText = "EmpEdu";
            this.empEduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empEduDataGridViewTextBoxColumn.Name = "empEduDataGridViewTextBoxColumn";
            this.empEduDataGridViewTextBoxColumn.ReadOnly = true;
            this.empEduDataGridViewTextBoxColumn.Width = 125;
            // 
            // empPosDataGridViewTextBoxColumn
            // 
            this.empPosDataGridViewTextBoxColumn.DataPropertyName = "EmpPos";
            this.empPosDataGridViewTextBoxColumn.HeaderText = "EmpPos";
            this.empPosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empPosDataGridViewTextBoxColumn.Name = "empPosDataGridViewTextBoxColumn";
            this.empPosDataGridViewTextBoxColumn.ReadOnly = true;
            this.empPosDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.myEmployeeDbDataSet;
            // 
            // myEmployeeDbDataSet
            // 
            this.myEmployeeDbDataSet.DataSetName = "MyEmployeeDbDataSet";
            this.myEmployeeDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Magenta;
            this.button5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(545, 97);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(1);
            this.button5.Size = new System.Drawing.Size(71, 47);
            this.button5.TabIndex = 20;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1316, 723);
            this.Controls.Add(this.EmpDGV);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Employee_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEmployeeDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmpPos;
        private System.Windows.Forms.ComboBox EmpEdu;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.TextBox EmpId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView EmpDGV;
        private MyEmployeeDbDataSet myEmployeeDbDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private MyEmployeeDbDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empEduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}