namespace AlbionTracking
{
    partial class PopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));
            picBox = new PictureBox();
            txtAVGh = new Label();
            txtAVGhCount = new Label();
            txtAVGd = new Label();
            txtAVGdCount = new Label();
            txtName = new Label();
            button1 = new Button();
            groupBoxHour = new GroupBox();
            listHistoryHour = new ListBox();
            groupBoxDay = new GroupBox();
            listHistoryDay = new ListBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            groupBoxHour.SuspendLayout();
            groupBoxDay.SuspendLayout();
            SuspendLayout();
            // 
            // picBox
            // 
            picBox.Location = new Point(5, 12);
            picBox.Name = "picBox";
            picBox.Size = new Size(168, 113);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.TabIndex = 2;
            picBox.TabStop = false;
            // 
            // txtAVGh
            // 
            txtAVGh.AutoSize = true;
            txtAVGh.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAVGh.Location = new Point(5, 161);
            txtAVGh.Name = "txtAVGh";
            txtAVGh.Size = new Size(56, 15);
            txtAVGh.TabIndex = 3;
            txtAVGh.Text = "txtAVGh";
            // 
            // txtAVGhCount
            // 
            txtAVGhCount.AutoSize = true;
            txtAVGhCount.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAVGhCount.Location = new Point(5, 176);
            txtAVGhCount.Name = "txtAVGhCount";
            txtAVGhCount.Size = new Size(91, 15);
            txtAVGhCount.TabIndex = 4;
            txtAVGhCount.Text = "txtAVGhCount";
            // 
            // txtAVGd
            // 
            txtAVGd.AutoSize = true;
            txtAVGd.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAVGd.Location = new Point(5, 191);
            txtAVGd.Name = "txtAVGd";
            txtAVGd.Size = new Size(56, 15);
            txtAVGd.TabIndex = 5;
            txtAVGd.Text = "txtAVGd";
            // 
            // txtAVGdCount
            // 
            txtAVGdCount.AutoSize = true;
            txtAVGdCount.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAVGdCount.Location = new Point(5, 206);
            txtAVGdCount.Name = "txtAVGdCount";
            txtAVGdCount.Size = new Size(91, 15);
            txtAVGdCount.TabIndex = 6;
            txtAVGdCount.Text = "txtAVGdCount";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(5, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(31, 14);
            txtName.TabIndex = 7;
            txtName.Text = "Item";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(5, 226);
            button1.Name = "button1";
            button1.Size = new Size(168, 39);
            button1.TabIndex = 9;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBoxHour
            // 
            groupBoxHour.Controls.Add(listHistoryHour);
            groupBoxHour.Location = new Point(179, 4);
            groupBoxHour.Name = "groupBoxHour";
            groupBoxHour.Size = new Size(512, 122);
            groupBoxHour.TabIndex = 10;
            groupBoxHour.TabStop = false;
            groupBoxHour.Text = "History / Hours";
            // 
            // listHistoryHour
            // 
            listHistoryHour.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listHistoryHour.FormattingEnabled = true;
            listHistoryHour.ItemHeight = 14;
            listHistoryHour.Location = new Point(6, 22);
            listHistoryHour.Name = "listHistoryHour";
            listHistoryHour.Size = new Size(500, 88);
            listHistoryHour.TabIndex = 0;
            // 
            // groupBoxDay
            // 
            groupBoxDay.Controls.Add(listHistoryDay);
            groupBoxDay.Location = new Point(179, 143);
            groupBoxDay.Name = "groupBoxDay";
            groupBoxDay.Size = new Size(512, 122);
            groupBoxDay.TabIndex = 11;
            groupBoxDay.TabStop = false;
            groupBoxDay.Text = "History / Day";
            // 
            // listHistoryDay
            // 
            listHistoryDay.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listHistoryDay.FormattingEnabled = true;
            listHistoryDay.ItemHeight = 14;
            listHistoryDay.Location = new Point(6, 23);
            listHistoryDay.Name = "listHistoryDay";
            listHistoryDay.Size = new Size(500, 88);
            listHistoryDay.TabIndex = 0;
            // 
            // PopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(695, 266);
            Controls.Add(groupBoxDay);
            Controls.Add(groupBoxHour);
            Controls.Add(button1);
            Controls.Add(txtName);
            Controls.Add(txtAVGdCount);
            Controls.Add(txtAVGd);
            Controls.Add(txtAVGhCount);
            Controls.Add(txtAVGh);
            Controls.Add(picBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PopUp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BlackMarket History";
            Load += PopUp_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            groupBoxHour.ResumeLayout(false);
            groupBoxDay.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picBox;
        private Label txtAVGh;
        private Label txtAVGhCount;
        private Label txtAVGd;
        private Label txtAVGdCount;
        private Label txtName;
        private Button button1;
        private GroupBox groupBoxHour;
        private GroupBox groupBoxDay;
        private ListBox listHistoryHour;
        private ListBox listHistoryDay;
    }
}