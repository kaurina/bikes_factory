namespace MyBikesFactory.UI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManufacturingYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTyreType = new System.Windows.Forms.ComboBox();
            this.cbSuspensionType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOriginalSerialNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbMountain = new System.Windows.Forms.RadioButton();
            this.rbRoad = new System.Windows.Forms.RadioButton();
            this.lstBikes = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bike Type:";
            // 
            // cbBikeType
            // 
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Items.AddRange(new object[] {
            "Mountain",
            "Road"});
            this.cbBikeType.Location = new System.Drawing.Point(12, 32);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(175, 28);
            this.cbBikeType.TabIndex = 0;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(211, 32);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(138, 27);
            this.txtSerialNumber.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(383, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(151, 27);
            this.txtModel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manufacturing Year:";
            // 
            // txtManufacturingYear
            // 
            this.txtManufacturingYear.Location = new System.Drawing.Point(557, 32);
            this.txtManufacturingYear.Name = "txtManufacturingYear";
            this.txtManufacturingYear.Size = new System.Drawing.Size(164, 27);
            this.txtManufacturingYear.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color:";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Green"});
            this.cbColor.Location = new System.Drawing.Point(12, 108);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(175, 28);
            this.cbColor.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Suspension Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tyre Type:";
            // 
            // cbTyreType
            // 
            this.cbTyreType.FormattingEnabled = true;
            this.cbTyreType.Items.AddRange(new object[] {
            "Regular",
            "Commuter",
            "Gravel"});
            this.cbTyreType.Location = new System.Drawing.Point(383, 108);
            this.cbTyreType.Name = "cbTyreType";
            this.cbTyreType.Size = new System.Drawing.Size(151, 28);
            this.cbTyreType.TabIndex = 6;
            // 
            // cbSuspensionType
            // 
            this.cbSuspensionType.FormattingEnabled = true;
            this.cbSuspensionType.Items.AddRange(new object[] {
            "Front",
            "Rear",
            "Dual"});
            this.cbSuspensionType.Location = new System.Drawing.Point(211, 108);
            this.cbSuspensionType.Name = "cbSuspensionType";
            this.cbSuspensionType.Size = new System.Drawing.Size(138, 28);
            this.cbSuspensionType.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Original Serial Number:";
            // 
            // txtOriginalSerialNumber
            // 
            this.txtOriginalSerialNumber.Location = new System.Drawing.Point(557, 163);
            this.txtOriginalSerialNumber.Name = "txtOriginalSerialNumber";
            this.txtOriginalSerialNumber.Size = new System.Drawing.Size(164, 27);
            this.txtOriginalSerialNumber.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(337, 57);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(383, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(338, 57);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Display All, Mountain BIkes or Road Bikes:";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(330, 287);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(48, 24);
            this.rbAll.TabIndex = 10;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbMountain
            // 
            this.rbMountain.AutoSize = true;
            this.rbMountain.Location = new System.Drawing.Point(383, 287);
            this.rbMountain.Name = "rbMountain";
            this.rbMountain.Size = new System.Drawing.Size(93, 24);
            this.rbMountain.TabIndex = 11;
            this.rbMountain.Text = "Mountain";
            this.rbMountain.UseVisualStyleBackColor = true;
            this.rbMountain.CheckedChanged += new System.EventHandler(this.rbMountain_CheckedChanged);
            // 
            // rbRoad
            // 
            this.rbRoad.AutoSize = true;
            this.rbRoad.Location = new System.Drawing.Point(482, 287);
            this.rbRoad.Name = "rbRoad";
            this.rbRoad.Size = new System.Drawing.Size(65, 24);
            this.rbRoad.TabIndex = 12;
            this.rbRoad.Text = "Road";
            this.rbRoad.UseVisualStyleBackColor = true;
            this.rbRoad.CheckedChanged += new System.EventHandler(this.rbRoad_CheckedChanged);
            // 
            // lstBikes
            // 
            this.lstBikes.FormattingEnabled = true;
            this.lstBikes.ItemHeight = 20;
            this.lstBikes.Location = new System.Drawing.Point(12, 322);
            this.lstBikes.Name = "lstBikes";
            this.lstBikes.Size = new System.Drawing.Size(709, 84);
            this.lstBikes.TabIndex = 22;
            this.lstBikes.SelectedIndexChanged += new System.EventHandler(this.lstBikes_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 432);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(157, 72);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(182, 432);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 72);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Searc&h";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(371, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 72);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(557, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 72);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstBikes);
            this.Controls.Add(this.rbRoad);
            this.Controls.Add(this.rbMountain);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOriginalSerialNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSuspensionType);
            this.Controls.Add(this.cbTyreType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtManufacturingYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbBikeType;
        private Label label2;
        private Label label3;
        private TextBox txtSerialNumber;
        private TextBox txtModel;
        private Label label4;
        private TextBox txtManufacturingYear;
        private Label label5;
        private ComboBox cbColor;
        private Label label6;
        private Label label7;
        private ComboBox cbTyreType;
        private ComboBox cbSuspensionType;
        private Label label8;
        private TextBox txtOriginalSerialNumber;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label9;
        private RadioButton rbAll;
        private RadioButton rbMountain;
        private RadioButton rbRoad;
        private ListBox lstBikes;
        private Button btnRemove;
        private Button btnSearch;
        private Button btnSave;
        private Button btnExit;
    }
}