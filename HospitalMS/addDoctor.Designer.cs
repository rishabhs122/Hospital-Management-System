namespace HospitalMS
{
    partial class addDoctor
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
            this.panelAddDoctor = new System.Windows.Forms.Panel();
            this.dType = new System.Windows.Forms.ComboBox();
            this.dMode = new System.Windows.Forms.ComboBox();
            this.dBlood = new System.Windows.Forms.ComboBox();
            this.dAddress = new System.Windows.Forms.TextBox();
            this.dContact = new System.Windows.Forms.TextBox();
            this.dName = new System.Windows.Forms.TextBox();
            this.dAge = new System.Windows.Forms.TextBox();
            this.dId = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dGender = new System.Windows.Forms.RadioButton();
            this.dExit = new System.Windows.Forms.Button();
            this.dSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dNam = new System.Windows.Forms.Label();
            this.dAg = new System.Windows.Forms.Label();
            this.dGende = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dI = new System.Windows.Forms.Label();
            this.panelAddDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(630, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Registration";
            // 
            // panelAddDoctor
            // 
            this.panelAddDoctor.BackColor = System.Drawing.Color.LightGray;
            this.panelAddDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddDoctor.Controls.Add(this.dType);
            this.panelAddDoctor.Controls.Add(this.dMode);
            this.panelAddDoctor.Controls.Add(this.dBlood);
            this.panelAddDoctor.Controls.Add(this.dAddress);
            this.panelAddDoctor.Controls.Add(this.dContact);
            this.panelAddDoctor.Controls.Add(this.dName);
            this.panelAddDoctor.Controls.Add(this.dAge);
            this.panelAddDoctor.Controls.Add(this.dId);
            this.panelAddDoctor.Controls.Add(this.radioButton1);
            this.panelAddDoctor.Controls.Add(this.radioButton2);
            this.panelAddDoctor.Controls.Add(this.dGender);
            this.panelAddDoctor.Controls.Add(this.dExit);
            this.panelAddDoctor.Controls.Add(this.dSave);
            this.panelAddDoctor.Controls.Add(this.label10);
            this.panelAddDoctor.Controls.Add(this.dNam);
            this.panelAddDoctor.Controls.Add(this.dAg);
            this.panelAddDoctor.Controls.Add(this.dGende);
            this.panelAddDoctor.Controls.Add(this.label6);
            this.panelAddDoctor.Controls.Add(this.label5);
            this.panelAddDoctor.Controls.Add(this.label4);
            this.panelAddDoctor.Controls.Add(this.label3);
            this.panelAddDoctor.Controls.Add(this.dI);
            this.panelAddDoctor.Location = new System.Drawing.Point(80, 74);
            this.panelAddDoctor.Name = "panelAddDoctor";
            this.panelAddDoctor.Size = new System.Drawing.Size(1282, 538);
            this.panelAddDoctor.TabIndex = 1;
            // 
            // dType
            // 
            this.dType.FormattingEnabled = true;
            this.dType.Items.AddRange(new object[] {
            "Cardiologist",
            "Dentist",
            "ENT specialist",
            "Psychiatrist",
            "Neurologist",
            "Physician",
            "Gynecologist",
            "Gastroenterologist",
            "Surgeon",
            "Urologist"});
            this.dType.Location = new System.Drawing.Point(860, 293);
            this.dType.Name = "dType";
            this.dType.Size = new System.Drawing.Size(274, 28);
            this.dType.TabIndex = 21;
            // 
            // dMode
            // 
            this.dMode.FormattingEnabled = true;
            this.dMode.Items.AddRange(new object[] {
            "Active"});
            this.dMode.Location = new System.Drawing.Point(860, 215);
            this.dMode.Name = "dMode";
            this.dMode.Size = new System.Drawing.Size(274, 28);
            this.dMode.TabIndex = 20;
            // 
            // dBlood
            // 
            this.dBlood.FormattingEnabled = true;
            this.dBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.dBlood.Location = new System.Drawing.Point(277, 293);
            this.dBlood.Name = "dBlood";
            this.dBlood.Size = new System.Drawing.Size(274, 28);
            this.dBlood.TabIndex = 19;
            // 
            // dAddress
            // 
            this.dAddress.Location = new System.Drawing.Point(277, 372);
            this.dAddress.Name = "dAddress";
            this.dAddress.Size = new System.Drawing.Size(857, 27);
            this.dAddress.TabIndex = 18;
            // 
            // dContact
            // 
            this.dContact.Location = new System.Drawing.Point(277, 215);
            this.dContact.Name = "dContact";
            this.dContact.Size = new System.Drawing.Size(274, 27);
            this.dContact.TabIndex = 17;
            // 
            // dName
            // 
            this.dName.Location = new System.Drawing.Point(860, 48);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(274, 27);
            this.dName.TabIndex = 16;
            // 
            // dAge
            // 
            this.dAge.Location = new System.Drawing.Point(277, 129);
            this.dAge.Name = "dAge";
            this.dAge.Size = new System.Drawing.Size(274, 27);
            this.dAge.TabIndex = 15;
            // 
            // dId
            // 
            this.dId.Location = new System.Drawing.Point(277, 48);
            this.dId.Name = "dId";
            this.dId.Size = new System.Drawing.Size(274, 27);
            this.dId.TabIndex = 14;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1061, 129);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Others";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(952, 129);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 24);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dGender
            // 
            this.dGender.AutoSize = true;
            this.dGender.Location = new System.Drawing.Point(860, 130);
            this.dGender.Name = "dGender";
            this.dGender.Size = new System.Drawing.Size(63, 24);
            this.dGender.TabIndex = 11;
            this.dGender.TabStop = true;
            this.dGender.Text = "Male";
            this.dGender.UseVisualStyleBackColor = true;
            this.dGender.CheckedChanged += new System.EventHandler(this.dGender_CheckedChanged);
            // 
            // dExit
            // 
            this.dExit.BackColor = System.Drawing.Color.OrangeRed;
            this.dExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dExit.Location = new System.Drawing.Point(673, 462);
            this.dExit.Name = "dExit";
            this.dExit.Size = new System.Drawing.Size(132, 39);
            this.dExit.TabIndex = 10;
            this.dExit.Text = "Exit";
            this.dExit.UseVisualStyleBackColor = false;
            this.dExit.Click += new System.EventHandler(this.dExit_Click);
            // 
            // dSave
            // 
            this.dSave.BackColor = System.Drawing.Color.ForestGreen;
            this.dSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dSave.Location = new System.Drawing.Point(410, 462);
            this.dSave.Name = "dSave";
            this.dSave.Size = new System.Drawing.Size(132, 39);
            this.dSave.TabIndex = 9;
            this.dSave.Text = "Save";
            this.dSave.UseVisualStyleBackColor = false;
            this.dSave.Click += new System.EventHandler(this.dSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(118, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Address";
            // 
            // dNam
            // 
            this.dNam.AutoSize = true;
            this.dNam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dNam.Location = new System.Drawing.Point(654, 51);
            this.dNam.Name = "dNam";
            this.dNam.Size = new System.Drawing.Size(51, 20);
            this.dNam.TabIndex = 7;
            this.dNam.Text = "Name";
            // 
            // dAg
            // 
            this.dAg.AutoSize = true;
            this.dAg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dAg.Location = new System.Drawing.Point(118, 134);
            this.dAg.Name = "dAg";
            this.dAg.Size = new System.Drawing.Size(37, 20);
            this.dAg.TabIndex = 6;
            this.dAg.Text = "Age";
            // 
            // dGende
            // 
            this.dGende.AutoSize = true;
            this.dGende.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dGende.Location = new System.Drawing.Point(654, 134);
            this.dGende.Name = "dGende";
            this.dGende.Size = new System.Drawing.Size(60, 20);
            this.dGende.TabIndex = 5;
            this.dGende.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(118, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(654, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(118, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Blood Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(654, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doctor Type";
            // 
            // dI
            // 
            this.dI.AutoSize = true;
            this.dI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dI.Location = new System.Drawing.Point(118, 51);
            this.dI.Name = "dI";
            this.dI.Size = new System.Drawing.Size(23, 20);
            this.dI.TabIndex = 0;
            this.dI.Text = "Id";
            // 
            // addDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1442, 683);
            this.Controls.Add(this.panelAddDoctor);
            this.Controls.Add(this.label1);
            this.Name = "addDoctor";
            this.Text = "addDoctor";
            this.Load += new System.EventHandler(this.addDoctor_Load);
            this.panelAddDoctor.ResumeLayout(false);
            this.panelAddDoctor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panelAddDoctor;
        private Label label10;
        private Label dNam;
        private Label dAg;
        private Label dGende;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label dI;
        private RadioButton radioButton2;
        private RadioButton dGender;
        private Button dExit;
        private Button dSave;
        private ComboBox dType;
        private ComboBox dMode;
        private ComboBox dBlood;
        private TextBox dAddress;
        private TextBox dContact;
        private TextBox dName;
        private TextBox dAge;
        private TextBox dId;
        private RadioButton radioButton1;
    }
}