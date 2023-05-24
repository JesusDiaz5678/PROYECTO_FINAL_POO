namespace I_Hacienda
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.lHacienda);
            this.groupBox1.Location = new System.Drawing.Point(-2, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lHacienda
            // 
            this.lHacienda.AutoSize = true;
            this.lHacienda.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lHacienda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lHacienda.Location = new System.Drawing.Point(407, 51);
            this.lHacienda.Name = "lHacienda";
            this.lHacienda.Size = new System.Drawing.Size(336, 68);
            this.lHacienda.TabIndex = 2;
            this.lHacienda.Text = "HACIENDAS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::I_Hacienda.Properties.Resources._407882;
            this.groupBox2.Controls.Add(this.cbHaciendas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bSiguiente);
            this.groupBox2.Location = new System.Drawing.Point(339, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 297);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cbHaciendas
            // 
            this.cbHaciendas.FormattingEnabled = true;
            this.cbHaciendas.Location = new System.Drawing.Point(128, 127);
            this.cbHaciendas.Margin = new System.Windows.Forms.Padding(2);
            this.cbHaciendas.Name = "cbHaciendas";
            this.cbHaciendas.Size = new System.Drawing.Size(226, 33);
            this.cbHaciendas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una hacienda";
            // 
            // bSiguiente
            // 
            this.bSiguiente.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bSiguiente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bSiguiente.Location = new System.Drawing.Point(168, 216);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(149, 34);
            this.bSiguiente.TabIndex = 3;
            this.bSiguiente.Text = "SIGUIENTE";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bRegresar.Location = new System.Drawing.Point(12, 618);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(222, 34);
            this.bRegresar.TabIndex = 3;
            this.bRegresar.Text = "CREAR HACIENDA";
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::I_Hacienda.Properties.Resources._407882;
            this.pictureBox1.InitialImage = global::I_Hacienda.Properties.Resources._407882;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 152);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1181, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormHaciendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHaciendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHaciendas";
            this.Load += new System.EventHandler(this.FormHaciendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}