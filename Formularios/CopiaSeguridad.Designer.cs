
namespace ManaCar
{
    partial class CopiaSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopiaSeguridad));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCS = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreCS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPathCopia = new System.Windows.Forms.Button();
            this.btnGuardarCS = new System.Windows.Forms.Button();
            this.tbPathCS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la copia";
            // 
            // dtpFechaCS
            // 
            this.dtpFechaCS.Enabled = false;
            this.dtpFechaCS.Location = new System.Drawing.Point(127, 37);
            this.dtpFechaCS.Name = "dtpFechaCS";
            this.dtpFechaCS.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta destino";
            // 
            // tbNombreCS
            // 
            this.tbNombreCS.Location = new System.Drawing.Point(12, 37);
            this.tbNombreCS.Name = "tbNombreCS";
            this.tbNombreCS.Size = new System.Drawing.Size(100, 20);
            this.tbNombreCS.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // btnPathCopia
            // 
            this.btnPathCopia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPathCopia.Location = new System.Drawing.Point(289, 84);
            this.btnPathCopia.Name = "btnPathCopia";
            this.btnPathCopia.Size = new System.Drawing.Size(38, 20);
            this.btnPathCopia.TabIndex = 4;
            this.btnPathCopia.Text = "...";
            this.btnPathCopia.UseVisualStyleBackColor = false;
            this.btnPathCopia.Click += new System.EventHandler(this.btnPathCopia_Click);
            // 
            // btnGuardarCS
            // 
            this.btnGuardarCS.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGuardarCS.Location = new System.Drawing.Point(12, 110);
            this.btnGuardarCS.Name = "btnGuardarCS";
            this.btnGuardarCS.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCS.TabIndex = 5;
            this.btnGuardarCS.Text = "Guardar";
            this.btnGuardarCS.UseVisualStyleBackColor = false;
            this.btnGuardarCS.Click += new System.EventHandler(this.btnGuardarCS_Click);
            // 
            // tbPathCS
            // 
            this.tbPathCS.Location = new System.Drawing.Point(12, 84);
            this.tbPathCS.Name = "tbPathCS";
            this.tbPathCS.Size = new System.Drawing.Size(271, 20);
            this.tbPathCS.TabIndex = 3;
            // 
            // CopiaSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(353, 154);
            this.Controls.Add(this.btnGuardarCS);
            this.Controls.Add(this.btnPathCopia);
            this.Controls.Add(this.tbPathCS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreCS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaCS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CopiaSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copia de seguridad";
            this.Load += new System.EventHandler(this.CopiaSeguridad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreCS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPathCopia;
        private System.Windows.Forms.Button btnGuardarCS;
        private System.Windows.Forms.TextBox tbPathCS;
    }
}