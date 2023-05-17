namespace I_Hacienda
{
    partial class FormCon_Ven
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
            this.lNombreHa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbVentas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lreses_ven = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bContinuar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.lNombreHa);
            this.groupBox1.Location = new System.Drawing.Point(-2, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lNombreHa
            // 
            this.lNombreHa.AutoSize = true;
            this.lNombreHa.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lNombreHa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lNombreHa.Location = new System.Drawing.Point(308, 53);
            this.lNombreHa.Name = "lNombreHa";
            this.lNombreHa.Size = new System.Drawing.Size(548, 68);
            this.lNombreHa.TabIndex = 2;
            this.lNombreHa.Text = "NOMBRE HACIENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbVentas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lreses_ven);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bContinuar);
            this.groupBox2.Location = new System.Drawing.Point(-2, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1181, 495);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbVentas
            // 
            this.lbVentas.FormattingEnabled = true;
            this.lbVentas.ItemHeight = 25;
            this.lbVentas.Location = new System.Drawing.Point(235, 144);
            this.lbVentas.Margin = new System.Windows.Forms.Padding(2);
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.Size = new System.Drawing.Size(934, 254);
            this.lbVentas.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista de reses vendidas";
            // 
            // lreses_ven
            // 
            this.lreses_ven.FormattingEnabled = true;
            this.lreses_ven.ItemHeight = 25;
            this.lreses_ven.Location = new System.Drawing.Point(13, 144);
            this.lreses_ven.Margin = new System.Windows.Forms.Padding(2);
            this.lreses_ven.Name = "lreses_ven";
            this.lreses_ven.Size = new System.Drawing.Size(198, 254);
            this.lreses_ven.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(446, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONSULTAR VENTA";
            // 
            // bContinuar
            // 
            this.bContinuar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bContinuar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bContinuar.Location = new System.Drawing.Point(479, 434);
            this.bContinuar.Name = "bContinuar";
            this.bContinuar.Size = new System.Drawing.Size(125, 34);
            this.bContinuar.TabIndex = 3;
            this.bContinuar.Text = "CONTINUAR";
            this.bContinuar.UseVisualStyleBackColor = true;
            this.bContinuar.Click += new System.EventHandler(this.bContinuar_Click);
            // 
            // FormCon_Ven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCon_Ven";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCon_Ven";
            this.Load += new System.EventHandler(this.FormCon_Ven_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lNombreHa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bContinuar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lreses_ven;
        private System.Windows.Forms.ListBox lbVentas;
        private System.Windows.Forms.Label label2;
    }
}