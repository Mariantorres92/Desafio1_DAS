using System.Drawing;

public class Libro : MaterialBiblioteca
{
    public int Paginas { get; set; }
    public string ISBN { get; set; }

    public Libro(string titulo, string autor, int anio, Image portada, int paginas, string isbn)
        : base(titulo, autor, anio, portada)
    {
        Paginas = paginas;
        ISBN = isbn;
    }

    public override string ObtenerDescripcion()
    {
        return $"Libro: {Titulo} - {Autor} ({Anio}), {Paginas} páginas, ISBN: {ISBN}";
    }
}