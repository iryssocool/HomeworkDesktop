using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= imlDemo.Images.Count; i++)
            {
                cbbChonHinh.Items.Add("Hình " + i);
            }
        }

        private void cbbChonHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbHinhAnh.Image = imlDemo.Images[cbbChonHinh.SelectedIndex];
        }
    }
}
