// Autor: Maria Torres
// Desafio 1 - Desarrollo de Aplicaciones con Software Propietario
// Universidad Don Bosco

namespace Desafio1_DAS.Domain
{
    // Clase derivada de MaterialBiblioteca - Herencia
    public class Revista : MaterialBiblioteca
    {
        public int NumeroEdicion { get; set; }
        public string MesPublicacion { get; set; }

        public Revista(string titulo, string autor, int anio, int edicion, string mes)
            : base(titulo, autor, anio)
        {
            NumeroEdicion = edicion;
            MesPublicacion = mes?.Trim();
        }

        // Polimorfismo: sobrescribe ObtenerDescripcion
        public override string ObtenerDescripcion()
            => $"Revista: {Titulo} - {Autor} ({Anio}), Ed. {NumeroEdicion}, {MesPublicacion}";
    }
}
