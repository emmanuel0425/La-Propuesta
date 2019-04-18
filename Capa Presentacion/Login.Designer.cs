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
            this.LbIniciarSesion = new System.Windows.Forms.Label();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LbRecovery = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbIniciarSesion
            // 
            this.LbIniciarSesion.AutoSize = true;
            this.LbIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIniciarSesion.Location = new System.Drawing.Point(205, 8);
            this.LbIniciarSesion.Name = "LbIniciarSesion";
            this.LbIniciarSesion.Size = new System.Drawing.Size(145, 25);
            this.LbIniciarSesion.TabIndex = 0;
            this.LbIniciarSesion.Text = "Iniciar Sesion";
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.Location = new System.Drawing.Point(182, 162);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(62, 18);
            this.LbUsuario.TabIndex = 1;
            this.LbUsuario.Text = "Usuario";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(182, 183);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(220, 20);
            this.TBUsuario.TabIndex = 2;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(182, 250);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(220, 20);
            this.TBPassword.TabIndex = 4;
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(182, 229);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(93, 18);
            this.LbPassword.TabIndex = 3;
            this.LbPassword.Text = "Contraseña";
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(210, 333);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(158, 28);
            this.BtnEntrar.TabIndex = 5;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            // 
            // LbRecovery
            // 
            this.LbRecovery.AutoSize = true;
            this.LbRecovery.Location = new System.Drawing.Point(269, 273);
            this.LbRecovery.Name = "LbRecovery";
            this.LbRecovery.Size = new System.Drawing.Size(133, 13);
            this.LbRecovery.TabIndex = 6;
            this.LbRecovery.Text = "He olvidado mi contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.New_Login;
            this.pictureBox1.Location = new System.Drawing.Point(200, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbRecovery);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.LbIniciarSesion);
            this.Name = "Login";
            this.Tag = "";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbIniciarSesion;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label LbRecovery;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

