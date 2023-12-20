// Clase Simulador con patrón Composite
class Simulador
{
    public void SimularCompra(List<Computadora> computadoras, Factura factura, List<IComputadoraComponente> carrito)
    {
        while (true)
        {
            // Mostrar las opciones al usuario
            Console.WriteLine("Opciones de Computadoras:");
            for (int i = 0; i < computadoras.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {computadoras[i].Marca}");
            }

            // Solicitar al usuario que elija las computadoras a mostrar
            Console.Write("Ingrese el número de la computadora que desea ver (o '0' para finalizar la compra): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                break; // Finalizar la compra
            }
            else if (input.ToLower() == "c")
            {
                // Visualizar el carrito
                MostrarInformacion(carrito);
                continue; // Continuar con la selección
            }

            if (int.TryParse(input, out int indice) && indice >= 1 && indice <= computadoras.Count)
            {
                MostrarInformacion(computadoras[indice - 1]);

                // Preguntar al usuario si desea comprar
                Console.Write("¿Desea comprar esta computadora? (Sí/No): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "si")
                {
                    carrito.Add(computadoras[indice - 1]);
                    Console.WriteLine("¡Computadora agregada al carrito!");
                }
            }
            else
            {
                Console.WriteLine($"Opción no válida: {input}");
            }
        }

        // Seleccionar forma de pago
        SeleccionarFormaDePago(factura);

        // Actualizar factura con productos del carrito
        factura.AgregarComputadoras(carrito);

        // Mostrar la factura
        factura.MostrarInformacion();
    }

    static void MostrarInformacion(Computadora computadora)
    {
        Console.WriteLine($"Marca: {computadora.Marca}");
        Console.WriteLine($"Procesador: {computadora.Procesador}");
        Console.WriteLine($"Sistema Operativo: {computadora.SistemaOperativo}");
        Console.WriteLine($"Almacenamiento: {computadora.Almacenamiento} GB");
        Console.WriteLine($"Precio: ${computadora.Precio}");
        Console.WriteLine("----------------------------");
    }

    static void MostrarInformacion(List<IComputadoraComponente> componentes)
    {
        Console.WriteLine("Carrito de Compras:");
        Console.WriteLine("----------------------------");

        foreach (var componente in componentes)
        {
            componente.MostrarInformacion();
        }

        Console.WriteLine("----------------------------");
    }

    static void SeleccionarFormaDePago(Factura factura)
    {
        Console.WriteLine("\nSeleccione la forma de pago:");
        Console.WriteLine("1. Efectivo");
        Console.WriteLine("2. Tarjeta de Crédito");
        Console.WriteLine("3. Cheque");
        Console.WriteLine("4. Transferencia");

        Console.Write("Ingrese el número de la forma de pago deseada: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                factura.FormaDePago = "Efectivo";
                break;
            case "2":
                factura.FormaDePago = "Tarjeta de Crédito";
                break;
            case "3":
                factura.FormaDePago = "Cheque";
                break;
            case "4":
                factura.FormaDePago = "Transferencia";
                break;
            default:
                Console.WriteLine("Forma de pago no válida. Seleccionando Efectivo por defecto.");
                factura.FormaDePago = "Efectivo";
                break;
        }
    }
}
