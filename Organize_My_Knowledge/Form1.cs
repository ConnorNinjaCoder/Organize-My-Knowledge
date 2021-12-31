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
    public partial class OMKI : Form
    {
        public OMKI()
        {
            InitializeComponent();
        }

        private void AddKnowledge_button_Click(object sender, EventArgs e)
        {
            OMKI1 newOMKI1 = new OMKI1();
            newOMKI1.Show();
            this.Hide();
        }

        private void SearchKnowledge_button_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
            this.Hide();
        }
    }
}
   
