namespace Homework1
{
    partial class Frm52
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
            lbDanhsach = new ListBox();
            lbDanhsachChon = new ListBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // lbDanhsach
            // 
            lbDanhsach.FormattingEnabled = true;
            lbDanhsach.ItemHeight = 25;
            lbDanhsach.Items.AddRange(new object[] { "Neymar ", "Ronaldo ", "Messi" });
            lbDanhsach.Location = new Point(45, 44);
            lbDanhsach.Name = "lbDanhsach";
            lbDanhsach.SelectionMode = SelectionMode.MultiExtended;
            lbDanhsach.Size = new Size(252, 329);
            lbDanhsach.TabIndex = 0;
            // 
            // lbDanhsachChon
            // 
            lbDanhsachChon.FormattingEnabled = true;
            lbDanhsachChon.ItemHeight = 25;
            lbDanhsachChon.Location = new Point(487, 44);
            lbDanhsachChon.Name = "lbDanhsachChon";
            lbDanhsachChon.Size = new Size(252, 329);
            lbDanhsachChon.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(331, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Chọn";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 13);
            label1.Name = "label1";
            label1.Size = new Size(316, 25);
            label1.TabIndex = 2;
            label1.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 13);
            label2.Name = "label2";
            label2.Size = new Size(199, 25);
            label2.TabIndex = 2;
            label2.Text = "Danh sách sinh viên lớp";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(331, 209);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 34);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Frm52
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lbDanhsachChon);
            Controls.Add(lbDanhsach);
            Name = "Frm52";
            Text = "Frm52";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbDanhsach;
        private ListBox lbDanhsachChon;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Button btnRemove;
    }
}