namespace fn13_exercicio5._6
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
            this.fatorialButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatorialButton
            // 
            this.fatorialButton.Location = new System.Drawing.Point(86, 77);
            this.fatorialButton.Name = "fatorialButton";
            this.fatorialButton.Size = new System.Drawing.Size(153, 59);
            this.fatorialButton.TabIndex = 0;
            this.fatorialButton.Text = "Fatorial 1 a 10";
            this.fatorialButton.UseVisualStyleBackColor = true;
            this.fatorialButton.Click += new System.EventHandler(this.fatorialButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 239);
            this.Controls.Add(this.fatorialButton);
            this.Name = "Form1";
            this.Text = "Fatorial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fatorialButton;
    }
}

