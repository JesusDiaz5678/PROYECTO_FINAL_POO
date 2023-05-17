namespace I_Hacienda
{
    partial class FormVac_Res
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
            this.bBacteriana = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPotreros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bVacunar = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.lbNombreHa);
            this.groupBox1.Location = new System.Drawing.Point(-2, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbNombreHa
            // 
            this.lbNombreHa.AutoSize = true;
            this.lbNombreHa.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombreHa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNombreHa.Location = new System.Drawing.Point(309, 55);
            this.lbNombreHa.Name = "lbNombreHa";
            this.lbNombreHa.Size = new System.Drawing.Size(548, 68);
            this.lbNombreHa.TabIndex = 2;
            this.lbNombreHa.Text = "NOMBRE HACIENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bBacteriana);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbReses);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbPotreros);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bVacunar);
            this.groupBox2.Location = new System.Drawing.Point(305, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 443);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // bBacteriana
            // 
            this.bBacteriana.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bBacteriana.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bBacteriana.Location = new System.Drawing.Point(336, 320);
            this.bBacteriana.Name = "bBacteriana";
            this.bBacteriana.Size = new System.Drawing.Size(170, 66);
            this.bBacteriana.TabIndex = 14;
            this.bBacteriana.Text = "BACTERIANA";
            this.bBacteriana.UseVisualStyleBackColor = true;
            this.bBacteriana.Click += new System.EventHandler(this.bBacteriana_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(162, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleccione el tipo de vacuna";
            // 
            // cbReses
            // 
            this.cbReses.BackColor = System.Drawing.SystemColors.Info;
            this.cbReses.FormattingEnabled = true;
            this.cbReses.Location = new System.Drawing.Point(62, 176);
            this.cbReses.Margin = new System.Windows.Forms.Padding(2);
            this.cbReses.Name = "cbReses";
            this.cbReses.Size = new System.Drawing.Size(446, 33);
            this.cbReses.TabIndex = 12;
            this.cbReses.SelectedIndexChanged += new System.EventHandler(this.cbReses_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione una res:";
            // 
            // cbPotreros
            // 
            this.cbPotreros.BackColor = System.Drawing.SystemColors.Info;
            this.cbPotreros.FormattingEnabled = true;
            this.cbPotreros.Location = new System.Drawing.Point(62, 95);
            this.cbPotreros.Margin = new System.Windows.Forms.Padding(2);
            this.cbPotreros.Name = "cbPotreros";
            this.cbPotreros.Size = new System.Drawing.Size(446, 33);
            this.cbPotreros.TabIndex = 9;
            this.cbPotreros.SelectedIndexChanged += new System.EventHandler(this.cbPotreros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione el potrero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "VACUNAR RES";
            // 
            // bVacunar
            // 
            this.bVacunar.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bVacunar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bVacunar.Location = new System.Drawing.Point(62, 320);
            this.bVacunar.Name = "bVacunar";
            this.bVacunar.Size = new System.Drawing.Size(170, 66);
            this.bVacunar.TabIndex = 3;
            this.bVacunar.Text = "VIVA";
            this.bVacunar.UseVisualStyleBackColor = true;
            this.bVacunar.Click += new System.EventHandler(this.bVacunar_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bRegresar.Location = new System.Drawing.Point(1036, 618);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(115, 34);
            this.bRegresar.TabIndex = 8;
            this.bRegresar.Text = "REGRESAR";
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::I_Hacienda.Properties.Resources.Vacas_en_Lusera_1_1;
            this.pictureBox1.Image = global::I_Hacienda.Properties.Resources.Vacas_en_Lusera_1_1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1181, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormVac_Res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVac_Res";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVac_Res";
            this.Load += new System.EventHandler(this.FormVac_Res_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNombreHa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bBacteriana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbReses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPotreros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVacunar;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}