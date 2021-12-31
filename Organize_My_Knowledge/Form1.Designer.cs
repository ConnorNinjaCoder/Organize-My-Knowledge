namespace Organize_My_Knowledge
{
    partial class OMKI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OMKI));
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.ExplainOMKI_textBox = new System.Windows.Forms.TextBox();
            this.SearchKnowledge_button = new System.Windows.Forms.Button();
            this.AddKnowledge_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Label.Location = new System.Drawing.Point(325, 23);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(184, 24);
            this.Welcome_Label.TabIndex = 2;
            this.Welcome_Label.Text = "Welcome to OMKI!";
            // 
            // ExplainOMKI_textBox
            // 
            this.ExplainOMKI_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ExplainOMKI_textBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExplainOMKI_textBox.CausesValidation = false;
            this.ExplainOMKI_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExplainOMKI_textBox.ForeColor = System.Drawing.Color.Black;
            this.ExplainOMKI_textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExplainOMKI_textBox.Location = new System.Drawing.Point(54, 59);
            this.ExplainOMKI_textBox.Multiline = true;
            this.ExplainOMKI_textBox.Name = "ExplainOMKI_textBox";
            this.ExplainOMKI_textBox.ReadOnly = true;
            this.ExplainOMKI_textBox.Size = new System.Drawing.Size(707, 93);
            this.ExplainOMKI_textBox.TabIndex = 4;
            this.ExplainOMKI_textBox.TabStop = false;
            this.ExplainOMKI_textBox.Text = resources.GetString("ExplainOMKI_textBox.Text");
            // 
            // SearchKnowledge_button
            // 
            this.SearchKnowledge_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchKnowledge_button.Location = new System.Drawing.Point(152, 270);
            this.SearchKnowledge_button.Name = "SearchKnowledge_button";
            this.SearchKnowledge_button.Size = new System.Drawing.Size(208, 100);
            this.SearchKnowledge_button.TabIndex = 5;
            this.SearchKnowledge_button.Text = "Search My Knowledge";
            this.SearchKnowledge_button.UseVisualStyleBackColor = true;
            this.SearchKnowledge_button.Click += new System.EventHandler(this.SearchKnowledge_button_Click);
            // 
            // AddKnowledge_button
            // 
            this.AddKnowledge_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AddKnowledge_button.Location = new System.Drawing.Point(431, 270);
            this.AddKnowledge_button.Name = "AddKnowledge_button";
            this.AddKnowledge_button.Size = new System.Drawing.Size(208, 100);
            this.AddKnowledge_button.TabIndex = 6;
            this.AddKnowledge_button.Text = "Add My Knowledge";
            this.AddKnowledge_button.UseVisualStyleBackColor = true;
            this.AddKnowledge_button.Click += new System.EventHandler(this.AddKnowledge_button_Click);
            // 
            // OMKI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 638);
            this.Controls.Add(this.AddKnowledge_button);
            this.Controls.Add(this.SearchKnowledge_button);
            this.Controls.Add(this.ExplainOMKI_textBox);
            this.Controls.Add(this.Welcome_Label);
            this.Name = "OMKI";
            this.Text = "Organize_My_Knowledge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.TextBox ExplainOMKI_textBox;
        private System.Windows.Forms.Button SearchKnowledge_button;
        private System.Windows.Forms.Button AddKnowledge_button;
    }
}

