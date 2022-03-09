
namespace BinarySearch
{
    partial class BinarySearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinarySearch));
            this.arrayInput = new System.Windows.Forms.TextBox();
            this.arraytextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.consoleOutput = new System.Windows.Forms.TextBox();
            this.downloadArray = new System.Windows.Forms.Button();
            this.Target = new System.Windows.Forms.Label();
            this.arraySize = new System.Windows.Forms.TextBox();
            this.arrayMax = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
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
            // arraytextBox
            // 
            this.arraytextBox.Location = new System.Drawing.Point(22, 86);
            this.arraytextBox.Multiline = true;
            this.arraytextBox.Name = "arraytextBox";
            this.arraytextBox.ReadOnly = true;
            this.arraytextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.arraytextBox.Size = new System.Drawing.Size(321, 128);
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
            this.search.Location = new System.Drawing.Point(380, 230);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 20);
            this.search.TabIndex = 4;
            this.search.Text = "Search!";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(22, 231);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(321, 98);
            this.output.TabIndex = 5;
            this.output.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // consoleOutput
            // 
            this.consoleOutput.Location = new System.Drawing.Point(22, 348);
            this.consoleOutput.Multiline = true;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOutput.Size = new System.Drawing.Size(321, 90);
            this.consoleOutput.TabIndex = 6;
            this.consoleOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // downloadArray
            // 
            this.downloadArray.Location = new System.Drawing.Point(380, 124);
            this.downloadArray.Name = "downloadArray";
            this.downloadArray.Size = new System.Drawing.Size(75, 90);
            this.downloadArray.TabIndex = 7;
            this.downloadArray.Text = "Download";
            this.downloadArray.UseVisualStyleBackColor = true;
            this.downloadArray.Click += new System.EventHandler(this.downloadArray_Click);
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Location = new System.Drawing.Point(380, 31);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(86, 13);
            this.Target.TabIndex = 8;
            this.Target.Text = "Your Target Item";
            // 
            // arraySize
            // 
            this.arraySize.Location = new System.Drawing.Point(530, 31);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(100, 20);
            this.arraySize.TabIndex = 9;
            this.arraySize.TextChanged += new System.EventHandler(this.arraySize_TextChanged);
            // 
            // arrayMax
            // 
            this.arrayMax.Location = new System.Drawing.Point(530, 86);
            this.arrayMax.Name = "arrayMax";
            this.arrayMax.Size = new System.Drawing.Size(100, 20);
            this.arrayMax.TabIndex = 10;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(636, 89);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(88, 13);
            this.labelMax.TabIndex = 11;
            this.labelMax.Text = "Max Random Int ";
            this.labelMax.Click += new System.EventHandler(this.labelMax_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(636, 34);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(68, 13);
            this.labelSize.TabIndex = 12;
            this.labelSize.Text = "Size Of Array";
            // 
            // BinarySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.arrayMax);
            this.Controls.Add(this.arraySize);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.downloadArray);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.output);
            this.Controls.Add(this.search);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.arraytextBox);
            this.Controls.Add(this.arrayInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "BinarySearch";
            this.Text = "Binary Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayInput;
        private System.Windows.Forms.TextBox arraytextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button downloadArray;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.TextBox arraySize;
        private System.Windows.Forms.TextBox arrayMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelSize;
        public System.Windows.Forms.TextBox consoleOutput;
    }
}

