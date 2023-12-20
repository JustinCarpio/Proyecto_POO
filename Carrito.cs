class Carrito
{
    public List<IComputadoraComponente> ProductosEnCarrito { get; set; } = new List<IComputadoraComponente>();

    public void AgregarAlCarrito(IComputadoraComponente producto)
    {
        ProductosEnCarrito.Add(producto);
    }

    public void VisualizarCarrito()
    {
        Console.WriteLine("Productos en el Carrito:");
        Console.WriteLine("----------------------------");

        foreach (var producto in ProductosEnCarrito)
        {
            producto.MostrarInformacion();
        }

        Console.WriteLine("----------------------------");
    }
}



