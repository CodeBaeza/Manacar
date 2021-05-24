
namespace ManaCar
{
    partial class EliminarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.tbEliminarUsuarioE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.btnEliminarE = new System.Windows.Forms.Button();
            this.dgvMostrarUsuarios = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // tbEliminarUsuarioE
            // 
            this.tbEliminarUsuarioE.BackColor = System.Drawing.SystemColors.Window;
            this.tbEliminarUsuarioE.Location = new System.Drawing.Point(267, 25);
            this.tbEliminarUsuarioE.Name = "tbEliminarUsuarioE";
            this.tbEliminarUsuarioE.Size = new System.Drawing.Size(228, 20);
            this.tbEliminarUsuarioE.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de usuarios";
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(12, 281);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarUsuarios.TabIndex = 3;
            this.btnMostrarUsuarios.Text = "Listar";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = false;
            this.btnMostrarUsuarios.Click += new System.EventHandler(this.btnMostrarUsuarios_Click);
            // 
            // btnEliminarE
            // 
            this.btnEliminarE.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarE.Location = new System.Drawing.Point(267, 51);
            this.btnEliminarE.Name = "btnEliminarE";
            this.btnEliminarE.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarE.TabIndex = 2;
            this.btnEliminarE.Text = "Eliminar";
            this.btnEliminarE.UseVisualStyleBackColor = false;
            this.btnEliminarE.Click += new System.EventHandler(this.btnEliminarE_Click);
            // 
            // dgvMostrarUsuarios
            // 
            this.dgvMostrarUsuarios.AllowUserToAddRows = false;
            this.dgvMostrarUsuarios.AllowUserToDeleteRows = false;
            this.dgvMostrarUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMostrarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarUsuarios.Location = new System.Drawing.Point(12, 25);
            this.dgvMostrarUsuarios.Name = "dgvMostrarUsuarios";
            this.dgvMostrarUsuarios.ReadOnly = true;
            this.dgvMostrarUsuarios.Size = new System.Drawing.Size(240, 249);
            this.dgvMostrarUsuarios.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManaCar.Properties.Resources.manacar1;
            this.pictureBox1.Location = new System.Drawing.Point(267, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 193);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(512, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvMostrarUsuarios);
            this.Controls.Add(this.btnEliminarE);
            this.Controls.Add(this.btnMostrarUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEliminarUsuarioE);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEliminarUsuarioE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrarUsuarios;
        private System.Windows.Forms.Button btnEliminarE;
        private System.Windows.Forms.DataGridView dgvMostrarUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}