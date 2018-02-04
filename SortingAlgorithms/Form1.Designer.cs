namespace SortingAlgorithms
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mergesort = new System.Windows.Forms.Button();
            this.bubblesort = new System.Windows.Forms.Button();
            this.sortedlist = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 89);
            this.textBox1.TabIndex = 0;
            // 
            // mergesort
            // 
            this.mergesort.Location = new System.Drawing.Point(12, 126);
            this.mergesort.Name = "mergesort";
            this.mergesort.Size = new System.Drawing.Size(116, 48);
            this.mergesort.TabIndex = 1;
            this.mergesort.Text = "Merge\r\nSort";
            this.mergesort.UseVisualStyleBackColor = true;
            // 
            // bubblesort
            // 
            this.bubblesort.Location = new System.Drawing.Point(156, 126);
            this.bubblesort.Name = "bubblesort";
            this.bubblesort.Size = new System.Drawing.Size(116, 48);
            this.bubblesort.TabIndex = 2;
            this.bubblesort.Text = "Bubble\r\nSort";
            this.bubblesort.UseVisualStyleBackColor = true;
            // 
            // sortedlist
            // 
            this.sortedlist.AutoSize = true;
            this.sortedlist.Location = new System.Drawing.Point(12, 189);
            this.sortedlist.Name = "sortedlist";
            this.sortedlist.Size = new System.Drawing.Size(0, 13);
            this.sortedlist.TabIndex = 3;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(12, 225);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(26, 13);
            this.time.TabIndex = 4;
            this.time.Text = "time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.time);
            this.Controls.Add(this.sortedlist);
            this.Controls.Add(this.bubblesort);
            this.Controls.Add(this.mergesort);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mergesort;
        private System.Windows.Forms.Button bubblesort;
        private System.Windows.Forms.Label sortedlist;
        private System.Windows.Forms.Label time;
    }
}

