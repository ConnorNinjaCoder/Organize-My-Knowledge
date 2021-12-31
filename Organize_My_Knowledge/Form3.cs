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
    public partial class Form3 : Form
    {
        string topicString = string.Empty;
        string questionString = string.Empty;
        string solutionString = string.Empty;
        string question = string.Empty;
        string checkTopic = string.Empty;
        char c;
        char d;
        string line = string.Empty;
        string Solution = string.Empty;
        static List<KnowledgeSolution> KnowledgeSolutionList = new List<KnowledgeSolution>();
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form3 newForm3)
        {
            Form3 newestForm3 = newForm3;
            InitializeComponent();
        }


        private void Topic_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Description_comboBox.Items.Clear();
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader s = new StreamReader("D:\\OMKI_Text_Storage");

                //Read the first line of text
                line = s.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    topicString = Topic_comboBox.Text.ToString();
                    question = string.Empty;
                    checkTopic = string.Empty;
                    int count = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (count == 0)
                        {
                            c = line.ElementAt(i);
                            if (c != ';')
                            {
                                checkTopic += c;
                            }
                            else if (c == ';')
                            {
                                count++;
                                for (int j = i + 1; j < line.Length; j++)
                                {
                                    if (checkTopic == topicString)
                                    {
                                        d = line.ElementAt(j);
                                        if ((count == 1) && (d != ';'))
                                        {
                                            question += d;
                                        }
                                        else if (d == ';')
                                        {
                                            Description_comboBox.Items.Add(question);
                                            count++;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    //Read the next line
                    line = s.ReadLine();

                    //close the file
                }
                //close the file
                s.Close();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private void HomePage_button_Click(object sender, EventArgs e)
        {
            OMKI newOMKI = new OMKI();
            newOMKI.Show();
            this.Hide();
        }

        private void Description_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader s = new StreamReader("D:\\OMKI_Text_Storage");

                //Read the first line of text
                line = s.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    char F;
                    topicString = Topic_comboBox.Text.ToString();
                    questionString = Description_comboBox.Text.ToString();
                    question = string.Empty;
                    checkTopic = string.Empty;
                    int count = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (count == 0)
                        {
                            c = line.ElementAt(i);
                            if (c != ';')
                            {
                                checkTopic += c;
                            }
                            else if (c == ';')
                            {
                                count++;
                                for (int j = i + 1; j < line.Length; j++)
                                {
                                    if (checkTopic == topicString)
                                    {
                                        d = line.ElementAt(j);
                                        if ((count == 1) && (d != ';'))
                                        {
                                            question += d;
                                        }
                                        else if (d == ';')
                                        {
                                            count++;
                                            if (question == questionString)
                                            {
                                                for (int k = j + 1; k < line.Length; k++)
                                                {
                                                    F = line.ElementAt(k);
                                                    if (F != ';')
                                                    {
                                                        solutionString += F;
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }                                           
                                                }
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //Read the next line
                    line = s.ReadLine();
                }
                //close the file
                s.Close();

            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private void Open_Form4(string topicString, string questionString, string solutionString)
        {
            Form newForm4 = new Form4(topicString, questionString, solutionString);
            newForm4.Show();
            this.Hide();

        }

        private void Search_Knowledge_button_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4(topicString, questionString, solutionString);
            newForm4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<string> CheckSameTopic = new List<string>();
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sp = new StreamReader("D:\\OMKI_Text_Storage");

                //Read the first line of text
                line = sp.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    bool check = false;
                    checkTopic = string.Empty;

                    for (int i = 0; i < line.Length; i++)
                    {
                        c = line.ElementAt(i);
                        if (c != ';')
                        {
                            checkTopic += c;
                        }
                        else if ((c == ';') && (checkTopic != ""))
                        {
                            check = false;
                            if (CheckSameTopic.Contains(checkTopic))
                            {
                                check = true;
                            }

                            else if (check == false)
                            {
                                CheckSameTopic.Add(checkTopic);
                                Topic_comboBox.Items.Add(checkTopic);
                            }
                            checkTopic = string.Empty;
                            break;
                        }
                    }                               
                   
                    /*if (count == 1)
                    {
                        d = line.ElementAt(i);
                        if (count == 1 && d != ';')
                        {
                            question += d;
                        }
                        else if (d == ';')
                        {
                            if (count == 1)
                            {
                                Description_comboBox.Items.Add(question);
                                question = string.Empty;
                                count++;
                            }
                        }
                    } */
                    //Read the next line
                    line = sp.ReadLine();
                    //close the file
                }
                //close the file
                sp.Close();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }
    }
}
    

        
    

        
    

            
            


    


  
    

