namespace I_Hacienda
{
    partial class FormAgre_Pot
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
            this.tbEdadmin = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bCrear = new System.Windows.Forms.Button();
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
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lNombreHa
            // 
            this.lNombreHa.AutoSize = true;
            this.lNombreHa.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lNombreHa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lNombreHa.Location = new System.Drawing.Point(308, 54);
            this.lNombreHa.Name = "lNombreHa";
            this.lNombreHa.Size = new System.Drawing.Size(548, 68);
            this.lNombreHa.TabIndex = 2;
            this.lNombreHa.Text = "NOMBRE HACIENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEdadmin);
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bCrear);
            this.groupBox2.Location = new System.Drawing.Point(341, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 388);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // tbEdadmin
            // 
            this.tbEdadmin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbEdadmin.Location = new System.Drawing.Point(40, 204);
            this.tbEdadmin.Name = "tbEdadmin";
            this.tbEdadmin.PlaceholderText = "Edad mínima del potrero";
            this.tbEdadmin.Size = new System.Drawing.Size(422, 28);
            this.tbEdadmin.TabIndex = 8;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbID.Location = new System.Drawing.Point(40, 124);
            this.tbID.Name = "tbID";
            this.tbID.PlaceholderText = "ID del potrero";
            this.tbID.Size = new System.Drawing.Size(422, 28);
            this.tbID.TabIndex = 7;
            this.tbID.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "AGREGAR POTRERO";
            // 
            // bCrear
            // 
            this.bCrear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCrear.Location = new System.Drawing.Point(182, 316);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(125, 34);
            this.bCrear.TabIndex = 3;
            this.bCrear.Text = "CREAR\r\n";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bContinuar_Click);
            // 
            // bContinuar
            // 
            this.bContinuar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bContinuar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bContinuar.Location = new System.Drawing.Point(1008, 608);
            this.bContinuar.Name = "bContinuar";
            this.bContinuar.Size = new System.Drawing.Size(125, 34);
            this.bContinuar.TabIndex = 12;
            this.bContinuar.Text = "CONTINUAR";
            this.bContinuar.UseVisualStyleBackColor = true;
            this.bContinuar.Click += new System.EventHandler(this.bContinuar_Click_1);
            // 
            // FormAgre_Pot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.bContinuar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAgre_Pot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgre_Pot";
            this.Load += new System.EventHandler(this.FormAgre_Pot_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbEdadmin;
        private System.Windows.Forms.Button bContinuar;
    }
}