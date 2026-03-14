// Autor: Maria Torres
// Desafio 1 - Desarrollo de Aplicaciones con Software Propietario
// Universidad Don Bosco

using Desafio1_DAS.Domain;
using Desafio1_DAS.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Desafio1_DAS
{
    public partial class Form1 : Form
    {
        // Instancia unica del servicio de biblioteca
        private readonly BibliotecaService _svc = new BibliotecaService();

        // =====================================================================
        // Paleta de colores - Tema Azul
        // =====================================================================
        private readonly Color ColorPrimario  = Color.FromArgb(25, 84, 153);   // azul oscuro
        private readonly Color ColorAcento    = Color.FromArgb(66, 133, 244);  // azul medio
        private readonly Color ColorBg        = Color.White;
        private readonly Color ColorBgAlt     = Color.FromArgb(240, 245, 255); // azul muy claro
        private readonly Color ColorTexto     = Color.FromArgb(30, 30, 30);
        private readonly Color ColorGrid      = Color.FromArgb(200, 215, 235);

        public Form1()
        {
            InitializeComponent();

            AgregarEncabezado();
            ConfigurarGrillas();
            ConfigurarCombos();
            AplicarTema();
            PintarGraficas();
            ActualizarVisibilidadGrupos();

            // Datos de ejemplo
            CargarDatosSemilla();

            // Cargar toda la interfaz
            RefrescarTodo();

            // Eventos UI
            cmbTipoMaterial.SelectedIndexChanged += cmbTipoMaterial_SelectedIndexChanged;
            dgvUsuarios.SelectionChanged         += dgvUsuarios_SelectionChanged;
            dgvMateriales.SelectionChanged       += dgvMateriales_SelectionChanged;

            btnAgregarUsuario.Click  += btnAgregarUsuario_Click;
            btnEditarUsuario.Click   += btnEditarUsuario_Click;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;

            btnAgregarMaterial.Click  += btnAgregarMaterial_Click;
            btnEditarMaterial.Click   += btnEditarMaterial_Click;
            btnEliminarMaterial.Click += btnEliminarMaterial_Click;

            btnPrestar.Click  += btnPrestar_Click;
            btnDevolver.Click += btnDevolver_Click;
        }

        // =====================================================================
        // ENCABEZADO
        // =====================================================================
        private void AgregarEncabezado()
        {
            var panel = new Panel
            {
                Name      = "pnlHeader",
                Dock      = DockStyle.Top,
                Height    = 56,
                BackColor = ColorPrimario
            };

            var titulo = new Label
            {
                AutoSize  = true,
                Text      = "Sistema de Gestión de Biblioteca",
                ForeColor = Color.White,
                Font      = new Font("Segoe UI", 15, FontStyle.Bold),
                Location  = new Point(16, 13)
            };

            panel.Controls.Add(titulo);
            this.Controls.Add(panel);
            this.Controls.SetChildIndex(panel, 0);
        }

        // =====================================================================
        // CONFIGURACION DE CONTROLES
        // =====================================================================
        private void ConfigurarGrillas()
        {
            foreach (var g in new[] { dgvUsuarios, dgvMateriales, dgvPrestamos })
            {
                g.AutoGenerateColumns    = false;
                g.AllowUserToAddRows     = false;
                g.AllowUserToDeleteRows  = false;
                g.ReadOnly               = true;
                g.RowHeadersVisible      = false;
                g.SelectionMode          = DataGridViewSelectionMode.FullRowSelect;
                g.MultiSelect            = false;
            }
        }

        private void ConfigurarCombos()
        {
            cmbTipoMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMaterial.Items.Clear();
            cmbTipoMaterial.Items.AddRange(new object[] { "Libro", "Revista" });
            cmbTipoMaterial.SelectedIndex = 0;
            cmbTipoMaterial.AutoCompleteMode   = AutoCompleteMode.None;
            cmbTipoMaterial.AutoCompleteSource = AutoCompleteSource.None;

            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.DropDownStyle  = ComboBoxStyle.DropDownList;
            cmbMaterial.AutoCompleteMode   = AutoCompleteMode.None;
            cmbMaterial.AutoCompleteSource = AutoCompleteSource.None;
            cmbUsuario.AutoCompleteMode    = AutoCompleteMode.None;
            cmbUsuario.AutoCompleteSource  = AutoCompleteSource.None;
            cmbMaterial.DisplayMember = "Titulo";
            cmbUsuario.DisplayMember  = "Nombre";
        }

        // =====================================================================
        // DATOS DE EJEMPLO
        // =====================================================================
        private void CargarDatosSemilla()
        {
            var u1 = _svc.AgregarUsuario(new UsuarioBiblioteca("Ana Martinez", "UDB-2024-001"));
            var u2 = _svc.AgregarUsuario(new UsuarioBiblioteca("Carlos Rivera", "UDB-2024-002"));
            var u3 = _svc.AgregarUsuario(new UsuarioBiblioteca("Sofia Lopez", "UDB-2024-003"));

            _svc.AgregarMaterial(new Libro("El Principito", "Antoine de Saint-Exupery", 1943, 96, "978-0156012195"));
            _svc.AgregarMaterial(new Libro("Clean Code", "Robert C. Martin", 2008, 431, "978-0132350884"));
            _svc.AgregarMaterial(new Libro("Introduction to Algorithms", "Thomas H. Cormen", 2009, 1292, "978-0262033848"));
            _svc.AgregarMaterial(new Revista("National Geographic", "Varios Autores", 2024, 312, "Enero"));
            _svc.AgregarMaterial(new Revista("Scientific American", "Varios Autores", 2024, 89, "Febrero"));

            // Prestamos de ejemplo
            var mats = _svc.ObtenerMateriales().ToList();
            _svc.Prestar(mats[0].Id, u1.Id, DateTime.Today.AddDays(-5));
            _svc.Prestar(mats[1].Id, u2.Id, DateTime.Today.AddDays(-3));
            _svc.Prestar(mats[3].Id, u3.Id, DateTime.Today.AddDays(-1));
        }

        // =====================================================================
        // REFRESCO DE PANTALLA
        // =====================================================================
        private void RefrescarTodo()
        {
            // Usuarios
            dgvUsuarios.Rows.Clear();
            foreach (var u in _svc.ObtenerUsuarios())
                dgvUsuarios.Rows.Add(u.Id, u.Nombre, u.Carnet);

            // Materiales
            dgvMateriales.Rows.Clear();
            cmbMaterial.Items.Clear();
            cmbUsuario.Items.Clear();

            foreach (var m in _svc.ObtenerMateriales())
            {
                dgvMateriales.Rows.Add(m.Id, m.GetType().Name, m.Titulo, m.Autor, m.Anio, m.ObtenerEstado());
                cmbMaterial.Items.Add(m);
            }
            foreach (var u in _svc.ObtenerUsuarios())
                cmbUsuario.Items.Add(u);

            // Prestamos
            dgvPrestamos.Rows.Clear();
            foreach (var p in _svc.ObtenerPrestamos())
            {
                var mat = _svc.ObtenerMaterialPorId(p.MaterialId);
                var usu = _svc.ObtenerUsuarioPorId(p.UsuarioId);
                dgvPrestamos.Rows.Add(
                    p.Id,
                    mat?.Titulo,
                    usu?.Nombre,
                    p.FechaPrestamo.ToShortDateString(),
                    p.FechaDevolucion.HasValue ? p.FechaDevolucion.Value.ToShortDateString() : "Activo"
                );
            }

            PintarGraficas();
            LimpiarInputsUsuario();
            LimpiarInputsMaterial();
        }

        // =====================================================================
        // TEMA VISUAL - AZUL
        // =====================================================================
        private void AplicarTema()
        {
            this.BackColor = ColorBg;
            foreach (TabPage tp in tabMain.TabPages)
                tp.BackColor = ColorBg;

            foreach (Control c in this.Controls)
                AplicarTemaRecursivo(c);

            EstilizarGrilla(dgvUsuarios);
            EstilizarGrilla(dgvMateriales);
            EstilizarGrilla(dgvPrestamos);

            EstilizarBoton(btnAgregarUsuario);
            EstilizarBoton(btnEditarUsuario);
            EstilizarBoton(btnEliminarUsuario);
            EstilizarBoton(btnAgregarMaterial);
            EstilizarBoton(btnEditarMaterial);
            EstilizarBoton(btnEliminarMaterial);
            EstilizarBoton(btnPrestar);
            EstilizarBoton(btnDevolver);

            if (chartTopLibros   != null) EstilizarAreaGrafica(chartTopLibros);
            if (chartTopUsuarios != null) EstilizarAreaGrafica(chartTopUsuarios);

            ConfigurarColorTabs();
        }

        private void AplicarTemaRecursivo(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = ColorPrimario;
                    c.BackColor = Color.Transparent;
                }
                else if (c is GroupBox gb)
                {
                    gb.ForeColor = ColorPrimario;
                    gb.BackColor = ColorBgAlt;
                }
                else if (c is TextBox tb)
                {
                    tb.BackColor    = Color.White;
                    tb.ForeColor    = ColorTexto;
                    tb.BorderStyle  = BorderStyle.FixedSingle;
                }
                else if (c is NumericUpDown nud)
                {
                    nud.BackColor = Color.White;
                    nud.ForeColor = ColorTexto;
                }
                else if (c is ComboBox cb)
                {
                    cb.FlatStyle  = FlatStyle.Popup;
                    cb.BackColor  = Color.White;
                    cb.ForeColor  = ColorTexto;
                }
                if (c.HasChildren) AplicarTemaRecursivo(c);
            }
        }

        private void EstilizarBoton(Button b)
        {
            if (b == null) return;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize  = 1;
            b.FlatAppearance.BorderColor = ColorPrimario;
            b.BackColor = ColorAcento;
            b.ForeColor = Color.White;
            b.UseVisualStyleBackColor = false;
        }

        private void EstilizarGrilla(DataGridView g)
        {
            if (g == null) return;
            g.BackgroundColor = ColorBg;
            g.BorderStyle     = BorderStyle.None;
            g.EnableHeadersVisualStyles = false;

            g.ColumnHeadersDefaultCellStyle.BackColor          = ColorPrimario;
            g.ColumnHeadersDefaultCellStyle.ForeColor          = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorPrimario;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            g.DefaultCellStyle.BackColor          = Color.White;
            g.DefaultCellStyle.ForeColor          = ColorTexto;
            g.DefaultCellStyle.SelectionBackColor = ColorAcento;
            g.DefaultCellStyle.SelectionForeColor = Color.White;

            g.AlternatingRowsDefaultCellStyle.BackColor = ColorBgAlt;
            g.GridColor = ColorGrid;
        }

        private void ConfigurarColorTabs()
        {
            tabMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabMain.DrawItem += (s, e) =>
            {
                var g        = e.Graphics;
                var tab      = tabMain.TabPages[e.Index];
                var selected = (e.Index == tabMain.SelectedIndex);
                var rect     = e.Bounds;

                using (var bg = new SolidBrush(selected ? ColorPrimario : ColorAcento))
                    g.FillRectangle(bg, rect);

                TextRenderer.DrawText(
                    g, tab.Text, new Font("Segoe UI", 9, FontStyle.Bold),
                    rect, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

        // =====================================================================
        // GRAFICAS ESTADISTICAS
        // =====================================================================
        private void EstilizarAreaGrafica(Chart chart)
        {
            var area = chart.ChartAreas[0];
            chart.BackColor          = ColorBg;
            area.BackColor           = ColorBg;
            area.AxisX.MajorGrid.Enabled    = false;
            area.AxisY.MajorGrid.LineColor  = ColorGrid;
            area.AxisX.LabelStyle.ForeColor = ColorTexto;
            area.AxisY.LabelStyle.ForeColor = ColorTexto;
        }

        private void PintarGraficas()
        {
            // Grafica 1: Materiales mas prestados
            var datosMat = _svc.TopMaterialesPrestados(5).ToList();
            chartTopLibros.Series.Clear();
            if (chartTopLibros.Legends.Count > 0) chartTopLibros.Legends.Clear();
            PintarTituloGrafica(chartTopLibros, "Materiales más prestados", ColorPrimario);

            var s1 = new Series { ChartType = SeriesChartType.Bar, IsValueShownAsLabel = true };
            foreach (var d in datosMat) s1.Points.AddXY(d.Titulo, d.Veces);
            chartTopLibros.Series.Add(s1);

            var maxMat = datosMat.Any() ? datosMat.Max(d => d.Veces) : 1;
            EstilizarBarras(chartTopLibros, ColorAcento, maxMat);

            // Grafica 2: Usuarios mas activos
            var datosUsr = _svc.UsuariosMasActivos(5).ToList();
            chartTopUsuarios.Series.Clear();
            if (chartTopUsuarios.Legends.Count > 0) chartTopUsuarios.Legends.Clear();
            PintarTituloGrafica(chartTopUsuarios, "Usuarios más activos", ColorPrimario);

            var s2 = new Series { ChartType = SeriesChartType.Bar, IsValueShownAsLabel = true };
            foreach (var d in datosUsr) s2.Points.AddXY(d.Usuario, d.Veces);
            chartTopUsuarios.Series.Add(s2);

            var maxUsr = datosUsr.Any() ? datosUsr.Max(d => d.Veces) : 1;
            EstilizarBarras(chartTopUsuarios, ColorAcento, maxUsr);
        }

        private void EstilizarBarras(Chart chart, Color color, int maxValor)
        {
            var area  = chart.ChartAreas[0];
            var serie = chart.Series[0];

            serie.Color       = color;
            serie.BorderColor = color;
            serie.BorderWidth = 1;
            serie["PointWidth"] = "0.35";

            area.AxisX.Minimum = 0;
            var maxEje = maxValor + 1;
            if (maxEje < 3) maxEje = 3;
            area.AxisX.Maximum             = maxEje;
            area.AxisX.Interval            = 1;
            area.AxisX.LabelStyle.Format   = "0";
            area.AxisX.MajorGrid.Interval  = 1;
            area.AxisX.MajorGrid.LineColor = ColorGrid;
            area.AxisY.Interval            = 1;
            area.AxisY.MajorGrid.Enabled   = false;
            area.RecalculateAxesScale();
        }

        private void PintarTituloGrafica(Chart chart, string texto, Color color)
        {
            chart.Titles.Clear();
            chart.Titles.Add(new Title
            {
                Text      = texto,
                Docking   = Docking.Top,
                Font      = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = color,
                Alignment = ContentAlignment.MiddleLeft
            });
        }

        // =====================================================================
        // HELPERS DE UI
        // =====================================================================
        private void ActualizarVisibilidadGrupos()
        {
            var tipo = cmbTipoMaterial.SelectedItem?.ToString() ?? "Libro";
            grpLibro.Visible   = (tipo == "Libro");
            grpRevista.Visible = (tipo == "Revista");
        }

        private void LimpiarInputsUsuario()
        {
            txtNombreUsuario.Text = "";
            txtCarnetUsuario.Text = "";
        }

        private void LimpiarInputsMaterial()
        {
            txtTitulo.Text  = "";
            txtAutor.Text   = "";
            numAnio.Value   = 2024;
            numPaginas.Value = 100;
            txtISBN.Text    = "";
            numEdicion.Value = 1;
            txtMes.Text     = "";
            cmbTipoMaterial.SelectedIndex = 0;
            ActualizarVisibilidadGrupos();
        }

        private void CargarUsuarioEnInputs()
        {
            if (dgvUsuarios.CurrentRow == null) return;
            txtNombreUsuario.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[1].Value);
            txtCarnetUsuario.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[2].Value);
        }

        private void CargarMaterialEnInputs()
        {
            if (dgvMateriales.CurrentRow == null) return;
            var idObj = dgvMateriales.CurrentRow.Cells[0].Value;
            if (idObj == null) return;

            int id = Convert.ToInt32(idObj);
            var m  = _svc.ObtenerMaterialPorId(id);
            if (m == null) return;

            txtTitulo.Text = m.Titulo;
            txtAutor.Text  = m.Autor;
            numAnio.Value  = m.Anio;

            if (m is Libro lib)
            {
                cmbTipoMaterial.SelectedItem = "Libro";
                numPaginas.Value = lib.Paginas;
                txtISBN.Text     = lib.ISBN;
            }
            else if (m is Revista rev)
            {
                cmbTipoMaterial.SelectedItem = "Revista";
                numEdicion.Value = rev.NumeroEdicion;
                txtMes.Text      = rev.MesPublicacion;
            }
        }

        private MaterialBiblioteca ConstruirMaterialDesdeInputs()
        {
            var tipo   = cmbTipoMaterial.SelectedItem?.ToString() ?? "Libro";
            var titulo = txtTitulo.Text.Trim();
            var autor  = txtAutor.Text.Trim();
            var anio   = (int)numAnio.Value;

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
                throw new Exception("Complete Titulo y Autor.");

            if (tipo == "Libro")
                return new Libro(titulo, autor, anio, (int)numPaginas.Value, txtISBN.Text.Trim());

            if (tipo == "Revista")
                return new Revista(titulo, autor, anio, (int)numEdicion.Value, txtMes.Text.Trim());

            throw new Exception("Tipo de material no reconocido.");
        }

        // =====================================================================
        // EVENTOS — USUARIOS
        // =====================================================================
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
            => CargarUsuarioEnInputs();

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var nombre = txtNombreUsuario.Text.Trim();
            var carnet = txtCarnetUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(carnet))
            { MessageBox.Show("Complete Nombre y Carnet.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // Validar duplicados de carnet
            if (_svc.ObtenerUsuarios().Any(u => u.Carnet.Equals(carnet, StringComparison.OrdinalIgnoreCase)))
            { MessageBox.Show("Ya existe un usuario con ese carnet.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            _svc.AgregarUsuario(new UsuarioBiblioteca(nombre, carnet));
            RefrescarTodo();
            MessageBox.Show("Usuario agregado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            { MessageBox.Show("Seleccione un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
            var u  = _svc.ObtenerUsuarioPorId(id);
            if (u == null) return;

            var nombre = txtNombreUsuario.Text.Trim();
            var carnet = txtCarnetUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(carnet))
            { MessageBox.Show("Complete Nombre y Carnet.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            u.Nombre = nombre;
            u.Carnet = carnet;
            _svc.ActualizarUsuario(u);
            RefrescarTodo();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            { MessageBox.Show("Seleccione un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);

            // Validar prestamos activos
            if (_svc.ContarPrestamosPorUsuario(id) > 0)
            { MessageBox.Show("No puede eliminar un usuario con prestamos activos.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var confirm = MessageBox.Show("¿Eliminar usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _svc.EliminarUsuario(id);
                RefrescarTodo();
            }
        }

        // =====================================================================
        // EVENTOS — MATERIALES
        // =====================================================================
        private void cmbTipoMaterial_SelectedIndexChanged(object sender, EventArgs e)
            => ActualizarVisibilidadGrupos();

        private void dgvMateriales_SelectionChanged(object sender, EventArgs e)
            => CargarMaterialEnInputs();

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevo = ConstruirMaterialDesdeInputs();
                _svc.AgregarMaterial(nuevo);
                RefrescarTodo();
                MessageBox.Show("Material agregado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEditarMaterial_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.CurrentRow == null)
            { MessageBox.Show("Seleccione un material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int id     = Convert.ToInt32(dgvMateriales.CurrentRow.Cells[0].Value);
            var actual = _svc.ObtenerMaterialPorId(id);
            if (actual == null) return;

            try
            {
                var mod = ConstruirMaterialDesdeInputs();
                mod.Id = actual.Id;
                if (actual.Prestado) mod.AsignarPrestamo(actual.UsuarioPrestamo);
                _svc.ActualizarMaterial(mod);
                RefrescarTodo();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.CurrentRow == null)
            { MessageBox.Show("Seleccione un material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int id  = Convert.ToInt32(dgvMateriales.CurrentRow.Cells[0].Value);
            var mat = _svc.ObtenerMaterialPorId(id);

            if (mat != null && mat.Prestado)
            { MessageBox.Show("No puede eliminar un material prestado.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var confirm = MessageBox.Show("¿Eliminar material?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _svc.EliminarMaterial(id);
                RefrescarTodo();
            }
        }

        // =====================================================================
        // EVENTOS — PRESTAMOS
        // =====================================================================
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            var m = cmbMaterial.SelectedItem as MaterialBiblioteca;
            var u = cmbUsuario.SelectedItem as UsuarioBiblioteca;

            if (m == null || u == null)
            { MessageBox.Show("Seleccione material y usuario.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                _svc.Prestar(m.Id, u.Id, DateTime.Today);
                RefrescarTodo();
                MessageBox.Show("Prestamo registrado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            var m = cmbMaterial.SelectedItem as MaterialBiblioteca;

            if (m == null)
            { MessageBox.Show("Seleccione un material.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!m.Prestado)
            { MessageBox.Show("Este material no esta prestado actualmente.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            _svc.Devolver(m.Id, DateTime.Today);
            RefrescarTodo();
            MessageBox.Show("Material devuelto correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
