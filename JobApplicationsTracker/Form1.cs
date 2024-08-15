using StockDataApp.BackEnd.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplicationsTracker
{
    public partial class Form1 : Form
    {
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
            Connection obj = new Connection();
            obj.getDataSet("INSERT INTO [dbo].[Table] (Id, Name, Url, CVLocation, CoverLetterLocation, Status)\r\nVALUES (1, 'John Doe', 'http://example.com', 'C:\\\\CVs\\\\JohnDoe.pdf', 'C:\\\\CoverLetters\\\\JohnDoe.pdf', 1);\r\n");
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
