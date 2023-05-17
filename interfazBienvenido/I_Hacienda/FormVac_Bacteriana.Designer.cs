namespace I_Hacienda
{
    partial class FormVac_Bacteriana
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
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.bVacunar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreV = new System.Windows.Forms.TextBox();
            this.cbLotes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.lbNombreHa);
            this.groupBox1.Location = new System.Drawing.Point(-2, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbNombreHa
            // 
            this.lbNombreHa.AutoSize = true;
            this.lbNombreHa.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombreHa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNombreHa.Location = new System.Drawing.Point(311, 56);
            this.lbNombreHa.Name = "lbNombreHa";
            this.lbNombreHa.Size = new System.Drawing.Size(548, 68);
            this.lbNombreHa.TabIndex = 2;
            this.lbNombreHa.Text = "NOMBRE HACIENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPeriodo);
            this.groupBox2.Controls.Add(this.bVacunar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbNombreV);
            this.groupBox2.Controls.Add(this.cbLotes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(305, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 476);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(62, 323);
            this.tbPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.PlaceholderText = "Periodo de aplicacion en dias";
            this.tbPeriodo.Size = new System.Drawing.Size(446, 31);
            this.tbPeriodo.TabIndex = 17;
            // 
            // bVacunar
            // 
            this.bVacunar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bVacunar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bVacunar.Location = new System.Drawing.Point(222, 412);
            this.bVacunar.Name = "bVacunar";
            this.bVacunar.Size = new System.Drawing.Size(125, 34);
            this.bVacunar.TabIndex = 16;
            this.bVacunar.Text = "VACUNAR";
            this.bVacunar.UseVisualStyleBackColor = true;
            this.bVacunar.Click += new System.EventHandler(this.bVacunar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingrese el periodo de aplicación:";
            // 
            // tbNombreV
            // 
            this.tbNombreV.Location = new System.Drawing.Point(62, 118);
            this.tbNombreV.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreV.Name = "tbNombreV";
            this.tbNombreV.PlaceholderText = "Agregue la etiqueta \'bacteriana\'";
            this.tbNombreV.Size = new System.Drawing.Size(446, 31);
            this.tbNombreV.TabIndex = 13;
            // 
            // cbLotes
            // 
            this.cbLotes.FormattingEnabled = true;
            this.cbLotes.Location = new System.Drawing.Point(62, 215);
            this.cbLotes.Margin = new System.Windows.Forms.Padding(2);
            this.cbLotes.Name = "cbLotes";
            this.cbLotes.Size = new System.Drawing.Size(446, 33);
            this.cbLotes.TabIndex = 12;
            this.cbLotes.SelectedIndexChanged += new System.EventHandler(this.cbLotes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione lote de vacuna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el nombre de vacuna:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "VACUNAR BACTERIANA";
            // 
            // bVolver
            // 
            this.bVolver.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bVolver.Location = new System.Drawing.Point(1043, 620);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(125, 34);
            this.bVolver.TabIndex = 10;
            this.bVolver.Text = "VOLVER";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // FormVac_Bacteriana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVac_Bacteriana";
            this.Text = "FormVac_Bacteriana";
            this.Load += new System.EventHandler(this.FormVac_Bacteriana_Load_1);
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
        private System.Windows.Forms.Button bVacunar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreV;
        private System.Windows.Forms.ComboBox cbLotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.Button bVolver;
    }
}