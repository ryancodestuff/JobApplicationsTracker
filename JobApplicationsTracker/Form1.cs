using JobApplicationsTracker.DataProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
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


//        INSERT INTO[dbo].[Job_Applications]
//        (
//    [Id],
//    [Title],
//    [Url],
//    [CompanyName],
//    [CvLocation],
//    [CoverLetterLocation],
//    [JobLocation],
//    [ApplicationDate],
//    [Deadline],
//    [InterviewDate],
//    [ContactPerson],
//    [ApplyMethod],
//    [FollowUpDate],
//    [JobDesc],
//    [SalaryRange],
//    [ApplicationStatus],
//    [Confidence],
//    [Notes]
//)
//VALUES
//(
//    1,                              -- Id
//    'Software Engineer',            -- Title
//    'https://example.com/job/123',  -- Url
//    'Tech Corp',                    -- CompanyName
//    'C:\\Resumes\\Resume.pdf',      -- CvLocation
//    'C:\\CoverLetters\\CoverLetter.pdf', -- CoverLetterLocation
//    'New York, NY',                 -- JobLocation
//    '2024-08-29 10:30:00',          -- ApplicationDate
//    '2024-09-15 23:59:59',          -- Deadline
//    '2024-09-20 09:00:00',          -- InterviewDate
//    'Jane Doe',                     -- ContactPerson
//    'Online',                       -- ApplyMethod
//    '2024-

        private void button2_Click(object sender, EventArgs e)
        {
            var codec = new Codec();
            var warningMessage = new StringBuilder();
            var queryFirstPart = new StringBuilder();
            var querySecondPart = new StringBuilder();



            if (!codec.ValidateGeneralText(textBox1.Text))
            {
                textBox1.Text = string.Empty;
                warningMessage.Append("Invalid/Empty Job Title \n");
            }
            if (!codec.ValidateURL(textBox2.Text))
            {
                textBox2.Text = string.Empty;
                warningMessage.Append("Invalid/Empty URL");
            }
            if(!codec.ValidateGeneralText(textBox3.Text))
            {
                textBox3.Text = string.Empty;
                warningMessage.Append("Invalid/Empty Company Name");
            }
            if(!codec.ValidateFileLocation(textBox4.Text))
            {
                textBox4.Text = string.Empty;
                warningMessage.Append("Invalid/Empty File Location");
            }
            if (!codec.ValidateGeneralText(textBox5.Text))
            {
                textBox3.Text = string.Empty;
                warningMessage.Append("Invalid/Empty Job Location");
            }

            DialogResult result = MessageBox.Show(
            warningMessage.ToString(),
            "Confirm Action",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            var title = textBox1.Text;
            var url = textBox2.Text;
            var company = textBox3.Text;
            var cvLocation = textBox4.Text;
            var jobLocation = textBox5.Text;
            var applicationDate = new DateTime((int)listBox3.SelectedItem, (int)listBox2.SelectedItem, (int)listBox1.SelectedItem);
            var deadLine = new DateTime((int)listBox6.SelectedItem, (int)listBox4.SelectedItem, (int)listBox5.SelectedItem);
            var interviewDate = new DateTime((int)listBox9.SelectedItem, (int)listBox7.SelectedItem, (int)listBox8.SelectedItem);
            var followUpDate = new DateTime((int)listBox12.SelectedItem, (int)listBox10.SelectedItem, (int)listBox11.SelectedItem);
            var contactPerson = textBox6.Text;
            var jobDesc = textBox9.Text;
            var salaryRange = int.Parse(textBox10.Text);
            var applicationMethod = textBox7.Text;
            var applicationStatus = checkedListBox1.SelectedItem;
            var confidence = (int)listBox14.SelectedItem;
            var notes = textBox8.Text;


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
            var dateTime = DateTime.Now;
            listBox3.SelectedIndex = dateTime.Year - 2000;
            listBox2.SelectedIndex = dateTime.Month - 1;
            listBox1.SelectedIndex = dateTime.Day - 1;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox4.SelectedIndex = 31;
            listBox5.SelectedIndex = 12;
            listBox6.SelectedIndex = 31;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox7.SelectedIndex = 31;
            listBox8.SelectedIndex = 12;
            listBox9.SelectedIndex = 31;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox10.SelectedIndex = 31;
            listBox11.SelectedIndex = 12;
            listBox12.SelectedIndex = 31;
        }
    }
}
