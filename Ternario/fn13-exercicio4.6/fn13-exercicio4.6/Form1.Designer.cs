namespace fn13_exercicio4._6
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
            this.msgButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgButton
            // 
            this.msgButton.Location = new System.Drawing.Point(106, 54);
            this.msgButton.Name = "msgButton";
            this.msgButton.Size = new System.Drawing.Size(124, 50);
            this.msgButton.TabIndex = 0;
            this.msgButton.Text = "Qual a mensagem?";
            this.msgButton.UseVisualStyleBackColor = true;
            this.msgButton.Click += new System.EventHandler(this.msgButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 177);
            this.Controls.Add(this.msgButton);
            this.Name = "Form1";
            this.Text = "Mensagem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button msgButton;
    }
}

