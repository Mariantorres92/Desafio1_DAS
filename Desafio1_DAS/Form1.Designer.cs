namespace Desafio1_DAS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.tabMain           = new System.Windows.Forms.TabControl();
            // --- Tab Usuarios ---
            this.tabUsuarios       = new System.Windows.Forms.TabPage();
            this.lblTituloUsuarios = new System.Windows.Forms.Label();
            this.lblNombreU        = new System.Windows.Forms.Label();
            this.lblCarnetU        = new System.Windows.Forms.Label();
            this.txtNombreUsuario  = new System.Windows.Forms.TextBox();
            this.txtCarnetUsuario  = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario  = new System.Windows.Forms.Button();
            this.btnEliminarUsuario= new System.Windows.Forms.Button();
            this.dgvUsuarios       = new System.Windows.Forms.DataGridView();
            this.colUId    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUNombre= new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUCarnet= new System.Windows.Forms.DataGridViewTextBoxColumn();
            // --- Tab Materiales ---
            this.tabMateriales     = new System.Windows.Forms.TabPage();
            this.lblTituloMat      = new System.Windows.Forms.Label();
            this.lblTipo           = new System.Windows.Forms.Label();
            this.cmbTipoMaterial   = new System.Windows.Forms.ComboBox();
            this.lblTitulo         = new System.Windows.Forms.Label();
            this.txtTitulo         = new System.Windows.Forms.TextBox();
            this.lblAutor          = new System.Windows.Forms.Label();
            this.txtAutor          = new System.Windows.Forms.TextBox();
            this.lblAnio           = new System.Windows.Forms.Label();
            this.numAnio           = new System.Windows.Forms.NumericUpDown();
            this.grpLibro          = new System.Windows.Forms.GroupBox();
            this.lblPaginas        = new System.Windows.Forms.Label();
            this.numPaginas        = new System.Windows.Forms.NumericUpDown();
            this.lblISBN           = new System.Windows.Forms.Label();
            this.txtISBN           = new System.Windows.Forms.TextBox();
            this.grpRevista        = new System.Windows.Forms.GroupBox();
            this.lblEdicion        = new System.Windows.Forms.Label();
            this.numEdicion        = new System.Windows.Forms.NumericUpDown();
            this.lblMes            = new System.Windows.Forms.Label();
            this.txtMes            = new System.Windows.Forms.TextBox();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.btnEditarMaterial  = new System.Windows.Forms.Button();
            this.btnEliminarMaterial= new System.Windows.Forms.Button();
            this.dgvMateriales     = new System.Windows.Forms.DataGridView();
            this.colMId     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMTipo   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMAutor  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMAnio   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            // --- Tab Prestamos ---
            this.tabPrestamos   = new System.Windows.Forms.TabPage();
            this.lblTituloPrest = new System.Windows.Forms.Label();
            this.lblMaterial    = new System.Windows.Forms.Label();
            this.cmbMaterial    = new System.Windows.Forms.ComboBox();
            this.lblUser        = new System.Windows.Forms.Label();
            this.cmbUsuario     = new System.Windows.Forms.ComboBox();
            this.btnPrestar     = new System.Windows.Forms.Button();
            this.btnDevolver    = new System.Windows.Forms.Button();
            this.dgvPrestamos   = new System.Windows.Forms.DataGridView();
            this.colPId       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPUsuario  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPFechaPr  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPFechaDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            // --- Tab Estadisticas ---
            this.tabEstadisticas  = new System.Windows.Forms.TabPage();
            this.lblTituloEst     = new System.Windows.Forms.Label();
            this.chartTopLibros   = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopUsuarios = new System.Windows.Forms.DataVisualization.Charting.Chart();

            // SuspendLayouts
            this.tabMain.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            this.grpLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).BeginInit();
            this.grpRevista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.tabPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.tabEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopUsuarios)).BeginInit();
            this.SuspendLayout();

            // ===========================================================
            // tabMain
            // ===========================================================
            this.tabMain.Controls.Add(this.tabUsuarios);
            this.tabMain.Controls.Add(this.tabMateriales);
            this.tabMain.Controls.Add(this.tabPrestamos);
            this.tabMain.Controls.Add(this.tabEstadisticas);
            this.tabMain.Dock          = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location      = new System.Drawing.Point(0, 56);
            this.tabMain.Name          = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size          = new System.Drawing.Size(980, 524);
            this.tabMain.TabIndex      = 0;

            // ===========================================================
            // TAB USUARIOS
            // ===========================================================
            this.tabUsuarios.Controls.Add(this.lblTituloUsuarios);
            this.tabUsuarios.Controls.Add(this.lblNombreU);
            this.tabUsuarios.Controls.Add(this.txtNombreUsuario);
            this.tabUsuarios.Controls.Add(this.lblCarnetU);
            this.tabUsuarios.Controls.Add(this.txtCarnetUsuario);
            this.tabUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tabUsuarios.Controls.Add(this.btnEditarUsuario);
            this.tabUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.tabUsuarios.Controls.Add(this.dgvUsuarios);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tabUsuarios.Name     = "tabUsuarios";
            this.tabUsuarios.Size     = new System.Drawing.Size(972, 495);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text     = "  Usuarios  ";
            this.tabUsuarios.UseVisualStyleBackColor = true;

            this.lblTituloUsuarios.AutoSize  = true;
            this.lblTituloUsuarios.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloUsuarios.Location  = new System.Drawing.Point(20, 18);
            this.lblTituloUsuarios.Name      = "lblTituloUsuarios";
            this.lblTituloUsuarios.Text      = "Gestión de Usuarios";

            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(20, 62);
            this.lblNombreU.Name     = "lblNombreU";
            this.lblNombreU.Text     = "Nombre Completo:";

            this.txtNombreUsuario.Location = new System.Drawing.Point(20, 82);
            this.txtNombreUsuario.Name     = "txtNombreUsuario";
            this.txtNombreUsuario.Size     = new System.Drawing.Size(220, 22);
            this.txtNombreUsuario.TabIndex = 0;

            this.lblCarnetU.AutoSize = true;
            this.lblCarnetU.Location = new System.Drawing.Point(260, 62);
            this.lblCarnetU.Name     = "lblCarnetU";
            this.lblCarnetU.Text     = "Carnet:";

            this.txtCarnetUsuario.Location = new System.Drawing.Point(260, 82);
            this.txtCarnetUsuario.Name     = "txtCarnetUsuario";
            this.txtCarnetUsuario.Size     = new System.Drawing.Size(180, 22);
            this.txtCarnetUsuario.TabIndex = 1;

            this.btnAgregarUsuario.Location = new System.Drawing.Point(20, 120);
            this.btnAgregarUsuario.Name     = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size     = new System.Drawing.Size(110, 34);
            this.btnAgregarUsuario.TabIndex = 2;
            this.btnAgregarUsuario.Text     = "Agregar";

            this.btnEditarUsuario.Location = new System.Drawing.Point(145, 120);
            this.btnEditarUsuario.Name     = "btnEditarUsuario";
            this.btnEditarUsuario.Size     = new System.Drawing.Size(110, 34);
            this.btnEditarUsuario.TabIndex = 3;
            this.btnEditarUsuario.Text     = "Editar";

            this.btnEliminarUsuario.Location = new System.Drawing.Point(270, 120);
            this.btnEliminarUsuario.Name     = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size     = new System.Drawing.Size(110, 34);
            this.btnEliminarUsuario.TabIndex = 4;
            this.btnEliminarUsuario.Text     = "Eliminar";

            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colUId, this.colUNombre, this.colUCarnet });
            this.dgvUsuarios.Location      = new System.Drawing.Point(20, 175);
            this.dgvUsuarios.Name          = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size          = new System.Drawing.Size(930, 295);
            this.dgvUsuarios.TabIndex      = 5;

            this.colUId.HeaderText = "ID";    this.colUId.Name = "colUId";    this.colUId.Width = 60;
            this.colUNombre.HeaderText = "Nombre"; this.colUNombre.Name = "colUNombre"; this.colUNombre.Width = 300;
            this.colUCarnet.HeaderText = "Carnet"; this.colUCarnet.Name = "colUCarnet"; this.colUCarnet.Width = 200;

            // ===========================================================
            // TAB MATERIALES
            // ===========================================================
            this.tabMateriales.Controls.Add(this.lblTituloMat);
            this.tabMateriales.Controls.Add(this.lblTipo);
            this.tabMateriales.Controls.Add(this.cmbTipoMaterial);
            this.tabMateriales.Controls.Add(this.lblTitulo);
            this.tabMateriales.Controls.Add(this.txtTitulo);
            this.tabMateriales.Controls.Add(this.lblAutor);
            this.tabMateriales.Controls.Add(this.txtAutor);
            this.tabMateriales.Controls.Add(this.lblAnio);
            this.tabMateriales.Controls.Add(this.numAnio);
            this.tabMateriales.Controls.Add(this.grpLibro);
            this.tabMateriales.Controls.Add(this.grpRevista);
            this.tabMateriales.Controls.Add(this.btnAgregarMaterial);
            this.tabMateriales.Controls.Add(this.btnEditarMaterial);
            this.tabMateriales.Controls.Add(this.btnEliminarMaterial);
            this.tabMateriales.Controls.Add(this.dgvMateriales);
            this.tabMateriales.Location = new System.Drawing.Point(4, 25);
            this.tabMateriales.Name     = "tabMateriales";
            this.tabMateriales.Size     = new System.Drawing.Size(972, 495);
            this.tabMateriales.TabIndex = 1;
            this.tabMateriales.Text     = "  Materiales  ";
            this.tabMateriales.UseVisualStyleBackColor = true;

            this.lblTituloMat.AutoSize = true;
            this.lblTituloMat.Font     = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloMat.Location = new System.Drawing.Point(20, 18);
            this.lblTituloMat.Name     = "lblTituloMat";
            this.lblTituloMat.Text     = "Gestión de Materiales Bibliográficos";

            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 60);
            this.lblTipo.Name     = "lblTipo";
            this.lblTipo.Text     = "Tipo:";

            this.cmbTipoMaterial.Location      = new System.Drawing.Point(20, 78);
            this.cmbTipoMaterial.Name          = "cmbTipoMaterial";
            this.cmbTipoMaterial.Size          = new System.Drawing.Size(120, 24);
            this.cmbTipoMaterial.TabIndex      = 0;
            this.cmbTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(160, 60);
            this.lblTitulo.Name     = "lblTitulo";
            this.lblTitulo.Text     = "Título:";

            this.txtTitulo.Location = new System.Drawing.Point(160, 78);
            this.txtTitulo.Name     = "txtTitulo";
            this.txtTitulo.Size     = new System.Drawing.Size(260, 22);
            this.txtTitulo.TabIndex = 1;

            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(440, 60);
            this.lblAutor.Name     = "lblAutor";
            this.lblAutor.Text     = "Autor:";

            this.txtAutor.Location = new System.Drawing.Point(440, 78);
            this.txtAutor.Name     = "txtAutor";
            this.txtAutor.Size     = new System.Drawing.Size(220, 22);
            this.txtAutor.TabIndex = 2;

            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(680, 60);
            this.lblAnio.Name     = "lblAnio";
            this.lblAnio.Text     = "Año:";

            this.numAnio.Location = new System.Drawing.Point(680, 78);
            this.numAnio.Maximum  = 2100;
            this.numAnio.Minimum  = 1800;
            this.numAnio.Name     = "numAnio";
            this.numAnio.Size     = new System.Drawing.Size(90, 22);
            this.numAnio.TabIndex = 3;
            this.numAnio.Value    = 2024;

            // grpLibro
            this.grpLibro.Controls.Add(this.lblPaginas);
            this.grpLibro.Controls.Add(this.numPaginas);
            this.grpLibro.Controls.Add(this.lblISBN);
            this.grpLibro.Controls.Add(this.txtISBN);
            this.grpLibro.Location = new System.Drawing.Point(20, 115);
            this.grpLibro.Name     = "grpLibro";
            this.grpLibro.Size     = new System.Drawing.Size(340, 70);
            this.grpLibro.TabIndex = 10;
            this.grpLibro.Text     = "Datos del Libro";

            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(10, 22);
            this.lblPaginas.Text     = "Páginas:";
            this.numPaginas.Location = new System.Drawing.Point(10, 40);
            this.numPaginas.Maximum  = 9999;
            this.numPaginas.Minimum  = 1;
            this.numPaginas.Name     = "numPaginas";
            this.numPaginas.Size     = new System.Drawing.Size(80, 22);
            this.numPaginas.Value    = 100;

            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(110, 22);
            this.lblISBN.Text     = "ISBN:";
            this.txtISBN.Location = new System.Drawing.Point(110, 40);
            this.txtISBN.Name     = "txtISBN";
            this.txtISBN.Size     = new System.Drawing.Size(200, 22);

            // grpRevista
            this.grpRevista.Controls.Add(this.lblEdicion);
            this.grpRevista.Controls.Add(this.numEdicion);
            this.grpRevista.Controls.Add(this.lblMes);
            this.grpRevista.Controls.Add(this.txtMes);
            this.grpRevista.Location = new System.Drawing.Point(20, 115);
            this.grpRevista.Name     = "grpRevista";
            this.grpRevista.Size     = new System.Drawing.Size(340, 70);
            this.grpRevista.TabIndex = 11;
            this.grpRevista.Text     = "Datos de la Revista";
            this.grpRevista.Visible  = false;

            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(10, 22);
            this.lblEdicion.Text     = "Edición N°:";
            this.numEdicion.Location = new System.Drawing.Point(10, 40);
            this.numEdicion.Maximum  = 9999;
            this.numEdicion.Minimum  = 1;
            this.numEdicion.Name     = "numEdicion";
            this.numEdicion.Size     = new System.Drawing.Size(80, 22);
            this.numEdicion.Value    = 1;

            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(110, 22);
            this.lblMes.Text     = "Mes de publicación:";
            this.txtMes.Location = new System.Drawing.Point(110, 40);
            this.txtMes.Name     = "txtMes";
            this.txtMes.Size     = new System.Drawing.Size(200, 22);

            this.btnAgregarMaterial.Location = new System.Drawing.Point(20, 200);
            this.btnAgregarMaterial.Name     = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size     = new System.Drawing.Size(110, 34);
            this.btnAgregarMaterial.TabIndex = 12;
            this.btnAgregarMaterial.Text     = "Agregar";

            this.btnEditarMaterial.Location = new System.Drawing.Point(145, 200);
            this.btnEditarMaterial.Name     = "btnEditarMaterial";
            this.btnEditarMaterial.Size     = new System.Drawing.Size(110, 34);
            this.btnEditarMaterial.TabIndex = 13;
            this.btnEditarMaterial.Text     = "Editar";

            this.btnEliminarMaterial.Location = new System.Drawing.Point(270, 200);
            this.btnEliminarMaterial.Name     = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size     = new System.Drawing.Size(110, 34);
            this.btnEliminarMaterial.TabIndex = 14;
            this.btnEliminarMaterial.Text     = "Eliminar";

            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colMId, this.colMTipo, this.colMTitulo, this.colMAutor, this.colMAnio, this.colMEstado });
            this.dgvMateriales.Location      = new System.Drawing.Point(20, 250);
            this.dgvMateriales.Name          = "dgvMateriales";
            this.dgvMateriales.RowTemplate.Height = 24;
            this.dgvMateriales.Size          = new System.Drawing.Size(930, 220);
            this.dgvMateriales.TabIndex      = 15;

            this.colMId.HeaderText     = "ID";        this.colMId.Name     = "colMId";     this.colMId.Width     = 50;
            this.colMTipo.HeaderText   = "Tipo";      this.colMTipo.Name   = "colMTipo";   this.colMTipo.Width   = 90;
            this.colMTitulo.HeaderText = "Título";    this.colMTitulo.Name = "colMTitulo"; this.colMTitulo.Width = 260;
            this.colMAutor.HeaderText  = "Autor";     this.colMAutor.Name  = "colMAutor";  this.colMAutor.Width  = 200;
            this.colMAnio.HeaderText   = "Año";       this.colMAnio.Name   = "colMAnio";   this.colMAnio.Width   = 60;
            this.colMEstado.HeaderText = "Estado";    this.colMEstado.Name = "colMEstado"; this.colMEstado.Width = 160;

            // ===========================================================
            // TAB PRESTAMOS
            // ===========================================================
            this.tabPrestamos.Controls.Add(this.lblTituloPrest);
            this.tabPrestamos.Controls.Add(this.lblMaterial);
            this.tabPrestamos.Controls.Add(this.cmbMaterial);
            this.tabPrestamos.Controls.Add(this.lblUser);
            this.tabPrestamos.Controls.Add(this.cmbUsuario);
            this.tabPrestamos.Controls.Add(this.btnPrestar);
            this.tabPrestamos.Controls.Add(this.btnDevolver);
            this.tabPrestamos.Controls.Add(this.dgvPrestamos);
            this.tabPrestamos.Location = new System.Drawing.Point(4, 25);
            this.tabPrestamos.Name     = "tabPrestamos";
            this.tabPrestamos.Size     = new System.Drawing.Size(972, 495);
            this.tabPrestamos.TabIndex = 2;
            this.tabPrestamos.Text     = "  Prestamos  ";
            this.tabPrestamos.UseVisualStyleBackColor = true;

            this.lblTituloPrest.AutoSize = true;
            this.lblTituloPrest.Font     = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloPrest.Location = new System.Drawing.Point(20, 18);
            this.lblTituloPrest.Name     = "lblTituloPrest";
            this.lblTituloPrest.Text     = "Control de Préstamos";

            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(20, 62);
            this.lblMaterial.Name     = "lblMaterial";
            this.lblMaterial.Text     = "Material:";

            this.cmbMaterial.Location = new System.Drawing.Point(20, 82);
            this.cmbMaterial.Name     = "cmbMaterial";
            this.cmbMaterial.Size     = new System.Drawing.Size(300, 24);
            this.cmbMaterial.TabIndex = 0;

            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(340, 62);
            this.lblUser.Name     = "lblUser";
            this.lblUser.Text     = "Usuario:";

            this.cmbUsuario.Location = new System.Drawing.Point(340, 82);
            this.cmbUsuario.Name     = "cmbUsuario";
            this.cmbUsuario.Size     = new System.Drawing.Size(260, 24);
            this.cmbUsuario.TabIndex = 1;

            this.btnPrestar.Location = new System.Drawing.Point(620, 75);
            this.btnPrestar.Name     = "btnPrestar";
            this.btnPrestar.Size     = new System.Drawing.Size(130, 36);
            this.btnPrestar.TabIndex = 2;
            this.btnPrestar.Text     = "Registrar Préstamo";

            this.btnDevolver.Location = new System.Drawing.Point(765, 75);
            this.btnDevolver.Name     = "btnDevolver";
            this.btnDevolver.Size     = new System.Drawing.Size(130, 36);
            this.btnDevolver.TabIndex = 3;
            this.btnDevolver.Text     = "Registrar Devolución";

            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colPId, this.colPMaterial, this.colPUsuario, this.colPFechaPr, this.colPFechaDev });
            this.dgvPrestamos.Location      = new System.Drawing.Point(20, 135);
            this.dgvPrestamos.Name          = "dgvPrestamos";
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size          = new System.Drawing.Size(930, 335);
            this.dgvPrestamos.TabIndex      = 4;

            this.colPId.HeaderText       = "ID";              this.colPId.Name       = "colPId";       this.colPId.Width       = 50;
            this.colPMaterial.HeaderText = "Material";        this.colPMaterial.Name = "colPMaterial"; this.colPMaterial.Width = 280;
            this.colPUsuario.HeaderText  = "Usuario";         this.colPUsuario.Name  = "colPUsuario";  this.colPUsuario.Width  = 200;
            this.colPFechaPr.HeaderText  = "Fecha Préstamo";  this.colPFechaPr.Name  = "colPFechaPr";  this.colPFechaPr.Width  = 130;
            this.colPFechaDev.HeaderText = "Fecha Devolución";this.colPFechaDev.Name = "colPFechaDev"; this.colPFechaDev.Width = 130;

            // ===========================================================
            // TAB ESTADISTICAS
            // ===========================================================
            this.tabEstadisticas.Controls.Add(this.lblTituloEst);
            this.tabEstadisticas.Controls.Add(this.chartTopLibros);
            this.tabEstadisticas.Controls.Add(this.chartTopUsuarios);
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 25);
            this.tabEstadisticas.Name     = "tabEstadisticas";
            this.tabEstadisticas.Size     = new System.Drawing.Size(972, 495);
            this.tabEstadisticas.TabIndex = 3;
            this.tabEstadisticas.Text     = "  Estadísticas  ";
            this.tabEstadisticas.UseVisualStyleBackColor = true;

            this.lblTituloEst.AutoSize = true;
            this.lblTituloEst.Font     = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloEst.Location = new System.Drawing.Point(20, 14);
            this.lblTituloEst.Name     = "lblTituloEst";
            this.lblTituloEst.Text     = "Estadísticas de la Biblioteca";

            // chartTopLibros
            chartArea1.Name = "ChartArea1";
            this.chartTopLibros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTopLibros.Legends.Add(legend1);
            series1.ChartArea = "ChartArea1"; series1.Legend = "Legend1"; series1.Name = "Series1";
            this.chartTopLibros.Series.Add(series1);
            this.chartTopLibros.Location = new System.Drawing.Point(20, 55);
            this.chartTopLibros.Name     = "chartTopLibros";
            this.chartTopLibros.Size     = new System.Drawing.Size(460, 400);
            this.chartTopLibros.TabIndex = 0;

            // chartTopUsuarios
            chartArea2.Name = "ChartArea1";
            this.chartTopUsuarios.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopUsuarios.Legends.Add(legend2);
            series2.ChartArea = "ChartArea1"; series2.Legend = "Legend1"; series2.Name = "Series1";
            this.chartTopUsuarios.Series.Add(series2);
            this.chartTopUsuarios.Location = new System.Drawing.Point(500, 55);
            this.chartTopUsuarios.Name     = "chartTopUsuarios";
            this.chartTopUsuarios.Size     = new System.Drawing.Size(450, 400);
            this.chartTopUsuarios.TabIndex = 1;

            // ===========================================================
            // FORM
            // ===========================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.tabMain);
            this.MinimumSize         = new System.Drawing.Size(996, 618);
            this.Name                = "Form1";
            this.Text                = "Sistema de Gestión de Biblioteca - UDB";

            // ResumeLayouts
            this.tabMain.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabMateriales.ResumeLayout(false);
            this.tabMateriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            this.grpLibro.ResumeLayout(false);
            this.grpLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).EndInit();
            this.grpRevista.ResumeLayout(false);
            this.grpRevista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.tabPrestamos.ResumeLayout(false);
            this.tabPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.tabEstadisticas.ResumeLayout(false);
            this.tabEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopUsuarios)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Controles
        private System.Windows.Forms.TabControl tabMain;
        // Tab Usuarios
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Label lblTituloUsuarios;
        private System.Windows.Forms.Label lblNombreU, lblCarnetU;
        private System.Windows.Forms.TextBox txtNombreUsuario, txtCarnetUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario, btnEditarUsuario, btnEliminarUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUId, colUNombre, colUCarnet;
        // Tab Materiales
        private System.Windows.Forms.TabPage tabMateriales;
        private System.Windows.Forms.Label lblTituloMat, lblTipo, lblTitulo, lblAutor, lblAnio;
        private System.Windows.Forms.ComboBox cmbTipoMaterial;
        private System.Windows.Forms.TextBox txtTitulo, txtAutor;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.GroupBox grpLibro, grpRevista;
        private System.Windows.Forms.Label lblPaginas, lblISBN, lblEdicion, lblMes;
        private System.Windows.Forms.NumericUpDown numPaginas, numEdicion;
        private System.Windows.Forms.TextBox txtISBN, txtMes;
        private System.Windows.Forms.Button btnAgregarMaterial, btnEditarMaterial, btnEliminarMaterial;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMId, colMTipo, colMTitulo, colMAutor, colMAnio, colMEstado;
        // Tab Prestamos
        private System.Windows.Forms.TabPage tabPrestamos;
        private System.Windows.Forms.Label lblTituloPrest, lblMaterial, lblUser;
        private System.Windows.Forms.ComboBox cmbMaterial, cmbUsuario;
        private System.Windows.Forms.Button btnPrestar, btnDevolver;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPId, colPMaterial, colPUsuario, colPFechaPr, colPFechaDev;
        // Tab Estadisticas
        private System.Windows.Forms.TabPage tabEstadisticas;
        private System.Windows.Forms.Label lblTituloEst;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopLibros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopUsuarios;
    }
}
