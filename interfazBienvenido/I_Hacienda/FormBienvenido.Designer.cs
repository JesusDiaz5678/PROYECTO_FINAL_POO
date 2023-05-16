
using System.Drawing;

namespace I_Hacienda
{
    partial class FormBienvenido
    {
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenido));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCrear = new System.Windows.Forms.Button();
            this.tbEdadmin = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCrear);
            this.groupBox2.Controls.Add(this.tbEdadmin);
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.tbNombre);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // bCrear
            // 
            resources.ApplyResources(this.bCrear, "bCrear");
            this.bCrear.Name = "bCrear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // tbEdadmin
            // 
            resources.ApplyResources(this.tbEdadmin, "tbEdadmin");
            this.tbEdadmin.Name = "tbEdadmin";
            // 
            // tbID
            // 
            resources.ApplyResources(this.tbID, "tbID");
            this.tbID.Name = "tbID";
            this.tbID.Tag = "";
            // 
            // tbNombre
            // 
            resources.ApplyResources(this.tbNombre, "tbNombre");
            this.tbNombre.Name = "tbNombre";
            // 
            // FormBienvenido
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBienvenido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.TextBox tbEdadmin;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNombre;
    }
}

