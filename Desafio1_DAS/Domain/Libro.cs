// Autor: Maria Torres
// Desafio 1 - Desarrollo de Aplicaciones con Software Propietario
// Universidad Don Bosco

namespace Desafio1_DAS.Domain
{
    // Clase derivada de MaterialBiblioteca - Herencia
    public class Libro : MaterialBiblioteca
    {
        public int Paginas { get; set; }
        public string ISBN { get; set; }

        public Libro(string titulo, string autor, int anio, int paginas, string isbn)
            : base(titulo, autor, anio)
        {
            Paginas = paginas;
            ISBN = isbn?.Trim();
        }

        // Polimorfismo: sobrescribe ObtenerDescripcion
        public override string ObtenerDescripcion()
            => $"Libro: {Titulo} - {Autor} ({Anio}), {Paginas} pags., ISBN: {ISBN}";
    }
}
