namespace fn13_exercicio4._5
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
            this.impostoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // impostoButton
            // 
            this.impostoButton.Location = new System.Drawing.Point(151, 107);
            this.impostoButton.Name = "impostoButton";
            this.impostoButton.Size = new System.Drawing.Size(124, 55);
            this.impostoButton.TabIndex = 0;
            this.impostoButton.Text = "Imposto";
            this.impostoButton.UseVisualStyleBackColor = true;
            this.impostoButton.Click += new System.EventHandler(this.impostoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 281);
            this.Controls.Add(this.impostoButton);
            this.Name = "Form1";
            this.Text = "Qual o valor?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button impostoButton;
    }
}

