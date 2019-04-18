namespace Capa_Presentacion
{
    partial class Busquedad_Empleados
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
            this.CHBEmpleadoActivo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBEmpleadoSector = new System.Windows.Forms.TextBox();
            this.LBSector = new System.Windows.Forms.Label();
            this.CBEmpleadoProvincia = new System.Windows.Forms.ComboBox();
            this.LbEmpleadoProvincia = new System.Windows.Forms.Label();
            this.TBEmpleadoCalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBEmpleadoMunicipio = new System.Windows.Forms.ComboBox();
            this.LbEmpleadoMunicipio = new System.Windows.Forms.Label();
            this.TBEmpleadoCedula = new System.Windows.Forms.MaskedTextBox();
            this.TBEmpleadoCelular = new System.Windows.Forms.MaskedTextBox();
            this.TBEmpleadoTelefono = new System.Windows.Forms.MaskedTextBox();
            this.DTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.LbEmplNameBusq = new System.Windows.Forms.Label();
            this.CBCargo = new System.Windows.Forms.ComboBox();
            this.CBEmpleadoEstadoCivil = new System.Windows.Forms.ComboBox();
            this.CBEmpleadoSexo = new System.Windows.Forms.ComboBox();
            this.TBEmpleadoEmail = new System.Windows.Forms.TextBox();
            this.TBEmpleadoApellidos = new System.Windows.Forms.TextBox();
            this.TBEmpleadoNombres = new System.Windows.Forms.TextBox();
            this.LbCargo = new System.Windows.Forms.Label();
            this.LbEmpleadoEstadoCivil = new System.Windows.Forms.Label();
            this.LbEmpleadoSexo = new System.Windows.Forms.Label();
            this.LbEmpleadoEmail = new System.Windows.Forms.Label();
            this.LbEmpleadoCedula = new System.Windows.Forms.Label();
            this.LbEmpleadoCelular = new System.Windows.Forms.Label();
            this.LbEmpleadoTelefono = new System.Windows.Forms.Label();
            this.LbEmpFechaNacimiento = new System.Windows.Forms.Label();
            this.LbEmpApellidos = new System.Windows.Forms.Label();
            this.GBBusquedadEmp = new System.Windows.Forms.GroupBox();
            this.LbEmpleadoInfo = new System.Windows.Forms.Label();
            this.TBEmplNombBusq = new System.Windows.Forms.TextBox();
            this.TBEmplCodeBusq = new System.Windows.Forms.TextBox();
            this.LbEmplNombBusq = new System.Windows.Forms.Label();
            this.LbEmplCodeBusq = new System.Windows.Forms.Label();
            this.BtnEliminarRegistroEmpleado = new System.Windows.Forms.Button();
            this.BtnActualizarRegistroEmpleado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GBBusquedadEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHBEmpleadoActivo
            // 
            this.CHBEmpleadoActivo.AutoSize = true;
            this.CHBEmpleadoActivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHBEmpleadoActivo.Location = new System.Drawing.Point(814, 310);
            this.CHBEmpleadoActivo.Name = "CHBEmpleadoActivo";
            this.CHBEmpleadoActivo.Size = new System.Drawing.Size(56, 17);
            this.CHBEmpleadoActivo.TabIndex = 62;
            this.CHBEmpleadoActivo.Text = "Activo";
            this.CHBEmpleadoActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBEmpleadoSector);
            this.groupBox1.Controls.Add(this.LBSector);
            this.groupBox1.Controls.Add(this.CBEmpleadoProvincia);
            this.groupBox1.Controls.Add(this.LbEmpleadoProvincia);
            this.groupBox1.Controls.Add(this.TBEmpleadoCalle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBEmpleadoMunicipio);
            this.groupBox1.Controls.Add(this.LbEmpleadoMunicipio);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(66, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 153);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio";
            // 
            // TBEmpleadoSector
            // 
            this.TBEmpleadoSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmpleadoSector.Location = new System.Drawing.Point(444, 53);
            this.TBEmpleadoSector.Name = "TBEmpleadoSector";
            this.TBEmpleadoSector.Size = new System.Drawing.Size(397, 24);
            this.TBEmpleadoSector.TabIndex = 33;
            // 
            // LBSector
            // 
            this.LBSector.AutoSize = true;
            this.LBSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LBSector.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBSector.Location = new System.Drawing.Point(444, 32);
            this.LBSector.Name = "LBSector";
            this.LBSector.Size = new System.Drawing.Size(52, 18);
            this.LBSector.TabIndex = 34;
            this.LBSector.Text = "Sector";
            // 
            // CBEmpleadoProvincia
            // 
            this.CBEmpleadoProvincia.DisplayMember = "Pro_Nombre";
            this.CBEmpleadoProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CBEmpleadoProvincia.FormattingEnabled = true;
            this.CBEmpleadoProvincia.Location = new System.Drawing.Point(9, 117);
            this.CBEmpleadoProvincia.Name = "CBEmpleadoProvincia";
            this.CBEmpleadoProvincia.Size = new System.Drawing.Size(394, 26);
            this.CBEmpleadoProvincia.TabIndex = 29;
            this.CBEmpleadoProvincia.ValueMember = "Pro_ID";
            // 
            // LbEmpleadoProvincia
            // 
            this.LbEmpleadoProvincia.AutoSize = true;
            this.LbEmpleadoProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpleadoProvincia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpleadoProvincia.Location = new System.Drawing.Point(6, 96);
            this.LbEmpleadoProvincia.Name = "LbEmpleadoProvincia";
            this.LbEmpleadoProvincia.Size = new System.Drawing.Size(69, 18);
            this.LbEmpleadoProvincia.TabIndex = 7;
            this.LbEmpleadoProvincia.Text = "Provincia";
            // 
            // TBEmpleadoCalle
            // 
            this.TBEmpleadoCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmpleadoCalle.Location = new System.Drawing.Point(6, 53);
            this.TBEmpleadoCalle.Name = "TBEmpleadoCalle";
            this.TBEmpleadoCalle.Size = new System.Drawing.Size(397, 24);
            this.TBEmpleadoCalle.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Calle";
            // 
            // CBEmpleadoMunicipio
            // 
            this.CBEmpleadoMunicipio.DisplayMember = "Mu_Nombre";
            this.CBEmpleadoMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CBEmpleadoMunicipio.FormattingEnabled = true;
            this.CBEmpleadoMunicipio.Location = new System.Drawing.Point(447, 117);
            this.CBEmpleadoMunicipio.Name = "CBEmpleadoMunicipio";
            this.CBEmpleadoMunicipio.Size = new System.Drawing.Size(394, 26);
            this.CBEmpleadoMunicipio.TabIndex = 30;
            this.CBEmpleadoMunicipio.ValueMember = "Mu_ID";
            // 
            // LbEmpleadoMunicipio
            // 
            this.LbEmpleadoMunicipio.AutoSize = true;
            this.LbEmpleadoMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpleadoMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpleadoMunicipio.Location = new System.Drawing.Point(444, 96);
            this.LbEmpleadoMunicipio.Name = "LbEmpleadoMunicipio";
            this.LbEmpleadoMunicipio.Size = new System.Drawing.Size(71, 18);
            this.LbEmpleadoMunicipio.TabIndex = 8;
            this.LbEmpleadoMunicipio.Text = "Municipio";
            // 
            // TBEmpleadoCedula
            // 
            this.TBEmpleadoCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmpleadoCedula.Location = new System.Drawing.Point(215, 284);
            this.TBEmpleadoCedula.Mask = "999-9999999-9";
            this.TBEmpleadoCedula.Name = "TBEmpleadoCedula";
            this.TBEmpleadoCedula.Size = new System.Drawing.Size(202, 24);
            this.TBEmpleadoCedula.TabIndex = 60;
            // 
            // TBEmpleadoCelular
            // 
            this.TBEmpleadoCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmpleadoCelular.Location = new System.Drawing.Point(668, 108);
            this.TBEmpleadoCelular.Mask = "(999) 000-0000";
            this.TBEmpleadoCelular.Name = "TBEmpleadoCelular";
            this.TBEmpleadoCelular.Size = new System.Drawing.Size(202, 24);
            this.TBEmpleadoCelular.TabIndex = 59;
            // 
            // TBEmpleadoTelefono
            // 
            this.TBEmpleadoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmpleadoTelefono.Location = new System.Drawing.Point(668, 147);
            this.TBEmpleadoTelefono.Mask = "(999) 000-0000";
            this.TBEmpleadoTelefono.Name = "TBEmpleadoTelefono";
            this.TBEmpleadoTelefono.Size = new System.Drawing.Size(202, 24);
            this.TBEmpleadoTelefono.TabIndex = 58;
            // 
            // DTPFechaNac
            // 
            this.DTPFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DTPFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaNac.Location = new System.Drawing.Point(215, 237);
            this.DTPFechaNac.Name = "DTPFechaNac";
            this.DTPFechaNac.Size = new System.Drawing.Size(202, 24);
            this.DTPFechaNac.TabIndex = 57;
            // 
            // LbEmplNameBusq
            // 
            this.LbEmplNameBusq.AutoSize = true;
            this.LbEmplNameBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmplNameBusq.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmplNameBusq.Location = new System.Drawing.Point(125, 114);
            this.LbEmplNameBusq.Name = "LbEmplNameBusq";
            this.LbEmplNameBusq.Size = new System.Drawing.Size(70, 18);
            this.LbEmplNameBusq.TabIndex = 56;
            this.LbEmplNameBusq.Text = "Nombres";
            // 
            // CBCargo
            // 
            this.CBCargo.DisplayMember = "Cargo_Nombre";
            this.CBCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CBCargo.FormattingEnabled = true;
            this.CBCargo.Location = new System.Drawing.Point(668, 278);
            this.CBCargo.Name = "CBCargo";
            this.CBCargo.Size = new System.Drawing.Size(202, 26);
            this.CBCargo.TabIndex = 55;
            this.CBCargo.ValueMember = "Cargo_ID";
            // 
            // CBEmpleadoEstadoCivil
            // 
            this.CBEmpleadoEstadoCivil.DisplayMember = "EstadoC_Descripcion";
            this.CBEmpleadoEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CBEmpleadoEstadoCivil.FormattingEnabled = true;
            this.CBEmpleadoEstadoCivil.Location = new System.Drawing.Point(668, 229);
            this.CBEmpleadoEstadoCivil.Name = "CBEmpleadoEstadoCivil";
            this.CBEmpleadoEstadoCivil.Size = new System.Drawing.Size(202, 26);
            this.CBEmpleadoEstadoCivil.TabIndex = 54;
            this.CBEmpleadoEstadoCivil.ValueMember = "EstadoC_ID";
            // 
            // CBEmpleadoSexo
            // 
            this.CBEmpleadoSexo.DisplayMember = "Sexo_Descripcion";
            this.CBEmpleadoSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CBEmpleadoSexo.FormattingEnabled = true;
            this.CBEmpleadoSexo.Location = new System.Drawing.Point(215, 193);
            this.CBEmpleadoSexo.Name = "CBEmpleadoSexo";
            this.CBEmpleadoSexo.Size = new System.Drawing.Size(202, 26);
            this.CBEmpleadoSexo.TabIndex = 53;
            this.CBEmpleadoSexo.ValueMember = "Sexo_ID";
            // 
            // TBEmpleadoEmail
            // 
            this.TBEmpleadoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmpleadoEmail.Location = new System.Drawing.Point(668, 187);
            this.TBEmpleadoEmail.Name = "TBEmpleadoEmail";
            this.TBEmpleadoEmail.Size = new System.Drawing.Size(202, 24);
            this.TBEmpleadoEmail.TabIndex = 52;
            // 
            // TBEmpleadoApellidos
            // 
            this.TBEmpleadoApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmpleadoApellidos.Location = new System.Drawing.Point(215, 153);
            this.TBEmpleadoApellidos.Name = "TBEmpleadoApellidos";
            this.TBEmpleadoApellidos.Size = new System.Drawing.Size(202, 24);
            this.TBEmpleadoApellidos.TabIndex = 50;
            // 
            // TBEmpleadoNombres
            // 
            this.TBEmpleadoNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmpleadoNombres.Location = new System.Drawing.Point(215, 111);
            this.TBEmpleadoNombres.Name = "TBEmpleadoNombres";
            this.TBEmpleadoNombres.Size = new System.Drawing.Size(202, 24);
            this.TBEmpleadoNombres.TabIndex = 49;
            // 
            // LbCargo
            // 
            this.LbCargo.AutoSize = true;
            this.LbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbCargo.Location = new System.Drawing.Point(599, 283);
            this.LbCargo.Name = "LbCargo";
            this.LbCargo.Size = new System.Drawing.Size(49, 18);
            this.LbCargo.TabIndex = 48;
            this.LbCargo.Text = "Cargo";
            // 
            // LbEmpleadoEstadoCivil
            // 
            this.LbEmpleadoEstadoCivil.AutoSize = true;
            this.LbEmpleadoEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpleadoEstadoCivil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpleadoEstadoCivil.Location = new System.Drawing.Point(562, 237);
            this.LbEmpleadoEstadoCivil.Name = "LbEmpleadoEstadoCivil";
            this.LbEmpleadoEstadoCivil.Size = new System.Drawing.Size(86, 18);
            this.LbEmpleadoEstadoCivil.TabIndex = 47;
            this.LbEmpleadoEstadoCivil.Text = "Estado Civil";
            // 
            // LbEmpleadoSexo
            // 
            this.LbEmpleadoSexo.AutoSize = true;
            this.LbEmpleadoSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpleadoSexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpleadoSexo.Location = new System.Drawing.Point(150, 196);
            this.LbEmpleadoSexo.Name = "LbEmpleadoSexo";
            this.LbEmpleadoSexo.Size = new System.Drawing.Size(42, 18);
            this.LbEmpleadoSexo.TabIndex = 46;
            this.LbEmpleadoSexo.Text = "Sexo";
            // 
            // LbEmpleadoEmail
            // 
            this.LbEmpleadoEmail.AutoSize = true;
            this.LbEmpleadoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpleadoEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpleadoEmail.Location = new System.Drawing.Point(603, 193);
            this.LbEmpleadoEmail.Name = "LbEmpleadoEmail";
            this.LbEmpleadoEmail.Size = new System.Drawing.Size(45, 18);
            this.LbEmpleadoEmail.TabIndex = 45;
            this.LbEmpleadoEmail.Text = "Email";
            // 
            // LbEmpleadoCedula
            // 
            this.LbEmpleadoCedula.AutoSize = true;
            this.LbEmpleadoCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpleadoCedula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpleadoCedula.Location = new System.Drawing.Point(141, 287);
            this.LbEmpleadoCedula.Name = "LbEmpleadoCedula";
            this.LbEmpleadoCedula.Size = new System.Drawing.Size(54, 18);
            this.LbEmpleadoCedula.TabIndex = 44;
            this.LbEmpleadoCedula.Text = "Cedula";
            // 
            // LbEmpleadoCelular
            // 
            this.LbEmpleadoCelular.AutoSize = true;
            this.LbEmpleadoCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpleadoCelular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpleadoCelular.Location = new System.Drawing.Point(594, 105);
            this.LbEmpleadoCelular.Name = "LbEmpleadoCelular";
            this.LbEmpleadoCelular.Size = new System.Drawing.Size(54, 18);
            this.LbEmpleadoCelular.TabIndex = 43;
            this.LbEmpleadoCelular.Text = "Celular";
            // 
            // LbEmpleadoTelefono
            // 
            this.LbEmpleadoTelefono.AutoSize = true;
            this.LbEmpleadoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpleadoTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpleadoTelefono.Location = new System.Drawing.Point(582, 153);
            this.LbEmpleadoTelefono.Name = "LbEmpleadoTelefono";
            this.LbEmpleadoTelefono.Size = new System.Drawing.Size(66, 18);
            this.LbEmpleadoTelefono.TabIndex = 42;
            this.LbEmpleadoTelefono.Text = "Teléfono";
            // 
            // LbEmpFechaNacimiento
            // 
            this.LbEmpFechaNacimiento.AutoSize = true;
            this.LbEmpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpFechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpFechaNacimiento.Location = new System.Drawing.Point(50, 240);
            this.LbEmpFechaNacimiento.Name = "LbEmpFechaNacimiento";
            this.LbEmpFechaNacimiento.Size = new System.Drawing.Size(145, 18);
            this.LbEmpFechaNacimiento.TabIndex = 40;
            this.LbEmpFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // LbEmpApellidos
            // 
            this.LbEmpApellidos.AutoSize = true;
            this.LbEmpApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbEmpApellidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmpApellidos.Location = new System.Drawing.Point(128, 153);
            this.LbEmpApellidos.Name = "LbEmpApellidos";
            this.LbEmpApellidos.Size = new System.Drawing.Size(67, 18);
            this.LbEmpApellidos.TabIndex = 39;
            this.LbEmpApellidos.Text = "Apellidos";
            // 
            // GBBusquedadEmp
            // 
            this.GBBusquedadEmp.Controls.Add(this.LbEmpleadoInfo);
            this.GBBusquedadEmp.Controls.Add(this.TBEmplNombBusq);
            this.GBBusquedadEmp.Controls.Add(this.TBEmplCodeBusq);
            this.GBBusquedadEmp.Controls.Add(this.LbEmplNombBusq);
            this.GBBusquedadEmp.Controls.Add(this.LbEmplCodeBusq);
            this.GBBusquedadEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBBusquedadEmp.Location = new System.Drawing.Point(41, 12);
            this.GBBusquedadEmp.Name = "GBBusquedadEmp";
            this.GBBusquedadEmp.Size = new System.Drawing.Size(950, 90);
            this.GBBusquedadEmp.TabIndex = 66;
            this.GBBusquedadEmp.TabStop = false;
            this.GBBusquedadEmp.Text = "Búsquedad";
            // 
            // LbEmpleadoInfo
            // 
            this.LbEmpleadoInfo.AutoSize = true;
            this.LbEmpleadoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpleadoInfo.Location = new System.Drawing.Point(77, 16);
            this.LbEmpleadoInfo.Name = "LbEmpleadoInfo";
            this.LbEmpleadoInfo.Size = new System.Drawing.Size(178, 18);
            this.LbEmpleadoInfo.TabIndex = 70;
            this.LbEmpleadoInfo.Text = "Información del empleado";
            // 
            // TBEmplNombBusq
            // 
            this.TBEmplNombBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmplNombBusq.Location = new System.Drawing.Point(627, 48);
            this.TBEmplNombBusq.Name = "TBEmplNombBusq";
            this.TBEmplNombBusq.Size = new System.Drawing.Size(202, 24);
            this.TBEmplNombBusq.TabIndex = 69;
            // 
            // TBEmplCodeBusq
            // 
            this.TBEmplCodeBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TBEmplCodeBusq.Location = new System.Drawing.Point(237, 51);
            this.TBEmplCodeBusq.Name = "TBEmplCodeBusq";
            this.TBEmplCodeBusq.Size = new System.Drawing.Size(74, 24);
            this.TBEmplCodeBusq.TabIndex = 68;
            // 
            // LbEmplNombBusq
            // 
            this.LbEmplNombBusq.AutoSize = true;
            this.LbEmplNombBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmplNombBusq.Location = new System.Drawing.Point(453, 51);
            this.LbEmplNombBusq.Name = "LbEmplNombBusq";
            this.LbEmplNombBusq.Size = new System.Drawing.Size(154, 18);
            this.LbEmplNombBusq.TabIndex = 67;
            this.LbEmplNombBusq.Text = "Nombre del empleado";
            // 
            // LbEmplCodeBusq
            // 
            this.LbEmplCodeBusq.AutoSize = true;
            this.LbEmplCodeBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmplCodeBusq.Location = new System.Drawing.Point(77, 51);
            this.LbEmplCodeBusq.Name = "LbEmplCodeBusq";
            this.LbEmplCodeBusq.Size = new System.Drawing.Size(148, 18);
            this.LbEmplCodeBusq.TabIndex = 66;
            this.LbEmplCodeBusq.Text = "Código del empleado\r\n";
            // 
            // BtnEliminarRegistroEmpleado
            // 
            this.BtnEliminarRegistroEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminarRegistroEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtnEliminarRegistroEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEliminarRegistroEmpleado.Location = new System.Drawing.Point(763, 508);
            this.BtnEliminarRegistroEmpleado.Name = "BtnEliminarRegistroEmpleado";
            this.BtnEliminarRegistroEmpleado.Size = new System.Drawing.Size(144, 47);
            this.BtnEliminarRegistroEmpleado.TabIndex = 67;
            this.BtnEliminarRegistroEmpleado.Text = "Eliminar Registro";
            this.BtnEliminarRegistroEmpleado.UseVisualStyleBackColor = false;
            // 
            // BtnActualizarRegistroEmpleado
            // 
            this.BtnActualizarRegistroEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnActualizarRegistroEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtnActualizarRegistroEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnActualizarRegistroEmpleado.Location = new System.Drawing.Point(72, 508);
            this.BtnActualizarRegistroEmpleado.Name = "BtnActualizarRegistroEmpleado";
            this.BtnActualizarRegistroEmpleado.Size = new System.Drawing.Size(144, 47);
            this.BtnActualizarRegistroEmpleado.TabIndex = 68;
            this.BtnActualizarRegistroEmpleado.Text = "Actualizar Registro";
            this.BtnActualizarRegistroEmpleado.UseVisualStyleBackColor = false;
            // 
            // Busquedad_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 585);
            this.Controls.Add(this.BtnActualizarRegistroEmpleado);
            this.Controls.Add(this.BtnEliminarRegistroEmpleado);
            this.Controls.Add(this.GBBusquedadEmp);
            this.Controls.Add(this.CHBEmpleadoActivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBEmpleadoCedula);
            this.Controls.Add(this.TBEmpleadoCelular);
            this.Controls.Add(this.TBEmpleadoTelefono);
            this.Controls.Add(this.DTPFechaNac);
            this.Controls.Add(this.LbEmplNameBusq);
            this.Controls.Add(this.CBCargo);
            this.Controls.Add(this.CBEmpleadoEstadoCivil);
            this.Controls.Add(this.CBEmpleadoSexo);
            this.Controls.Add(this.TBEmpleadoEmail);
            this.Controls.Add(this.TBEmpleadoApellidos);
            this.Controls.Add(this.TBEmpleadoNombres);
            this.Controls.Add(this.LbCargo);
            this.Controls.Add(this.LbEmpleadoEstadoCivil);
            this.Controls.Add(this.LbEmpleadoSexo);
            this.Controls.Add(this.LbEmpleadoEmail);
            this.Controls.Add(this.LbEmpleadoCedula);
            this.Controls.Add(this.LbEmpleadoCelular);
            this.Controls.Add(this.LbEmpleadoTelefono);
            this.Controls.Add(this.LbEmpFechaNacimiento);
            this.Controls.Add(this.LbEmpApellidos);
            this.Name = "Busquedad_Empleados";
            this.Text = "Busquedad_Empleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBBusquedadEmp.ResumeLayout(false);
            this.GBBusquedadEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CHBEmpleadoActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBEmpleadoSector;
        private System.Windows.Forms.Label LBSector;
        private System.Windows.Forms.ComboBox CBEmpleadoProvincia;
        private System.Windows.Forms.Label LbEmpleadoProvincia;
        private System.Windows.Forms.TextBox TBEmpleadoCalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBEmpleadoMunicipio;
        private System.Windows.Forms.Label LbEmpleadoMunicipio;
        private System.Windows.Forms.MaskedTextBox TBEmpleadoCedula;
        private System.Windows.Forms.MaskedTextBox TBEmpleadoCelular;
        private System.Windows.Forms.MaskedTextBox TBEmpleadoTelefono;
        private System.Windows.Forms.DateTimePicker DTPFechaNac;
        private System.Windows.Forms.Label LbEmplNameBusq;
        private System.Windows.Forms.ComboBox CBCargo;
        private System.Windows.Forms.ComboBox CBEmpleadoEstadoCivil;
        private System.Windows.Forms.ComboBox CBEmpleadoSexo;
        private System.Windows.Forms.TextBox TBEmpleadoEmail;
        private System.Windows.Forms.TextBox TBEmpleadoApellidos;
        private System.Windows.Forms.TextBox TBEmpleadoNombres;
        private System.Windows.Forms.Label LbCargo;
        private System.Windows.Forms.Label LbEmpleadoEstadoCivil;
        private System.Windows.Forms.Label LbEmpleadoSexo;
        private System.Windows.Forms.Label LbEmpleadoEmail;
        private System.Windows.Forms.Label LbEmpleadoCedula;
        private System.Windows.Forms.Label LbEmpleadoCelular;
        private System.Windows.Forms.Label LbEmpleadoTelefono;
        private System.Windows.Forms.Label LbEmpFechaNacimiento;
        private System.Windows.Forms.Label LbEmpApellidos;
        private System.Windows.Forms.GroupBox GBBusquedadEmp;
        private System.Windows.Forms.Label LbEmpleadoInfo;
        private System.Windows.Forms.TextBox TBEmplNombBusq;
        private System.Windows.Forms.TextBox TBEmplCodeBusq;
        private System.Windows.Forms.Label LbEmplNombBusq;
        private System.Windows.Forms.Label LbEmplCodeBusq;
        private System.Windows.Forms.Button BtnEliminarRegistroEmpleado;
        private System.Windows.Forms.Button BtnActualizarRegistroEmpleado;
    }
}