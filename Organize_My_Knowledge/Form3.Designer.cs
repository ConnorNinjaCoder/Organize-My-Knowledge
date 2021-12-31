namespace Organize_My_Knowledge
{
    partial class Form3
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
            this.TopicLabel2 = new System.Windows.Forms.Label();
            this.Topic_comboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionLabel2 = new System.Windows.Forms.Label();
            this.Description_comboBox = new System.Windows.Forms.ComboBox();
            this.Search_Knowledge_button = new System.Windows.Forms.Button();
            this.HomePage_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopicLabel2
            // 
            this.TopicLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TopicLabel2.AutoSize = true;
            this.TopicLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicLabel2.Location = new System.Drawing.Point(391, 77);
            this.TopicLabel2.Name = "TopicLabel2";
            this.TopicLabel2.Size = new System.Drawing.Size(65, 25);
            this.TopicLabel2.TabIndex = 0;
            this.TopicLabel2.Text = "Topic";
            // 
            // Topic_comboBox
            // 
            this.Topic_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Topic_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Topic_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topic_comboBox.FormattingEnabled = true;
            this.Topic_comboBox.Location = new System.Drawing.Point(282, 105);
            this.Topic_comboBox.Name = "Topic_comboBox";
            this.Topic_comboBox.Size = new System.Drawing.Size(277, 28);
            this.Topic_comboBox.TabIndex = 1;
            this.Topic_comboBox.SelectedIndexChanged += new System.EventHandler(this.Topic_comboBox_SelectedIndexChanged);
            // 
            // DescriptionLabel2
            // 
            this.DescriptionLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DescriptionLabel2.AutoSize = true;
            this.DescriptionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel2.Location = new System.Drawing.Point(326, 182);
            this.DescriptionLabel2.Name = "DescriptionLabel2";
            this.DescriptionLabel2.Size = new System.Drawing.Size(183, 25);
            this.DescriptionLabel2.TabIndex = 2;
            this.DescriptionLabel2.Text = "Question/Problem";
            // 
            // Description_comboBox
            // 
            this.Description_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Description_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Description_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_comboBox.FormattingEnabled = true;
            this.Description_comboBox.Location = new System.Drawing.Point(155, 210);
            this.Description_comboBox.Name = "Description_comboBox";
            this.Description_comboBox.Size = new System.Drawing.Size(509, 28);
            this.Description_comboBox.TabIndex = 3;
            this.Description_comboBox.SelectedIndexChanged += new System.EventHandler(this.Description_comboBox_SelectedIndexChanged);
            // 
            // Search_Knowledge_button
            // 
            this.Search_Knowledge_button.Location = new System.Drawing.Point(331, 344);
            this.Search_Knowledge_button.Name = "Search_Knowledge_button";
            this.Search_Knowledge_button.Size = new System.Drawing.Size(165, 69);
            this.Search_Knowledge_button.TabIndex = 4;
            this.Search_Knowledge_button.Text = "Search Knowledge";
            this.Search_Knowledge_button.UseVisualStyleBackColor = true;
            this.Search_Knowledge_button.Click += new System.EventHandler(this.Search_Knowledge_button_Click);
            // 
            // HomePage_button
            // 
            this.HomePage_button.Location = new System.Drawing.Point(37, 12);
            this.HomePage_button.Name = "HomePage_button";
            this.HomePage_button.Size = new System.Drawing.Size(95, 23);
            this.HomePage_button.TabIndex = 7;
            this.HomePage_button.Text = "Home Page";
            this.HomePage_button.UseVisualStyleBackColor = true;
            this.HomePage_button.Click += new System.EventHandler(this.HomePage_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 638);
            this.Controls.Add(this.HomePage_button);
            this.Controls.Add(this.Search_Knowledge_button);
            this.Controls.Add(this.Description_comboBox);
            this.Controls.Add(this.DescriptionLabel2);
            this.Controls.Add(this.Topic_comboBox);
            this.Controls.Add(this.TopicLabel2);
            this.Name = "Form3";
            this.Text = "Search My Knowledge";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopicLabel2;
        private System.Windows.Forms.ComboBox Topic_comboBox;
        private System.Windows.Forms.Label DescriptionLabel2;
        private System.Windows.Forms.ComboBox Description_comboBox;
        private System.Windows.Forms.Button Search_Knowledge_button;
        private System.Windows.Forms.Button HomePage_button;
    }
}