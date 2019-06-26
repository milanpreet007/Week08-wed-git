using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week08_wed_git
{
    public partial class Lab8Form : Form
    {
        /// <summary>
        /// this is the constructor for the lab8 form
        /// </summary>
        public string username { get; set; }
        public float userAge { get; set; }
        public Lab8Form()
        {
            InitializeComponent();
        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is the event handler for the submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            username = NameTextBox.Text;
            userAge = float.Parse(ageTextBox.Text);
            outputlabel.Text = NameTextBox.Text + " " + ageTextBox.Text;

            NameTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
        }
        /// <summary>
        /// thus is the venet handler for lab8 form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
