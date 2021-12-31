namespace Organize_My_Knowledge
{
    partial class Form4
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
            this.AccessTopic_textBox = new System.Windows.Forms.TextBox();
            this.AccessDescription_textBox = new System.Windows.Forms.TextBox();
            this.AccessTopic_Label = new System.Windows.Forms.Label();
            this.AccessDescription_Label = new System.Windows.Forms.Label();
            this.AccessSolution_Label = new System.Windows.Forms.Label();
            this.AccessSolution_textBox = new System.Windows.Forms.TextBox();
            this.HomePage_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccessTopic_textBox
            // 
            this.AccessTopic_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AccessTopic_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessTopic_textBox.Location = new System.Drawing.Point(243, 39);
            this.AccessTopic_textBox.Name = "AccessTopic_textBox";
            this.AccessTopic_textBox.ReadOnly = true;
            this.AccessTopic_textBox.Size = new System.Drawing.Size(386, 29);
            this.AccessTopic_textBox.TabIndex = 0;
            // 
            // AccessDescription_textBox
            // 
            this.AccessDescription_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AccessDescription_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessDescription_textBox.Location = new System.Drawing.Point(243, 86);
            this.AccessDescription_textBox.Multiline = true;
            this.AccessDescription_textBox.Name = "AccessDescription_textBox";
            this.AccessDescription_textBox.ReadOnly = true;
            this.AccessDescription_textBox.Size = new System.Drawing.Size(386, 76);
            this.AccessDescription_textBox.TabIndex = 1;
            // 
            // AccessTopic_Label
            // 
            this.AccessTopic_Label.AutoSize = true;
            this.AccessTopic_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessTopic_Label.Location = new System.Drawing.Point(166, 41);
            this.AccessTopic_Label.Name = "AccessTopic_Label";
            this.AccessTopic_Label.Size = new System.Drawing.Size(71, 25);
            this.AccessTopic_Label.TabIndex = 2;
            this.AccessTopic_Label.Text = "Topic:";
            // 
            // AccessDescription_Label
            // 
            this.AccessDescription_Label.AutoSize = true;
            this.AccessDescription_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessDescription_Label.Location = new System.Drawing.Point(111, 81);
            this.AccessDescription_Label.Name = "AccessDescription_Label";
            this.AccessDescription_Label.Size = new System.Drawing.Size(126, 25);
            this.AccessDescription_Label.TabIndex = 3;
            this.AccessDescription_Label.Text = "Description:";
            // 
            // AccessSolution_Label
            // 
            this.AccessSolution_Label.AutoSize = true;
            this.AccessSolution_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessSolution_Label.Location = new System.Drawing.Point(14, 181);
            this.AccessSolution_Label.Name = "AccessSolution_Label";
            this.AccessSolution_Label.Size = new System.Drawing.Size(96, 25);
            this.AccessSolution_Label.TabIndex = 4;
            this.AccessSolution_Label.Text = "Solution:";
            // 
            // AccessSolution_textBox
            // 
            this.AccessSolution_textBox.Location = new System.Drawing.Point(116, 185);
            this.AccessSolution_textBox.Multiline = true;
            this.AccessSolution_textBox.Name = "AccessSolution_textBox";
            this.AccessSolution_textBox.ReadOnly = true;
            this.AccessSolution_textBox.Size = new System.Drawing.Size(701, 441);
            this.AccessSolution_textBox.TabIndex = 5;
            // 
            // HomePage_button
            // 
            this.HomePage_button.Location = new System.Drawing.Point(28, 12);
            this.HomePage_button.Name = "HomePage_button";
            this.HomePage_button.Size = new System.Drawing.Size(95, 23);
            this.HomePage_button.TabIndex = 8;
            this.HomePage_button.Text = "Home Page";
            this.HomePage_button.UseVisualStyleBackColor = true;
            this.HomePage_button.Click += new System.EventHandler(this.HomePage_button_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 638);
            this.Controls.Add(this.HomePage_button);
            this.Controls.Add(this.AccessSolution_textBox);
            this.Controls.Add(this.AccessSolution_Label);
            this.Controls.Add(this.AccessDescription_Label);
            this.Controls.Add(this.AccessTopic_Label);
            this.Controls.Add(this.AccessDescription_textBox);
            this.Controls.Add(this.AccessTopic_textBox);
            this.Name = "Form4";
            this.Text = "Access My Knowledge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccessTopic_textBox;
        private System.Windows.Forms.TextBox AccessDescription_textBox;
        private System.Windows.Forms.Label AccessTopic_Label;
        private System.Windows.Forms.Label AccessDescription_Label;
        private System.Windows.Forms.Label AccessSolution_Label;
        private System.Windows.Forms.TextBox AccessSolution_textBox;
        private System.Windows.Forms.Button HomePage_button;
    }
}