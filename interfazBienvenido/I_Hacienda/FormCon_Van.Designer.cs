namespace I_Hacienda
{
    partial class FormCon_Van
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
            this.lbNombreHa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lVacunas = new System.Windows.Forms.ListBox();
            this.cbReses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPotreros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bVacunar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.lbNombreHa);
            this.groupBox1.Location = new System.Drawing.Point(-3, -20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1535, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lbNombreHa
            // 
            this.lbNombreHa.AutoSize = true;
            this.lbNombreHa.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombreHa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNombreHa.Location = new System.Drawing.Point(401, 69);
            this.lbNombreHa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreHa.Name = "lbNombreHa";
            this.lbNombreHa.Size = new System.Drawing.Size(737, 93);
            this.lbNombreHa.TabIndex = 2;
            this.lbNombreHa.Text = "NOMBRE HACIENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lVacunas);
            this.groupBox2.Controls.Add(this.cbReses);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbPotreros);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bVacunar);
            this.groupBox2.Location = new System.Drawing.Point(396, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(738, 620);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lVacunas
            // 
            this.lVacunas.FormattingEnabled = true;
            this.lVacunas.ItemHeight = 32;
            this.lVacunas.Location = new System.Drawing.Point(80, 317);
            this.lVacunas.Name = "lVacunas";
            this.lVacunas.Size = new System.Drawing.Size(578, 196);
            this.lVacunas.TabIndex = 13;
            // 
            // cbReses
            // 
            this.cbReses.FormattingEnabled = true;
            this.cbReses.Location = new System.Drawing.Point(80, 225);
            this.cbReses.Name = "cbReses";
            this.cbReses.Size = new System.Drawing.Size(578, 40);
            this.cbReses.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione una res:";
            // 
            // cbPotreros
            // 
            this.cbPotreros.FormattingEnabled = true;
            this.cbPotreros.Location = new System.Drawing.Point(80, 122);
            this.cbPotreros.Name = "cbPotreros";
            this.cbPotreros.Size = new System.Drawing.Size(578, 40);
            this.cbPotreros.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione el potrero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONSULTAR VACUNA";
            // 
            // bVacunar
            // 
            this.bVacunar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bVacunar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bVacunar.Location = new System.Drawing.Point(275, 568);
            this.bVacunar.Margin = new System.Windows.Forms.Padding(4);
            this.bVacunar.Name = "bVacunar";
            this.bVacunar.Size = new System.Drawing.Size(162, 44);
            this.bVacunar.TabIndex = 3;
            this.bVacunar.Text = "VACUNAR";
            this.bVacunar.UseVisualStyleBackColor = true;
            // 
            // FormCon_Van
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 850);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCon_Van";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCon_Van";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNombreHa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lVacunas;
        private System.Windows.Forms.ComboBox cbReses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPotreros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVacunar;
    }
}