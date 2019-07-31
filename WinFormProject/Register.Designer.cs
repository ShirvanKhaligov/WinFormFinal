namespace WinFormProject
{
    partial class Register
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
            this.txtRgsRptPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrgssurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrgsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtpaswwordRegister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRgsEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRgsRptPassword
            // 
            this.txtRgsRptPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgsRptPassword.Location = new System.Drawing.Point(106, 317);
            this.txtRgsRptPassword.Name = "txtRgsRptPassword";
            this.txtRgsRptPassword.Size = new System.Drawing.Size(165, 24);
            this.txtRgsRptPassword.TabIndex = 27;
            this.txtRgsRptPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Repeat Password";
            // 
            // txtrgssurname
            // 
            this.txtrgssurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrgssurname.Location = new System.Drawing.Point(106, 204);
            this.txtrgssurname.Name = "txtrgssurname";
            this.txtrgssurname.Size = new System.Drawing.Size(165, 24);
            this.txtrgssurname.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Surname";
            // 
            // txtrgsName
            // 
            this.txtrgsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrgsName.Location = new System.Drawing.Point(106, 148);
            this.txtrgsName.Name = "txtrgsName";
            this.txtrgsName.Size = new System.Drawing.Size(165, 24);
            this.txtrgsName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(145, 367);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtpaswwordRegister
            // 
            this.txtpaswwordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaswwordRegister.Location = new System.Drawing.Point(106, 263);
            this.txtpaswwordRegister.Name = "txtpaswwordRegister";
            this.txtpaswwordRegister.Size = new System.Drawing.Size(165, 24);
            this.txtpaswwordRegister.TabIndex = 20;
            this.txtpaswwordRegister.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // txtRgsEmail
            // 
            this.txtRgsEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgsEmail.Location = new System.Drawing.Point(106, 95);
            this.txtRgsEmail.Name = "txtRgsEmail";
            this.txtRgsEmail.Size = new System.Drawing.Size(165, 24);
            this.txtRgsEmail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "User Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 442);
            this.Controls.Add(this.txtRgsRptPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtrgssurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtrgsName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtpaswwordRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRgsEmail);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRgsRptPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrgssurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrgsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtpaswwordRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRgsEmail;
        private System.Windows.Forms.Label label1;
    }
}