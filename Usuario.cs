// Clase Usuario
class Usuario
{
    public string Nombre { get; set; }
    public int Cedula { get; set; }
    public string Correo { get; set; }
    public int Telefono { get; set; }

    public Usuario(string Nombre, int Cedula, string Correo, int Telefono)
    {
        this.Nombre = Nombre;
        this.Cedula = Cedula;
        this.Correo = Correo;
        this.Telefono = Telefono;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Cédula: {Cedula}");
        Console.WriteLine($"Correo: {Correo}");
        Console.WriteLine($"Teléfono: {Telefono}");
    }
}