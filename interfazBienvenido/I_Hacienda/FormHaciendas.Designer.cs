﻿namespace I_Hacienda
{
    partial class FormHaciendas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lHacienda = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHaciendas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.lHacienda);
            this.groupBox1.Location = new System.Drawing.Point(-3, -21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1535, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lHacienda
            // 
            this.lHacienda.AutoSize = true;
            this.lHacienda.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lHacienda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lHacienda.Location = new System.Drawing.Point(529, 65);
            this.lHacienda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHacienda.Name = "lHacienda";
            this.lHacienda.Size = new System.Drawing.Size(450, 93);
            this.lHacienda.TabIndex = 2;
            this.lHacienda.Text = "HACIENDAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHaciendas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bSiguiente);
            this.groupBox2.Location = new System.Drawing.Point(426, 257);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(641, 380);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cbHaciendas
            // 
            this.cbHaciendas.FormattingEnabled = true;
            this.cbHaciendas.Location = new System.Drawing.Point(166, 163);
            this.cbHaciendas.Name = "cbHaciendas";
            this.cbHaciendas.Size = new System.Drawing.Size(292, 40);
            this.cbHaciendas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una hacienda";
            // 
            // bSiguiente
            // 
            this.bSiguiente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSiguiente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bSiguiente.Location = new System.Drawing.Point(229, 276);
            this.bSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(146, 44);
            this.bSiguiente.TabIndex = 3;
            this.bSiguiente.Text = "SIGUIENTE";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRegresar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bRegresar.Location = new System.Drawing.Point(13, 793);
            this.bRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(146, 44);
            this.bRegresar.TabIndex = 4;
            this.bRegresar.Text = "REGRESAR";
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // FormHaciendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 850);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHaciendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHaciendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lHacienda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbHaciendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bRegresar;
    }
}