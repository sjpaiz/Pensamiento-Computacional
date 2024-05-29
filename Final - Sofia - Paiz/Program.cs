using Final___Sofia___Paiz;

Cliente[] Clientes = new Cliente[2];


Console.WriteLine("Ingresar los datos de 2 clientes");
for (int i = 0; i < 2; i++)
{
    Cliente objClientes = new Cliente();
    objClientes.PedirDatosCliente();
    objClientes.ActividadMembresia();
    objClientes.pedirDatosClases();
    objClientes.PedirDatosSede();
    Clientes[i] = objClientes;
}

string opcion = "";
do
{
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("¿Qué quiere hacer dentro del sistema?");
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("Mostrar datos");
    Console.WriteLine("a.Imprimir lista de clientes con membresía activa");
    Console.WriteLine("b. Consultar catálogo de clases");
    Console.WriteLine("c. Imprimir listado de instalaciones disponibles");
    Console.WriteLine("d. Salir");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "a":

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("LISTA DE CLIENTES CON MEMBRESÍA ACTIVA");
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < Clientes.Length; i++)
            {
                if (Clientes[i] != null)
                {
                    if (Clientes[i].OpcionElegida == "1")
                    {
                        Console.WriteLine($"{Clientes[i].Nombre}{Clientes[i].Apellido} Posee membresía activa");
                    }
                }
            }
            break;

        case "b":
            for (int i = 0; i < Clientes.Length; i++)
            {
                if (Clientes[i] != null)
                {
                    if (Clientes[i].ClaseElegida == "1")
                    {
                        Console.WriteLine($"{Clientes[i].Nombre} {Clientes[i].Apellido} hará crossfit");
                    }
                    if (Clientes[i].ClaseElegida == "2")
                    {
                        Console.WriteLine($"{Clientes[i].Nombre} {Clientes[i].Apellido} hará yoga");
                    }
                    if (Clientes[i].ClaseElegida == "3")
                    {
                        Console.WriteLine($"{Clientes[i].Nombre} {Clientes[i].Apellido} hará zumba");
                    }
                    if (Clientes[i].ClaseElegida == "4")
                    {
                        Console.WriteLine($"{Clientes[i].Nombre} {Clientes[i].Apellido} hará circuitos");
                    }
                    if (Clientes[i].ClaseElegida == "5")
                    {
                        Console.WriteLine($"{Clientes[i].Nombre} {Clientes[i].Apellido}hará spinning");
                    }
                }
            }
            break;

        case "c":
            for (int i = 0; i < Clientes.Length; i++)
            {
                if (Clientes[i].SedeElegida == "1")
                {
                    Console.WriteLine($"{Clientes[i].Nombre} {Clientes[i].Apellido} irá a Zona 1 / Disponible");
                }
                if (Clientes[i].SedeElegida == "2")
                {
                    Console.WriteLine($"{Clientes[i].Nombre} {Clientes[i].Apellido} irá a Zona 2 / Disponible");
                }
                if (Clientes[i].SedeElegida == "3")
                {
                    Console.WriteLine($"{Clientes[i].Nombre} {Clientes[i].Apellido} irá a Zona 10 / Disponible");
                }
            }
            break;
        case "d":
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Ingrese una opción válida");
            break;
    }
} while (opcion != "d");



