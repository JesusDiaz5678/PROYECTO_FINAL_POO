namespace I_Hacienda
{
    partial class FormAgre_Res
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipo_Res = new System.Windows.Forms.ComboBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bCrear = new System.Windows.Forms.Button();
            this.bContinuar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.lNombreHa);
            this.groupBox1.Location = new System.Drawing.Point(-3, -20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1535, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lNombreHa
            // 
            this.lNombreHa.AutoSize = true;
            this.lNombreHa.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lNombreHa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lNombreHa.Location = new System.Drawing.Point(402, 70);
            this.lNombreHa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombreHa.Name = "lNombreHa";
            this.lNombreHa.Size = new System.Drawing.Size(737, 93);
            this.lNombreHa.TabIndex = 2;
            this.lNombreHa.Text = "NOMBRE HACIENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::I_Hacienda.Properties.Resources.vaca_ganado_vaca_lechera;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTipo_Res);
            this.groupBox2.Controls.Add(this.tbEdad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bCrear);
            this.groupBox2.Location = new System.Drawing.Point(443, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(641, 519);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingrese:";
            // 
            // cbTipo_Res
            // 
            this.cbTipo_Res.BackColor = System.Drawing.SystemColors.Info;
            this.cbTipo_Res.FormattingEnabled = true;
            this.cbTipo_Res.Location = new System.Drawing.Point(52, 156);
            this.cbTipo_Res.Name = "cbTipo_Res";
            this.cbTipo_Res.Size = new System.Drawing.Size(547, 40);
            this.cbTipo_Res.TabIndex = 9;
            // 
            // tbEdad
            // 
            this.tbEdad.BackColor = System.Drawing.SystemColors.Info;
            this.tbEdad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbEdad.Location = new System.Drawing.Point(52, 326);
            this.tbEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.PlaceholderText = "Edad de la res";
            this.tbEdad.Size = new System.Drawing.Size(547, 35);
            this.tbEdad.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione el tipo de res:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "AGREGAR RES";
            // 
            // bCrear
            // 
            this.bCrear.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bCrear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCrear.Location = new System.Drawing.Point(218, 402);
            this.bCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(186, 76);
            this.bCrear.TabIndex = 3;
            this.bCrear.Text = "AGREGAR RES";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bContinuar_Click);
            // 
            // bContinuar
            // 
            this.bContinuar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bContinuar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bContinuar.Location = new System.Drawing.Point(1295, 777);
            this.bContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bContinuar.Name = "bContinuar";
            this.bContinuar.Size = new System.Drawing.Size(162, 44);
            this.bContinuar.TabIndex = 11;
            this.bContinuar.Text = "CONTINUAR";
            this.bContinuar.UseVisualStyleBackColor = true;
            this.bContinuar.Click += new System.EventHandler(this.bContinuar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::I_Hacienda.Properties.Resources.vaca_ganado_vaca_lechera;
            this.pictureBox1.InitialImage = global::I_Hacienda.Properties.Resources.AdobeStock_112363536_khj__1248x698_abc;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1542, 662);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormAgre_Res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 850);
            this.Controls.Add(this.bContinuar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAgre_Res";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgre_Res";
            this.Load += new System.EventHandler(this.FormAgre_Res_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lNombreHa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.ComboBox cbTipo_Res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bContinuar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}