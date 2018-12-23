namespace fn13_exercicio4
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
            this.bhaskaraButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bhaskaraButton
            // 
            this.bhaskaraButton.Location = new System.Drawing.Point(129, 119);
            this.bhaskaraButton.Name = "bhaskaraButton";
            this.bhaskaraButton.Size = new System.Drawing.Size(121, 46);
            this.bhaskaraButton.TabIndex = 0;
            this.bhaskaraButton.Text = "Qual o valor?";
            this.bhaskaraButton.UseVisualStyleBackColor = true;
            this.bhaskaraButton.Click += new System.EventHandler(this.bhaskaraButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 320);
            this.Controls.Add(this.bhaskaraButton);
            this.Name = "Form1";
            this.Text = "Bhaskara";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bhaskaraButton;
    }
}

