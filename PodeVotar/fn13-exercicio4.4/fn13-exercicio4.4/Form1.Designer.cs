namespace fn13_exercicio4._4
{
    partial class VotacaoForm
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
            this.votarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // votarButton
            // 
            this.votarButton.Location = new System.Drawing.Point(86, 82);
            this.votarButton.Name = "votarButton";
            this.votarButton.Size = new System.Drawing.Size(120, 51);
            this.votarButton.TabIndex = 0;
            this.votarButton.Text = "Pode Votar ?";
            this.votarButton.UseVisualStyleBackColor = true;
            this.votarButton.Click += new System.EventHandler(this.votarButton_Click);
            // 
            // VotacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 227);
            this.Controls.Add(this.votarButton);
            this.Name = "VotacaoForm";
            this.Text = "Votação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button votarButton;
    }
}

