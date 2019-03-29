namespace fn13_exercicio12._2
{
    partial class FormCadastroNovaConta
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
            this.numeroLabel = new System.Windows.Forms.Label();
            this.titularLabel = new System.Windows.Forms.Label();
            this.cadastrarContaButton = new System.Windows.Forms.Button();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.titularTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(31, 37);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(58, 17);
            this.numeroLabel.TabIndex = 0;
            this.numeroLabel.Text = "Numero";
            // 
            // titularLabel
            // 
            this.titularLabel.AutoSize = true;
            this.titularLabel.Location = new System.Drawing.Point(31, 107);
            this.titularLabel.Name = "titularLabel";
            this.titularLabel.Size = new System.Drawing.Size(48, 17);
            this.titularLabel.TabIndex = 1;
            this.titularLabel.Text = "Titular";
            // 
            // cadastrarContaButton
            // 
            this.cadastrarContaButton.Location = new System.Drawing.Point(96, 172);
            this.cadastrarContaButton.Name = "cadastrarContaButton";
            this.cadastrarContaButton.Size = new System.Drawing.Size(114, 41);
            this.cadastrarContaButton.TabIndex = 2;
            this.cadastrarContaButton.Text = "Cadastrar";
            this.cadastrarContaButton.UseVisualStyleBackColor = true;
            this.cadastrarContaButton.Click += new System.EventHandler(this.cadastrarContaButton_Click);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(96, 37);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(111, 22);
            this.numeroTextBox.TabIndex = 3;
            // 
            // titularTextBox
            // 
            this.titularTextBox.Location = new System.Drawing.Point(96, 107);
            this.titularTextBox.Name = "titularTextBox";
            this.titularTextBox.Size = new System.Drawing.Size(111, 22);
            this.titularTextBox.TabIndex = 4;
            // 
            // FormCadastroNovaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 225);
            this.Controls.Add(this.titularTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.cadastrarContaButton);
            this.Controls.Add(this.titularLabel);
            this.Controls.Add(this.numeroLabel);
            this.Name = "FormCadastroNovaConta";
            this.Text = "FormCadastroNovaConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label titularLabel;
        private System.Windows.Forms.Button cadastrarContaButton;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox titularTextBox;
    }
}