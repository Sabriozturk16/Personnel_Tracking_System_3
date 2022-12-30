
namespace Personnel_Tracking_System_3
{
    partial class UserPage
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perBirtdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnel_TableDataSet3 = new Personnel_Tracking_System_3.Personnel_TableDataSet3();
            this.txtbox_position = new System.Windows.Forms.TextBox();
            this.txtbox_gender = new System.Windows.Forms.TextBox();
            this.txtbox_Surname = new System.Windows.Forms.TextBox();
            this.txtbox_Id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_off_surname = new System.Windows.Forms.TextBox();
            this.txt_off_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offDayTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnel_TableDataSet2 = new Personnel_Tracking_System_3.Personnel_TableDataSet2();
            this.off_Day_TableTableAdapter = new Personnel_Tracking_System_3.Personnel_TableDataSet2TableAdapters.Off_Day_TableTableAdapter();
            this.personnelTableAdapter = new Personnel_Tracking_System_3.Personnel_TableDataSet3TableAdapters.PersonnelTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offDayTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 186);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker2.TabIndex = 42;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(267, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 76);
            this.button5.TabIndex = 40;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(268, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 76);
            this.button4.TabIndex = 39;
            this.button4.Text = "List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(267, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 76);
            this.button1.TabIndex = 37;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.perNameDataGridViewTextBoxColumn1,
            this.perSurNameDataGridViewTextBoxColumn1,
            this.perBirtdayDataGridViewTextBoxColumn,
            this.perGenderDataGridViewTextBoxColumn,
            this.perStartTimeDataGridViewTextBoxColumn,
            this.perPositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personnelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 150);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            // 
            // perNameDataGridViewTextBoxColumn1
            // 
            this.perNameDataGridViewTextBoxColumn1.DataPropertyName = "Per_Name";
            this.perNameDataGridViewTextBoxColumn1.HeaderText = "Per_Name";
            this.perNameDataGridViewTextBoxColumn1.Name = "perNameDataGridViewTextBoxColumn1";
            // 
            // perSurNameDataGridViewTextBoxColumn1
            // 
            this.perSurNameDataGridViewTextBoxColumn1.DataPropertyName = "Per_SurName";
            this.perSurNameDataGridViewTextBoxColumn1.HeaderText = "Per_SurName";
            this.perSurNameDataGridViewTextBoxColumn1.Name = "perSurNameDataGridViewTextBoxColumn1";
            // 
            // perBirtdayDataGridViewTextBoxColumn
            // 
            this.perBirtdayDataGridViewTextBoxColumn.DataPropertyName = "Per_Birtday";
            this.perBirtdayDataGridViewTextBoxColumn.HeaderText = "Per_Birtday";
            this.perBirtdayDataGridViewTextBoxColumn.Name = "perBirtdayDataGridViewTextBoxColumn";
            // 
            // perGenderDataGridViewTextBoxColumn
            // 
            this.perGenderDataGridViewTextBoxColumn.DataPropertyName = "Per_Gender";
            this.perGenderDataGridViewTextBoxColumn.HeaderText = "Per_Gender";
            this.perGenderDataGridViewTextBoxColumn.Name = "perGenderDataGridViewTextBoxColumn";
            // 
            // perStartTimeDataGridViewTextBoxColumn
            // 
            this.perStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Per_Start_Time";
            this.perStartTimeDataGridViewTextBoxColumn.HeaderText = "Per_Start_Time";
            this.perStartTimeDataGridViewTextBoxColumn.Name = "perStartTimeDataGridViewTextBoxColumn";
            // 
            // perPositionDataGridViewTextBoxColumn
            // 
            this.perPositionDataGridViewTextBoxColumn.DataPropertyName = "Per_Position";
            this.perPositionDataGridViewTextBoxColumn.HeaderText = "Per_Position";
            this.perPositionDataGridViewTextBoxColumn.Name = "perPositionDataGridViewTextBoxColumn";
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "Personnel";
            this.personnelBindingSource.DataSource = this.personnel_TableDataSet3;
            // 
            // personnel_TableDataSet3
            // 
            this.personnel_TableDataSet3.DataSetName = "Personnel_TableDataSet3";
            this.personnel_TableDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbox_position
            // 
            this.txtbox_position.Location = new System.Drawing.Point(100, 219);
            this.txtbox_position.Name = "txtbox_position";
            this.txtbox_position.Size = new System.Drawing.Size(100, 20);
            this.txtbox_position.TabIndex = 35;
            // 
            // txtbox_gender
            // 
            this.txtbox_gender.Location = new System.Drawing.Point(100, 153);
            this.txtbox_gender.Name = "txtbox_gender";
            this.txtbox_gender.Size = new System.Drawing.Size(100, 20);
            this.txtbox_gender.TabIndex = 34;
            // 
            // txtbox_Surname
            // 
            this.txtbox_Surname.Location = new System.Drawing.Point(100, 84);
            this.txtbox_Surname.Name = "txtbox_Surname";
            this.txtbox_Surname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Surname.TabIndex = 33;
            // 
            // txtbox_Id
            // 
            this.txtbox_Id.Location = new System.Drawing.Point(100, 19);
            this.txtbox_Id.Name = "txtbox_Id";
            this.txtbox_Id.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Id.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Position :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Start Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Birthday :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Surname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(35, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "DATA";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(700, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 76);
            this.button2.TabIndex = 43;
            this.button2.Text = "Holiday Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txt_off_surname
            // 
            this.txt_off_surname.Location = new System.Drawing.Point(517, 54);
            this.txt_off_surname.Name = "txt_off_surname";
            this.txt_off_surname.Size = new System.Drawing.Size(100, 20);
            this.txt_off_surname.TabIndex = 47;
            // 
            // txt_off_name
            // 
            this.txt_off_name.Location = new System.Drawing.Point(517, 21);
            this.txt_off_name.Name = "txt_off_name";
            this.txt_off_name.Size = new System.Drawing.Size(100, 20);
            this.txt_off_name.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(429, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Surname :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(452, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Name :";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(517, 82);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker3.TabIndex = 49;
            this.dateTimePicker3.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(440, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Off Day :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perSurnameDataGridViewTextBoxColumn,
            this.offDayDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.offDayTableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(393, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(441, 150);
            this.dataGridView2.TabIndex = 50;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "Per_Name";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "Per_Name";
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            // 
            // perSurnameDataGridViewTextBoxColumn
            // 
            this.perSurnameDataGridViewTextBoxColumn.DataPropertyName = "Per_Surname";
            this.perSurnameDataGridViewTextBoxColumn.HeaderText = "Per_Surname";
            this.perSurnameDataGridViewTextBoxColumn.Name = "perSurnameDataGridViewTextBoxColumn";
            // 
            // offDayDataGridViewTextBoxColumn
            // 
            this.offDayDataGridViewTextBoxColumn.DataPropertyName = "Off_Day";
            this.offDayDataGridViewTextBoxColumn.HeaderText = "Off_Day";
            this.offDayDataGridViewTextBoxColumn.Name = "offDayDataGridViewTextBoxColumn";
            // 
            // offDayTableBindingSource
            // 
            this.offDayTableBindingSource.DataMember = "Off_Day_Table";
            this.offDayTableBindingSource.DataSource = this.personnel_TableDataSet2;
            // 
            // personnel_TableDataSet2
            // 
            this.personnel_TableDataSet2.DataSetName = "Personnel_TableDataSet2";
            this.personnel_TableDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // off_Day_TableTableAdapter
            // 
            this.off_Day_TableTableAdapter.ClearBeforeFill = true;
            // 
            // personnelTableAdapter
            // 
            this.personnelTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(700, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 53);
            this.button3.TabIndex = 51;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(100, 52);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Name.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Id :";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 503);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_off_surname);
            this.Controls.Add(this.txt_off_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbox_position);
            this.Controls.Add(this.txtbox_gender);
            this.Controls.Add(this.txtbox_Surname);
            this.Controls.Add(this.txtbox_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offDayTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbox_position;
        private System.Windows.Forms.TextBox txtbox_gender;
        private System.Windows.Forms.TextBox txtbox_Surname;
        private System.Windows.Forms.TextBox txtbox_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_off_surname;
        private System.Windows.Forms.TextBox txt_off_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Personnel_TableDataSet2 personnel_TableDataSet2;
        private System.Windows.Forms.BindingSource offDayTableBindingSource;
        private Personnel_TableDataSet2TableAdapters.Off_Day_TableTableAdapter off_Day_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offDayDataGridViewTextBoxColumn;
        private Personnel_TableDataSet3 personnel_TableDataSet3;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private Personnel_TableDataSet3TableAdapters.PersonnelTableAdapter personnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perBirtdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.Label label1;
    }
}