internal class Program
{
    private static void Main(string[] args)
    {
        // Se crea el usuario
        Usuario usuario = new Usuario("Luis", 130353323, "Luis@gmail.com", 0999994242);
        usuario.MostrarInformacion();

        // Crear una lista de Computadoras
        var computadoras = new List<Computadora>
        {
            new Computadora
            {
                Marca = "DELL",
                Procesador = "Intel Core i5",
                SistemaOperativo = "Windows 10",
                Almacenamiento = 256,
                Precio = 900
            },
            new Computadora
            {
                Marca = "HP",
                Procesador = "AMD Ryzen 7",
                SistemaOperativo = "Windows 11",
                Almacenamiento = 512,
                Precio = 1200
            },
            new Computadora
            {
                Marca = "TOSHIBA",
                Procesador = "Intel Core i3",
                SistemaOperativo = "Windows 10",
                Almacenamiento = 128,
                Precio = 800
            },
            new Computadora
            {
                Marca = "MAC",
                Procesador = "Apple M1",
                SistemaOperativo = "macOS",
                Almacenamiento = 512,
                Precio = 1500
            },
            new Computadora
            {
                Marca = "ASUS",
                Procesador = "AMD Ryzen 5",
                SistemaOperativo = "Windows 10",
                Almacenamiento = 256,
                Precio = 1000
            }
        };

        // Crear instancia del simulador, la factura y el carrito
        var simulador = new Simulador();
        var factura = new Factura();
        var carrito = new List<IComputadoraComponente>();

        // Simular la compra
        simulador.SimularCompra(computadoras, factura, carrito);
    }
}