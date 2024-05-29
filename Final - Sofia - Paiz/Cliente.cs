namespace Final___Sofia___Paiz;

public class Cliente
{
    public string Nombre;
    public string Apellido;

    public string OpcionElegida;
    public string ClaseElegida;
    
    public string SedeElegida;


    public void PedirDatosCliente()
    {
        Console.WriteLine("Nombre del cliente");
        Nombre = Console.ReadLine();

        Console.WriteLine("Apellido del cliente");
        Apellido = Console.ReadLine();

    }

    public void ActividadMembresia()
    {

        Console.WriteLine("¿La membresía del cliente está activa?");
        Console.WriteLine("1. Si");
        Console.WriteLine("2. No");
        OpcionElegida = Console.ReadLine();
        do
        {
            switch (OpcionElegida)
            {
                case "1":
                    Console.WriteLine("Si posee una membresía activa");
                    break;

                case "2":
                    Console.WriteLine("No posee membresía activa");
                    break;

                default:
                    Console.WriteLine("La opción ingresada no es válida");
                    OpcionElegida = "3";
                    break;
            }
        } while (OpcionElegida == "3");

    }

    public void pedirDatosClases()
    {
        Console.WriteLine("¿Qué clase quiere recibir el cliente?");
        Console.WriteLine("1. Crossfit");
        Console.WriteLine("2. Yoga");
        Console.WriteLine("3. Zumba");
        Console.WriteLine("4. Circuitos");
        Console.WriteLine("5. Spinning");

        ClaseElegida = Console.ReadLine();

        do
        {
            switch (ClaseElegida)
            {
                case "1":
                    Console.WriteLine("Participará en la clase de crossfit");
                    break;
                case "2":
                    Console.WriteLine("Participará en la clase de yoga");
                    break;
                case "3":
                    Console.WriteLine("Participará en la clase de zumba");
                    break;
                case "4":
                    Console.WriteLine("Participará en la clase de circuitos");
                    break;
                case "5":
                    Console.WriteLine("Participará en la clase de spinning");
                    break;
                default:
                    ClaseElegida = "6";
                    Console.WriteLine("La opción ingresada no es válida");
                    break;
            }
        } while (ClaseElegida == "6");
    }

    public void PedirDatosSede ()
    {
        Console.WriteLine("Sedes disponibles");
        Console.WriteLine("1. Zona 1") ;
        Console.WriteLine("2. Zona 2");
        Console.WriteLine("3. Zona 10");

        SedeElegida= Console.ReadLine();

        do 
        {
            switch (SedeElegida)
            {
                case "1":
                Console.WriteLine("Irá a la sede en zona 1");
                break;

                case "2":
                Console.WriteLine("Irá a la sede en zona 2");
                break;

                case "3":
                Console.WriteLine("Irá a la sede en zona 10");
                break;
                
                default:
                SedeElegida = "4";
                Console.WriteLine("Ingrese una opción válida");
                break;
            }
        } while (SedeElegida == "4");
    }

}


