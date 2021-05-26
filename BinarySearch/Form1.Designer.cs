
namespace BinarySearch
{
    partial class Form1
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
            this.arrayInput = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.arraytextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.consoleOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arrayInput
            // 
            this.arrayInput.Location = new System.Drawing.Point(22, 31);
            this.arrayInput.Name = "arrayInput";
            this.arrayInput.Size = new System.Drawing.Size(321, 20);
            this.arrayInput.TabIndex = 0;
            this.arrayInput.TextChanged += new System.EventHandler(this.arrayInput_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(380, 31);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 19);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // arraytextBox
            // 
            this.arraytextBox.Location = new System.Drawing.Point(22, 86);
            this.arraytextBox.Name = "arraytextBox";
            this.arraytextBox.Size = new System.Drawing.Size(321, 20);
            this.arraytextBox.TabIndex = 2;
            this.arraytextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(380, 86);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 19);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(380, 143);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 20);
            this.search.TabIndex = 4;
            this.search.Text = "Search!";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(22, 142);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(321, 187);
            this.output.TabIndex = 5;
            this.output.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // consoleOutput
            // 
            this.consoleOutput.Location = new System.Drawing.Point(22, 348);
            this.consoleOutput.Multiline = true;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.Size = new System.Drawing.Size(321, 90);
            this.consoleOutput.TabIndex = 6;
            this.consoleOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.output);
            this.Controls.Add(this.search);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.arraytextBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.arrayInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayInput;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox arraytextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox consoleOutput;
    }
}

