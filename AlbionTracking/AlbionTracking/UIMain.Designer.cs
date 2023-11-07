namespace AlbionTracking
{
    partial class UIMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMain));
            btnSearch = new Button();
            cmbGroup = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            cBoxX4 = new CheckBox();
            cBoxX3 = new CheckBox();
            cBoxX2 = new CheckBox();
            cBoxX1 = new CheckBox();
            cBoxT8 = new CheckBox();
            cBoxT7 = new CheckBox();
            cBoxT6 = new CheckBox();
            cBoxT5 = new CheckBox();
            cBoxT4 = new CheckBox();
            cBoxT3 = new CheckBox();
            cBoxT2 = new CheckBox();
            groupBox2 = new GroupBox();
            cBoxBM = new CheckBox();
            cBoxC = new CheckBox();
            cBoxF = new CheckBox();
            cBoxM = new CheckBox();
            cBoxB = new CheckBox();
            cBoxL = new CheckBox();
            cBoxT = new CheckBox();
            cmbOrder = new ComboBox();
            label3 = new Label();
            cmbQuality = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            modelDataGridBindingSource = new BindingSource(components);
            gBoxLog = new GroupBox();
            listBoxLog = new ListBox();
            dataGridView = new DataGridView();
            gConfig = new GroupBox();
            label4 = new Label();
            cmbLenguage = new ComboBox();
            btnExportExcel = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modelDataGridBindingSource).BeginInit();
            gBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            gConfig.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LimeGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.Desktop;
            btnSearch.Location = new Point(6, 363);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(254, 45);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbGroup
            // 
            cmbGroup.FlatStyle = FlatStyle.Flat;
            cmbGroup.FormattingEnabled = true;
            cmbGroup.Location = new Point(6, 39);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Size = new Size(254, 23);
            cmbGroup.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.WindowText;
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cmbOrder);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbQuality);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbGroup);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 415);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cBoxX4);
            groupBox4.Controls.Add(cBoxX3);
            groupBox4.Controls.Add(cBoxX2);
            groupBox4.Controls.Add(cBoxX1);
            groupBox4.Controls.Add(cBoxT8);
            groupBox4.Controls.Add(cBoxT7);
            groupBox4.Controls.Add(cBoxT6);
            groupBox4.Controls.Add(cBoxT5);
            groupBox4.Controls.Add(cBoxT4);
            groupBox4.Controls.Add(cBoxT3);
            groupBox4.Controls.Add(cBoxT2);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Chartreuse;
            groupBox4.Location = new Point(139, 156);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(121, 201);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tier/Enchantment";
            // 
            // cBoxX4
            // 
            cBoxX4.AutoSize = true;
            cBoxX4.Checked = true;
            cBoxX4.CheckState = CheckState.Checked;
            cBoxX4.Location = new Point(77, 97);
            cBoxX4.Name = "cBoxX4";
            cBoxX4.Size = new Size(42, 19);
            cBoxX4.TabIndex = 10;
            cBoxX4.Text = "X.4";
            cBoxX4.UseVisualStyleBackColor = true;
            // 
            // cBoxX3
            // 
            cBoxX3.AutoSize = true;
            cBoxX3.Checked = true;
            cBoxX3.CheckState = CheckState.Checked;
            cBoxX3.Location = new Point(77, 72);
            cBoxX3.Name = "cBoxX3";
            cBoxX3.Size = new Size(42, 19);
            cBoxX3.TabIndex = 9;
            cBoxX3.Text = "X.3";
            cBoxX3.UseVisualStyleBackColor = true;
            // 
            // cBoxX2
            // 
            cBoxX2.AutoSize = true;
            cBoxX2.Checked = true;
            cBoxX2.CheckState = CheckState.Checked;
            cBoxX2.Location = new Point(77, 47);
            cBoxX2.Name = "cBoxX2";
            cBoxX2.Size = new Size(42, 19);
            cBoxX2.TabIndex = 8;
            cBoxX2.Text = "X.2";
            cBoxX2.UseVisualStyleBackColor = true;
            // 
            // cBoxX1
            // 
            cBoxX1.AutoSize = true;
            cBoxX1.Checked = true;
            cBoxX1.CheckState = CheckState.Checked;
            cBoxX1.Location = new Point(77, 22);
            cBoxX1.Name = "cBoxX1";
            cBoxX1.Size = new Size(42, 19);
            cBoxX1.TabIndex = 7;
            cBoxX1.Text = "X.1";
            cBoxX1.UseVisualStyleBackColor = true;
            // 
            // cBoxT8
            // 
            cBoxT8.AutoSize = true;
            cBoxT8.Checked = true;
            cBoxT8.CheckState = CheckState.Checked;
            cBoxT8.Location = new Point(6, 172);
            cBoxT8.Name = "cBoxT8";
            cBoxT8.Size = new Size(38, 19);
            cBoxT8.TabIndex = 6;
            cBoxT8.Text = "T8";
            cBoxT8.UseVisualStyleBackColor = true;
            // 
            // cBoxT7
            // 
            cBoxT7.AutoSize = true;
            cBoxT7.Checked = true;
            cBoxT7.CheckState = CheckState.Checked;
            cBoxT7.Location = new Point(6, 147);
            cBoxT7.Name = "cBoxT7";
            cBoxT7.Size = new Size(38, 19);
            cBoxT7.TabIndex = 5;
            cBoxT7.Text = "T7";
            cBoxT7.UseVisualStyleBackColor = true;
            // 
            // cBoxT6
            // 
            cBoxT6.AutoSize = true;
            cBoxT6.Checked = true;
            cBoxT6.CheckState = CheckState.Checked;
            cBoxT6.Location = new Point(6, 122);
            cBoxT6.Name = "cBoxT6";
            cBoxT6.Size = new Size(38, 19);
            cBoxT6.TabIndex = 4;
            cBoxT6.Text = "T6";
            cBoxT6.UseVisualStyleBackColor = true;
            // 
            // cBoxT5
            // 
            cBoxT5.AutoSize = true;
            cBoxT5.Checked = true;
            cBoxT5.CheckState = CheckState.Checked;
            cBoxT5.Location = new Point(6, 97);
            cBoxT5.Name = "cBoxT5";
            cBoxT5.Size = new Size(38, 19);
            cBoxT5.TabIndex = 3;
            cBoxT5.Text = "T5";
            cBoxT5.UseVisualStyleBackColor = true;
            // 
            // cBoxT4
            // 
            cBoxT4.AutoSize = true;
            cBoxT4.Checked = true;
            cBoxT4.CheckState = CheckState.Checked;
            cBoxT4.Location = new Point(6, 72);
            cBoxT4.Name = "cBoxT4";
            cBoxT4.Size = new Size(38, 19);
            cBoxT4.TabIndex = 2;
            cBoxT4.Text = "T4";
            cBoxT4.UseVisualStyleBackColor = true;
            // 
            // cBoxT3
            // 
            cBoxT3.AutoSize = true;
            cBoxT3.Checked = true;
            cBoxT3.CheckState = CheckState.Checked;
            cBoxT3.Location = new Point(6, 47);
            cBoxT3.Name = "cBoxT3";
            cBoxT3.Size = new Size(38, 19);
            cBoxT3.TabIndex = 1;
            cBoxT3.Text = "T3";
            cBoxT3.UseVisualStyleBackColor = true;
            // 
            // cBoxT2
            // 
            cBoxT2.AutoSize = true;
            cBoxT2.Checked = true;
            cBoxT2.CheckState = CheckState.Checked;
            cBoxT2.Location = new Point(6, 22);
            cBoxT2.Name = "cBoxT2";
            cBoxT2.Size = new Size(38, 19);
            cBoxT2.TabIndex = 0;
            cBoxT2.Text = "T2";
            cBoxT2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.MenuText;
            groupBox2.Controls.Add(cBoxBM);
            groupBox2.Controls.Add(cBoxC);
            groupBox2.Controls.Add(cBoxF);
            groupBox2.Controls.Add(cBoxM);
            groupBox2.Controls.Add(cBoxB);
            groupBox2.Controls.Add(cBoxL);
            groupBox2.Controls.Add(cBoxT);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Chocolate;
            groupBox2.Location = new Point(6, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(127, 201);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "City";
            // 
            // cBoxBM
            // 
            cBoxBM.AutoSize = true;
            cBoxBM.BackColor = Color.OrangeRed;
            cBoxBM.Checked = true;
            cBoxBM.CheckState = CheckState.Indeterminate;
            cBoxBM.Enabled = false;
            cBoxBM.ForeColor = SystemColors.Control;
            cBoxBM.Location = new Point(6, 172);
            cBoxBM.Name = "cBoxBM";
            cBoxBM.Size = new Size(94, 19);
            cBoxBM.TabIndex = 6;
            cBoxBM.Text = "Black Market";
            cBoxBM.UseVisualStyleBackColor = false;
            // 
            // cBoxC
            // 
            cBoxC.AutoSize = true;
            cBoxC.Checked = true;
            cBoxC.CheckState = CheckState.Checked;
            cBoxC.Location = new Point(6, 147);
            cBoxC.Name = "cBoxC";
            cBoxC.Size = new Size(73, 19);
            cBoxC.TabIndex = 5;
            cBoxC.Text = "Caerleon";
            cBoxC.UseVisualStyleBackColor = true;
            // 
            // cBoxF
            // 
            cBoxF.AutoSize = true;
            cBoxF.Checked = true;
            cBoxF.CheckState = CheckState.Checked;
            cBoxF.Location = new Point(6, 122);
            cBoxF.Name = "cBoxF";
            cBoxF.Size = new Size(87, 19);
            cBoxF.TabIndex = 4;
            cBoxF.Text = "FortSterling";
            cBoxF.UseVisualStyleBackColor = true;
            // 
            // cBoxM
            // 
            cBoxM.AutoSize = true;
            cBoxM.Checked = true;
            cBoxM.CheckState = CheckState.Checked;
            cBoxM.Location = new Point(6, 97);
            cBoxM.Name = "cBoxM";
            cBoxM.Size = new Size(73, 19);
            cBoxM.TabIndex = 3;
            cBoxM.Text = "Martlock";
            cBoxM.UseVisualStyleBackColor = true;
            // 
            // cBoxB
            // 
            cBoxB.AutoSize = true;
            cBoxB.Checked = true;
            cBoxB.CheckState = CheckState.Checked;
            cBoxB.Location = new Point(6, 72);
            cBoxB.Name = "cBoxB";
            cBoxB.Size = new Size(92, 19);
            cBoxB.TabIndex = 2;
            cBoxB.Text = "Bridgewatch";
            cBoxB.UseVisualStyleBackColor = true;
            // 
            // cBoxL
            // 
            cBoxL.AutoSize = true;
            cBoxL.Checked = true;
            cBoxL.CheckState = CheckState.Checked;
            cBoxL.Location = new Point(6, 47);
            cBoxL.Name = "cBoxL";
            cBoxL.Size = new Size(75, 19);
            cBoxL.TabIndex = 1;
            cBoxL.Text = "Lymhurst";
            cBoxL.UseVisualStyleBackColor = true;
            // 
            // cBoxT
            // 
            cBoxT.AutoSize = true;
            cBoxT.Checked = true;
            cBoxT.CheckState = CheckState.Checked;
            cBoxT.Location = new Point(6, 22);
            cBoxT.Name = "cBoxT";
            cBoxT.Size = new Size(71, 19);
            cBoxT.TabIndex = 0;
            cBoxT.Text = "Thetford";
            cBoxT.UseVisualStyleBackColor = true;
            // 
            // cmbOrder
            // 
            cmbOrder.FlatStyle = FlatStyle.Flat;
            cmbOrder.FormattingEnabled = true;
            cmbOrder.Location = new Point(6, 127);
            cmbOrder.Name = "cmbOrder";
            cmbOrder.Size = new Size(254, 23);
            cmbOrder.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Violet;
            label3.Location = new Point(3, 109);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Order by";
            // 
            // cmbQuality
            // 
            cmbQuality.FlatStyle = FlatStyle.Flat;
            cmbQuality.FormattingEnabled = true;
            cmbQuality.Location = new Point(6, 83);
            cmbQuality.Name = "cmbQuality";
            cmbQuality.Size = new Size(254, 23);
            cmbQuality.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Violet;
            label2.Location = new Point(3, 65);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Quality";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Violet;
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Group";
            // 
            // modelDataGridBindingSource
            // 
            modelDataGridBindingSource.DataSource = typeof(ModelDataGrid);
            // 
            // gBoxLog
            // 
            gBoxLog.Controls.Add(listBoxLog);
            gBoxLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gBoxLog.ForeColor = Color.CornflowerBlue;
            gBoxLog.Location = new Point(12, 433);
            gBoxLog.Name = "gBoxLog";
            gBoxLog.Size = new Size(984, 107);
            gBoxLog.TabIndex = 4;
            gBoxLog.TabStop = false;
            gBoxLog.Text = "LOG";
            // 
            // listBoxLog
            // 
            listBoxLog.BorderStyle = BorderStyle.None;
            listBoxLog.FormattingEnabled = true;
            listBoxLog.ItemHeight = 15;
            listBoxLog.Location = new Point(6, 22);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.ScrollAlwaysVisible = true;
            listBoxLog.Size = new Size(972, 75);
            listBoxLog.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ControlText;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(284, 19);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1179, 408);
            dataGridView.TabIndex = 5;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // gConfig
            // 
            gConfig.Controls.Add(label4);
            gConfig.Controls.Add(cmbLenguage);
            gConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gConfig.ForeColor = SystemColors.ControlLightLight;
            gConfig.Location = new Point(1002, 433);
            gConfig.Name = "gConfig";
            gConfig.Size = new Size(200, 107);
            gConfig.TabIndex = 6;
            gConfig.TabStop = false;
            gConfig.Text = "CONFIG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 1;
            label4.Text = "Lenguage";
            // 
            // cmbLenguage
            // 
            cmbLenguage.FormattingEnabled = true;
            cmbLenguage.Location = new Point(73, 22);
            cmbLenguage.Name = "cmbLenguage";
            cmbLenguage.Size = new Size(121, 23);
            cmbLenguage.TabIndex = 0;
            cmbLenguage.SelectedIndexChanged += cmbLenguage_SelectedIndexChanged;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.LimeGreen;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportExcel.ForeColor = SystemColors.Desktop;
            btnExportExcel.Location = new Point(1209, 440);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(254, 100);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "EXPORT HISTORY EXCEL";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // UIMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1475, 546);
            Controls.Add(btnExportExcel);
            Controls.Add(gConfig);
            Controls.Add(dataGridView);
            Controls.Add(gBoxLog);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UIMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Albion Tracking BlackMarket by Unsingned";
            Load += UIMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)modelDataGridBindingSource).EndInit();
            gBoxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            gConfig.ResumeLayout(false);
            gConfig.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private ComboBox cmbGroup;
        private GroupBox groupBox1;
        private ComboBox cmbQuality;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox cBoxF;
        private CheckBox cBoxM;
        private CheckBox cBoxB;
        private CheckBox cBoxL;
        private CheckBox cBoxT;
        private ComboBox cmbOrder;
        private Label label3;
        private GroupBox groupBox4;
        private CheckBox cBoxT8;
        private CheckBox cBoxT7;
        private CheckBox cBoxT6;
        private CheckBox cBoxT5;
        private CheckBox cBoxT4;
        private CheckBox cBoxT3;
        private CheckBox cBoxT2;
        private CheckBox cBoxC;
        private CheckBox cBoxBM;
        private CheckBox cBoxX4;
        private CheckBox cBoxX3;
        private CheckBox cBoxX2;
        private CheckBox cBoxX1;
        private GroupBox gBoxLog;
        private ListBox listBoxLog;
        private BindingSource modelDataGridBindingSource;
        private DataGridView dataGridView;
        private GroupBox gConfig;
        private Label label4;
        private ComboBox cmbLenguage;
        private Button btnExportExcel;
    }
}