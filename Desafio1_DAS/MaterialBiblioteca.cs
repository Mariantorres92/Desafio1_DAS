using System.Drawing;

public abstract class MaterialBiblioteca
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }
    public Image Portada { get; set; }
    public bool Prestado { get; private set; }
    public UsuarioBiblioteca UsuarioPrestamo { get; private set; }

    public MaterialBiblioteca(string titulo, string autor, int anio, Image portada)
    {
        Titulo = titulo;
        Autor = autor;
        Anio = anio;
        Portada = portada;
        Prestado = false;
    }

    public void AsignarPrestamo(UsuarioBiblioteca usuario)
    {
        Prestado = true;
        UsuarioPrestamo = usuario;
    }

    public void Devolver()
    {
        Prestado = false;
        UsuarioPrestamo = null;
    }

    public virtual string ObtenerDescripcion()
    {
        return $"{Titulo} - {Autor} ({Anio})";
    }

    public string ObtenerEstado()
    {
        return Prestado ? $"Prestado a {UsuarioPrestamo.Nombre}" : "Disponible";
    }
}