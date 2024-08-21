namespace Homework1
{
    partial class Form3
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
            btnCancel = new System.Windows.Forms.Button();
            lblUser = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            btnOk = new System.Windows.Forms.Button();
            txtUser = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(463, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(112, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(78, 41);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(47, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(78, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(87, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(78, 195);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(102, 25);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // btnOk
            // 
            btnOk.Location = new System.Drawing.Point(190, 386);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(112, 34);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            txtUser.Location = new System.Drawing.Point(190, 41);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(185, 31);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(190, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(185, 31);
            txtPassword.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(78, 237);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(297, 121);
            textBox3.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(textBox3);
            this.Controls.Add(txtPassword);
            this.Controls.Add(txtUser);
            this.Controls.Add(lblDescription);
            this.Controls.Add(lblPassword);
            this.Controls.Add(lblUser);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Label lblUser;
        private Label lblPassword;
        private Label lblDescription;
        private Button btnOk;
        private TextBox txtUser;
        private TextBox txtPassword;
        private TextBox textBox3;
    }
}