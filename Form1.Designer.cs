namespace AsistenciaAlumnosForms
{
    partial class Form1 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControlMenu = new MaterialSkin.Controls.MaterialTabControl();
            tabInicio = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            tabAdministrarDatos = new TabPage();
            tabSelectorCargas = new MaterialSkin.Controls.MaterialTabSelector();
            tabControlDatos = new MaterialSkin.Controls.MaterialTabControl();
            tabCarreras = new TabPage();
            btnBuscarCarrera = new MaterialSkin.Controls.MaterialButton();
            txtBuscarCarrera = new MaterialSkin.Controls.MaterialTextBox();
            btnLimpiarCarrera = new MaterialSkin.Controls.MaterialButton();
            btnEliminarCarrera = new MaterialSkin.Controls.MaterialButton();
            chkInactivoCarrera = new MaterialSkin.Controls.MaterialCheckbox();
            chkActivoCarrera = new MaterialSkin.Controls.MaterialCheckbox();
            txtFechaInicioCarrera = new MaterialSkin.Controls.MaterialTextBox();
            txtCantidadMateriasCarrera = new MaterialSkin.Controls.MaterialTextBox();
            cbcDuracionCarrera = new MaterialSkin.Controls.MaterialComboBox();
            txtDescripcionCarrera = new MaterialSkin.Controls.MaterialTextBox();
            btnModificarCarrera = new MaterialSkin.Controls.MaterialButton();
            btnCargarCarrera = new MaterialSkin.Controls.MaterialButton();
            txtNombreCarrera = new MaterialSkin.Controls.MaterialTextBox();
            tabProfesores = new TabPage();
            btnBuscarProfesor = new MaterialSkin.Controls.MaterialButton();
            txtBuscarProfesor = new MaterialSkin.Controls.MaterialTextBox();
            btnLimpiarProfesor = new MaterialSkin.Controls.MaterialButton();
            btnEliminarProfesor = new MaterialSkin.Controls.MaterialButton();
            btnModificarProfesor = new MaterialSkin.Controls.MaterialButton();
            btnCargarProfesor = new MaterialSkin.Controls.MaterialButton();
            txtTelefonoProfesor = new MaterialSkin.Controls.MaterialTextBox();
            txtInformacionAdicionalProfesor = new MaterialSkin.Controls.MaterialTextBox();
            txtEmailProfesor = new MaterialSkin.Controls.MaterialTextBox();
            txtLocalidadProfesor = new MaterialSkin.Controls.MaterialTextBox();
            txtDomicilioProfesor = new MaterialSkin.Controls.MaterialTextBox();
            txtFechaNacProfesor = new MaterialSkin.Controls.MaterialTextBox();
            txtDniProfesor = new MaterialSkin.Controls.MaterialTextBox();
            txtApellidoProfesor = new MaterialSkin.Controls.MaterialTextBox();
            txtNombreProfesor = new MaterialSkin.Controls.MaterialTextBox();
            tabMaterias = new TabPage();
            btnBuscarMateria = new MaterialSkin.Controls.MaterialButton();
            txtBuscarMateria = new MaterialSkin.Controls.MaterialTextBox();
            btnLimpiarMateria = new MaterialSkin.Controls.MaterialButton();
            btnEliminarMateria = new MaterialSkin.Controls.MaterialButton();
            btnModificarMateria = new MaterialSkin.Controls.MaterialButton();
            btnCargarMateria = new MaterialSkin.Controls.MaterialButton();
            cbdTipoMateria = new MaterialSkin.Controls.MaterialComboBox();
            cbdAsignarMateriaProfesor = new MaterialSkin.Controls.MaterialComboBox();
            cbdAñoCursoMateria = new MaterialSkin.Controls.MaterialComboBox();
            txtCargaHorariaMateria = new MaterialSkin.Controls.MaterialTextBox();
            cbdAsignarCarreraMateria = new MaterialSkin.Controls.MaterialComboBox();
            txtNombreMateria = new MaterialSkin.Controls.MaterialTextBox();
            tabAlumnos = new TabPage();
            btnBuscarAlumno = new MaterialSkin.Controls.MaterialButton();
            txtBuscarAlumno = new MaterialSkin.Controls.MaterialTextBox();
            btnLimpiarAlumno = new MaterialSkin.Controls.MaterialButton();
            btnEliminarAlumno = new MaterialSkin.Controls.MaterialButton();
            btnModificarAlumno = new MaterialSkin.Controls.MaterialButton();
            btnCargarAlumno = new MaterialSkin.Controls.MaterialButton();
            txtTelefonoAlumno = new MaterialSkin.Controls.MaterialTextBox();
            cbdAsignarCarreraAlumno = new MaterialSkin.Controls.MaterialComboBox();
            txtEmailAlumno = new MaterialSkin.Controls.MaterialTextBox();
            txtLocalidadAlumno = new MaterialSkin.Controls.MaterialTextBox();
            txtDomicilioAlumno = new MaterialSkin.Controls.MaterialTextBox();
            txtFechaNacAlumno = new MaterialSkin.Controls.MaterialTextBox();
            txtDniAlumno = new MaterialSkin.Controls.MaterialTextBox();
            txtApellidoAlumno = new MaterialSkin.Controls.MaterialTextBox();
            txtNombreAlumno = new MaterialSkin.Controls.MaterialTextBox();
            tabControlAsistencias = new TabPage();
            tabInformes = new TabPage();
            tabAcercaDe = new TabPage();
            tabControlMenu.SuspendLayout();
            tabInicio.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabAdministrarDatos.SuspendLayout();
            tabControlDatos.SuspendLayout();
            tabCarreras.SuspendLayout();
            tabProfesores.SuspendLayout();
            tabMaterias.SuspendLayout();
            tabAlumnos.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMenu
            // 
            tabControlMenu.Controls.Add(tabInicio);
            tabControlMenu.Controls.Add(tabAdministrarDatos);
            tabControlMenu.Controls.Add(tabControlAsistencias);
            tabControlMenu.Controls.Add(tabInformes);
            tabControlMenu.Controls.Add(tabAcercaDe);
            tabControlMenu.Depth = 0;
            tabControlMenu.Dock = DockStyle.Fill;
            tabControlMenu.Location = new Point(3, 72);
            tabControlMenu.MouseState = MaterialSkin.MouseState.HOVER;
            tabControlMenu.Multiline = true;
            tabControlMenu.Name = "tabControlMenu";
            tabControlMenu.SelectedIndex = 0;
            tabControlMenu.Size = new Size(848, 537);
            tabControlMenu.TabIndex = 1;
            // 
            // tabInicio
            // 
            tabInicio.Controls.Add(materialCard1);
            tabInicio.Location = new Point(4, 24);
            tabInicio.Name = "tabInicio";
            tabInicio.Padding = new Padding(3);
            tabInicio.Size = new Size(840, 509);
            tabInicio.TabIndex = 0;
            tabInicio.Text = "Inicio";
            tabInicio.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(63, 26);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(654, 331);
            materialCard1.TabIndex = 2;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(0, 190);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(654, 136);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = resources.GetString("materialLabel1.Text");
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabAdministrarDatos
            // 
            tabAdministrarDatos.Controls.Add(tabSelectorCargas);
            tabAdministrarDatos.Controls.Add(tabControlDatos);
            tabAdministrarDatos.ForeColor = SystemColors.ActiveCaptionText;
            tabAdministrarDatos.Location = new Point(4, 24);
            tabAdministrarDatos.Name = "tabAdministrarDatos";
            tabAdministrarDatos.Padding = new Padding(3);
            tabAdministrarDatos.Size = new Size(840, 509);
            tabAdministrarDatos.TabIndex = 1;
            tabAdministrarDatos.Text = "Administrar Datos";
            tabAdministrarDatos.UseVisualStyleBackColor = true;
            // 
            // tabSelectorCargas
            // 
            tabSelectorCargas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabSelectorCargas.BaseTabControl = tabControlDatos;
            tabSelectorCargas.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            tabSelectorCargas.Depth = 0;
            tabSelectorCargas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            tabSelectorCargas.Location = new Point(29, 24);
            tabSelectorCargas.MouseState = MaterialSkin.MouseState.HOVER;
            tabSelectorCargas.Name = "tabSelectorCargas";
            tabSelectorCargas.Size = new Size(684, 39);
            tabSelectorCargas.TabIndex = 0;
            tabSelectorCargas.Text = "materialTabSelector1";
            // 
            // tabControlDatos
            // 
            tabControlDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlDatos.Controls.Add(tabCarreras);
            tabControlDatos.Controls.Add(tabProfesores);
            tabControlDatos.Controls.Add(tabMaterias);
            tabControlDatos.Controls.Add(tabAlumnos);
            tabControlDatos.Depth = 0;
            tabControlDatos.Location = new Point(30, 71);
            tabControlDatos.MouseState = MaterialSkin.MouseState.HOVER;
            tabControlDatos.Multiline = true;
            tabControlDatos.Name = "tabControlDatos";
            tabControlDatos.SelectedIndex = 0;
            tabControlDatos.Size = new Size(683, 421);
            tabControlDatos.TabIndex = 0;
            // 
            // tabCarreras
            // 
            tabCarreras.Controls.Add(btnBuscarCarrera);
            tabCarreras.Controls.Add(txtBuscarCarrera);
            tabCarreras.Controls.Add(btnLimpiarCarrera);
            tabCarreras.Controls.Add(btnEliminarCarrera);
            tabCarreras.Controls.Add(chkInactivoCarrera);
            tabCarreras.Controls.Add(chkActivoCarrera);
            tabCarreras.Controls.Add(txtFechaInicioCarrera);
            tabCarreras.Controls.Add(txtCantidadMateriasCarrera);
            tabCarreras.Controls.Add(cbcDuracionCarrera);
            tabCarreras.Controls.Add(txtDescripcionCarrera);
            tabCarreras.Controls.Add(btnModificarCarrera);
            tabCarreras.Controls.Add(btnCargarCarrera);
            tabCarreras.Controls.Add(txtNombreCarrera);
            tabCarreras.Location = new Point(4, 24);
            tabCarreras.Name = "tabCarreras";
            tabCarreras.Padding = new Padding(3);
            tabCarreras.Size = new Size(675, 393);
            tabCarreras.TabIndex = 0;
            tabCarreras.Text = "Carreras";
            tabCarreras.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCarrera
            // 
            btnBuscarCarrera.AutoSize = false;
            btnBuscarCarrera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarCarrera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarCarrera.Depth = 0;
            btnBuscarCarrera.HighEmphasis = true;
            btnBuscarCarrera.Icon = null;
            btnBuscarCarrera.Location = new Point(600, 250);
            btnBuscarCarrera.Margin = new Padding(4, 6, 4, 6);
            btnBuscarCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarCarrera.Name = "btnBuscarCarrera";
            btnBuscarCarrera.NoAccentTextColor = Color.Empty;
            btnBuscarCarrera.Size = new Size(65, 50);
            btnBuscarCarrera.TabIndex = 21;
            btnBuscarCarrera.Text = "Buscar";
            btnBuscarCarrera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarCarrera.UseAccentColor = false;
            btnBuscarCarrera.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCarrera
            // 
            txtBuscarCarrera.AnimateReadOnly = false;
            txtBuscarCarrera.BorderStyle = BorderStyle.None;
            txtBuscarCarrera.Depth = 0;
            txtBuscarCarrera.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarCarrera.LeadingIcon = null;
            txtBuscarCarrera.Location = new Point(423, 250);
            txtBuscarCarrera.MaxLength = 50;
            txtBuscarCarrera.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarCarrera.Multiline = false;
            txtBuscarCarrera.Name = "txtBuscarCarrera";
            txtBuscarCarrera.Size = new Size(170, 50);
            txtBuscarCarrera.TabIndex = 20;
            txtBuscarCarrera.Text = "";
            txtBuscarCarrera.TrailingIcon = null;
            // 
            // btnLimpiarCarrera
            // 
            btnLimpiarCarrera.AutoSize = false;
            btnLimpiarCarrera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarCarrera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiarCarrera.Depth = 0;
            btnLimpiarCarrera.HighEmphasis = true;
            btnLimpiarCarrera.Icon = null;
            btnLimpiarCarrera.Location = new Point(423, 172);
            btnLimpiarCarrera.Margin = new Padding(4, 6, 4, 6);
            btnLimpiarCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiarCarrera.Name = "btnLimpiarCarrera";
            btnLimpiarCarrera.NoAccentTextColor = Color.Empty;
            btnLimpiarCarrera.Size = new Size(242, 36);
            btnLimpiarCarrera.TabIndex = 19;
            btnLimpiarCarrera.Text = "Limpiar";
            btnLimpiarCarrera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiarCarrera.UseAccentColor = false;
            btnLimpiarCarrera.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCarrera
            // 
            btnEliminarCarrera.AutoSize = false;
            btnEliminarCarrera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarCarrera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarCarrera.Depth = 0;
            btnEliminarCarrera.HighEmphasis = true;
            btnEliminarCarrera.Icon = null;
            btnEliminarCarrera.Location = new Point(423, 124);
            btnEliminarCarrera.Margin = new Padding(4, 6, 4, 6);
            btnEliminarCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarCarrera.Name = "btnEliminarCarrera";
            btnEliminarCarrera.NoAccentTextColor = Color.Empty;
            btnEliminarCarrera.Size = new Size(242, 36);
            btnEliminarCarrera.TabIndex = 18;
            btnEliminarCarrera.Text = "Eliminar";
            btnEliminarCarrera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminarCarrera.UseAccentColor = false;
            btnEliminarCarrera.UseVisualStyleBackColor = true;
            // 
            // chkInactivoCarrera
            // 
            chkInactivoCarrera.CheckAlign = ContentAlignment.MiddleCenter;
            chkInactivoCarrera.Depth = 0;
            chkInactivoCarrera.Location = new Point(201, 303);
            chkInactivoCarrera.Margin = new Padding(0);
            chkInactivoCarrera.MouseLocation = new Point(-1, -1);
            chkInactivoCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            chkInactivoCarrera.Name = "chkInactivoCarrera";
            chkInactivoCarrera.ReadOnly = false;
            chkInactivoCarrera.Ripple = true;
            chkInactivoCarrera.Size = new Size(129, 53);
            chkInactivoCarrera.TabIndex = 17;
            chkInactivoCarrera.Text = "Inactivo";
            chkInactivoCarrera.TextAlign = ContentAlignment.TopCenter;
            chkInactivoCarrera.UseVisualStyleBackColor = true;
            // 
            // chkActivoCarrera
            // 
            chkActivoCarrera.CheckAlign = ContentAlignment.MiddleCenter;
            chkActivoCarrera.Depth = 0;
            chkActivoCarrera.Location = new Point(42, 303);
            chkActivoCarrera.Margin = new Padding(0);
            chkActivoCarrera.MouseLocation = new Point(-1, -1);
            chkActivoCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            chkActivoCarrera.Name = "chkActivoCarrera";
            chkActivoCarrera.ReadOnly = false;
            chkActivoCarrera.Ripple = true;
            chkActivoCarrera.Size = new Size(129, 53);
            chkActivoCarrera.TabIndex = 17;
            chkActivoCarrera.Text = "Activo";
            chkActivoCarrera.TextAlign = ContentAlignment.BottomCenter;
            chkActivoCarrera.UseVisualStyleBackColor = true;
            // 
            // txtFechaInicioCarrera
            // 
            txtFechaInicioCarrera.AnimateReadOnly = false;
            txtFechaInicioCarrera.BorderStyle = BorderStyle.None;
            txtFechaInicioCarrera.Depth = 0;
            txtFechaInicioCarrera.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFechaInicioCarrera.Hint = "Fecha de Inicio en la Institución";
            txtFechaInicioCarrera.LeadingIcon = null;
            txtFechaInicioCarrera.Location = new Point(17, 250);
            txtFechaInicioCarrera.MaxLength = 50;
            txtFechaInicioCarrera.MouseState = MaterialSkin.MouseState.OUT;
            txtFechaInicioCarrera.Multiline = false;
            txtFechaInicioCarrera.Name = "txtFechaInicioCarrera";
            txtFechaInicioCarrera.Size = new Size(376, 50);
            txtFechaInicioCarrera.TabIndex = 15;
            txtFechaInicioCarrera.Text = "";
            txtFechaInicioCarrera.TrailingIcon = null;
            // 
            // txtCantidadMateriasCarrera
            // 
            txtCantidadMateriasCarrera.AnimateReadOnly = false;
            txtCantidadMateriasCarrera.BorderStyle = BorderStyle.None;
            txtCantidadMateriasCarrera.Depth = 0;
            txtCantidadMateriasCarrera.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidadMateriasCarrera.Hint = "Cantidad de Materias";
            txtCantidadMateriasCarrera.LeadingIcon = null;
            txtCantidadMateriasCarrera.Location = new Point(17, 194);
            txtCantidadMateriasCarrera.MaxLength = 50;
            txtCantidadMateriasCarrera.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidadMateriasCarrera.Multiline = false;
            txtCantidadMateriasCarrera.Name = "txtCantidadMateriasCarrera";
            txtCantidadMateriasCarrera.Size = new Size(376, 50);
            txtCantidadMateriasCarrera.TabIndex = 14;
            txtCantidadMateriasCarrera.Text = "";
            txtCantidadMateriasCarrera.TrailingIcon = null;
            // 
            // cbcDuracionCarrera
            // 
            cbcDuracionCarrera.AutoResize = false;
            cbcDuracionCarrera.BackColor = Color.FromArgb(255, 255, 255);
            cbcDuracionCarrera.Depth = 0;
            cbcDuracionCarrera.DrawMode = DrawMode.OwnerDrawVariable;
            cbcDuracionCarrera.DropDownHeight = 174;
            cbcDuracionCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcDuracionCarrera.DropDownWidth = 121;
            cbcDuracionCarrera.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbcDuracionCarrera.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbcDuracionCarrera.FormattingEnabled = true;
            cbcDuracionCarrera.Hint = "Duración";
            cbcDuracionCarrera.IntegralHeight = false;
            cbcDuracionCarrera.ItemHeight = 43;
            cbcDuracionCarrera.Location = new Point(17, 139);
            cbcDuracionCarrera.MaxDropDownItems = 4;
            cbcDuracionCarrera.MouseState = MaterialSkin.MouseState.OUT;
            cbcDuracionCarrera.Name = "cbcDuracionCarrera";
            cbcDuracionCarrera.Size = new Size(376, 49);
            cbcDuracionCarrera.StartIndex = 0;
            cbcDuracionCarrera.TabIndex = 13;
            // 
            // txtDescripcionCarrera
            // 
            txtDescripcionCarrera.AnimateReadOnly = false;
            txtDescripcionCarrera.BorderStyle = BorderStyle.None;
            txtDescripcionCarrera.Depth = 0;
            txtDescripcionCarrera.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescripcionCarrera.Hint = "Descripción";
            txtDescripcionCarrera.LeadingIcon = null;
            txtDescripcionCarrera.Location = new Point(17, 83);
            txtDescripcionCarrera.MaxLength = 50;
            txtDescripcionCarrera.MouseState = MaterialSkin.MouseState.OUT;
            txtDescripcionCarrera.Multiline = false;
            txtDescripcionCarrera.Name = "txtDescripcionCarrera";
            txtDescripcionCarrera.Size = new Size(376, 50);
            txtDescripcionCarrera.TabIndex = 12;
            txtDescripcionCarrera.Text = "";
            txtDescripcionCarrera.TrailingIcon = null;
            // 
            // btnModificarCarrera
            // 
            btnModificarCarrera.AutoSize = false;
            btnModificarCarrera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarCarrera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificarCarrera.Depth = 0;
            btnModificarCarrera.HighEmphasis = true;
            btnModificarCarrera.Icon = null;
            btnModificarCarrera.Location = new Point(423, 76);
            btnModificarCarrera.Margin = new Padding(4, 6, 4, 6);
            btnModificarCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificarCarrera.Name = "btnModificarCarrera";
            btnModificarCarrera.NoAccentTextColor = Color.Empty;
            btnModificarCarrera.Size = new Size(242, 36);
            btnModificarCarrera.TabIndex = 11;
            btnModificarCarrera.Text = "Modificar";
            btnModificarCarrera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificarCarrera.UseAccentColor = false;
            btnModificarCarrera.UseVisualStyleBackColor = true;
            // 
            // btnCargarCarrera
            // 
            btnCargarCarrera.AutoSize = false;
            btnCargarCarrera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCargarCarrera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCargarCarrera.Depth = 0;
            btnCargarCarrera.HighEmphasis = true;
            btnCargarCarrera.Icon = null;
            btnCargarCarrera.Location = new Point(423, 28);
            btnCargarCarrera.Margin = new Padding(4, 6, 4, 6);
            btnCargarCarrera.MouseState = MaterialSkin.MouseState.HOVER;
            btnCargarCarrera.Name = "btnCargarCarrera";
            btnCargarCarrera.NoAccentTextColor = Color.Empty;
            btnCargarCarrera.Size = new Size(242, 36);
            btnCargarCarrera.TabIndex = 10;
            btnCargarCarrera.Text = "Cargar";
            btnCargarCarrera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCargarCarrera.UseAccentColor = false;
            btnCargarCarrera.UseVisualStyleBackColor = true;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.AnimateReadOnly = false;
            txtNombreCarrera.BorderStyle = BorderStyle.None;
            txtNombreCarrera.Depth = 0;
            txtNombreCarrera.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreCarrera.Hint = "Nombre";
            txtNombreCarrera.LeadingIcon = null;
            txtNombreCarrera.Location = new Point(17, 27);
            txtNombreCarrera.MaxLength = 50;
            txtNombreCarrera.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreCarrera.Multiline = false;
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.Size = new Size(376, 50);
            txtNombreCarrera.TabIndex = 0;
            txtNombreCarrera.Text = "";
            txtNombreCarrera.TrailingIcon = null;
            // 
            // tabProfesores
            // 
            tabProfesores.Controls.Add(btnBuscarProfesor);
            tabProfesores.Controls.Add(txtBuscarProfesor);
            tabProfesores.Controls.Add(btnLimpiarProfesor);
            tabProfesores.Controls.Add(btnEliminarProfesor);
            tabProfesores.Controls.Add(btnModificarProfesor);
            tabProfesores.Controls.Add(btnCargarProfesor);
            tabProfesores.Controls.Add(txtTelefonoProfesor);
            tabProfesores.Controls.Add(txtInformacionAdicionalProfesor);
            tabProfesores.Controls.Add(txtEmailProfesor);
            tabProfesores.Controls.Add(txtLocalidadProfesor);
            tabProfesores.Controls.Add(txtDomicilioProfesor);
            tabProfesores.Controls.Add(txtFechaNacProfesor);
            tabProfesores.Controls.Add(txtDniProfesor);
            tabProfesores.Controls.Add(txtApellidoProfesor);
            tabProfesores.Controls.Add(txtNombreProfesor);
            tabProfesores.Location = new Point(4, 24);
            tabProfesores.Name = "tabProfesores";
            tabProfesores.Size = new Size(675, 393);
            tabProfesores.TabIndex = 3;
            tabProfesores.Text = "Profesores";
            tabProfesores.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProfesor
            // 
            btnBuscarProfesor.AutoSize = false;
            btnBuscarProfesor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarProfesor.Depth = 0;
            btnBuscarProfesor.HighEmphasis = true;
            btnBuscarProfesor.Icon = null;
            btnBuscarProfesor.Location = new Point(600, 250);
            btnBuscarProfesor.Margin = new Padding(4, 6, 4, 6);
            btnBuscarProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarProfesor.Name = "btnBuscarProfesor";
            btnBuscarProfesor.NoAccentTextColor = Color.Empty;
            btnBuscarProfesor.Size = new Size(65, 50);
            btnBuscarProfesor.TabIndex = 28;
            btnBuscarProfesor.Text = "Buscar";
            btnBuscarProfesor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarProfesor.UseAccentColor = false;
            btnBuscarProfesor.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProfesor
            // 
            txtBuscarProfesor.AnimateReadOnly = false;
            txtBuscarProfesor.BorderStyle = BorderStyle.None;
            txtBuscarProfesor.Depth = 0;
            txtBuscarProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarProfesor.LeadingIcon = null;
            txtBuscarProfesor.Location = new Point(423, 250);
            txtBuscarProfesor.MaxLength = 50;
            txtBuscarProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarProfesor.Multiline = false;
            txtBuscarProfesor.Name = "txtBuscarProfesor";
            txtBuscarProfesor.Size = new Size(170, 50);
            txtBuscarProfesor.TabIndex = 27;
            txtBuscarProfesor.Text = "";
            txtBuscarProfesor.TrailingIcon = null;
            // 
            // btnLimpiarProfesor
            // 
            btnLimpiarProfesor.AutoSize = false;
            btnLimpiarProfesor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiarProfesor.Depth = 0;
            btnLimpiarProfesor.HighEmphasis = true;
            btnLimpiarProfesor.Icon = null;
            btnLimpiarProfesor.Location = new Point(423, 172);
            btnLimpiarProfesor.Margin = new Padding(4, 6, 4, 6);
            btnLimpiarProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiarProfesor.Name = "btnLimpiarProfesor";
            btnLimpiarProfesor.NoAccentTextColor = Color.Empty;
            btnLimpiarProfesor.Size = new Size(242, 36);
            btnLimpiarProfesor.TabIndex = 26;
            btnLimpiarProfesor.Text = "Limpiar";
            btnLimpiarProfesor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiarProfesor.UseAccentColor = false;
            btnLimpiarProfesor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProfesor
            // 
            btnEliminarProfesor.AutoSize = false;
            btnEliminarProfesor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarProfesor.Depth = 0;
            btnEliminarProfesor.HighEmphasis = true;
            btnEliminarProfesor.Icon = null;
            btnEliminarProfesor.Location = new Point(423, 124);
            btnEliminarProfesor.Margin = new Padding(4, 6, 4, 6);
            btnEliminarProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarProfesor.Name = "btnEliminarProfesor";
            btnEliminarProfesor.NoAccentTextColor = Color.Empty;
            btnEliminarProfesor.Size = new Size(242, 36);
            btnEliminarProfesor.TabIndex = 25;
            btnEliminarProfesor.Text = "Eliminar";
            btnEliminarProfesor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminarProfesor.UseAccentColor = false;
            btnEliminarProfesor.UseVisualStyleBackColor = true;
            // 
            // btnModificarProfesor
            // 
            btnModificarProfesor.AutoSize = false;
            btnModificarProfesor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificarProfesor.Depth = 0;
            btnModificarProfesor.HighEmphasis = true;
            btnModificarProfesor.Icon = null;
            btnModificarProfesor.Location = new Point(423, 76);
            btnModificarProfesor.Margin = new Padding(4, 6, 4, 6);
            btnModificarProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificarProfesor.Name = "btnModificarProfesor";
            btnModificarProfesor.NoAccentTextColor = Color.Empty;
            btnModificarProfesor.Size = new Size(242, 36);
            btnModificarProfesor.TabIndex = 24;
            btnModificarProfesor.Text = "Modificar";
            btnModificarProfesor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificarProfesor.UseAccentColor = false;
            btnModificarProfesor.UseVisualStyleBackColor = true;
            // 
            // btnCargarProfesor
            // 
            btnCargarProfesor.AutoSize = false;
            btnCargarProfesor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCargarProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCargarProfesor.Depth = 0;
            btnCargarProfesor.HighEmphasis = true;
            btnCargarProfesor.Icon = null;
            btnCargarProfesor.Location = new Point(423, 28);
            btnCargarProfesor.Margin = new Padding(4, 6, 4, 6);
            btnCargarProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            btnCargarProfesor.Name = "btnCargarProfesor";
            btnCargarProfesor.NoAccentTextColor = Color.Empty;
            btnCargarProfesor.Size = new Size(242, 36);
            btnCargarProfesor.TabIndex = 23;
            btnCargarProfesor.Text = "Cargar";
            btnCargarProfesor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCargarProfesor.UseAccentColor = false;
            btnCargarProfesor.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoProfesor
            // 
            txtTelefonoProfesor.AnimateReadOnly = false;
            txtTelefonoProfesor.BorderStyle = BorderStyle.None;
            txtTelefonoProfesor.Depth = 0;
            txtTelefonoProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefonoProfesor.Hint = "Teléfono";
            txtTelefonoProfesor.LeadingIcon = null;
            txtTelefonoProfesor.Location = new Point(208, 251);
            txtTelefonoProfesor.MaxLength = 50;
            txtTelefonoProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefonoProfesor.Multiline = false;
            txtTelefonoProfesor.Name = "txtTelefonoProfesor";
            txtTelefonoProfesor.Size = new Size(185, 50);
            txtTelefonoProfesor.TabIndex = 22;
            txtTelefonoProfesor.Text = "";
            txtTelefonoProfesor.TrailingIcon = null;
            // 
            // txtInformacionAdicionalProfesor
            // 
            txtInformacionAdicionalProfesor.AnimateReadOnly = false;
            txtInformacionAdicionalProfesor.BorderStyle = BorderStyle.None;
            txtInformacionAdicionalProfesor.Depth = 0;
            txtInformacionAdicionalProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInformacionAdicionalProfesor.Hint = "Información Adicional";
            txtInformacionAdicionalProfesor.LeadingIcon = null;
            txtInformacionAdicionalProfesor.Location = new Point(17, 307);
            txtInformacionAdicionalProfesor.MaxLength = 50;
            txtInformacionAdicionalProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtInformacionAdicionalProfesor.Multiline = false;
            txtInformacionAdicionalProfesor.Name = "txtInformacionAdicionalProfesor";
            txtInformacionAdicionalProfesor.Size = new Size(376, 50);
            txtInformacionAdicionalProfesor.TabIndex = 21;
            txtInformacionAdicionalProfesor.Text = "";
            txtInformacionAdicionalProfesor.TrailingIcon = null;
            // 
            // txtEmailProfesor
            // 
            txtEmailProfesor.AnimateReadOnly = false;
            txtEmailProfesor.BorderStyle = BorderStyle.None;
            txtEmailProfesor.Depth = 0;
            txtEmailProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmailProfesor.Hint = "Email";
            txtEmailProfesor.LeadingIcon = null;
            txtEmailProfesor.Location = new Point(17, 251);
            txtEmailProfesor.MaxLength = 50;
            txtEmailProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtEmailProfesor.Multiline = false;
            txtEmailProfesor.Name = "txtEmailProfesor";
            txtEmailProfesor.Size = new Size(185, 50);
            txtEmailProfesor.TabIndex = 18;
            txtEmailProfesor.Text = "";
            txtEmailProfesor.TrailingIcon = null;
            // 
            // txtLocalidadProfesor
            // 
            txtLocalidadProfesor.AnimateReadOnly = false;
            txtLocalidadProfesor.BorderStyle = BorderStyle.None;
            txtLocalidadProfesor.Depth = 0;
            txtLocalidadProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLocalidadProfesor.Hint = "Localidad";
            txtLocalidadProfesor.LeadingIcon = null;
            txtLocalidadProfesor.Location = new Point(208, 195);
            txtLocalidadProfesor.MaxLength = 50;
            txtLocalidadProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtLocalidadProfesor.Multiline = false;
            txtLocalidadProfesor.Name = "txtLocalidadProfesor";
            txtLocalidadProfesor.Size = new Size(185, 50);
            txtLocalidadProfesor.TabIndex = 17;
            txtLocalidadProfesor.Text = "";
            txtLocalidadProfesor.TrailingIcon = null;
            // 
            // txtDomicilioProfesor
            // 
            txtDomicilioProfesor.AnimateReadOnly = false;
            txtDomicilioProfesor.BorderStyle = BorderStyle.None;
            txtDomicilioProfesor.Depth = 0;
            txtDomicilioProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDomicilioProfesor.Hint = "Domicilio";
            txtDomicilioProfesor.LeadingIcon = null;
            txtDomicilioProfesor.Location = new Point(17, 195);
            txtDomicilioProfesor.MaxLength = 50;
            txtDomicilioProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtDomicilioProfesor.Multiline = false;
            txtDomicilioProfesor.Name = "txtDomicilioProfesor";
            txtDomicilioProfesor.Size = new Size(185, 50);
            txtDomicilioProfesor.TabIndex = 16;
            txtDomicilioProfesor.Text = "";
            txtDomicilioProfesor.TrailingIcon = null;
            // 
            // txtFechaNacProfesor
            // 
            txtFechaNacProfesor.AnimateReadOnly = false;
            txtFechaNacProfesor.BorderStyle = BorderStyle.None;
            txtFechaNacProfesor.Depth = 0;
            txtFechaNacProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFechaNacProfesor.Hint = "Fecha de Nacimiento";
            txtFechaNacProfesor.LeadingIcon = null;
            txtFechaNacProfesor.Location = new Point(208, 139);
            txtFechaNacProfesor.MaxLength = 50;
            txtFechaNacProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtFechaNacProfesor.Multiline = false;
            txtFechaNacProfesor.Name = "txtFechaNacProfesor";
            txtFechaNacProfesor.Size = new Size(185, 50);
            txtFechaNacProfesor.TabIndex = 15;
            txtFechaNacProfesor.Text = "";
            txtFechaNacProfesor.TrailingIcon = null;
            // 
            // txtDniProfesor
            // 
            txtDniProfesor.AnimateReadOnly = false;
            txtDniProfesor.BorderStyle = BorderStyle.None;
            txtDniProfesor.Depth = 0;
            txtDniProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDniProfesor.Hint = "DNI";
            txtDniProfesor.LeadingIcon = null;
            txtDniProfesor.Location = new Point(17, 139);
            txtDniProfesor.MaxLength = 50;
            txtDniProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtDniProfesor.Multiline = false;
            txtDniProfesor.Name = "txtDniProfesor";
            txtDniProfesor.Size = new Size(185, 50);
            txtDniProfesor.TabIndex = 14;
            txtDniProfesor.Text = "";
            txtDniProfesor.TrailingIcon = null;
            // 
            // txtApellidoProfesor
            // 
            txtApellidoProfesor.AnimateReadOnly = false;
            txtApellidoProfesor.BorderStyle = BorderStyle.None;
            txtApellidoProfesor.Depth = 0;
            txtApellidoProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellidoProfesor.Hint = "Apellido";
            txtApellidoProfesor.LeadingIcon = null;
            txtApellidoProfesor.Location = new Point(17, 83);
            txtApellidoProfesor.MaxLength = 50;
            txtApellidoProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtApellidoProfesor.Multiline = false;
            txtApellidoProfesor.Name = "txtApellidoProfesor";
            txtApellidoProfesor.Size = new Size(376, 50);
            txtApellidoProfesor.TabIndex = 13;
            txtApellidoProfesor.Text = "";
            txtApellidoProfesor.TrailingIcon = null;
            // 
            // txtNombreProfesor
            // 
            txtNombreProfesor.AnimateReadOnly = false;
            txtNombreProfesor.BorderStyle = BorderStyle.None;
            txtNombreProfesor.Depth = 0;
            txtNombreProfesor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreProfesor.Hint = "Nombre";
            txtNombreProfesor.LeadingIcon = null;
            txtNombreProfesor.Location = new Point(17, 27);
            txtNombreProfesor.MaxLength = 50;
            txtNombreProfesor.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreProfesor.Multiline = false;
            txtNombreProfesor.Name = "txtNombreProfesor";
            txtNombreProfesor.Size = new Size(376, 50);
            txtNombreProfesor.TabIndex = 12;
            txtNombreProfesor.Text = "";
            txtNombreProfesor.TrailingIcon = null;
            // 
            // tabMaterias
            // 
            tabMaterias.Controls.Add(btnBuscarMateria);
            tabMaterias.Controls.Add(txtBuscarMateria);
            tabMaterias.Controls.Add(btnLimpiarMateria);
            tabMaterias.Controls.Add(btnEliminarMateria);
            tabMaterias.Controls.Add(btnModificarMateria);
            tabMaterias.Controls.Add(btnCargarMateria);
            tabMaterias.Controls.Add(cbdTipoMateria);
            tabMaterias.Controls.Add(cbdAsignarMateriaProfesor);
            tabMaterias.Controls.Add(cbdAñoCursoMateria);
            tabMaterias.Controls.Add(txtCargaHorariaMateria);
            tabMaterias.Controls.Add(cbdAsignarCarreraMateria);
            tabMaterias.Controls.Add(txtNombreMateria);
            tabMaterias.Location = new Point(4, 24);
            tabMaterias.Name = "tabMaterias";
            tabMaterias.Padding = new Padding(3);
            tabMaterias.Size = new Size(675, 393);
            tabMaterias.TabIndex = 1;
            tabMaterias.Text = "Materias";
            tabMaterias.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMateria
            // 
            btnBuscarMateria.AutoSize = false;
            btnBuscarMateria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarMateria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarMateria.Depth = 0;
            btnBuscarMateria.HighEmphasis = true;
            btnBuscarMateria.Icon = null;
            btnBuscarMateria.Location = new Point(600, 250);
            btnBuscarMateria.Margin = new Padding(4, 6, 4, 6);
            btnBuscarMateria.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarMateria.Name = "btnBuscarMateria";
            btnBuscarMateria.NoAccentTextColor = Color.Empty;
            btnBuscarMateria.Size = new Size(65, 50);
            btnBuscarMateria.TabIndex = 34;
            btnBuscarMateria.Text = "Buscar";
            btnBuscarMateria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarMateria.UseAccentColor = false;
            btnBuscarMateria.UseVisualStyleBackColor = true;
            // 
            // txtBuscarMateria
            // 
            txtBuscarMateria.AnimateReadOnly = false;
            txtBuscarMateria.BorderStyle = BorderStyle.None;
            txtBuscarMateria.Depth = 0;
            txtBuscarMateria.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarMateria.LeadingIcon = null;
            txtBuscarMateria.Location = new Point(423, 250);
            txtBuscarMateria.MaxLength = 50;
            txtBuscarMateria.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarMateria.Multiline = false;
            txtBuscarMateria.Name = "txtBuscarMateria";
            txtBuscarMateria.Size = new Size(170, 50);
            txtBuscarMateria.TabIndex = 33;
            txtBuscarMateria.Text = "";
            txtBuscarMateria.TrailingIcon = null;
            // 
            // btnLimpiarMateria
            // 
            btnLimpiarMateria.AutoSize = false;
            btnLimpiarMateria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarMateria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiarMateria.Depth = 0;
            btnLimpiarMateria.HighEmphasis = true;
            btnLimpiarMateria.Icon = null;
            btnLimpiarMateria.Location = new Point(423, 172);
            btnLimpiarMateria.Margin = new Padding(4, 6, 4, 6);
            btnLimpiarMateria.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiarMateria.Name = "btnLimpiarMateria";
            btnLimpiarMateria.NoAccentTextColor = Color.Empty;
            btnLimpiarMateria.Size = new Size(242, 36);
            btnLimpiarMateria.TabIndex = 32;
            btnLimpiarMateria.Text = "Limpiar";
            btnLimpiarMateria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiarMateria.UseAccentColor = false;
            btnLimpiarMateria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.AutoSize = false;
            btnEliminarMateria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarMateria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarMateria.Depth = 0;
            btnEliminarMateria.HighEmphasis = true;
            btnEliminarMateria.Icon = null;
            btnEliminarMateria.Location = new Point(423, 124);
            btnEliminarMateria.Margin = new Padding(4, 6, 4, 6);
            btnEliminarMateria.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.NoAccentTextColor = Color.Empty;
            btnEliminarMateria.Size = new Size(242, 36);
            btnEliminarMateria.TabIndex = 31;
            btnEliminarMateria.Text = "Eliminar";
            btnEliminarMateria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminarMateria.UseAccentColor = false;
            btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // btnModificarMateria
            // 
            btnModificarMateria.AutoSize = false;
            btnModificarMateria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarMateria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificarMateria.Depth = 0;
            btnModificarMateria.HighEmphasis = true;
            btnModificarMateria.Icon = null;
            btnModificarMateria.Location = new Point(423, 76);
            btnModificarMateria.Margin = new Padding(4, 6, 4, 6);
            btnModificarMateria.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificarMateria.Name = "btnModificarMateria";
            btnModificarMateria.NoAccentTextColor = Color.Empty;
            btnModificarMateria.Size = new Size(242, 36);
            btnModificarMateria.TabIndex = 30;
            btnModificarMateria.Text = "Modificar";
            btnModificarMateria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificarMateria.UseAccentColor = false;
            btnModificarMateria.UseVisualStyleBackColor = true;
            // 
            // btnCargarMateria
            // 
            btnCargarMateria.AutoSize = false;
            btnCargarMateria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCargarMateria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCargarMateria.Depth = 0;
            btnCargarMateria.HighEmphasis = true;
            btnCargarMateria.Icon = null;
            btnCargarMateria.Location = new Point(423, 28);
            btnCargarMateria.Margin = new Padding(4, 6, 4, 6);
            btnCargarMateria.MouseState = MaterialSkin.MouseState.HOVER;
            btnCargarMateria.Name = "btnCargarMateria";
            btnCargarMateria.NoAccentTextColor = Color.Empty;
            btnCargarMateria.Size = new Size(242, 36);
            btnCargarMateria.TabIndex = 29;
            btnCargarMateria.Text = "Cargar";
            btnCargarMateria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCargarMateria.UseAccentColor = false;
            btnCargarMateria.UseVisualStyleBackColor = true;
            // 
            // cbdTipoMateria
            // 
            cbdTipoMateria.AutoResize = false;
            cbdTipoMateria.BackColor = Color.FromArgb(255, 255, 255);
            cbdTipoMateria.Depth = 0;
            cbdTipoMateria.DrawMode = DrawMode.OwnerDrawVariable;
            cbdTipoMateria.DropDownHeight = 174;
            cbdTipoMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdTipoMateria.DropDownWidth = 121;
            cbdTipoMateria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbdTipoMateria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbdTipoMateria.FormattingEnabled = true;
            cbdTipoMateria.Hint = "Tipo de Materia";
            cbdTipoMateria.IntegralHeight = false;
            cbdTipoMateria.ItemHeight = 43;
            cbdTipoMateria.Location = new Point(17, 249);
            cbdTipoMateria.MaxDropDownItems = 4;
            cbdTipoMateria.MouseState = MaterialSkin.MouseState.OUT;
            cbdTipoMateria.Name = "cbdTipoMateria";
            cbdTipoMateria.Size = new Size(376, 49);
            cbdTipoMateria.StartIndex = 0;
            cbdTipoMateria.TabIndex = 16;
            // 
            // cbdAsignarMateriaProfesor
            // 
            cbdAsignarMateriaProfesor.AutoResize = false;
            cbdAsignarMateriaProfesor.BackColor = Color.FromArgb(255, 255, 255);
            cbdAsignarMateriaProfesor.Depth = 0;
            cbdAsignarMateriaProfesor.DrawMode = DrawMode.OwnerDrawVariable;
            cbdAsignarMateriaProfesor.DropDownHeight = 174;
            cbdAsignarMateriaProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdAsignarMateriaProfesor.DropDownWidth = 121;
            cbdAsignarMateriaProfesor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbdAsignarMateriaProfesor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbdAsignarMateriaProfesor.FormattingEnabled = true;
            cbdAsignarMateriaProfesor.Hint = "Asignar Profesor";
            cbdAsignarMateriaProfesor.IntegralHeight = false;
            cbdAsignarMateriaProfesor.ItemHeight = 43;
            cbdAsignarMateriaProfesor.Location = new Point(17, 193);
            cbdAsignarMateriaProfesor.MaxDropDownItems = 4;
            cbdAsignarMateriaProfesor.MouseState = MaterialSkin.MouseState.OUT;
            cbdAsignarMateriaProfesor.Name = "cbdAsignarMateriaProfesor";
            cbdAsignarMateriaProfesor.Size = new Size(376, 49);
            cbdAsignarMateriaProfesor.StartIndex = 0;
            cbdAsignarMateriaProfesor.TabIndex = 15;
            // 
            // cbdAñoCursoMateria
            // 
            cbdAñoCursoMateria.AutoResize = false;
            cbdAñoCursoMateria.BackColor = Color.FromArgb(255, 255, 255);
            cbdAñoCursoMateria.Depth = 0;
            cbdAñoCursoMateria.DrawMode = DrawMode.OwnerDrawVariable;
            cbdAñoCursoMateria.DropDownHeight = 174;
            cbdAñoCursoMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdAñoCursoMateria.DropDownWidth = 121;
            cbdAñoCursoMateria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbdAñoCursoMateria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbdAñoCursoMateria.FormattingEnabled = true;
            cbdAñoCursoMateria.Hint = "Año en que se dicta";
            cbdAñoCursoMateria.IntegralHeight = false;
            cbdAñoCursoMateria.ItemHeight = 43;
            cbdAñoCursoMateria.Location = new Point(17, 138);
            cbdAñoCursoMateria.MaxDropDownItems = 4;
            cbdAñoCursoMateria.MouseState = MaterialSkin.MouseState.OUT;
            cbdAñoCursoMateria.Name = "cbdAñoCursoMateria";
            cbdAñoCursoMateria.Size = new Size(376, 49);
            cbdAñoCursoMateria.StartIndex = 0;
            cbdAñoCursoMateria.TabIndex = 14;
            // 
            // txtCargaHorariaMateria
            // 
            txtCargaHorariaMateria.AnimateReadOnly = false;
            txtCargaHorariaMateria.BorderStyle = BorderStyle.None;
            txtCargaHorariaMateria.Depth = 0;
            txtCargaHorariaMateria.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCargaHorariaMateria.Hint = "Carga Horaria";
            txtCargaHorariaMateria.LeadingIcon = null;
            txtCargaHorariaMateria.Location = new Point(17, 304);
            txtCargaHorariaMateria.MaxLength = 50;
            txtCargaHorariaMateria.MouseState = MaterialSkin.MouseState.OUT;
            txtCargaHorariaMateria.Multiline = false;
            txtCargaHorariaMateria.Name = "txtCargaHorariaMateria";
            txtCargaHorariaMateria.Size = new Size(376, 50);
            txtCargaHorariaMateria.TabIndex = 13;
            txtCargaHorariaMateria.Text = "";
            txtCargaHorariaMateria.TrailingIcon = null;
            // 
            // cbdAsignarCarreraMateria
            // 
            cbdAsignarCarreraMateria.AutoResize = false;
            cbdAsignarCarreraMateria.BackColor = Color.FromArgb(255, 255, 255);
            cbdAsignarCarreraMateria.Depth = 0;
            cbdAsignarCarreraMateria.DrawMode = DrawMode.OwnerDrawVariable;
            cbdAsignarCarreraMateria.DropDownHeight = 174;
            cbdAsignarCarreraMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdAsignarCarreraMateria.DropDownWidth = 121;
            cbdAsignarCarreraMateria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbdAsignarCarreraMateria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbdAsignarCarreraMateria.FormattingEnabled = true;
            cbdAsignarCarreraMateria.Hint = "Asignar Carrera";
            cbdAsignarCarreraMateria.IntegralHeight = false;
            cbdAsignarCarreraMateria.ItemHeight = 43;
            cbdAsignarCarreraMateria.Location = new Point(17, 83);
            cbdAsignarCarreraMateria.MaxDropDownItems = 4;
            cbdAsignarCarreraMateria.MouseState = MaterialSkin.MouseState.OUT;
            cbdAsignarCarreraMateria.Name = "cbdAsignarCarreraMateria";
            cbdAsignarCarreraMateria.Size = new Size(376, 49);
            cbdAsignarCarreraMateria.StartIndex = 0;
            cbdAsignarCarreraMateria.TabIndex = 2;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.AnimateReadOnly = false;
            txtNombreMateria.BorderStyle = BorderStyle.None;
            txtNombreMateria.Depth = 0;
            txtNombreMateria.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreMateria.Hint = "Nombre";
            txtNombreMateria.LeadingIcon = null;
            txtNombreMateria.Location = new Point(17, 27);
            txtNombreMateria.MaxLength = 50;
            txtNombreMateria.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreMateria.Multiline = false;
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(376, 50);
            txtNombreMateria.TabIndex = 1;
            txtNombreMateria.Text = "";
            txtNombreMateria.TrailingIcon = null;
            // 
            // tabAlumnos
            // 
            tabAlumnos.Controls.Add(btnBuscarAlumno);
            tabAlumnos.Controls.Add(txtBuscarAlumno);
            tabAlumnos.Controls.Add(btnLimpiarAlumno);
            tabAlumnos.Controls.Add(btnEliminarAlumno);
            tabAlumnos.Controls.Add(btnModificarAlumno);
            tabAlumnos.Controls.Add(btnCargarAlumno);
            tabAlumnos.Controls.Add(txtTelefonoAlumno);
            tabAlumnos.Controls.Add(cbdAsignarCarreraAlumno);
            tabAlumnos.Controls.Add(txtEmailAlumno);
            tabAlumnos.Controls.Add(txtLocalidadAlumno);
            tabAlumnos.Controls.Add(txtDomicilioAlumno);
            tabAlumnos.Controls.Add(txtFechaNacAlumno);
            tabAlumnos.Controls.Add(txtDniAlumno);
            tabAlumnos.Controls.Add(txtApellidoAlumno);
            tabAlumnos.Controls.Add(txtNombreAlumno);
            tabAlumnos.Location = new Point(4, 24);
            tabAlumnos.Name = "tabAlumnos";
            tabAlumnos.Size = new Size(675, 393);
            tabAlumnos.TabIndex = 2;
            tabAlumnos.Text = "Alumnos";
            tabAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAlumno
            // 
            btnBuscarAlumno.AutoSize = false;
            btnBuscarAlumno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarAlumno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarAlumno.Depth = 0;
            btnBuscarAlumno.HighEmphasis = true;
            btnBuscarAlumno.Icon = null;
            btnBuscarAlumno.Location = new Point(600, 250);
            btnBuscarAlumno.Margin = new Padding(4, 6, 4, 6);
            btnBuscarAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarAlumno.Name = "btnBuscarAlumno";
            btnBuscarAlumno.NoAccentTextColor = Color.Empty;
            btnBuscarAlumno.Size = new Size(65, 50);
            btnBuscarAlumno.TabIndex = 40;
            btnBuscarAlumno.Text = "Buscar";
            btnBuscarAlumno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarAlumno.UseAccentColor = false;
            btnBuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // txtBuscarAlumno
            // 
            txtBuscarAlumno.AnimateReadOnly = false;
            txtBuscarAlumno.BorderStyle = BorderStyle.None;
            txtBuscarAlumno.Depth = 0;
            txtBuscarAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscarAlumno.LeadingIcon = null;
            txtBuscarAlumno.Location = new Point(423, 250);
            txtBuscarAlumno.MaxLength = 50;
            txtBuscarAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscarAlumno.Multiline = false;
            txtBuscarAlumno.Name = "txtBuscarAlumno";
            txtBuscarAlumno.Size = new Size(170, 50);
            txtBuscarAlumno.TabIndex = 39;
            txtBuscarAlumno.Text = "";
            txtBuscarAlumno.TrailingIcon = null;
            // 
            // btnLimpiarAlumno
            // 
            btnLimpiarAlumno.AutoSize = false;
            btnLimpiarAlumno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiarAlumno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiarAlumno.Depth = 0;
            btnLimpiarAlumno.HighEmphasis = true;
            btnLimpiarAlumno.Icon = null;
            btnLimpiarAlumno.Location = new Point(423, 172);
            btnLimpiarAlumno.Margin = new Padding(4, 6, 4, 6);
            btnLimpiarAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiarAlumno.Name = "btnLimpiarAlumno";
            btnLimpiarAlumno.NoAccentTextColor = Color.Empty;
            btnLimpiarAlumno.Size = new Size(242, 36);
            btnLimpiarAlumno.TabIndex = 38;
            btnLimpiarAlumno.Text = "Limpiar";
            btnLimpiarAlumno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiarAlumno.UseAccentColor = false;
            btnLimpiarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAlumno
            // 
            btnEliminarAlumno.AutoSize = false;
            btnEliminarAlumno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarAlumno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarAlumno.Depth = 0;
            btnEliminarAlumno.HighEmphasis = true;
            btnEliminarAlumno.Icon = null;
            btnEliminarAlumno.Location = new Point(423, 124);
            btnEliminarAlumno.Margin = new Padding(4, 6, 4, 6);
            btnEliminarAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarAlumno.Name = "btnEliminarAlumno";
            btnEliminarAlumno.NoAccentTextColor = Color.Empty;
            btnEliminarAlumno.Size = new Size(242, 36);
            btnEliminarAlumno.TabIndex = 37;
            btnEliminarAlumno.Text = "Eliminar";
            btnEliminarAlumno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminarAlumno.UseAccentColor = false;
            btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            btnModificarAlumno.AutoSize = false;
            btnModificarAlumno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarAlumno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificarAlumno.Depth = 0;
            btnModificarAlumno.HighEmphasis = true;
            btnModificarAlumno.Icon = null;
            btnModificarAlumno.Location = new Point(423, 76);
            btnModificarAlumno.Margin = new Padding(4, 6, 4, 6);
            btnModificarAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificarAlumno.Name = "btnModificarAlumno";
            btnModificarAlumno.NoAccentTextColor = Color.Empty;
            btnModificarAlumno.Size = new Size(242, 36);
            btnModificarAlumno.TabIndex = 36;
            btnModificarAlumno.Text = "Modificar";
            btnModificarAlumno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificarAlumno.UseAccentColor = false;
            btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnCargarAlumno
            // 
            btnCargarAlumno.AutoSize = false;
            btnCargarAlumno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCargarAlumno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCargarAlumno.Depth = 0;
            btnCargarAlumno.HighEmphasis = true;
            btnCargarAlumno.Icon = null;
            btnCargarAlumno.Location = new Point(423, 28);
            btnCargarAlumno.Margin = new Padding(4, 6, 4, 6);
            btnCargarAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            btnCargarAlumno.Name = "btnCargarAlumno";
            btnCargarAlumno.NoAccentTextColor = Color.Empty;
            btnCargarAlumno.Size = new Size(242, 36);
            btnCargarAlumno.TabIndex = 35;
            btnCargarAlumno.Text = "Cargar";
            btnCargarAlumno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCargarAlumno.UseAccentColor = false;
            btnCargarAlumno.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.AnimateReadOnly = false;
            txtTelefonoAlumno.BorderStyle = BorderStyle.None;
            txtTelefonoAlumno.Depth = 0;
            txtTelefonoAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefonoAlumno.Hint = "Teléfono";
            txtTelefonoAlumno.LeadingIcon = null;
            txtTelefonoAlumno.Location = new Point(208, 251);
            txtTelefonoAlumno.MaxLength = 50;
            txtTelefonoAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefonoAlumno.Multiline = false;
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(185, 50);
            txtTelefonoAlumno.TabIndex = 12;
            txtTelefonoAlumno.Text = "";
            txtTelefonoAlumno.TrailingIcon = null;
            // 
            // cbdAsignarCarreraAlumno
            // 
            cbdAsignarCarreraAlumno.AutoResize = false;
            cbdAsignarCarreraAlumno.BackColor = Color.FromArgb(255, 255, 255);
            cbdAsignarCarreraAlumno.Depth = 0;
            cbdAsignarCarreraAlumno.DrawMode = DrawMode.OwnerDrawVariable;
            cbdAsignarCarreraAlumno.DropDownHeight = 174;
            cbdAsignarCarreraAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdAsignarCarreraAlumno.DropDownWidth = 121;
            cbdAsignarCarreraAlumno.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbdAsignarCarreraAlumno.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbdAsignarCarreraAlumno.FormattingEnabled = true;
            cbdAsignarCarreraAlumno.Hint = "Asignar Carrera";
            cbdAsignarCarreraAlumno.IntegralHeight = false;
            cbdAsignarCarreraAlumno.ItemHeight = 43;
            cbdAsignarCarreraAlumno.Location = new Point(17, 307);
            cbdAsignarCarreraAlumno.MaxDropDownItems = 4;
            cbdAsignarCarreraAlumno.MouseState = MaterialSkin.MouseState.OUT;
            cbdAsignarCarreraAlumno.Name = "cbdAsignarCarreraAlumno";
            cbdAsignarCarreraAlumno.Size = new Size(376, 49);
            cbdAsignarCarreraAlumno.StartIndex = 0;
            cbdAsignarCarreraAlumno.TabIndex = 11;
            // 
            // txtEmailAlumno
            // 
            txtEmailAlumno.AnimateReadOnly = false;
            txtEmailAlumno.BorderStyle = BorderStyle.None;
            txtEmailAlumno.Depth = 0;
            txtEmailAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmailAlumno.Hint = "Email";
            txtEmailAlumno.LeadingIcon = null;
            txtEmailAlumno.Location = new Point(17, 251);
            txtEmailAlumno.MaxLength = 50;
            txtEmailAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtEmailAlumno.Multiline = false;
            txtEmailAlumno.Name = "txtEmailAlumno";
            txtEmailAlumno.Size = new Size(185, 50);
            txtEmailAlumno.TabIndex = 8;
            txtEmailAlumno.Text = "";
            txtEmailAlumno.TrailingIcon = null;
            // 
            // txtLocalidadAlumno
            // 
            txtLocalidadAlumno.AnimateReadOnly = false;
            txtLocalidadAlumno.BorderStyle = BorderStyle.None;
            txtLocalidadAlumno.Depth = 0;
            txtLocalidadAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLocalidadAlumno.Hint = "Localidad";
            txtLocalidadAlumno.LeadingIcon = null;
            txtLocalidadAlumno.Location = new Point(208, 195);
            txtLocalidadAlumno.MaxLength = 50;
            txtLocalidadAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtLocalidadAlumno.Multiline = false;
            txtLocalidadAlumno.Name = "txtLocalidadAlumno";
            txtLocalidadAlumno.Size = new Size(185, 50);
            txtLocalidadAlumno.TabIndex = 7;
            txtLocalidadAlumno.Text = "";
            txtLocalidadAlumno.TrailingIcon = null;
            // 
            // txtDomicilioAlumno
            // 
            txtDomicilioAlumno.AnimateReadOnly = false;
            txtDomicilioAlumno.BorderStyle = BorderStyle.None;
            txtDomicilioAlumno.Depth = 0;
            txtDomicilioAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDomicilioAlumno.Hint = "Domicilio";
            txtDomicilioAlumno.LeadingIcon = null;
            txtDomicilioAlumno.Location = new Point(17, 195);
            txtDomicilioAlumno.MaxLength = 50;
            txtDomicilioAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtDomicilioAlumno.Multiline = false;
            txtDomicilioAlumno.Name = "txtDomicilioAlumno";
            txtDomicilioAlumno.Size = new Size(185, 50);
            txtDomicilioAlumno.TabIndex = 6;
            txtDomicilioAlumno.Text = "";
            txtDomicilioAlumno.TrailingIcon = null;
            // 
            // txtFechaNacAlumno
            // 
            txtFechaNacAlumno.AnimateReadOnly = false;
            txtFechaNacAlumno.BorderStyle = BorderStyle.None;
            txtFechaNacAlumno.Depth = 0;
            txtFechaNacAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFechaNacAlumno.Hint = "Fecha de Nacimiento";
            txtFechaNacAlumno.LeadingIcon = null;
            txtFechaNacAlumno.Location = new Point(208, 139);
            txtFechaNacAlumno.MaxLength = 50;
            txtFechaNacAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtFechaNacAlumno.Multiline = false;
            txtFechaNacAlumno.Name = "txtFechaNacAlumno";
            txtFechaNacAlumno.Size = new Size(185, 50);
            txtFechaNacAlumno.TabIndex = 5;
            txtFechaNacAlumno.Text = "";
            txtFechaNacAlumno.TrailingIcon = null;
            // 
            // txtDniAlumno
            // 
            txtDniAlumno.AnimateReadOnly = false;
            txtDniAlumno.BorderStyle = BorderStyle.None;
            txtDniAlumno.Depth = 0;
            txtDniAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDniAlumno.Hint = "DNI";
            txtDniAlumno.LeadingIcon = null;
            txtDniAlumno.Location = new Point(17, 139);
            txtDniAlumno.MaxLength = 50;
            txtDniAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtDniAlumno.Multiline = false;
            txtDniAlumno.Name = "txtDniAlumno";
            txtDniAlumno.Size = new Size(185, 50);
            txtDniAlumno.TabIndex = 4;
            txtDniAlumno.Text = "";
            txtDniAlumno.TrailingIcon = null;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.AnimateReadOnly = false;
            txtApellidoAlumno.BorderStyle = BorderStyle.None;
            txtApellidoAlumno.Depth = 0;
            txtApellidoAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellidoAlumno.Hint = "Apellido";
            txtApellidoAlumno.LeadingIcon = null;
            txtApellidoAlumno.Location = new Point(17, 83);
            txtApellidoAlumno.MaxLength = 50;
            txtApellidoAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtApellidoAlumno.Multiline = false;
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(376, 50);
            txtApellidoAlumno.TabIndex = 3;
            txtApellidoAlumno.Text = "";
            txtApellidoAlumno.TrailingIcon = null;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.AnimateReadOnly = false;
            txtNombreAlumno.BorderStyle = BorderStyle.None;
            txtNombreAlumno.Depth = 0;
            txtNombreAlumno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreAlumno.Hint = "Nombre";
            txtNombreAlumno.LeadingIcon = null;
            txtNombreAlumno.Location = new Point(17, 27);
            txtNombreAlumno.MaxLength = 50;
            txtNombreAlumno.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreAlumno.Multiline = false;
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(376, 50);
            txtNombreAlumno.TabIndex = 2;
            txtNombreAlumno.Text = "";
            txtNombreAlumno.TrailingIcon = null;
            // 
            // tabControlAsistencias
            // 
            tabControlAsistencias.Location = new Point(4, 24);
            tabControlAsistencias.Name = "tabControlAsistencias";
            tabControlAsistencias.Size = new Size(840, 509);
            tabControlAsistencias.TabIndex = 2;
            tabControlAsistencias.Text = "Control Asistencias";
            tabControlAsistencias.UseVisualStyleBackColor = true;
            // 
            // tabInformes
            // 
            tabInformes.Location = new Point(4, 24);
            tabInformes.Name = "tabInformes";
            tabInformes.Size = new Size(840, 509);
            tabInformes.TabIndex = 3;
            tabInformes.Text = "Informes";
            tabInformes.UseVisualStyleBackColor = true;
            // 
            // tabAcercaDe
            // 
            tabAcercaDe.Location = new Point(4, 24);
            tabAcercaDe.Name = "tabAcercaDe";
            tabAcercaDe.Size = new Size(840, 509);
            tabAcercaDe.TabIndex = 4;
            tabAcercaDe.Text = "Acerca de";
            tabAcercaDe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(854, 612);
            Controls.Add(tabControlMenu);
            DrawerTabControl = tabControlMenu;
            FormStyle = FormStyles.ActionBar_48;
            Name = "Form1";
            Padding = new Padding(3, 72, 3, 3);
            Text = "Menu";
            tabControlMenu.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabAdministrarDatos.ResumeLayout(false);
            tabControlDatos.ResumeLayout(false);
            tabCarreras.ResumeLayout(false);
            tabProfesores.ResumeLayout(false);
            tabMaterias.ResumeLayout(false);
            tabAlumnos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControlMenu;
        private TabPage tabInicio;
        private TabPage tabAdministrarDatos;
        private TabPage tabControlAsistencias;
        private TabPage tabInformes;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorCargas;
        private MaterialSkin.Controls.MaterialTabControl tabControlDatos;
        private TabPage tabCarreras;
        private TabPage tabMaterias;
        private TabPage tabAlumnos;
        private MaterialSkin.Controls.MaterialTextBox txtNombreCarrera;
        private MaterialSkin.Controls.MaterialTextBox txtNombreMateria;
        private MaterialSkin.Controls.MaterialComboBox cbdAsignarCarreraMateria;
        private MaterialSkin.Controls.MaterialTextBox txtApellidoAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtNombreAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtDniAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtFechaNacAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtLocalidadAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtDomicilioAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtEmailAlumno;
        private TabPage tabProfesores;
        private MaterialSkin.Controls.MaterialButton btnModificarCarrera;
        private MaterialSkin.Controls.MaterialButton btnCargarCarrera;
        private MaterialSkin.Controls.MaterialComboBox cbdAsignarCarreraAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtEmailProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtLocalidadProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtDomicilioProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtFechaNacProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtDniProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtApellidoProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtNombreProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtFechaInicioCarrera;
        private MaterialSkin.Controls.MaterialTextBox txtCantidadMateriasCarrera;
        private MaterialSkin.Controls.MaterialComboBox cbcDuracionCarrera;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcionCarrera;
        private MaterialSkin.Controls.MaterialCheckbox chkInactivoCarrera;
        private MaterialSkin.Controls.MaterialCheckbox chkActivoCarrera;
        private MaterialSkin.Controls.MaterialTextBox txtCargaHorariaMateria;
        private MaterialSkin.Controls.MaterialComboBox cbdAñoCursoMateria;
        private MaterialSkin.Controls.MaterialComboBox cbdAsignarMateriaProfesor;
        private MaterialSkin.Controls.MaterialComboBox cbdTipoMateria;
        private MaterialSkin.Controls.MaterialTextBox txtTelefonoAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtInformacionAdicionalProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtTelefonoProfesor;
        private TabPage tabAcercaDe;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarCarrera;
        private MaterialSkin.Controls.MaterialButton btnLimpiarCarrera;
        private MaterialSkin.Controls.MaterialButton btnEliminarCarrera;
        private MaterialSkin.Controls.MaterialButton btnBuscarCarrera;
        private MaterialSkin.Controls.MaterialButton btnBuscarProfesor;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarProfesor;
        private MaterialSkin.Controls.MaterialButton btnLimpiarProfesor;
        private MaterialSkin.Controls.MaterialButton btnEliminarProfesor;
        private MaterialSkin.Controls.MaterialButton btnModificarProfesor;
        private MaterialSkin.Controls.MaterialButton btnCargarProfesor;
        private MaterialSkin.Controls.MaterialButton btnBuscarMateria;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarMateria;
        private MaterialSkin.Controls.MaterialButton btnLimpiarMateria;
        private MaterialSkin.Controls.MaterialButton btnEliminarMateria;
        private MaterialSkin.Controls.MaterialButton btnModificarMateria;
        private MaterialSkin.Controls.MaterialButton btnCargarMateria;
        private MaterialSkin.Controls.MaterialButton btnLimpiarAlumno;
        private MaterialSkin.Controls.MaterialButton btnEliminarAlumno;
        private MaterialSkin.Controls.MaterialButton btnModificarAlumno;
        private MaterialSkin.Controls.MaterialButton btnCargarAlumno;
        private MaterialSkin.Controls.MaterialButton btnBuscarAlumno;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarAlumno;
    }
}
