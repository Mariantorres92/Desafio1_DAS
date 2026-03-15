// Autor: Mariana Torres
// Desafio 1 - Desarrollo de Aplicaciones con Software Propietario
// Universidad Don Bosco

using System;

namespace Desafio1_DAS.Domain
{
    public class UsuarioBiblioteca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Carnet { get; set; }

        public UsuarioBiblioteca(string nombre, string carnet)
        {
            Nombre = nombre?.Trim();
            Carnet = carnet?.Trim();
        }

        public override string ToString() => $"{Nombre} ({Carnet})";
    }
}
