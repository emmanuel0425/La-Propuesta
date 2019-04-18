namespace Capa_Presentacion
{
    partial class Login
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
            this.GBSesion = new System.Windows.Forms.GroupBox();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LLBOlvidasteContraseña = new System.Windows.Forms.LinkLabel();
            this.GBSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSesion
            // 
            this.GBSesion.BackColor = System.Drawing.SystemColors.Control;
            this.GBSesion.BackgroundImage = global::Capa_Presentacion.Properties.Resources.New_Login;
            this.GBSesion.Controls.Add(this.LLBOlvidasteContraseña);
            this.GBSesion.Controls.Add(this.BtnEntrar);
            this.GBSesion.Controls.Add(this.BtnCancelar);
            this.GBSesion.Controls.Add(this.TBContraseña);
            this.GBSesion.Controls.Add(this.TBUsuario);
            this.GBSesion.Controls.Add(this.label2);
            this.GBSesion.Controls.Add(this.LbUsuario);
            this.GBSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSesion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GBSesion.Location = new System.Drawing.Point(24, 12);
            this.GBSesion.Name = "GBSesion";
            this.GBSesion.Size = new System.Drawing.Size(346, 258);
            this.GBSesion.TabIndex = 0;
            this.GBSesion.TabStop = false;
            this.GBSesion.Text = "Iniciar Sesión";
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Location = new System.Drawing.Point(123, 48);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(58, 13);
            this.LbUsuario.TabIndex = 0;
            this.LbUsuario.Text = "Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña :";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(229, 45);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(100, 20);
            this.TBUsuario.TabIndex = 2;
            // 
            // TBContraseña
            // 
            this.TBContraseña.Location = new System.Drawing.Point(229, 81);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(100, 20);
            this.TBContraseña.TabIndex = 3;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancelar.Location = new System.Drawing.Point(126, 174);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(254, 174);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtnEntrar.TabIndex = 4;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            // 
            // LLBOlvidasteContraseña
            // 
            this.LLBOlvidasteContraseña.AutoSize = true;
            this.LLBOlvidasteContraseña.Location = new System.Drawing.Point(123, 230);
            this.LLBOlvidasteContraseña.Name = "LLBOlvidasteContraseña";
            this.LLBOlvidasteContraseña.Size = new System.Drawing.Size(149, 13);
            this.LLBOlvidasteContraseña.TabIndex = 5;
            this.LLBOlvidasteContraseña.TabStop = true;
            this.LLBOlvidasteContraseña.Text = "Olvidaste tu contraseña?";
            // 
            // Login
            // 
            this.AcceptButton = this.BtnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(415, 302);
            this.Controls.Add(this.GBSesion);
            this.Name = "Login";
            this.Tag = "";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.GBSesion.ResumeLayout(false);
            this.GBSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBSesion;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.LinkLabel LLBOlvidasteContraseña;
    }
}

