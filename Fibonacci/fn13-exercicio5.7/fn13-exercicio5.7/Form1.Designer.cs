namespace fn13_exercicio5._7
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
            this.fibonacciButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fibonacciButton
            // 
            this.fibonacciButton.Location = new System.Drawing.Point(88, 72);
            this.fibonacciButton.Name = "fibonacciButton";
            this.fibonacciButton.Size = new System.Drawing.Size(165, 55);
            this.fibonacciButton.TabIndex = 0;
            this.fibonacciButton.Text = "Fibonacci";
            this.fibonacciButton.UseVisualStyleBackColor = true;
            this.fibonacciButton.Click += new System.EventHandler(this.fibonacciButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 230);
            this.Controls.Add(this.fibonacciButton);
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fibonacciButton;
    }
}

