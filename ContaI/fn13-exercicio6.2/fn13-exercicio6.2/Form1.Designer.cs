namespace fn13_exercicio6._2
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
            this.contaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contaButton
            // 
            this.contaButton.Location = new System.Drawing.Point(111, 91);
            this.contaButton.Name = "contaButton";
            this.contaButton.Size = new System.Drawing.Size(166, 64);
            this.contaButton.TabIndex = 0;
            this.contaButton.Text = "Conta";
            this.contaButton.UseVisualStyleBackColor = true;
            this.contaButton.Click += new System.EventHandler(this.contaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 281);
            this.Controls.Add(this.contaButton);
            this.Name = "Form1";
            this.Text = "ContaI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contaButton;
    }
}

