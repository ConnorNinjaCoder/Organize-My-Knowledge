namespace Organize_My_Knowledge
{
    partial class OMKI1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopicLabel = new System.Windows.Forms.Label();
            this.Topic_textBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSolution_textBox = new System.Windows.Forms.TextBox();
            this.HomePage_button = new System.Windows.Forms.Button();
            this.SaveKnowledge_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopicLabel
            // 
            this.TopicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicLabel.Location = new System.Drawing.Point(59, 51);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(71, 25);
            this.TopicLabel.TabIndex = 0;
            this.TopicLabel.Text = "Topic:";
            // 
            // Topic_textBox
            // 
            this.Topic_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Topic_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topic_textBox.Location = new System.Drawing.Point(136, 50);
            this.Topic_textBox.Name = "Topic_textBox";
            this.Topic_textBox.Size = new System.Drawing.Size(254, 26);
            this.Topic_textBox.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(59, 107);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(303, 25);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Question/Problem Description:";
            // 
            // Description_textBox
            // 
            this.Description_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_textBox.Location = new System.Drawing.Point(381, 107);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(321, 91);
            this.Description_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Solution:";
            // 
            // AddSolution_textBox
            // 
            this.AddSolution_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AddSolution_textBox.Location = new System.Drawing.Point(170, 225);
            this.AddSolution_textBox.Multiline = true;
            this.AddSolution_textBox.Name = "AddSolution_textBox";
            this.AddSolution_textBox.Size = new System.Drawing.Size(636, 308);
            this.AddSolution_textBox.TabIndex = 5;
            // 
            // HomePage_button
            // 
            this.HomePage_button.Location = new System.Drawing.Point(12, 12);
            this.HomePage_button.Name = "HomePage_button";
            this.HomePage_button.Size = new System.Drawing.Size(95, 23);
            this.HomePage_button.TabIndex = 6;
            this.HomePage_button.Text = "Home Page";
            this.HomePage_button.UseVisualStyleBackColor = true;
            this.HomePage_button.Click += new System.EventHandler(this.HomePage_button_Click);
            // 
            // SaveKnowledge_Button
            // 
            this.SaveKnowledge_Button.Location = new System.Drawing.Point(408, 562);
            this.SaveKnowledge_Button.Name = "SaveKnowledge_Button";
            this.SaveKnowledge_Button.Size = new System.Drawing.Size(144, 50);
            this.SaveKnowledge_Button.TabIndex = 7;
            this.SaveKnowledge_Button.Text = "Save Knowledge";
            this.SaveKnowledge_Button.UseVisualStyleBackColor = true;
            this.SaveKnowledge_Button.Click += new System.EventHandler(this.SaveKnowledge_Button_Click);
            // 
            // OMKI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 638);
            this.Controls.Add(this.SaveKnowledge_Button);
            this.Controls.Add(this.HomePage_button);
            this.Controls.Add(this.AddSolution_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.Topic_textBox);
            this.Controls.Add(this.TopicLabel);
            this.Name = "OMKI1";
            this.Text = "Add My Knowledge";
            this.Load += new System.EventHandler(this.OMKI1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.TextBox Topic_textBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddSolution_textBox;
        private System.Windows.Forms.Button HomePage_button;
        private System.Windows.Forms.Button SaveKnowledge_Button;
    }
}