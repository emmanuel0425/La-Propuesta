namespace Capa_Presentacion
{
    partial class Registro_Empleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Empleados));
            this.LbEmpApellidos = new System.Windows.Forms.Label();
            this.LbEmpFechaNacimiento = new System.Windows.Forms.Label();
            this.LbEmpleadoTelefono = new System.Windows.Forms.Label();
            this.LbEmpleadoCelular = new System.Windows.Forms.Label();
            this.LbEmpleadoProvincia = new System.Windows.Forms.Label();
            this.LbEmpleadoCedula = new System.Windows.Forms.Label();
            this.LbEmpleadoEmail = new System.Windows.Forms.Label();
            this.LbEmpleadoSexo = new System.Windows.Forms.Label();
            this.LbEmpleadoEstadoCivil = new System.Windows.Forms.Label();
            this.LbCargo = new System.Windows.Forms.Label();
            this.BtnEmpleadoAgregarRegistro = new System.Windows.Forms.Button();
            this.BtnEmpleadoEliminarRegistro = new System.Windows.Forms.Button();
            this.TBEmpleadoNombres = new System.Windows.Forms.TextBox();
            this.TBEmpleadoApellidos = new System.Windows.Forms.TextBox();
            this.TBEmpleadoEmail = new System.Windows.Forms.TextBox();
            this.CBEmpleadoSexo = new System.Windows.Forms.ComboBox();
            this.CBEmpleadoEstadoCivil = new System.Windows.Forms.ComboBox();
            this.CBCargo = new System.Windows.Forms.ComboBox();
            this.CBEmpleadoProvincia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TBTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TBCelular = new System.Windows.Forms.MaskedTextBox();
            this.TBCedula = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBSector = new System.Windows.Forms.TextBox();
            this.LBSector = new System.Windows.Forms.Label();
            this.TBEmpleadoCalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBEmpleadoMunicipio = new System.Windows.Forms.ComboBox();
            this.LbEmpleadoMunicipio = new System.Windows.Forms.Label();
            this.CHBActivo = new System.Windows.Forms.CheckBox();
            this.DGVEmpleado = new System.Windows.Forms.DataGridView();
            this.BtnBuscarEmpleados = new System.Windows.Forms.Button();
            this.BtnActualizarRegistroEmpleado = new System.Windows.Forms.Button();
            this.BtnEliminarRegistroEmpleado = new System.Windows.Forms.Button();
            this.empleadoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoNombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoApellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoActivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.muIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoFechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoSectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyecto_FinalDataSet = new Capa_Presentacion.Proyecto_FinalDataSet();
            this.empleadoTableAdapter = new Capa_Presentacion.Proyecto_FinalDataSetTableAdapters.EmpleadoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_FinalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LbEmpApellidos
            // 
            resources.ApplyResources(this.LbEmpApellidos, "LbEmpApellidos");
            this.LbEmpApellidos.Name = "LbEmpApellidos";
            // 
            // LbEmpFechaNacimiento
            // 
            resources.ApplyResources(this.LbEmpFechaNacimiento, "LbEmpFechaNacimiento");
            this.LbEmpFechaNacimiento.Name = "LbEmpFechaNacimiento";
            // 
            // LbEmpleadoTelefono
            // 
            resources.ApplyResources(this.LbEmpleadoTelefono, "LbEmpleadoTelefono");
            this.LbEmpleadoTelefono.Name = "LbEmpleadoTelefono";
            // 
            // LbEmpleadoCelular
            // 
            resources.ApplyResources(this.LbEmpleadoCelular, "LbEmpleadoCelular");
            this.LbEmpleadoCelular.Name = "LbEmpleadoCelular";
            // 
            // LbEmpleadoProvincia
            // 
            resources.ApplyResources(this.LbEmpleadoProvincia, "LbEmpleadoProvincia");
            this.LbEmpleadoProvincia.Name = "LbEmpleadoProvincia";
            // 
            // LbEmpleadoCedula
            // 
            resources.ApplyResources(this.LbEmpleadoCedula, "LbEmpleadoCedula");
            this.LbEmpleadoCedula.Name = "LbEmpleadoCedula";
            // 
            // LbEmpleadoEmail
            // 
            resources.ApplyResources(this.LbEmpleadoEmail, "LbEmpleadoEmail");
            this.LbEmpleadoEmail.Name = "LbEmpleadoEmail";
            // 
            // LbEmpleadoSexo
            // 
            resources.ApplyResources(this.LbEmpleadoSexo, "LbEmpleadoSexo");
            this.LbEmpleadoSexo.Name = "LbEmpleadoSexo";
            // 
            // LbEmpleadoEstadoCivil
            // 
            resources.ApplyResources(this.LbEmpleadoEstadoCivil, "LbEmpleadoEstadoCivil");
            this.LbEmpleadoEstadoCivil.Name = "LbEmpleadoEstadoCivil";
            // 
            // LbCargo
            // 
            resources.ApplyResources(this.LbCargo, "LbCargo");
            this.LbCargo.Name = "LbCargo";
            // 
            // BtnEmpleadoAgregarRegistro
            // 
            this.BtnEmpleadoAgregarRegistro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.BtnEmpleadoAgregarRegistro, "BtnEmpleadoAgregarRegistro");
            this.BtnEmpleadoAgregarRegistro.Name = "BtnEmpleadoAgregarRegistro";
            this.BtnEmpleadoAgregarRegistro.UseVisualStyleBackColor = false;
            this.BtnEmpleadoAgregarRegistro.Click += new System.EventHandler(this.BtnEmpleadoAgregarRegistro_Click);
            // 
            // BtnEmpleadoEliminarRegistro
            // 
            this.BtnEmpleadoEliminarRegistro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.BtnEmpleadoEliminarRegistro, "BtnEmpleadoEliminarRegistro");
            this.BtnEmpleadoEliminarRegistro.Name = "BtnEmpleadoEliminarRegistro";
            this.BtnEmpleadoEliminarRegistro.UseVisualStyleBackColor = false;
            // 
            // TBEmpleadoNombres
            // 
            resources.ApplyResources(this.TBEmpleadoNombres, "TBEmpleadoNombres");
            this.TBEmpleadoNombres.Name = "TBEmpleadoNombres";
            // 
            // TBEmpleadoApellidos
            // 
            resources.ApplyResources(this.TBEmpleadoApellidos, "TBEmpleadoApellidos");
            this.TBEmpleadoApellidos.Name = "TBEmpleadoApellidos";
            // 
            // TBEmpleadoEmail
            // 
            resources.ApplyResources(this.TBEmpleadoEmail, "TBEmpleadoEmail");
            this.TBEmpleadoEmail.Name = "TBEmpleadoEmail";
            // 
            // CBEmpleadoSexo
            // 
            this.CBEmpleadoSexo.DisplayMember = "Sexo_Descripcion";
            resources.ApplyResources(this.CBEmpleadoSexo, "CBEmpleadoSexo");
            this.CBEmpleadoSexo.FormattingEnabled = true;
            this.CBEmpleadoSexo.Name = "CBEmpleadoSexo";
            this.CBEmpleadoSexo.ValueMember = "Sexo_ID";
            this.CBEmpleadoSexo.SelectedIndexChanged += new System.EventHandler(this.CBEmpleadoSexo_SelectedIndexChanged);
            // 
            // CBEmpleadoEstadoCivil
            // 
            this.CBEmpleadoEstadoCivil.DisplayMember = "EstadoC_Descripcion";
            resources.ApplyResources(this.CBEmpleadoEstadoCivil, "CBEmpleadoEstadoCivil");
            this.CBEmpleadoEstadoCivil.FormattingEnabled = true;
            this.CBEmpleadoEstadoCivil.Name = "CBEmpleadoEstadoCivil";
            this.CBEmpleadoEstadoCivil.ValueMember = "EstadoC_ID";
            // 
            // CBCargo
            // 
            this.CBCargo.DisplayMember = "Cargo_Nombre";
            resources.ApplyResources(this.CBCargo, "CBCargo");
            this.CBCargo.FormattingEnabled = true;
            this.CBCargo.Name = "CBCargo";
            this.CBCargo.ValueMember = "Cargo_ID";
            // 
            // CBEmpleadoProvincia
            // 
            this.CBEmpleadoProvincia.DisplayMember = "Pro_Nombre";
            resources.ApplyResources(this.CBEmpleadoProvincia, "CBEmpleadoProvincia");
            this.CBEmpleadoProvincia.FormattingEnabled = true;
            this.CBEmpleadoProvincia.Name = "CBEmpleadoProvincia";
            this.CBEmpleadoProvincia.ValueMember = "Pro_ID";
            this.CBEmpleadoProvincia.SelectedIndexChanged += new System.EventHandler(this.CBEmpleadoProvincia_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DTPFechaNac
            // 
            resources.ApplyResources(this.DTPFechaNac, "DTPFechaNac");
            this.DTPFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaNac.Name = "DTPFechaNac";
            // 
            // TBTelefono
            // 
            resources.ApplyResources(this.TBTelefono, "TBTelefono");
            this.TBTelefono.Name = "TBTelefono";
            // 
            // TBCelular
            // 
            resources.ApplyResources(this.TBCelular, "TBCelular");
            this.TBCelular.Name = "TBCelular";
            // 
            // TBCedula
            // 
            resources.ApplyResources(this.TBCedula, "TBCedula");
            this.TBCedula.Name = "TBCedula";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBSector);
            this.groupBox1.Controls.Add(this.LBSector);
            this.groupBox1.Controls.Add(this.CBEmpleadoProvincia);
            this.groupBox1.Controls.Add(this.LbEmpleadoProvincia);
            this.groupBox1.Controls.Add(this.TBEmpleadoCalle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBEmpleadoMunicipio);
            this.groupBox1.Controls.Add(this.LbEmpleadoMunicipio);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // TBSector
            // 
            resources.ApplyResources(this.TBSector, "TBSector");
            this.TBSector.Name = "TBSector";
            // 
            // LBSector
            // 
            resources.ApplyResources(this.LBSector, "LBSector");
            this.LBSector.Name = "LBSector";
            // 
            // TBEmpleadoCalle
            // 
            resources.ApplyResources(this.TBEmpleadoCalle, "TBEmpleadoCalle");
            this.TBEmpleadoCalle.Name = "TBEmpleadoCalle";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CBEmpleadoMunicipio
            // 
            this.CBEmpleadoMunicipio.DisplayMember = "Mu_Nombre";
            resources.ApplyResources(this.CBEmpleadoMunicipio, "CBEmpleadoMunicipio");
            this.CBEmpleadoMunicipio.FormattingEnabled = true;
            this.CBEmpleadoMunicipio.Name = "CBEmpleadoMunicipio";
            this.CBEmpleadoMunicipio.ValueMember = "Mu_ID";
            // 
            // LbEmpleadoMunicipio
            // 
            resources.ApplyResources(this.LbEmpleadoMunicipio, "LbEmpleadoMunicipio");
            this.LbEmpleadoMunicipio.Name = "LbEmpleadoMunicipio";
            // 
            // CHBActivo
            // 
            resources.ApplyResources(this.CHBActivo, "CHBActivo");
            this.CHBActivo.Name = "CHBActivo";
            this.CHBActivo.UseVisualStyleBackColor = true;
            // 
            // DGVEmpleado
            // 
            this.DGVEmpleado.AutoGenerateColumns = false;
            this.DGVEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleadoIDDataGridViewTextBoxColumn,
            this.cargoIDDataGridViewTextBoxColumn,
            this.empleadoNombresDataGridViewTextBoxColumn,
            this.empleadoApellidosDataGridViewTextBoxColumn,
            this.empleadoTelefonoDataGridViewTextBoxColumn,
            this.empleadoCelularDataGridViewTextBoxColumn,
            this.empleadoDireccionDataGridViewTextBoxColumn,
            this.empleadoEmailDataGridViewTextBoxColumn,
            this.empleadoCedulaDataGridViewTextBoxColumn,
            this.empleadoActivoDataGridViewCheckBoxColumn,
            this.muIDDataGridViewTextBoxColumn,
            this.empleadoFechaNacimientoDataGridViewTextBoxColumn,
            this.estadoCIDDataGridViewTextBoxColumn,
            this.sexoIDDataGridViewTextBoxColumn,
            this.empleadoSectorDataGridViewTextBoxColumn});
            this.DGVEmpleado.DataSource = this.empleadoBindingSource;
            resources.ApplyResources(this.DGVEmpleado, "DGVEmpleado");
            this.DGVEmpleado.Name = "DGVEmpleado";
            
            //this.DGVEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVEmpleado_KeyDown);
            // 
            // BtnBuscarEmpleados
            // 
            this.BtnBuscarEmpleados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.BtnBuscarEmpleados, "BtnBuscarEmpleados");
            this.BtnBuscarEmpleados.Name = "BtnBuscarEmpleados";
            this.BtnBuscarEmpleados.UseVisualStyleBackColor = false;
            this.BtnBuscarEmpleados.Click += new System.EventHandler(this.BtnBuscarEmpleados_Click);
            // 
            // BtnActualizarRegistroEmpleado
            // 
            this.BtnActualizarRegistroEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.BtnActualizarRegistroEmpleado, "BtnActualizarRegistroEmpleado");
            this.BtnActualizarRegistroEmpleado.Name = "BtnActualizarRegistroEmpleado";
            this.BtnActualizarRegistroEmpleado.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarRegistroEmpleado
            // 
            this.BtnEliminarRegistroEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.BtnEliminarRegistroEmpleado, "BtnEliminarRegistroEmpleado");
            this.BtnEliminarRegistroEmpleado.Name = "BtnEliminarRegistroEmpleado";
            this.BtnEliminarRegistroEmpleado.UseVisualStyleBackColor = false;
            // 
            // empleadoIDDataGridViewTextBoxColumn
            // 
            this.empleadoIDDataGridViewTextBoxColumn.DataPropertyName = "Empleado_ID";
            resources.ApplyResources(this.empleadoIDDataGridViewTextBoxColumn, "empleadoIDDataGridViewTextBoxColumn");
            this.empleadoIDDataGridViewTextBoxColumn.Name = "empleadoIDDataGridViewTextBoxColumn";
            this.empleadoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoIDDataGridViewTextBoxColumn
            // 
            this.cargoIDDataGridViewTextBoxColumn.DataPropertyName = "Cargo_ID";
            resources.ApplyResources(this.cargoIDDataGridViewTextBoxColumn, "cargoIDDataGridViewTextBoxColumn");
            this.cargoIDDataGridViewTextBoxColumn.Name = "cargoIDDataGridViewTextBoxColumn";
            // 
            // empleadoNombresDataGridViewTextBoxColumn
            // 
            this.empleadoNombresDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Nombres";
            resources.ApplyResources(this.empleadoNombresDataGridViewTextBoxColumn, "empleadoNombresDataGridViewTextBoxColumn");
            this.empleadoNombresDataGridViewTextBoxColumn.Name = "empleadoNombresDataGridViewTextBoxColumn";
            // 
            // empleadoApellidosDataGridViewTextBoxColumn
            // 
            this.empleadoApellidosDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Apellidos";
            resources.ApplyResources(this.empleadoApellidosDataGridViewTextBoxColumn, "empleadoApellidosDataGridViewTextBoxColumn");
            this.empleadoApellidosDataGridViewTextBoxColumn.Name = "empleadoApellidosDataGridViewTextBoxColumn";
            // 
            // empleadoTelefonoDataGridViewTextBoxColumn
            // 
            this.empleadoTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Telefono";
            resources.ApplyResources(this.empleadoTelefonoDataGridViewTextBoxColumn, "empleadoTelefonoDataGridViewTextBoxColumn");
            this.empleadoTelefonoDataGridViewTextBoxColumn.Name = "empleadoTelefonoDataGridViewTextBoxColumn";
            // 
            // empleadoCelularDataGridViewTextBoxColumn
            // 
            this.empleadoCelularDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Celular";
            resources.ApplyResources(this.empleadoCelularDataGridViewTextBoxColumn, "empleadoCelularDataGridViewTextBoxColumn");
            this.empleadoCelularDataGridViewTextBoxColumn.Name = "empleadoCelularDataGridViewTextBoxColumn";
            // 
            // empleadoDireccionDataGridViewTextBoxColumn
            // 
            this.empleadoDireccionDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Direccion";
            resources.ApplyResources(this.empleadoDireccionDataGridViewTextBoxColumn, "empleadoDireccionDataGridViewTextBoxColumn");
            this.empleadoDireccionDataGridViewTextBoxColumn.Name = "empleadoDireccionDataGridViewTextBoxColumn";
            // 
            // empleadoEmailDataGridViewTextBoxColumn
            // 
            this.empleadoEmailDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Email";
            resources.ApplyResources(this.empleadoEmailDataGridViewTextBoxColumn, "empleadoEmailDataGridViewTextBoxColumn");
            this.empleadoEmailDataGridViewTextBoxColumn.Name = "empleadoEmailDataGridViewTextBoxColumn";
            // 
            // empleadoCedulaDataGridViewTextBoxColumn
            // 
            this.empleadoCedulaDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Cedula";
            resources.ApplyResources(this.empleadoCedulaDataGridViewTextBoxColumn, "empleadoCedulaDataGridViewTextBoxColumn");
            this.empleadoCedulaDataGridViewTextBoxColumn.Name = "empleadoCedulaDataGridViewTextBoxColumn";
            // 
            // empleadoActivoDataGridViewCheckBoxColumn
            // 
            this.empleadoActivoDataGridViewCheckBoxColumn.DataPropertyName = "Empleado_Activo";
            resources.ApplyResources(this.empleadoActivoDataGridViewCheckBoxColumn, "empleadoActivoDataGridViewCheckBoxColumn");
            this.empleadoActivoDataGridViewCheckBoxColumn.Name = "empleadoActivoDataGridViewCheckBoxColumn";
            // 
            // muIDDataGridViewTextBoxColumn
            // 
            this.muIDDataGridViewTextBoxColumn.DataPropertyName = "Mu_ID";
            resources.ApplyResources(this.muIDDataGridViewTextBoxColumn, "muIDDataGridViewTextBoxColumn");
            this.muIDDataGridViewTextBoxColumn.Name = "muIDDataGridViewTextBoxColumn";
            // 
            // empleadoFechaNacimientoDataGridViewTextBoxColumn
            // 
            this.empleadoFechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Fecha_Nacimiento";
            resources.ApplyResources(this.empleadoFechaNacimientoDataGridViewTextBoxColumn, "empleadoFechaNacimientoDataGridViewTextBoxColumn");
            this.empleadoFechaNacimientoDataGridViewTextBoxColumn.Name = "empleadoFechaNacimientoDataGridViewTextBoxColumn";
            // 
            // estadoCIDDataGridViewTextBoxColumn
            // 
            this.estadoCIDDataGridViewTextBoxColumn.DataPropertyName = "EstadoC_ID";
            resources.ApplyResources(this.estadoCIDDataGridViewTextBoxColumn, "estadoCIDDataGridViewTextBoxColumn");
            this.estadoCIDDataGridViewTextBoxColumn.Name = "estadoCIDDataGridViewTextBoxColumn";
            // 
            // sexoIDDataGridViewTextBoxColumn
            // 
            this.sexoIDDataGridViewTextBoxColumn.DataPropertyName = "Sexo_ID";
            resources.ApplyResources(this.sexoIDDataGridViewTextBoxColumn, "sexoIDDataGridViewTextBoxColumn");
            this.sexoIDDataGridViewTextBoxColumn.Name = "sexoIDDataGridViewTextBoxColumn";
            // 
            // empleadoSectorDataGridViewTextBoxColumn
            // 
            this.empleadoSectorDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Sector";
            resources.ApplyResources(this.empleadoSectorDataGridViewTextBoxColumn, "empleadoSectorDataGridViewTextBoxColumn");
            this.empleadoSectorDataGridViewTextBoxColumn.Name = "empleadoSectorDataGridViewTextBoxColumn";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.proyecto_FinalDataSet;
            // 
            // proyecto_FinalDataSet
            // 
            this.proyecto_FinalDataSet.DataSetName = "Proyecto_FinalDataSet";
            this.proyecto_FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // Registro_Empleados
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.BtnEliminarRegistroEmpleado);
            this.Controls.Add(this.BtnActualizarRegistroEmpleado);
            this.Controls.Add(this.BtnBuscarEmpleados);
            this.Controls.Add(this.DGVEmpleado);
            this.Controls.Add(this.CHBActivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBCedula);
            this.Controls.Add(this.TBCelular);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.DTPFechaNac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBCargo);
            this.Controls.Add(this.CBEmpleadoEstadoCivil);
            this.Controls.Add(this.CBEmpleadoSexo);
            this.Controls.Add(this.TBEmpleadoEmail);
            this.Controls.Add(this.TBEmpleadoApellidos);
            this.Controls.Add(this.TBEmpleadoNombres);
            this.Controls.Add(this.BtnEmpleadoEliminarRegistro);
            this.Controls.Add(this.BtnEmpleadoAgregarRegistro);
            this.Controls.Add(this.LbCargo);
            this.Controls.Add(this.LbEmpleadoEstadoCivil);
            this.Controls.Add(this.LbEmpleadoSexo);
            this.Controls.Add(this.LbEmpleadoEmail);
            this.Controls.Add(this.LbEmpleadoCedula);
            this.Controls.Add(this.LbEmpleadoCelular);
            this.Controls.Add(this.LbEmpleadoTelefono);
            this.Controls.Add(this.LbEmpFechaNacimiento);
            this.Controls.Add(this.LbEmpApellidos);
            this.Name = "Registro_Empleados";
            this.Load += new System.EventHandler(this.Registro_Empleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_FinalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbEmpApellidos;
        private System.Windows.Forms.Label LbEmpFechaNacimiento;
        private System.Windows.Forms.Label LbEmpleadoTelefono;
        private System.Windows.Forms.Label LbEmpleadoCelular;
        private System.Windows.Forms.Label LbEmpleadoProvincia;
        private System.Windows.Forms.Label LbEmpleadoCedula;
        private System.Windows.Forms.Label LbEmpleadoEmail;
        private System.Windows.Forms.Label LbEmpleadoSexo;
        private System.Windows.Forms.Label LbEmpleadoEstadoCivil;
        private System.Windows.Forms.Label LbCargo;
        private System.Windows.Forms.Button BtnEmpleadoAgregarRegistro;
        private System.Windows.Forms.Button BtnEmpleadoEliminarRegistro;
        private System.Windows.Forms.TextBox TBEmpleadoNombres;
        private System.Windows.Forms.TextBox TBEmpleadoApellidos;
        private System.Windows.Forms.TextBox TBEmpleadoEmail;
        private System.Windows.Forms.ComboBox CBEmpleadoSexo;
        private System.Windows.Forms.ComboBox CBEmpleadoEstadoCivil;
        private System.Windows.Forms.ComboBox CBCargo;
        private System.Windows.Forms.ComboBox CBEmpleadoProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPFechaNac;
        private System.Windows.Forms.MaskedTextBox TBTelefono;
        private System.Windows.Forms.MaskedTextBox TBCelular;
        private System.Windows.Forms.MaskedTextBox TBCedula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBSector;
        private System.Windows.Forms.Label LBSector;
        private System.Windows.Forms.TextBox TBEmpleadoCalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBEmpleadoMunicipio;
        private System.Windows.Forms.Label LbEmpleadoMunicipio;
        private System.Windows.Forms.CheckBox CHBActivo;
        private System.Windows.Forms.DataGridView DGVEmpleado;
        private Proyecto_FinalDataSet proyecto_FinalDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private Proyecto_FinalDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoNombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoApellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn empleadoActivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoFechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoSectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnBuscarEmpleados;
        private System.Windows.Forms.Button BtnActualizarRegistroEmpleado;
        private System.Windows.Forms.Button BtnEliminarRegistroEmpleado;
    }
}