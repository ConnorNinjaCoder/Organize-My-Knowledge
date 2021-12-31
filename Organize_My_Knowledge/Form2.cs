using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Organize_My_Knowledge
{
    public partial class OMKI1 : Form
    {
        string FileName = "D:\\OMKI_Text_Storage";
        static List<KnowledgeSolution> KnowledgeSolutionList = new List<KnowledgeSolution>();
        static KnowledgeSolution KnowledgeSolution1;
        List<string> TopicKnowledgeStringList = new List<string>();
        List<string> DescriptionKnowledgeStringList = new List<string>();
        //List<string> SolutionKnowledgeStringList = new List<string>();
        Form3 nextnewestForm3;
        public OMKI1()
        {
            InitializeComponent();
        }

       /* public long ReturnSizeKnowledgeList()
        {
            long count = KnowledgeSolutionList.LongCount();

            return (count);
        }*/

        public Form ReturnOMKI1()
        {
            return (ActiveForm);
        }

       /* public void ReturnForm3(ref Form3 nextnewestForm3)
        {
            nextnewestForm3 = new Form3();
            for (int i = 0; i < KnowledgeSolutionList.LongCount(); i++)
            {
                TopicKnowledgeStringList.Add(KnowledgeSolutionList.ElementAt(i).ReturnTopic().Text);
                nextnewestForm3.SetTopicKnowledgeList(TopicKnowledgeStringList.ElementAt(i));
                DescriptionKnowledgeStringList.Add(KnowledgeSolutionList.ElementAt(i).ReturnDescription().Text);
                nextnewestForm3.SetDescriptionKnowledgeList(DescriptionKnowledgeStringList.ElementAt(i));
            }
        }*/

        /* public void FindMatchingSolution(string Topic, string Description, ref string Solution)
         {
             for (int i = 0; i < KnowledgeSolutionList.LongCount(); i++)
             {
                 if ((Topic == KnowledgeSolutionList.ElementAt(i).ReturnTopic().Text) && (Description == KnowledgeSolutionList.ElementAt(i).ReturnDescription().Text))
                 {
                     Solution = KnowledgeSolutionList.ElementAt(i).ReturnSolution().Text;
                 }
                 else
                 {
                     MessageBox.Show("No Matching entries!");
                 }
             }

         }*/

        private void ClearAddTextBoxes()
        {
            Topic_textBox.Clear();
            Description_textBox.Clear();
            AddSolution_textBox.Clear();
        }

        private void OMKI1_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_button_Click(object sender, EventArgs e)
        {
            OMKI newOMKI = new OMKI();
            newOMKI.Show();
            this.Hide();
        }

        private void SaveKnowledge_Button_Click(object sender, EventArgs e)
        {
            if ((Topic_textBox.Text.Length < 1) || (Description_textBox.Text.Length < 1) || (AddSolution_textBox.Text.Length < 1))
            {
                MessageBox.Show("Must fill every textbox!");
            }
            else
            {
                KnowledgeSolution1 = new KnowledgeSolution(Topic_textBox, Description_textBox, AddSolution_textBox);

                WriteToTextFile();

                KnowledgeSolutionList.Add(KnowledgeSolution1);

                ClearAddTextBoxes();
            }
        }

        private void WriteToTextFile()
        {
            try
            {               
                if ((Topic_textBox.Text.Length >= 1) && (Description_textBox.Text.Length >= 1) && (AddSolution_textBox.Text.Length >= 1))
                {
                    using(TextWriter fs = new StreamWriter(FileName, true))
                    {
                        fs.WriteLine(Topic_textBox.Text.ToString() + ";" + Description_textBox.Text.ToString() + ";" + AddSolution_textBox.Text.ToString() + ";" + "\n");
                        MessageBox.Show("Saved!");
                        fs.Close();
                    }
                }
                ClearAddTextBoxes();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}


