
namespace Personnel_Tracking_System_3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perBirtdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personnel_TableDataSet1 = new Personnel_Tracking_System_3.Personnel_TableDataSet1();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnel_TableDataSet = new Personnel_Tracking_System_3.Personnel_TableDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.personnelTableAdapter = new Personnel_Tracking_System_3.Personnel_TableDataSetTableAdapters.PersonnelTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.personnelTableAdapter1 = new Personnel_Tracking_System_3.Personnel_TableDataSet1TableAdapters.PersonnelTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.personnel_TableDataSet4 = new Personnel_Tracking_System_3.Personnel_TableDataSet4();
            this.offDayTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.off_Day_TableTableAdapter = new Personnel_Tracking_System_3.Personnel_TableDataSet4TableAdapters.Off_Day_TableTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offDayTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Start Time :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Position :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(111, 158);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(111, 224);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.perNameDataGridViewTextBoxColumn,
            this.perSurNameDataGridViewTextBoxColumn,
            this.perBirtdayDataGridViewTextBoxColumn,
            this.perGenderDataGridViewTextBoxColumn,
            this.perStartTimeDataGridViewTextBoxColumn,
            this.perPositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personnelBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "Per_Name";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "Per_Name";
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            // 
            // perSurNameDataGridViewTextBoxColumn
            // 
            this.perSurNameDataGridViewTextBoxColumn.DataPropertyName = "Per_SurName";
            this.perSurNameDataGridViewTextBoxColumn.HeaderText = "Per_SurName";
            this.perSurNameDataGridViewTextBoxColumn.Name = "perSurNameDataGridViewTextBoxColumn";
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
            // personnelBindingSource1
            // 
            this.personnelBindingSource1.DataMember = "Personnel";
            this.personnelBindingSource1.DataSource = this.personnel_TableDataSet1;
            // 
            // personnel_TableDataSet1
            // 
            this.personnel_TableDataSet1.DataSetName = "Personnel_TableDataSet1";
            this.personnel_TableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "Personnel";
            this.personnelBindingSource.DataSource = this.personnel_TableDataSet;
            // 
            // personnel_TableDataSet
            // 
            this.personnel_TableDataSet.DataSetName = "Personnel_TableDataSet";
            this.personnel_TableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(282, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(282, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 55);
            this.button2.TabIndex = 18;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(822, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 79);
            this.button3.TabIndex = 19;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(282, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 55);
            this.button4.TabIndex = 20;
            this.button4.Text = "List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // personnelTableAdapter
            // 
            this.personnelTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(282, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 55);
            this.button5.TabIndex = 21;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(111, 191);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(74, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Id :";
            // 
            // personnelTableAdapter1
            // 
            this.personnelTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn1,
            this.perSurnameDataGridViewTextBoxColumn1,
            this.offDayDataGridViewTextBoxColumn,
            this.acceptDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.offDayTableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(407, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(549, 150);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // personnel_TableDataSet4
            // 
            this.personnel_TableDataSet4.DataSetName = "Personnel_TableDataSet4";
            this.personnel_TableDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offDayTableBindingSource
            // 
            this.offDayTableBindingSource.DataMember = "Off_Day_Table";
            this.offDayTableBindingSource.DataSource = this.personnel_TableDataSet4;
            // 
            // off_Day_TableTableAdapter
            // 
            this.off_Day_TableTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perNameDataGridViewTextBoxColumn1
            // 
            this.perNameDataGridViewTextBoxColumn1.DataPropertyName = "Per_Name";
            this.perNameDataGridViewTextBoxColumn1.HeaderText = "Per_Name";
            this.perNameDataGridViewTextBoxColumn1.Name = "perNameDataGridViewTextBoxColumn1";
            // 
            // perSurnameDataGridViewTextBoxColumn1
            // 
            this.perSurnameDataGridViewTextBoxColumn1.DataPropertyName = "Per_Surname";
            this.perSurnameDataGridViewTextBoxColumn1.HeaderText = "Per_Surname";
            this.perSurnameDataGridViewTextBoxColumn1.Name = "perSurnameDataGridViewTextBoxColumn1";
            // 
            // offDayDataGridViewTextBoxColumn
            // 
            this.offDayDataGridViewTextBoxColumn.DataPropertyName = "Off_Day";
            this.offDayDataGridViewTextBoxColumn.HeaderText = "Off_Day";
            this.offDayDataGridViewTextBoxColumn.Name = "offDayDataGridViewTextBoxColumn";
            // 
            // acceptDataGridViewCheckBoxColumn
            // 
            this.acceptDataGridViewCheckBoxColumn.DataPropertyName = "Accept";
            this.acceptDataGridViewCheckBoxColumn.HeaderText = "Accept";
            this.acceptDataGridViewCheckBoxColumn.Name = "acceptDataGridViewCheckBoxColumn";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(807, 370);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 53);
            this.button6.TabIndex = 52;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(426, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(403, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Surname :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(491, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 56;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(491, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(414, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Off Day :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(491, 248);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker3.TabIndex = 59;
            this.dateTimePicker3.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(683, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Select :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Lime;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(652, 195);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 24);
            this.radioButton1.TabIndex = 61;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(725, 195);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 24);
            this.radioButton2.TabIndex = 62;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(491, 169);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(454, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "Id :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(684, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "label14";
            this.label14.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_TableDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offDayTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Personnel_TableDataSet personnel_TableDataSet;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private Personnel_TableDataSetTableAdapters.PersonnelTableAdapter personnelTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private Personnel_TableDataSet1 personnel_TableDataSet1;
        private System.Windows.Forms.BindingSource personnelBindingSource1;
        private Personnel_TableDataSet1TableAdapters.PersonnelTableAdapter personnelTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perBirtdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Personnel_TableDataSet4 personnel_TableDataSet4;
        private System.Windows.Forms.BindingSource offDayTableBindingSource;
        private Personnel_TableDataSet4TableAdapters.Off_Day_TableTableAdapter off_Day_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn offDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

