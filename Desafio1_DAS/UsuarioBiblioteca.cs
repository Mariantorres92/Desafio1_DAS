public class UsuarioBiblioteca
{
    public string Nombre { get; set; }
    public string Carnet { get; set; }

    public UsuarioBiblioteca(string nombre, string carnet)
    {
        Nombre = nombre;
        Carnet = carnet;
    }

    public override string ToString()
    {
        return $"{Nombre} ({Carnet})";
    }
}