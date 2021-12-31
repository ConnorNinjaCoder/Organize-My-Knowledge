using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Organize_My_Knowledge
{
    public partial class Form4 : Form
    {
        public Form4(string topic, string description, string solution)
        {
            InitializeComponent();
            AccessTopic_textBox.ResetText();
            AccessDescription_textBox.ResetText();
            AccessSolution_textBox.ResetText();
            AccessTopic_textBox.Text = topic;
            AccessDescription_textBox.Text = description;
            AccessSolution_textBox.Text = solution;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void HomePage_button_Click(object sender, EventArgs e)
        {
            OMKI newOMKI = new OMKI();
            newOMKI.Show();
            this.Hide();
        }
    }
}
