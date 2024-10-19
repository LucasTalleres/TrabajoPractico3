using System;

class Program
{
    public static int[] asientos = new int[60];
    public const int TotalAsientos = 60;

    public static void ReservarAsiento(int asiento)
    {
        if (asientos[asiento - 1] == 0)
        {
            asientos[asiento - 1] = 1;
            Console.WriteLine($"Asiento {asiento} reservado.");
        }
        else
        {
            Console.WriteLine($"El asiento {asiento} ya está ocupado.");
        }
    }

    public static void CancelarReserva(int asiento)
    {
        if (asientos[asiento - 1] == 1)
        {
            asientos[asiento - 1] = 0;
            Console.WriteLine($"Reserva del asiento {asiento} cancelada.");
        }
        else
        {
            Console.WriteLine($"El asiento {asiento} no está reservado.");
        }
    }

    public static void MostrarEstado()
    {
        Console.WriteLine("Estado de los asientos:");
        for (int i = 0; i < TotalAsientos; i++)
        {
            Console.Write(asientos[i] == 0 ? "0 " : "X ");
        }
        Console.WriteLine();
    }

    public static void MostrarCantidad()
    {
        int ocupados = 0;
        foreach (var asiento in asientos)
        {
            if (asiento == 1) ocupados++;
        }
        Console.WriteLine($"Asientos ocupados: {ocupados}, disponibles: {TotalAsientos - ocupados}");
    }

    public static void BuscarAsiento(int asiento)
    {
        if (asientos[asiento - 1] == 0)
        {
            Console.WriteLine($"El asiento {asiento} está disponible.");
        }
        else
        {
            Console.WriteLine($"El asiento {asiento} está ocupado.");
        }
    }

    public static void Main(string[] args)
    {
        bool repetir = true;
        while (repetir)
        {
            Console.WriteLine("\nSeleccioná una opción:");
            Console.WriteLine("1. Reservar asiento");
            Console.WriteLine("2. Cancelar reserva");
            Console.WriteLine("3. Mostrar estado de todos los asientos");
            Console.WriteLine("4. Mostrar cantidad de asientos disponibles y ocupados");
            Console.WriteLine("5. Buscar asiento");
            Console.WriteLine("6. Salir");

            int opcion = int.Parse(Console.ReadLine());

            int asiento;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresá el número de asiento (1 a 60):");
                    asiento = int.Parse(Console.ReadLine());
                    ReservarAsiento(asiento);
                    break;
                case 2:
                    Console.WriteLine("Ingresá el número de asiento (1 a 60):");
                    asiento = int.Parse(Console.ReadLine());
                    CancelarReserva(asiento);
                    break;
                case 3:
                    MostrarEstado();
                    break;
                case 4:
                    MostrarCantidad();
                    break;
                case 5:
                    Console.WriteLine("Ingresá el número de asiento (1 a 60):");
                    asiento = int.Parse(Console.ReadLine());
                    BuscarAsiento(asiento);
                    break;
                case 6:
                    repetir = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}