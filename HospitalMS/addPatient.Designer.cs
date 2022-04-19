namespace HospitalMS
{
    partial class addPatient
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
            this.paneladdPatient = new System.Windows.Forms.Panel();
            this.pExit = new System.Windows.Forms.Button();
            this.pSave = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pMode = new System.Windows.Forms.ComboBox();
            this.pBlood = new System.Windows.Forms.ComboBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.pAge = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.TextBox();
            this.pSymptoms = new System.Windows.Forms.TextBox();
            this.pContact = new System.Windows.Forms.TextBox();
            this.pId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paneladdPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(631, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Registration";
            // 
            // paneladdPatient
            // 
            this.paneladdPatient.BackColor = System.Drawing.Color.LightGray;
            this.paneladdPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneladdPatient.Controls.Add(this.pExit);
            this.paneladdPatient.Controls.Add(this.pSave);
            this.paneladdPatient.Controls.Add(this.radioButton3);
            this.paneladdPatient.Controls.Add(this.radioButton2);
            this.paneladdPatient.Controls.Add(this.radioButton1);
            this.paneladdPatient.Controls.Add(this.pMode);
            this.paneladdPatient.Controls.Add(this.pBlood);
            this.paneladdPatient.Controls.Add(this.pName);
            this.paneladdPatient.Controls.Add(this.pAge);
            this.paneladdPatient.Controls.Add(this.pAddress);
            this.paneladdPatient.Controls.Add(this.pSymptoms);
            this.paneladdPatient.Controls.Add(this.pContact);
            this.paneladdPatient.Controls.Add(this.pId);
            this.paneladdPatient.Controls.Add(this.label10);
            this.paneladdPatient.Controls.Add(this.label9);
            this.paneladdPatient.Controls.Add(this.label8);
            this.paneladdPatient.Controls.Add(this.label7);
            this.paneladdPatient.Controls.Add(this.label6);
            this.paneladdPatient.Controls.Add(this.label5);
            this.paneladdPatient.Controls.Add(this.label4);
            this.paneladdPatient.Controls.Add(this.label3);
            this.paneladdPatient.Controls.Add(this.label2);
            this.paneladdPatient.Location = new System.Drawing.Point(81, 77);
            this.paneladdPatient.Name = "paneladdPatient";
            this.paneladdPatient.Size = new System.Drawing.Size(1273, 520);
            this.paneladdPatient.TabIndex = 1;
            // 
            // pExit
            // 
            this.pExit.BackColor = System.Drawing.Color.OrangeRed;
            this.pExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pExit.Location = new System.Drawing.Point(695, 422);
            this.pExit.Name = "pExit";
            this.pExit.Size = new System.Drawing.Size(133, 41);
            this.pExit.TabIndex = 21;
            this.pExit.Text = "Exit";
            this.pExit.UseVisualStyleBackColor = false;
            this.pExit.Click += new System.EventHandler(this.pExit_Click);
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.Color.ForestGreen;
            this.pSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pSave.Location = new System.Drawing.Point(458, 422);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(136, 41);
            this.pSave.TabIndex = 20;
            this.pSave.Text = "Save";
            this.pSave.UseVisualStyleBackColor = false;
            this.pSave.Click += new System.EventHandler(this.pSave_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1069, 111);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 24);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Others";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(949, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 24);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(843, 110);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pMode
            // 
            this.pMode.FormattingEnabled = true;
            this.pMode.Items.AddRange(new object[] {
            "Active"});
            this.pMode.Location = new System.Drawing.Point(843, 254);
            this.pMode.Name = "pMode";
            this.pMode.Size = new System.Drawing.Size(299, 28);
            this.pMode.TabIndex = 16;
            // 
            // pBlood
            // 
            this.pBlood.FormattingEnabled = true;
            this.pBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.pBlood.Location = new System.Drawing.Point(295, 254);
            this.pBlood.Name = "pBlood";
            this.pBlood.Size = new System.Drawing.Size(299, 28);
            this.pBlood.TabIndex = 15;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(843, 42);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(299, 27);
            this.pName.TabIndex = 14;
            // 
            // pAge
            // 
            this.pAge.Location = new System.Drawing.Point(295, 111);
            this.pAge.Name = "pAge";
            this.pAge.Size = new System.Drawing.Size(297, 27);
            this.pAge.TabIndex = 13;
            // 
            // pAddress
            // 
            this.pAddress.Location = new System.Drawing.Point(843, 177);
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(299, 27);
            this.pAddress.TabIndex = 12;
            // 
            // pSymptoms
            // 
            this.pSymptoms.Location = new System.Drawing.Point(295, 334);
            this.pSymptoms.Name = "pSymptoms";
            this.pSymptoms.Size = new System.Drawing.Size(847, 27);
            this.pSymptoms.TabIndex = 11;
            // 
            // pContact
            // 
            this.pContact.Location = new System.Drawing.Point(295, 177);
            this.pContact.Name = "pContact";
            this.pContact.Size = new System.Drawing.Size(297, 27);
            this.pContact.TabIndex = 10;
            // 
            // pId
            // 
            this.pId.Location = new System.Drawing.Point(295, 42);
            this.pId.Name = "pId";
            this.pId.Size = new System.Drawing.Size(297, 27);
            this.pId.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(140, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(140, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(140, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Blood Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(140, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Symptoms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(658, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(658, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(658, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(658, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(140, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // addPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1442, 683);
            this.Controls.Add(this.paneladdPatient);
            this.Controls.Add(this.label1);
            this.Name = "addPatient";
            this.Text = "addPatient";
            this.Load += new System.EventHandler(this.addPatient_Load);
            this.paneladdPatient.ResumeLayout(false);
            this.paneladdPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel paneladdPatient;
        private Button pExit;
        private Button pSave;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox pMode;
        private ComboBox pBlood;
        private TextBox pName;
        private TextBox pAge;
        private TextBox pAddress;
        private TextBox pSymptoms;
        private TextBox pContact;
        private TextBox pId;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}