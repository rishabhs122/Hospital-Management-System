namespace HospitalMS
{
    partial class ForgetPass
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
            this.fpUser = new System.Windows.Forms.Label();
            this.fpp = new System.Windows.Forms.Label();
            this.fpPas = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btnSaveFP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fpUser
            // 
            this.fpUser.BackColor = System.Drawing.Color.Indigo;
            this.fpUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fpUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fpUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fpUser.Location = new System.Drawing.Point(120, 131);
            this.fpUser.Name = "fpUser";
            this.fpUser.Size = new System.Drawing.Size(164, 42);
            this.fpUser.TabIndex = 0;
            this.fpUser.Text = "Username";
            this.fpUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpp
            // 
            this.fpp.BackColor = System.Drawing.Color.Indigo;
            this.fpp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fpp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fpp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fpp.Location = new System.Drawing.Point(120, 226);
            this.fpp.Name = "fpp";
            this.fpp.Size = new System.Drawing.Size(164, 42);
            this.fpp.TabIndex = 1;
            this.fpp.Text = "New Password";
            this.fpp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpPas
            // 
            this.fpPas.BackColor = System.Drawing.Color.Indigo;
            this.fpPas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fpPas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fpPas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fpPas.Location = new System.Drawing.Point(120, 320);
            this.fpPas.Name = "fpPas";
            this.fpPas.Size = new System.Drawing.Size(164, 42);
            this.fpPas.TabIndex = 2;
            this.fpPas.Text = "Confirm PAssword";
            this.fpPas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(379, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(328, 42);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(379, 320);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(328, 42);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(379, 226);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(328, 42);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // btnSaveFP
            // 
            this.btnSaveFP.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveFP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveFP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveFP.Location = new System.Drawing.Point(476, 429);
            this.btnSaveFP.Name = "btnSaveFP";
            this.btnSaveFP.Size = new System.Drawing.Size(137, 45);
            this.btnSaveFP.TabIndex = 6;
            this.btnSaveFP.Text = "Save Password";
            this.btnSaveFP.UseVisualStyleBackColor = false;
            this.btnSaveFP.Click += new System.EventHandler(this.btnSaveFP_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(476, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalMS.Properties.Resources._4113098;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveFP);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fpPas);
            this.Controls.Add(this.fpp);
            this.Controls.Add(this.fpUser);
            this.DoubleBuffered = true;
            this.Name = "ForgetPass";
            this.Text = "ForgetPass";
            this.Load += new System.EventHandler(this.ForgetPass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label fpUser;
        private Label fpp;
        private Label fpPas;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button btnSaveFP;
        private Button button1;
    }
}