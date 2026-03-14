// Autor: Maria Torres
// Desafio 1 - Desarrollo de Aplicaciones con Software Propietario
// Universidad Don Bosco

using System;

namespace Desafio1_DAS.Domain
{
    // Clase que representa un prestamo de material bibliografico
    public class Prestamo
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        // Propiedad calculada: true si aun no ha sido devuelto
        public bool Activo => FechaDevolucion == null;
    }
}
