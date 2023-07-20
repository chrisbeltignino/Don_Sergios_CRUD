using ClassClientes;
using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int lastClientId = 0;

        static void Main()
        {
            CargarDatosAleatorios(5); // Cargamos 5 clientes con datos aleatorios

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar cliente");
                Console.WriteLine("2. Mostrar todos los clientes");
                Console.WriteLine("3. Actualizar cliente");
                Console.WriteLine("4. Eliminar cliente");
                Console.WriteLine("5. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCliente();
                        break;
                    case "2":
                        MostrarClientes();
                        break;
                    case "3":
                        ActualizarCliente();
                        break;
                    case "4":
                        EliminarCliente();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void AgregarCliente()
        {
            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del cliente:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la dirección del cliente:");
            string direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el número de teléfono del cliente:");
            string numeroTelefono = Console.ReadLine();

            Console.WriteLine("Ingrese el Facebook del cliente:");
            string facebook = Console.ReadLine();

            Console.WriteLine("Ingrese la patente del auto:");
            string patente = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del auto:");
            int modelo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año del auto:");
            int anio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los problemas del servicio:");
            string problemas = Console.ReadLine();

            Console.WriteLine("Ingrese las pruebas realizadas:");
            string pruebas = Console.ReadLine();

            Console.WriteLine("Ingrese los repuestos utilizados:");
            string repuestos = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del servicio:");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las observaciones del servicio:");
            string observaciones = Console.ReadLine();

            Cliente cliente = new Cliente
            {
                ID = ++lastClientId,
                Nombre = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Telefono = numeroTelefono,
                Facebook = facebook,
                Auto = new Auto
                {
                    Patente = patente,
                    EnumModelo = (eModelos)modelo,
                    EnumAño = anio
                },
                Servicio = new Servicio
                {
                    Problemas = problemas,
                    PruebasRealizadas = pruebas,
                    Repuestos = repuestos,
                    Precio = precio,
                    Observaciones = observaciones
                },
                FechaLlegada = DateTime.Now
            };

            Console.WriteLine("Ingrese la fecha de salida (dd/mm/aaaa):");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaSalida))
            {
                cliente.FechaSalida = fechaSalida;
            }
            else
            {
                cliente.FechaSalida = DateTime.Now;
            }

            clientes.Add(cliente);

            Console.WriteLine("Cliente agregado exitosamente.");
            Console.WriteLine();
        }

        static void MostrarClientes()
        {
            Console.WriteLine("----- Clientes -----");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.ID}");
                Console.WriteLine($"Nombre: {cliente.Nombre}");
                Console.WriteLine($"Apellido: {cliente.Apellido}");
                Console.WriteLine($"Dirección: {cliente.Direccion}");
                Console.WriteLine($"Número de Teléfono: {cliente.Telefono}");
                Console.WriteLine($"Facebook: {cliente.Facebook}");
                Console.WriteLine($"Patente del Auto: {cliente.Auto.Patente}");
                Console.WriteLine($"Modelo del Auto: {cliente.Auto.EnumModelo}");
                Console.WriteLine($"Año del Auto: {cliente.Auto.EnumAño}");
                Console.WriteLine($"Problemas del Servicio: {cliente.Servicio.Problemas}");
                Console.WriteLine($"Pruebas Realizadas: {cliente.Servicio.PruebasRealizadas}");
                Console.WriteLine($"Repuestos: {cliente.Servicio.Repuestos}");
                Console.WriteLine($"Precio del Servicio: {cliente.Servicio.Precio}");
                Console.WriteLine($"Observaciones: {cliente.Servicio.Observaciones}");
                Console.WriteLine($"Fecha de Llegada: {cliente.FechaLlegada}");
                Console.WriteLine($"Fecha de Salida: {cliente.FechaSalida}");
                Console.WriteLine();
            }
        }

        static void ActualizarCliente()
        {
            Console.WriteLine("Ingrese el ID del cliente que desea actualizar:");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.ID == id);
            if (cliente == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Ingrese el nuevo nombre del cliente:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo apellido del cliente:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la nueva dirección del cliente:");
            string direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo número de teléfono del cliente:");
            string numeroTelefono = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo Facebook del cliente:");
            string facebook = Console.ReadLine();

            Console.WriteLine("Ingrese la nueva patente del auto:");
            string patente = Console.ReadLine();

            Console.WriteLine("Ingrese la nueva marca del auto:");
            string marca = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo modelo del auto:");
            int modelo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo año del auto:");
            int anio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los nuevos problemas del servicio:");
            string problemas = Console.ReadLine();

            Console.WriteLine("Ingrese las nuevas pruebas realizadas:");
            string pruebas = Console.ReadLine();

            Console.WriteLine("Ingrese los nuevos repuestos utilizados:");
            string repuestos = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo precio del servicio:");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las nuevas observaciones del servicio:");
            string observaciones = Console.ReadLine();

            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Direccion = direccion;
            cliente.Telefono = numeroTelefono;
            cliente.Facebook = facebook;
            cliente.Auto.Patente = patente;
            cliente.Auto.EnumModelo = (eModelos)modelo;
            cliente.Auto.EnumAño = anio;
            cliente.Servicio.Problemas = problemas;
            cliente.Servicio.PruebasRealizadas = pruebas;
            cliente.Servicio.Repuestos = repuestos;
            cliente.Servicio.Precio = precio;
            cliente.Servicio.Observaciones = observaciones;

            Console.WriteLine("Cliente actualizado exitosamente.");
            Console.WriteLine();
        }

        static void EliminarCliente()
        {
            Console.WriteLine("Ingrese el ID del cliente que desea eliminar:");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.ID == id);
            if (cliente == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                Console.WriteLine();
                return;
            }

            clientes.Remove(cliente);

            Console.WriteLine("Cliente eliminado exitosamente.");
            Console.WriteLine();
        }

        static void CargarDatosAleatorios(int cantidad)
        {
            Random random = new Random();

            string[] nombres = { "Juan", "María", "Carlos", "Laura", "Luis", "Ana", "Pedro", "Sofía", "Manuel", "Carmen" };
            string[] apellidos = { "Gómez", "Rodríguez", "Pérez", "Fernández", "García", "López", "Martínez", "Díaz" };
            string[] direcciones = { "Calle 123", "Avenida 456", "Plaza Principal", "Camino Real", "Boulevard 789" };
            string[] numerosTelefono = { "555-1234", "444-5678", "333-9876", "222-6543", "666-8765" };
            string[] facebookIds = { "usuario1", "usuario2", "usuario3", "usuario4", "usuario5" };
            string[] patentes = { "ABC123", "XYZ987", "LMN456", "QRS789", "DEF234" };
            int[] modelos = { 2,3,4,1,1 };
            string[] problemas = { "Problema en el motor", "Fallo eléctrico", "Fuga de aceite", "Problema en la transmisión" };
            string[] pruebas = { "Prueba de frenos", "Prueba de aceleración", "Prueba de suspensión" };
            string[] repuestos = { "Bujías", "Filtro de aire", "Pastillas de freno", "Amortiguadores" };
            double[] precios = { 100, 150, 200, 250, 300 };

            for (int i = 0; i < cantidad; i++)
            {
                Cliente cliente = new Cliente
                {
                    ID = ++lastClientId,
                    Nombre = nombres[random.Next(nombres.Length)],
                    Apellido = apellidos[random.Next(apellidos.Length)],
                    Direccion = direcciones[random.Next(direcciones.Length)],
                    Telefono = numerosTelefono[random.Next(numerosTelefono.Length)],
                    Facebook = facebookIds[random.Next(facebookIds.Length)],
                    Auto = new Auto
                    {
                        Patente = patentes[random.Next(patentes.Length)],
                        EnumModelo = (eModelos)modelos[random.Next(modelos.Length)],
                        EnumAño = random.Next(1995, 2010) // Año aleatorio entre 1995 y 2010
                    },
                    Servicio = new Servicio
                    {
                        Problemas = problemas[random.Next(problemas.Length)],
                        PruebasRealizadas = pruebas[random.Next(pruebas.Length)],
                        Repuestos = repuestos[random.Next(repuestos.Length)],
                        Precio = precios[random.Next(precios.Length)],
                        Observaciones = $"Observaciones del cliente {i + 1}"
                    },
                    FechaLlegada = DateTime.Now.AddDays(-random.Next(1, 30)), // Fecha aleatoria de llegada en los últimos 30 días
                    FechaSalida = DateTime.Now.AddDays(-random.Next(0, 5)) // Fecha aleatoria de salida en los últimos 5 días
                };

                clientes.Add(cliente);
            }
        }
    }
}
