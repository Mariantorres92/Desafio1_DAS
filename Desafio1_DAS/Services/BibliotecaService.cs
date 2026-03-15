// Autor: Mariana Torres
// Desafio 1 - Desarrollo de Aplicaciones con Software Propietario
// Universidad Don Bosco

using System;
using System.Collections.Generic;
using System.Linq;
using Desafio1_DAS.Domain;

namespace Desafio1_DAS.Services
{
    // Servicio principal: maneja toda la logica de negocio de la biblioteca
    public class BibliotecaService
    {
        // Contadores para IDs autoincrementales
        private int _seqMat = 0, _seqUser = 0, _seqPrest = 0;

        // Estructuras de datos: diccionarios para materiales y usuarios, lista para prestamos
        private readonly Dictionary<int, MaterialBiblioteca> _materiales =
            new Dictionary<int, MaterialBiblioteca>();
        private readonly Dictionary<int, UsuarioBiblioteca> _usuarios =
            new Dictionary<int, UsuarioBiblioteca>();
        private readonly List<Prestamo> _prestamos =
            new List<Prestamo>();

        // =====================================================================
        // CRUD Materiales
        // =====================================================================
        public MaterialBiblioteca AgregarMaterial(MaterialBiblioteca m)
        {
            m.Id = ++_seqMat;
            _materiales[m.Id] = m;
            return m;
        }

        public bool ActualizarMaterial(MaterialBiblioteca m)
        {
            if (_materiales.ContainsKey(m.Id))
            {
                _materiales[m.Id] = m;
                return true;
            }
            return false;
        }

        public bool EliminarMaterial(int id) => _materiales.Remove(id);

        public IEnumerable<MaterialBiblioteca> ObtenerMateriales()
            => _materiales.Values.OrderBy(x => x.Titulo);

        // =====================================================================
        // CRUD Usuarios
        // =====================================================================
        public UsuarioBiblioteca AgregarUsuario(UsuarioBiblioteca u)
        {
            u.Id = ++_seqUser;
            _usuarios[u.Id] = u;
            return u;
        }

        public bool ActualizarUsuario(UsuarioBiblioteca u)
        {
            if (_usuarios.ContainsKey(u.Id))
            {
                _usuarios[u.Id] = u;
                return true;
            }
            return false;
        }

        public bool EliminarUsuario(int id) => _usuarios.Remove(id);

        public IEnumerable<UsuarioBiblioteca> ObtenerUsuarios()
            => _usuarios.Values.OrderBy(x => x.Nombre);

        // =====================================================================
        // Prestamos
        // =====================================================================
        public Prestamo Prestar(int materialId, int usuarioId, DateTime fecha)
        {
            var m = _materiales[materialId];
            var u = _usuarios[usuarioId];

            if (m.Prestado)
                throw new InvalidOperationException("El material ya esta prestado.");

            m.AsignarPrestamo(u);
            var p = new Prestamo
            {
                Id = ++_seqPrest,
                MaterialId = m.Id,
                UsuarioId = u.Id,
                FechaPrestamo = fecha
            };
            _prestamos.Add(p);
            return p;
        }

        public void Devolver(int materialId, DateTime fecha)
        {
            var m = _materiales[materialId];
            if (!m.Prestado) return;

            m.Devolver();
            var p = _prestamos.LastOrDefault(x => x.MaterialId == materialId && x.Activo);
            if (p != null) p.FechaDevolucion = fecha;
        }

        public IEnumerable<Prestamo> ObtenerPrestamos(bool soloActivos = false)
            => soloActivos ? _prestamos.Where(p => p.Activo) : _prestamos;

        // =====================================================================
        // Consultas para graficos estadisticos
        // =====================================================================

        // Materiales mas prestados (top N)
        public IEnumerable<(string Titulo, int Veces)> TopMaterialesPrestados(int top = 5)
            => _prestamos
                .GroupBy(p => p.MaterialId)
                .Select(g => (Titulo: _materiales[g.Key].Titulo, Veces: g.Count()))
                .OrderByDescending(x => x.Veces)
                .Take(top);

        // Usuarios mas activos (top N)
        public IEnumerable<(string Usuario, int Veces)> UsuariosMasActivos(int top = 5)
            => _prestamos
                .GroupBy(p => p.UsuarioId)
                .Select(g => (Usuario: _usuarios[g.Key].Nombre, Veces: g.Count()))
                .OrderByDescending(x => x.Veces)
                .Take(top);

        // Materiales disponibles (no prestados)
        public IEnumerable<MaterialBiblioteca> ObtenerDisponibles()
            => _materiales.Values.Where(m => !m.Prestado);

        // Materiales prestados por un usuario especifico
        public IEnumerable<MaterialBiblioteca> PrestadosPorUsuario(int usuarioId)
            => _prestamos
                .Where(p => p.UsuarioId == usuarioId && p.Activo)
                .Select(p => _materiales[p.MaterialId]);

        // Cantidad de prestamos activos de un usuario
        public int ContarPrestamosPorUsuario(int usuarioId)
            => _prestamos.Count(p => p.UsuarioId == usuarioId && p.Activo);

        // Obtener material por id
        public MaterialBiblioteca ObtenerMaterialPorId(int id)
            => _materiales.ContainsKey(id) ? _materiales[id] : null;

        // Obtener usuario por id
        public UsuarioBiblioteca ObtenerUsuarioPorId(int id)
            => _usuarios.ContainsKey(id) ? _usuarios[id] : null;
    }
}
