// Clase Factura con patrón Composite
class Factura : IComputadoraComponente
{
    public List<IComputadoraComponente> ComputadorasCompradas { get; set; } = new List<IComputadoraComponente>();
    public double Total { get; set; }
    public string FormaDePago { get; set; }

    public void AgregarComputadoras(List<IComputadoraComponente> computadoras)
    {
        ComputadorasCompradas.AddRange(computadoras);
        Total += computadoras.Sum(c => c.ObtenerPrecio());
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Factura:");
        Console.WriteLine("----------------------------");

        foreach (var componente in ComputadorasCompradas)
        {
            componente.MostrarInformacion();
        }

        Console.WriteLine($"Total a Pagar: ${Total}");
        Console.WriteLine($"Forma de Pago: {FormaDePago}");
        Console.WriteLine("----------------------------");
        Console.WriteLine("¡Gracias por su compra!");
    }

    // Implementación del método ObtenerPrecio para la interfaz IComputadoraComponente
    public double ObtenerPrecio()
    {
        return Total;
    }
}
