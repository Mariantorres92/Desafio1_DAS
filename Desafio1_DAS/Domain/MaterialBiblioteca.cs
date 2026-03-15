// Autor: Mariana Torres
// Autor: Mariana Torres
// Desafio 1 - Desarrollo de Aplicaciones con Software Propietario
// Universidad Don Bosco

using System;

namespace Desafio1_DAS.Domain
{
    // Clase base abstracta: define atributos y comportamiento comun de todos los materiales
    public abstract class MaterialBiblioteca
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }

        // Encapsulacion: solo se modifican mediante metodos
        public bool Prestado { get; private set; }
        public UsuarioBiblioteca UsuarioPrestamo { get; private set; }

        protected MaterialBiblioteca(string titulo, string autor, int anio)
        {
            Titulo = titulo?.Trim();
            Autor = autor?.Trim();
            Anio = anio;
            Prestado = false;
        }

        // Asigna un prestamo al material
        public void AsignarPrestamo(UsuarioBiblioteca usuario)
        {
            Prestado = true;
            UsuarioPrestamo = usuario;
        }

        // Devuelve el material
        public void Devolver()
        {
            Prestado = false;
            UsuarioPrestamo = null;
        }

        // Polimorfismo: cada clase derivada sobrescribe este metodo
        public virtual string ObtenerDescripcion()
            => $"{Titulo} - {Autor} ({Anio})";

        public string ObtenerEstado()
            => Prestado ? $"Prestado a {UsuarioPrestamo?.Nombre}" : "Disponible";
    }
}
