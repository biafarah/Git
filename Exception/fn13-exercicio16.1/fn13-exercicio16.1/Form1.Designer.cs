﻿namespace fn13_exercicio16._1
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
            this.buttonImpostos = new System.Windows.Forms.Button();
            this.buscaContaGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxContas = new System.Windows.Forms.ComboBox();
            this.escolhaContaLabel = new System.Windows.Forms.Label();
            this.novaContaButton = new System.Windows.Forms.Button();
            this.depositarButton = new System.Windows.Forms.Button();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.saldoTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.titularTextBox = new System.Windows.Forms.TextBox();
            this.valorLabel = new System.Windows.Forms.Label();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sacarButton = new System.Windows.Forms.Button();
            this.buscaContaGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonImpostos
            // 
            this.buttonImpostos.Location = new System.Drawing.Point(182, 400);
            this.buttonImpostos.Name = "buttonImpostos";
            this.buttonImpostos.Size = new System.Drawing.Size(107, 38);
            this.buttonImpostos.TabIndex = 25;
            this.buttonImpostos.Text = "Imposto";
            this.buttonImpostos.UseVisualStyleBackColor = true;
            this.buttonImpostos.Click += new System.EventHandler(this.buttonImpostos_Click);
            // 
            // buscaContaGroupBox
            // 
            this.buscaContaGroupBox.Controls.Add(this.comboBoxContas);
            this.buscaContaGroupBox.Controls.Add(this.escolhaContaLabel);
            this.buscaContaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.buscaContaGroupBox.Name = "buscaContaGroupBox";
            this.buscaContaGroupBox.Size = new System.Drawing.Size(325, 76);
            this.buscaContaGroupBox.TabIndex = 23;
            this.buscaContaGroupBox.TabStop = false;
            this.buscaContaGroupBox.Text = "Busca de Conta";
            // 
            // comboBoxContas
            // 
            this.comboBoxContas.FormattingEnabled = true;
            this.comboBoxContas.Location = new System.Drawing.Point(138, 31);
            this.comboBoxContas.Name = "comboBoxContas";
            this.comboBoxContas.Size = new System.Drawing.Size(158, 24);
            this.comboBoxContas.TabIndex = 1;
            this.comboBoxContas.SelectedIndexChanged += new System.EventHandler(this.comboBoxContas_SelectedIndexChanged);
            // 
            // escolhaContaLabel
            // 
            this.escolhaContaLabel.AutoSize = true;
            this.escolhaContaLabel.Location = new System.Drawing.Point(7, 34);
            this.escolhaContaLabel.Name = "escolhaContaLabel";
            this.escolhaContaLabel.Size = new System.Drawing.Size(111, 17);
            this.escolhaContaLabel.TabIndex = 0;
            this.escolhaContaLabel.Text = "Escolha a Conta";
            // 
            // novaContaButton
            // 
            this.novaContaButton.Location = new System.Drawing.Point(29, 400);
            this.novaContaButton.Name = "novaContaButton";
            this.novaContaButton.Size = new System.Drawing.Size(111, 38);
            this.novaContaButton.TabIndex = 24;
            this.novaContaButton.Text = "Nova Conta";
            this.novaContaButton.UseVisualStyleBackColor = true;
            // 
            // depositarButton
            // 
            this.depositarButton.Location = new System.Drawing.Point(17, 211);
            this.depositarButton.Name = "depositarButton";
            this.depositarButton.Size = new System.Drawing.Size(111, 41);
            this.depositarButton.TabIndex = 8;
            this.depositarButton.Text = "Depositar";
            this.depositarButton.UseVisualStyleBackColor = true;
            this.depositarButton.Click += new System.EventHandler(this.depositarButton_Click);
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(112, 160);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(133, 22);
            this.valorTextBox.TabIndex = 7;
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.Location = new System.Drawing.Point(112, 116);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.Size = new System.Drawing.Size(133, 22);
            this.saldoTextBox.TabIndex = 6;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(112, 77);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(133, 22);
            this.numeroTextBox.TabIndex = 5;
            // 
            // titularTextBox
            // 
            this.titularTextBox.Location = new System.Drawing.Point(112, 41);
            this.titularTextBox.Name = "titularTextBox";
            this.titularTextBox.Size = new System.Drawing.Size(133, 22);
            this.titularTextBox.TabIndex = 4;
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(28, 163);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(46, 17);
            this.valorLabel.TabIndex = 3;
            this.valorLabel.Text = "Valor";
            // 
            // saldoLabel
            // 
            this.saldoLabel.AutoSize = true;
            this.saldoLabel.Location = new System.Drawing.Point(28, 119);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.Size = new System.Drawing.Size(49, 17);
            this.saldoLabel.TabIndex = 2;
            this.saldoLabel.Text = "Saldo";
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(28, 80);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(64, 17);
            this.numeroLabel.TabIndex = 1;
            this.numeroLabel.Text = "Número";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(28, 44);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(55, 17);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Titular";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sacarButton);
            this.groupBox1.Controls.Add(this.depositarButton);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(this.saldoTextBox);
            this.groupBox1.Controls.Add(this.numeroTextBox);
            this.groupBox1.Controls.Add(this.titularTextBox);
            this.groupBox1.Controls.Add(this.valorLabel);
            this.groupBox1.Controls.Add(this.saldoLabel);
            this.groupBox1.Controls.Add(this.numeroLabel);
            this.groupBox1.Controls.Add(this.textLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 273);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // sacarButton
            // 
            this.sacarButton.Location = new System.Drawing.Point(166, 211);
            this.sacarButton.Name = "sacarButton";
            this.sacarButton.Size = new System.Drawing.Size(111, 41);
            this.sacarButton.TabIndex = 9;
            this.sacarButton.Text = "Sacar";
            this.sacarButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.buttonImpostos);
            this.Controls.Add(this.buscaContaGroupBox);
            this.Controls.Add(this.novaContaButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.buscaContaGroupBox.ResumeLayout(false);
            this.buscaContaGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonImpostos;
        private System.Windows.Forms.GroupBox buscaContaGroupBox;
        private System.Windows.Forms.ComboBox comboBoxContas;
        private System.Windows.Forms.Label escolhaContaLabel;
        private System.Windows.Forms.Button novaContaButton;
        private System.Windows.Forms.Button depositarButton;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox saldoTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox titularTextBox;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.Label saldoLabel;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sacarButton;
    }
}

