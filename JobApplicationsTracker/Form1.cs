using JobApplicationsTracker.DataProcess;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JobApplicationsTracker
{
    public partial class Form1 : Form
    {
        Font SmallFont = new Font("Arial", 8);
        Font MediumFont = new Font("Arial", 10);
        Font LargeFont = new Font("Arial", 16, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codec = new Codec();
            if (!codec.ValidateTitle(textBox1.Text))
                textBox1.Text = string.Empty;
            if (!codec.ValidateURL(textBox2.Text))
                textBox2.Text = string.Empty;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
