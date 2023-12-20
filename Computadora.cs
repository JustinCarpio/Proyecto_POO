// Clase Computadora con el patrón Composite
class Computadora : IComputadoraComponente
{
    // Propiedades de la computadora
    public string Marca { get; set; }
    public string Procesador { get; set; }
    public string SistemaOperativo { get; set; }
    public double Almacenamiento { get; set; } // en GB
    public double Precio { get; set; }

    // Implementación de la interfaz para mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Procesador: {Procesador}");
        Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
        Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
        Console.WriteLine($"Precio: ${Precio}");
        Console.WriteLine("----------------------------");
    }

    // Implementación de la interfaz para obtener el precio
    public double ObtenerPrecio()
    {
        return Precio;
    }
}
