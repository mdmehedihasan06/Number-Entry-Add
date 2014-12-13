namespace numberEntryAddApp
{
    partial class numberEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterNumberTextBox = new System.Windows.Forms.TextBox();
            this.addNumberButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.savedNumbersListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sumResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // enterNumberTextBox
            // 
            this.enterNumberTextBox.Location = new System.Drawing.Point(91, 23);
            this.enterNumberTextBox.Name = "enterNumberTextBox";
            this.enterNumberTextBox.Size = new System.Drawing.Size(181, 20);
            this.enterNumberTextBox.TabIndex = 1;
            // 
            // addNumberButton
            // 
            this.addNumberButton.Location = new System.Drawing.Point(321, 23);
            this.addNumberButton.Name = "addNumberButton";
            this.addNumberButton.Size = new System.Drawing.Size(75, 23);
            this.addNumberButton.TabIndex = 2;
            this.addNumberButton.Text = "Add";
            this.addNumberButton.UseVisualStyleBackColor = true;
            this.addNumberButton.Click += new System.EventHandler(this.addNumberButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(299, 76);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(97, 23);
            this.showAllButton.TabIndex = 3;
            this.showAllButton.Text = "Show All Number";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // savedNumbersListBox
            // 
            this.savedNumbersListBox.FormattingEnabled = true;
            this.savedNumbersListBox.Location = new System.Drawing.Point(91, 105);
            this.savedNumbersListBox.Name = "savedNumbersListBox";
            this.savedNumbersListBox.Size = new System.Drawing.Size(305, 147);
            this.savedNumbersListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sum Result";
            // 
            // sumResultTextBox
            // 
            this.sumResultTextBox.Location = new System.Drawing.Point(91, 290);
            this.sumResultTextBox.Name = "sumResultTextBox";
            this.sumResultTextBox.Size = new System.Drawing.Size(181, 20);
            this.sumResultTextBox.TabIndex = 6;
            // 
            // numberEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 331);
            this.Controls.Add(this.sumResultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savedNumbersListBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.addNumberButton);
            this.Controls.Add(this.enterNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "numberEntry";
            this.Text = "Number Entry and Addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNumberTextBox;
        private System.Windows.Forms.Button addNumberButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ListBox savedNumbersListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumResultTextBox;
    }
}

