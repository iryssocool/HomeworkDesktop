namespace Homework1
{
    partial class Frm56
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
            groupBox1 = new GroupBox();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNu);
            groupBox1.Controls.Add(rbNam);
            groupBox1.Location = new Point(191, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới Tính";
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(27, 94);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(61, 29);
            rbNu.TabIndex = 0;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            rbNu.CheckedChanged += rbNu_CheckedChanged;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Checked = true;
            rbNam.Location = new Point(27, 42);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(75, 29);
            rbNam.TabIndex = 0;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            rbNam.CheckedChanged += rbNam_CheckedChanged;
            // 
            // Frm56
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 450);
            Controls.Add(groupBox1);
            Name = "Frm56";
            Text = "Frm56";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbNu;
        private RadioButton rbNam;
    }
}