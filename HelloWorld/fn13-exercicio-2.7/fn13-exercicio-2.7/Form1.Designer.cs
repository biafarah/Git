namespace fn13_exercicio_2._7
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
            this.buttonClique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClique
            // 
            this.buttonClique.Location = new System.Drawing.Point(89, 44);
            this.buttonClique.Name = "buttonClique";
            this.buttonClique.Size = new System.Drawing.Size(107, 42);
            this.buttonClique.TabIndex = 0;
            this.buttonClique.Text = "Clique Aqui!";
            this.buttonClique.UseVisualStyleBackColor = true;
            this.buttonClique.Click += new System.EventHandler(this.buttonClique_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 147);
            this.Controls.Add(this.buttonClique);
            this.Name = "Form1";
            this.Text = "Hello";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClique;
    }
}

