
namespace Win_MiNegosio
{
    partial class frmInicioSesion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(298, 12);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(135, 124);
            this.imagen.TabIndex = 1;
            this.imagen.TabStop = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsuario.Location = new System.Drawing.Point(264, 142);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(215, 30);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.Text = "Usuario";
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContrasena.Location = new System.Drawing.Point(264, 178);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(215, 30);
            this.textBoxContrasena.TabIndex = 3;
            this.textBoxContrasena.Text = "Contraseña";
            this.textBoxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(298, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(502, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 26);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "x";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 260);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
    }
}

