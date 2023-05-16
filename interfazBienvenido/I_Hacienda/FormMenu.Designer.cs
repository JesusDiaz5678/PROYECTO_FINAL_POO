namespace I_Hacienda
{
    partial class FormMenu
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
            this.cbPotreros = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lReses = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bConsultar_Ven = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bConsultar_Vac = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bAgregar_Res = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bAgregar_pot = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bVender_Res = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bVacunar_Res = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.lbNombreHa);
            this.groupBox1.Location = new System.Drawing.Point(-3, -20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1535, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbNombreHa
            // 
            this.lbNombreHa.AutoSize = true;
            this.lbNombreHa.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombreHa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNombreHa.Location = new System.Drawing.Point(399, 67);
            this.lbNombreHa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreHa.Name = "lbNombreHa";
            this.lbNombreHa.Size = new System.Drawing.Size(737, 93);
            this.lbNombreHa.TabIndex = 2;
            this.lbNombreHa.Text = "NOMBRE HACIENDA";
            this.lbNombreHa.Click += new System.EventHandler(this.lNombreHa_Click);
            // 
            // cbPotreros
            // 
            this.cbPotreros.FormattingEnabled = true;
            this.cbPotreros.Location = new System.Drawing.Point(16, 88);
            this.cbPotreros.Name = "cbPotreros";
            this.cbPotreros.Size = new System.Drawing.Size(764, 40);
            this.cbPotreros.TabIndex = 2;
            this.cbPotreros.SelectedIndexChanged += new System.EventHandler(this.cbPotreros_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lReses);
            this.groupBox2.Controls.Add(this.cbPotreros);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 552);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de reses del potrero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de potreros";
            // 
            // lReses
            // 
            this.lReses.FormattingEnabled = true;
            this.lReses.ItemHeight = 32;
            this.lReses.Location = new System.Drawing.Point(16, 207);
            this.lReses.Name = "lReses";
            this.lReses.Size = new System.Drawing.Size(764, 324);
            this.lReses.TabIndex = 3;
            this.lReses.SelectedIndexChanged += new System.EventHandler(this.lReses_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.bConsultar_Ven);
            this.panel1.Location = new System.Drawing.Point(892, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 109);
            this.panel1.TabIndex = 7;
            // 
            // bConsultar_Ven
            // 
            this.bConsultar_Ven.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bConsultar_Ven.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bConsultar_Ven.Location = new System.Drawing.Point(211, 27);
            this.bConsultar_Ven.Name = "bConsultar_Ven";
            this.bConsultar_Ven.Size = new System.Drawing.Size(276, 46);
            this.bConsultar_Ven.TabIndex = 0;
            this.bConsultar_Ven.Text = "Consultar Ventas";
            this.bConsultar_Ven.UseVisualStyleBackColor = true;
            this.bConsultar_Ven.Click += new System.EventHandler(this.bConsultar_Ven_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.bConsultar_Vac);
            this.panel2.Location = new System.Drawing.Point(892, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 109);
            this.panel2.TabIndex = 8;
            // 
            // bConsultar_Vac
            // 
            this.bConsultar_Vac.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bConsultar_Vac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bConsultar_Vac.Location = new System.Drawing.Point(211, 29);
            this.bConsultar_Vac.Name = "bConsultar_Vac";
            this.bConsultar_Vac.Size = new System.Drawing.Size(276, 46);
            this.bConsultar_Vac.TabIndex = 1;
            this.bConsultar_Vac.Text = "Consultar Vacunas";
            this.bConsultar_Vac.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Controls.Add(this.bAgregar_Res);
            this.panel3.Location = new System.Drawing.Point(892, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 109);
            this.panel3.TabIndex = 10;
            // 
            // bAgregar_Res
            // 
            this.bAgregar_Res.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bAgregar_Res.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAgregar_Res.Location = new System.Drawing.Point(211, 27);
            this.bAgregar_Res.Name = "bAgregar_Res";
            this.bAgregar_Res.Size = new System.Drawing.Size(276, 46);
            this.bAgregar_Res.TabIndex = 3;
            this.bAgregar_Res.Text = "Agregar Res";
            this.bAgregar_Res.UseVisualStyleBackColor = true;
            this.bAgregar_Res.Click += new System.EventHandler(this.bAgregar_Res_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.bAgregar_pot);
            this.panel4.Location = new System.Drawing.Point(892, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(640, 109);
            this.panel4.TabIndex = 9;
            // 
            // bAgregar_pot
            // 
            this.bAgregar_pot.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bAgregar_pot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAgregar_pot.Location = new System.Drawing.Point(211, 29);
            this.bAgregar_pot.Name = "bAgregar_pot";
            this.bAgregar_pot.Size = new System.Drawing.Size(276, 46);
            this.bAgregar_pot.TabIndex = 2;
            this.bAgregar_pot.Text = "Agregar Potrero";
            this.bAgregar_pot.UseVisualStyleBackColor = true;
            this.bAgregar_pot.Click += new System.EventHandler(this.bAgregar_pot_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.bVender_Res);
            this.panel5.Location = new System.Drawing.Point(892, 733);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(640, 119);
            this.panel5.TabIndex = 12;
            // 
            // bVender_Res
            // 
            this.bVender_Res.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bVender_Res.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bVender_Res.Location = new System.Drawing.Point(211, 32);
            this.bVender_Res.Name = "bVender_Res";
            this.bVender_Res.Size = new System.Drawing.Size(276, 46);
            this.bVender_Res.TabIndex = 5;
            this.bVender_Res.Text = "Vender Res";
            this.bVender_Res.UseVisualStyleBackColor = true;
            this.bVender_Res.Click += new System.EventHandler(this.bVender_Res_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleGreen;
            this.panel6.Controls.Add(this.bVacunar_Res);
            this.panel6.Location = new System.Drawing.Point(892, 608);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(640, 125);
            this.panel6.TabIndex = 11;
            // 
            // bVacunar_Res
            // 
            this.bVacunar_Res.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bVacunar_Res.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bVacunar_Res.Location = new System.Drawing.Point(211, 35);
            this.bVacunar_Res.Name = "bVacunar_Res";
            this.bVacunar_Res.Size = new System.Drawing.Size(276, 46);
            this.bVacunar_Res.TabIndex = 4;
            this.bVacunar_Res.Text = "Vacunar Res";
            this.bVacunar_Res.UseVisualStyleBackColor = true;
            this.bVacunar_Res.Click += new System.EventHandler(this.bVacunar_Res_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 850);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNombreHa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lReses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button bConsultar_Ven;
        private System.Windows.Forms.Button bConsultar_Vac;
        private System.Windows.Forms.Button bAgregar_pot;
        private System.Windows.Forms.Button bAgregar_Res;
        private System.Windows.Forms.Button bVender_Res;
        private System.Windows.Forms.Button bVacunar_Res;
        public System.Windows.Forms.ComboBox cbPotreros;
    }
}