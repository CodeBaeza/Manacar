
namespace ManaCar
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuarioN = new System.Windows.Forms.TextBox();
            this.tbContraseñaN = new System.Windows.Forms.TextBox();
            this.btnCrearUsuarioN = new System.Windows.Forms.Button();
            this.btnLimpiarN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // tbUsuarioN
            // 
            this.tbUsuarioN.Location = new System.Drawing.Point(28, 44);
            this.tbUsuarioN.Name = "tbUsuarioN";
            this.tbUsuarioN.Size = new System.Drawing.Size(301, 20);
            this.tbUsuarioN.TabIndex = 1;
            // 
            // tbContraseñaN
            // 
            this.tbContraseñaN.Location = new System.Drawing.Point(28, 83);
            this.tbContraseñaN.Name = "tbContraseñaN";
            this.tbContraseñaN.Size = new System.Drawing.Size(301, 20);
            this.tbContraseñaN.TabIndex = 2;
            // 
            // btnCrearUsuarioN
            // 
            this.btnCrearUsuarioN.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCrearUsuarioN.Location = new System.Drawing.Point(28, 109);
            this.btnCrearUsuarioN.Name = "btnCrearUsuarioN";
            this.btnCrearUsuarioN.Size = new System.Drawing.Size(75, 23);
            this.btnCrearUsuarioN.TabIndex = 3;
            this.btnCrearUsuarioN.Text = "Crear";
            this.btnCrearUsuarioN.UseVisualStyleBackColor = false;
            this.btnCrearUsuarioN.Click += new System.EventHandler(this.btnCrearUsuarioN_Click);
            // 
            // btnLimpiarN
            // 
            this.btnLimpiarN.BackColor = System.Drawing.Color.Khaki;
            this.btnLimpiarN.Location = new System.Drawing.Point(254, 109);
            this.btnLimpiarN.Name = "btnLimpiarN";
            this.btnLimpiarN.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarN.TabIndex = 4;
            this.btnLimpiarN.Text = "Limpiar";
            this.btnLimpiarN.UseVisualStyleBackColor = false;
            this.btnLimpiarN.Click += new System.EventHandler(this.btnLimpiarN_Click);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(357, 164);
            this.Controls.Add(this.btnLimpiarN);
            this.Controls.Add(this.btnCrearUsuarioN);
            this.Controls.Add(this.tbContraseñaN);
            this.Controls.Add(this.tbUsuarioN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear nuevo usuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuarioN;
        private System.Windows.Forms.TextBox tbContraseñaN;
        private System.Windows.Forms.Button btnCrearUsuarioN;
        private System.Windows.Forms.Button btnLimpiarN;
    }
}