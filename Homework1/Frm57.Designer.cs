namespace Homework1
{
    partial class Frm57
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
            btnButton = new Button();
            btnFlat = new Button();
            ckbMauChu = new CheckBox();
            ckbMauNen = new CheckBox();
            rdPopup = new RadioButton();
            rdFlat = new RadioButton();
            SuspendLayout();
            // 
            // btnButton
            // 
            btnButton.Location = new Point(48, 124);
            btnButton.Name = "btnButton";
            btnButton.Size = new Size(112, 34);
            btnButton.TabIndex = 0;
            btnButton.Text = "Button";
            btnButton.UseVisualStyleBackColor = true;
            // 
            // btnFlat
            // 
            btnFlat.Location = new Point(48, 261);
            btnFlat.Name = "btnFlat";
            btnFlat.Size = new Size(112, 34);
            btnFlat.TabIndex = 0;
            btnFlat.Text = "ButtonFlat";
            btnFlat.UseVisualStyleBackColor = true;
            // 
            // ckbMauChu
            // 
            ckbMauChu.AutoSize = true;
            ckbMauChu.Checked = true;
            ckbMauChu.CheckState = CheckState.Checked;
            ckbMauChu.Location = new Point(318, 85);
            ckbMauChu.Name = "ckbMauChu";
            ckbMauChu.Size = new Size(180, 29);
            ckbMauChu.TabIndex = 1;
            ckbMauChu.Text = "Thay đổi màu chữ";
            ckbMauChu.UseVisualStyleBackColor = true;
            ckbMauChu.CheckedChanged += ckbMauChu_CheckedChanged;
            // 
            // ckbMauNen
            // 
            ckbMauNen.AutoSize = true;
            ckbMauNen.Location = new Point(318, 129);
            ckbMauNen.Name = "ckbMauNen";
            ckbMauNen.Size = new Size(180, 29);
            ckbMauNen.TabIndex = 1;
            ckbMauNen.Text = "Thay đổi màu nền";
            ckbMauNen.UseVisualStyleBackColor = true;
            ckbMauNen.CheckedChanged += ckbMauNen_CheckedChanged;
            // 
            // rdPopup
            // 
            rdPopup.AutoSize = true;
            rdPopup.Location = new Point(311, 261);
            rdPopup.Name = "rdPopup";
            rdPopup.Size = new Size(129, 29);
            rdPopup.TabIndex = 2;
            rdPopup.Text = "Kiểu PopUp";
            rdPopup.UseVisualStyleBackColor = true;
            // 
            // rdFlat
            // 
            rdFlat.AutoSize = true;
            rdFlat.Checked = true;
            rdFlat.Location = new Point(311, 217);
            rdFlat.Name = "rdFlat";
            rdFlat.Size = new Size(103, 29);
            rdFlat.TabIndex = 2;
            rdFlat.TabStop = true;
            rdFlat.Text = "Kiểu Flat";
            rdFlat.UseVisualStyleBackColor = true;
            rdFlat.CheckedChanged += rdFlat_CheckedChanged;
            // 
            // Frm57
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(rdFlat);
            Controls.Add(rdPopup);
            Controls.Add(ckbMauNen);
            Controls.Add(ckbMauChu);
            Controls.Add(btnFlat);
            Controls.Add(btnButton);
            Name = "Frm57";
            Text = "Frm57";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnButton;
        private Button btnFlat;
        private CheckBox ckbMauChu;
        private CheckBox ckbMauNen;
        private RadioButton rdPopup;
        private RadioButton rdFlat;
    }
}