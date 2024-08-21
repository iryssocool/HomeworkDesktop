namespace Homework1
{
    partial class Frm60
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
            clbMonHoc = new CheckedListBox();
            SuspendLayout();
            // 
            // clbMonHoc
            // 
            clbMonHoc.FormattingEnabled = true;
            clbMonHoc.Items.AddRange(new object[] { "Mạng máy tính", "Lập trình mạng", "Cấu trúc dữ liệu", "Thể chất" });
            clbMonHoc.Location = new Point(106, 81);
            clbMonHoc.Name = "clbMonHoc";
            clbMonHoc.Size = new Size(180, 144);
            clbMonHoc.TabIndex = 0;
            clbMonHoc.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Frm60
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clbMonHoc);
            Name = "Frm60";
            Text = "Frm60";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox clbMonHoc;
    }
}