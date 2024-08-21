namespace Homework1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            cbbChonHinh = new ComboBox();
            pbHinhAnh = new PictureBox();
            imlDemo = new ImageList(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // cbbChonHinh
            // 
            cbbChonHinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChonHinh.FormattingEnabled = true;
            cbbChonHinh.Location = new Point(298, 30);
            cbbChonHinh.Name = "cbbChonHinh";
            cbbChonHinh.Size = new Size(258, 33);
            cbbChonHinh.TabIndex = 0;
            cbbChonHinh.SelectedIndexChanged += cbbChonHinh_SelectedIndexChanged;
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.BorderStyle = BorderStyle.Fixed3D;
            pbHinhAnh.Location = new Point(298, 97);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(256, 256);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinhAnh.TabIndex = 1;
            pbHinhAnh.TabStop = false;
            // 
            // imlDemo
            // 
            imlDemo.ColorDepth = ColorDepth.Depth8Bit;
            imlDemo.ImageStream = (ImageListStreamer)resources.GetObject("imlDemo.ImageStream");
            imlDemo.TransparentColor = Color.Transparent;
            imlDemo.Images.SetKeyName(0, "im1.jpg");
            imlDemo.Images.SetKeyName(1, "im2.jpg");
            imlDemo.Images.SetKeyName(2, "im3.jpg");
            imlDemo.Images.SetKeyName(3, "im4.jpg");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 38);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 2;
            label1.Text = "Chọn hình hiển thị";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pbHinhAnh);
            Controls.Add(cbbChonHinh);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbChonHinh;
        private PictureBox pbHinhAnh;
        private ImageList imlDemo;
        private Label label1;
    }
}