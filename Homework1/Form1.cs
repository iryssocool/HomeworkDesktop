namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Đã chạy xong!!!");
                progressBar1.Value = progressBar1.Minimum;
                this.lblValue.Text = "0 %";
            }
            else
            {
                progressBar1.PerformStep();
                this.lblValue.Text = progressBar1.Value.ToString() + " %";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}