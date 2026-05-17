namespace HealthClub
{
    partial class Form1
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
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.grpBoxTypeofMemberhsip = new System.Windows.Forms.GroupBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkPersonalTrainer = new System.Windows.Forms.CheckBox();
            this.grpBoxOptions = new System.Windows.Forms.GroupBox();
            this.grpBoxMembershipLength = new System.Windows.Forms.GroupBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.lblNumberofMonths = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMonthlyFee = new System.Windows.Forms.TextBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxTypeofMemberhsip.SuspendLayout();
            this.grpBoxOptions.SuspendLayout();
            this.grpBoxMembershipLength.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(18, 27);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(150, 26);
            this.radAdult.TabIndex = 0;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(18, 53);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(177, 26);
            this.radChild.TabIndex = 1;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child (12 && under)";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(18, 79);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(93, 26);
            this.radStudent.TabIndex = 2;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(18, 105);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(142, 26);
            this.radSenior.TabIndex = 3;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior Citizen";
            this.radSenior.UseVisualStyleBackColor = true;
            // 
            // grpBoxTypeofMemberhsip
            // 
            this.grpBoxTypeofMemberhsip.Controls.Add(this.radSenior);
            this.grpBoxTypeofMemberhsip.Controls.Add(this.radStudent);
            this.grpBoxTypeofMemberhsip.Controls.Add(this.radChild);
            this.grpBoxTypeofMemberhsip.Controls.Add(this.radAdult);
            this.grpBoxTypeofMemberhsip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTypeofMemberhsip.Location = new System.Drawing.Point(41, 36);
            this.grpBoxTypeofMemberhsip.Name = "grpBoxTypeofMemberhsip";
            this.grpBoxTypeofMemberhsip.Size = new System.Drawing.Size(220, 175);
            this.grpBoxTypeofMemberhsip.TabIndex = 4;
            this.grpBoxTypeofMemberhsip.TabStop = false;
            this.grpBoxTypeofMemberhsip.Text = "Type of Membership";
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(27, 17);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(74, 26);
            this.chkYoga.TabIndex = 5;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(27, 43);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(85, 26);
            this.chkKarate.TabIndex = 6;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            // 
            // chkPersonalTrainer
            // 
            this.chkPersonalTrainer.AutoSize = true;
            this.chkPersonalTrainer.Location = new System.Drawing.Point(27, 69);
            this.chkPersonalTrainer.Name = "chkPersonalTrainer";
            this.chkPersonalTrainer.Size = new System.Drawing.Size(166, 26);
            this.chkPersonalTrainer.TabIndex = 7;
            this.chkPersonalTrainer.Text = "Personal Trainer";
            this.chkPersonalTrainer.UseVisualStyleBackColor = true;
            // 
            // grpBoxOptions
            // 
            this.grpBoxOptions.Controls.Add(this.chkPersonalTrainer);
            this.grpBoxOptions.Controls.Add(this.chkKarate);
            this.grpBoxOptions.Controls.Add(this.chkYoga);
            this.grpBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOptions.Location = new System.Drawing.Point(289, 24);
            this.grpBoxOptions.Name = "grpBoxOptions";
            this.grpBoxOptions.Size = new System.Drawing.Size(225, 155);
            this.grpBoxOptions.TabIndex = 8;
            this.grpBoxOptions.TabStop = false;
            this.grpBoxOptions.Text = "Options";
            // 
            // grpBoxMembershipLength
            // 
            this.grpBoxMembershipLength.Controls.Add(this.txtMonths);
            this.grpBoxMembershipLength.Controls.Add(this.lblNumberofMonths);
            this.grpBoxMembershipLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMembershipLength.Location = new System.Drawing.Point(45, 237);
            this.grpBoxMembershipLength.Name = "grpBoxMembershipLength";
            this.grpBoxMembershipLength.Size = new System.Drawing.Size(273, 117);
            this.grpBoxMembershipLength.TabIndex = 9;
            this.grpBoxMembershipLength.TabStop = false;
            this.grpBoxMembershipLength.Text = "Membership Length";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(37, 85);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(100, 28);
            this.txtMonths.TabIndex = 1;
            // 
            // lblNumberofMonths
            // 
            this.lblNumberofMonths.AutoSize = true;
            this.lblNumberofMonths.Location = new System.Drawing.Point(24, 41);
            this.lblNumberofMonths.Name = "lblNumberofMonths";
            this.lblNumberofMonths.Size = new System.Drawing.Size(239, 22);
            this.lblNumberofMonths.TabIndex = 0;
            this.lblNumberofMonths.Text = "Enter the Number of Months:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtMonthlyFee);
            this.groupBox1.Controls.Add(this.lblTotalFee);
            this.groupBox1.Controls.Add(this.lblMonthlyFee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(324, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 130);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memberhsip Fees";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(69, 64);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 28);
            this.txtTotal.TabIndex = 3;
            // 
            // txtMonthlyFee
            // 
            this.txtMonthlyFee.Location = new System.Drawing.Point(127, 27);
            this.txtMonthlyFee.Name = "txtMonthlyFee";
            this.txtMonthlyFee.Size = new System.Drawing.Size(100, 28);
            this.txtMonthlyFee.TabIndex = 2;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Location = new System.Drawing.Point(7, 64);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(56, 22);
            this.lblTotalFee.TabIndex = 1;
            this.lblTotalFee.Text = "Total:";
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.AutoSize = true;
            this.lblMonthlyFee.Location = new System.Drawing.Point(8, 31);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(113, 22);
            this.lblMonthlyFee.TabIndex = 0;
            this.lblMonthlyFee.Text = "Monthly Fee:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(38, 387);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 30);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(243, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(425, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxMembershipLength);
            this.Controls.Add(this.grpBoxOptions);
            this.Controls.Add(this.grpBoxTypeofMemberhsip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxTypeofMemberhsip.ResumeLayout(false);
            this.grpBoxTypeofMemberhsip.PerformLayout();
            this.grpBoxOptions.ResumeLayout(false);
            this.grpBoxOptions.PerformLayout();
            this.grpBoxMembershipLength.ResumeLayout(false);
            this.grpBoxMembershipLength.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.GroupBox grpBoxTypeofMemberhsip;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkPersonalTrainer;
        private System.Windows.Forms.GroupBox grpBoxOptions;
        private System.Windows.Forms.GroupBox grpBoxMembershipLength;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label lblNumberofMonths;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMonthlyFee;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblMonthlyFee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

