namespace HospitalMS
{
    partial class dashboard
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
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddDoctor = new System.Windows.Forms.Panel();
            this.panelPatientlist = new System.Windows.Forms.Panel();
            this.panelViewdoctor = new System.Windows.Forms.Panel();
            this.btnexitviewdoctor = new System.Windows.Forms.Button();
            this.gridDoctorlist = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.btnPatientlist = new System.Windows.Forms.Button();
            this.gridViewPatient = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.dExit = new System.Windows.Forms.Button();
            this.dSave = new System.Windows.Forms.Button();
            this.dGender = new System.Windows.Forms.ComboBox();
            this.dBloodgroup = new System.Windows.Forms.ComboBox();
            this.dMode = new System.Windows.Forms.ComboBox();
            this.dType = new System.Windows.Forms.ComboBox();
            this.dName = new System.Windows.Forms.TextBox();
            this.dAddress = new System.Windows.Forms.TextBox();
            this.dContact = new System.Windows.Forms.TextBox();
            this.dAge = new System.Windows.Forms.TextBox();
            this.dId = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAPExit = new System.Windows.Forms.Button();
            this.btnAPSave = new System.Windows.Forms.Button();
            this.pMode = new System.Windows.Forms.ComboBox();
            this.pBloodgroup = new System.Windows.Forms.ComboBox();
            this.pGender = new System.Windows.Forms.RadioButton();
            this.pGenger = new System.Windows.Forms.RadioButton();
            this.pName = new System.Windows.Forms.TextBox();
            this.pAge = new System.Windows.Forms.TextBox();
            this.pContact = new System.Windows.Forms.TextBox();
            this.pSymptoms = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.TextBox();
            this.pId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panelPatientlist.SuspendLayout();
            this.panelViewdoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctorlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPatient.Location = new System.Drawing.Point(0, 168);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(195, 76);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddDoctor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDoctor.Location = new System.Drawing.Point(0, 243);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(195, 80);
            this.btnAddDoctor.TabIndex = 1;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = false;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnViewDoctor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewDoctor.Location = new System.Drawing.Point(0, 390);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(195, 73);
            this.btnViewDoctor.TabIndex = 2;
            this.btnViewDoctor.Text = "Doctors List";
            this.btnViewDoctor.UseVisualStyleBackColor = false;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click);
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.BackColor = System.Drawing.Color.DarkGreen;
            this.btnViewPatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewPatient.Location = new System.Drawing.Point(0, 320);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(195, 72);
            this.btnViewPatient.TabIndex = 3;
            this.btnViewPatient.Text = "Patients List";
            this.btnViewPatient.UseVisualStyleBackColor = false;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdatePatient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdatePatient.Location = new System.Drawing.Point(0, 463);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(195, 77);
            this.btnUpdatePatient.TabIndex = 4;
            this.btnUpdatePatient.Text = "Update Patient";
            this.btnUpdatePatient.UseVisualStyleBackColor = false;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateDoctor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateDoctor.Location = new System.Drawing.Point(0, 537);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(195, 74);
            this.btnUpdateDoctor.TabIndex = 5;
            this.btnUpdateDoctor.Text = "Update Doctor";
            this.btnUpdateDoctor.UseVisualStyleBackColor = false;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(0, 608);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(195, 75);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 172);
            this.label1.TabIndex = 7;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddDoctor
            // 
            this.panelAddDoctor.Location = new System.Drawing.Point(0, 0);
            this.panelAddDoctor.Name = "panelAddDoctor";
            this.panelAddDoctor.Size = new System.Drawing.Size(200, 100);
            this.panelAddDoctor.TabIndex = 0;
            // 
            // panelPatientlist
            // 
            this.panelPatientlist.Controls.Add(this.panelViewdoctor);
            this.panelPatientlist.Controls.Add(this.btnPatientlist);
            this.panelPatientlist.Controls.Add(this.gridViewPatient);
            this.panelPatientlist.Controls.Add(this.label22);
            this.panelPatientlist.Location = new System.Drawing.Point(798, 350);
            this.panelPatientlist.Name = "panelPatientlist";
            this.panelPatientlist.Size = new System.Drawing.Size(1442, 683);
            this.panelPatientlist.TabIndex = 21;
            // 
            // panelViewdoctor
            // 
            this.panelViewdoctor.Controls.Add(this.btnexitviewdoctor);
            this.panelViewdoctor.Controls.Add(this.gridDoctorlist);
            this.panelViewdoctor.Controls.Add(this.label23);
            this.panelViewdoctor.Location = new System.Drawing.Point(290, 139);
            this.panelViewdoctor.Name = "panelViewdoctor";
            this.panelViewdoctor.Size = new System.Drawing.Size(1442, 683);
            this.panelViewdoctor.TabIndex = 4;
            // 
            // btnexitviewdoctor
            // 
            this.btnexitviewdoctor.BackColor = System.Drawing.Color.OrangeRed;
            this.btnexitviewdoctor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexitviewdoctor.Location = new System.Drawing.Point(661, 604);
            this.btnexitviewdoctor.Name = "btnexitviewdoctor";
            this.btnexitviewdoctor.Size = new System.Drawing.Size(126, 40);
            this.btnexitviewdoctor.TabIndex = 2;
            this.btnexitviewdoctor.Text = "Exit";
            this.btnexitviewdoctor.UseVisualStyleBackColor = false;
            // 
            // gridDoctorlist
            // 
            this.gridDoctorlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDoctorlist.Location = new System.Drawing.Point(76, 79);
            this.gridDoctorlist.Name = "gridDoctorlist";
            this.gridDoctorlist.RowHeadersWidth = 51;
            this.gridDoctorlist.RowTemplate.Height = 29;
            this.gridDoctorlist.Size = new System.Drawing.Size(1287, 504);
            this.gridDoctorlist.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(671, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 28);
            this.label23.TabIndex = 0;
            this.label23.Text = "Doctor List";
            // 
            // btnPatientlist
            // 
            this.btnPatientlist.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPatientlist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPatientlist.Location = new System.Drawing.Point(645, 614);
            this.btnPatientlist.Name = "btnPatientlist";
            this.btnPatientlist.Size = new System.Drawing.Size(106, 39);
            this.btnPatientlist.TabIndex = 3;
            this.btnPatientlist.Text = "Exit";
            this.btnPatientlist.UseVisualStyleBackColor = false;
            // 
            // gridViewPatient
            // 
            this.gridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPatient.Location = new System.Drawing.Point(65, 88);
            this.gridViewPatient.Name = "gridViewPatient";
            this.gridViewPatient.RowHeadersWidth = 51;
            this.gridViewPatient.RowTemplate.Height = 29;
            this.gridViewPatient.Size = new System.Drawing.Size(1311, 510);
            this.gridViewPatient.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(653, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 28);
            this.label22.TabIndex = 0;
            this.label22.Text = "Patient List";
            // 
            // dExit
            // 
            this.dExit.Location = new System.Drawing.Point(0, 0);
            this.dExit.Name = "dExit";
            this.dExit.Size = new System.Drawing.Size(75, 23);
            this.dExit.TabIndex = 0;
            // 
            // dSave
            // 
            this.dSave.Location = new System.Drawing.Point(0, 0);
            this.dSave.Name = "dSave";
            this.dSave.Size = new System.Drawing.Size(75, 23);
            this.dSave.TabIndex = 0;
            // 
            // dGender
            // 
            this.dGender.Location = new System.Drawing.Point(0, 0);
            this.dGender.Name = "dGender";
            this.dGender.Size = new System.Drawing.Size(121, 28);
            this.dGender.TabIndex = 0;
            // 
            // dBloodgroup
            // 
            this.dBloodgroup.Location = new System.Drawing.Point(0, 0);
            this.dBloodgroup.Name = "dBloodgroup";
            this.dBloodgroup.Size = new System.Drawing.Size(121, 28);
            this.dBloodgroup.TabIndex = 0;
            // 
            // dMode
            // 
            this.dMode.Location = new System.Drawing.Point(0, 0);
            this.dMode.Name = "dMode";
            this.dMode.Size = new System.Drawing.Size(121, 28);
            this.dMode.TabIndex = 0;
            // 
            // dType
            // 
            this.dType.Location = new System.Drawing.Point(0, 0);
            this.dType.Name = "dType";
            this.dType.Size = new System.Drawing.Size(121, 28);
            this.dType.TabIndex = 0;
            // 
            // dName
            // 
            this.dName.Location = new System.Drawing.Point(0, 0);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(100, 27);
            this.dName.TabIndex = 0;
            // 
            // dAddress
            // 
            this.dAddress.Location = new System.Drawing.Point(0, 0);
            this.dAddress.Name = "dAddress";
            this.dAddress.Size = new System.Drawing.Size(100, 27);
            this.dAddress.TabIndex = 0;
            // 
            // dContact
            // 
            this.dContact.Location = new System.Drawing.Point(0, 0);
            this.dContact.Name = "dContact";
            this.dContact.Size = new System.Drawing.Size(100, 27);
            this.dContact.TabIndex = 0;
            // 
            // dAge
            // 
            this.dAge.Location = new System.Drawing.Point(0, 0);
            this.dAge.Name = "dAge";
            this.dAge.Size = new System.Drawing.Size(100, 27);
            this.dAge.TabIndex = 0;
            // 
            // dId
            // 
            this.dId.Location = new System.Drawing.Point(0, 0);
            this.dId.Name = "dId";
            this.dId.Size = new System.Drawing.Size(100, 27);
            this.dId.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // btnAPExit
            // 
            this.btnAPExit.Location = new System.Drawing.Point(0, 0);
            this.btnAPExit.Name = "btnAPExit";
            this.btnAPExit.Size = new System.Drawing.Size(75, 23);
            this.btnAPExit.TabIndex = 0;
            // 
            // btnAPSave
            // 
            this.btnAPSave.Location = new System.Drawing.Point(0, 0);
            this.btnAPSave.Name = "btnAPSave";
            this.btnAPSave.Size = new System.Drawing.Size(75, 23);
            this.btnAPSave.TabIndex = 0;
            // 
            // pMode
            // 
            this.pMode.Location = new System.Drawing.Point(0, 0);
            this.pMode.Name = "pMode";
            this.pMode.Size = new System.Drawing.Size(121, 28);
            this.pMode.TabIndex = 0;
            // 
            // pBloodgroup
            // 
            this.pBloodgroup.Location = new System.Drawing.Point(0, 0);
            this.pBloodgroup.Name = "pBloodgroup";
            this.pBloodgroup.Size = new System.Drawing.Size(121, 28);
            this.pBloodgroup.TabIndex = 0;
            // 
            // pGender
            // 
            this.pGender.Location = new System.Drawing.Point(0, 0);
            this.pGender.Name = "pGender";
            this.pGender.Size = new System.Drawing.Size(104, 24);
            this.pGender.TabIndex = 0;
            // 
            // pGenger
            // 
            this.pGenger.Location = new System.Drawing.Point(0, 0);
            this.pGenger.Name = "pGenger";
            this.pGenger.Size = new System.Drawing.Size(104, 24);
            this.pGenger.TabIndex = 0;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(0, 0);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(100, 27);
            this.pName.TabIndex = 0;
            // 
            // pAge
            // 
            this.pAge.Location = new System.Drawing.Point(0, 0);
            this.pAge.Name = "pAge";
            this.pAge.Size = new System.Drawing.Size(100, 27);
            this.pAge.TabIndex = 0;
            // 
            // pContact
            // 
            this.pContact.Location = new System.Drawing.Point(0, 0);
            this.pContact.Name = "pContact";
            this.pContact.Size = new System.Drawing.Size(100, 27);
            this.pContact.TabIndex = 0;
            // 
            // pSymptoms
            // 
            this.pSymptoms.Location = new System.Drawing.Point(0, 0);
            this.pSymptoms.Name = "pSymptoms";
            this.pSymptoms.Size = new System.Drawing.Size(100, 27);
            this.pSymptoms.TabIndex = 0;
            // 
            // pAddress
            // 
            this.pAddress.Location = new System.Drawing.Point(0, 0);
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(100, 27);
            this.pAddress.TabIndex = 0;
            // 
            // pId
            // 
            this.pId.Location = new System.Drawing.Point(0, 0);
            this.pId.Name = "pId";
            this.pId.Size = new System.Drawing.Size(100, 27);
            this.pId.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalMS.Properties.Resources._422429;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdateDoctor);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnViewPatient);
            this.Controls.Add(this.btnViewDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.btnAddPatient);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panelPatientlist.ResumeLayout(false);
            this.panelPatientlist.PerformLayout();
            this.panelViewdoctor.ResumeLayout(false);
            this.panelViewdoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctorlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddPatient;
        private Button btnAddDoctor;
        private Button btnViewDoctor;
        private Button btnViewPatient;
        private Button btnUpdatePatient;
        private Button btnUpdateDoctor;
        private Button btnLogout;
        private Label label1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAPExit;
        private Button btnAPSave;
        private ComboBox pMode;
        private ComboBox pBloodgroup;
        private RadioButton pGender;
        private RadioButton pGenger;
        private TextBox pName;
        private TextBox pAge;
        private TextBox pContact;
        private TextBox pSymptoms;
        private TextBox pAddress;
        private TextBox pId;
        private Panel panelAddDoctor;
        private TextBox dName;
        private TextBox dAddress;
        private TextBox dContact;
        private TextBox dAge;
        private TextBox dId;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox dBloodgroup;
        private ComboBox dMode;
        private ComboBox dType;
        private Button dExit;
        private Button dSave;
        private ComboBox dGender;
        private Panel panelPatientlist;
        private DataGridView gridViewPatient;
        private Label label22;
        private Button btnPatientlist;
        private Panel panelViewdoctor;
        private DataGridView gridDoctorlist;
        private Label label23;
        private Button btnexitviewdoctor;
        private RadioButton radioButton1;
    }
}