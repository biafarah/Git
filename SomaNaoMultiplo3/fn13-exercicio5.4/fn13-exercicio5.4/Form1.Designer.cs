namespace fn13_exercicio5._4
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
            this.somaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // somaButton
            // 
            this.somaButton.Location = new System.Drawing.Point(125, 89);
            this.somaButton.Name = "somaButton";
            this.somaButton.Size = new System.Drawing.Size(142, 53);
            this.somaButton.TabIndex = 0;
            this.somaButton.Text = "Soma Não Múltiplos 3";
            this.somaButton.UseVisualStyleBackColor = true;
            this.somaButton.Click += new System.EventHandler(this.somaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 258);
            this.Controls.Add(this.somaButton);
            this.Name = "Form1";
            this.Text = "Somatório III";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button somaButton;
    }
}

