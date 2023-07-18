using ClassClientes;
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

            Console.WriteLine("Ingrese la marca del auto:");
            string marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del auto:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el año del auto:");
            int anio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los problemas del servicio:");
            string problemas = Console.ReadLine();

            Console.WriteLine("Ingrese las pruebas realizadas:");
            string pruebas = Console.ReadLine();

            Console.WriteLine("Ingrese los repuestos utilizados:");
            string repuestos = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del servicio:");
            decimal precio = decimal.Parse(Console.ReadLine());

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
                Auto = new ClassLibrary.Auto
                {
                    Patente = patente,
                    EnumModelo = modelo,
                    Anio = anio
                },
                Servicio = new Servicio
                {
                    Problemas = problemas,
                    PruebasRealizadas = pruebas,
                    Repuestos = repuestos,
                    Precios = precio,
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
                Console.WriteLine($"ID: {cliente.Id}");
                Console.WriteLine($"Nombre: {cliente.Nombre}");
                Console.WriteLine($"Apellido: {cliente.Apellido}");
                Console.WriteLine($"Dirección: {cliente.Direccion}");
                Console.WriteLine($"Número de Teléfono: {cliente.NumeroTelefono}");
                Console.WriteLine($"Facebook: {cliente.Facebook}");
                Console.WriteLine($"Patente del Auto: {cliente.Auto.Patente}");
                Console.WriteLine($"Marca del Auto: {cliente.Auto.Marca}");
                Console.WriteLine($"Modelo del Auto: {cliente.Auto.Modelo}");
                Console.WriteLine($"Año del Auto: {cliente.Auto.Anio}");
                Console.WriteLine($"Problemas del Servicio: {cliente.Servicio.Problemas}");
                Console.WriteLine($"Pruebas Realizadas: {cliente.Servicio.PruebasRealizadas}");
                Console.WriteLine($"Repuestos: {cliente.Servicio.Repuestos}");
                Console.WriteLine($"Precio del Servicio: {cliente.Servicio.Precios}");
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

            Cliente cliente = clientes.Find(c => c.Id == id);
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
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo año del auto:");
            int anio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los nuevos problemas del servicio:");
            string problemas = Console.ReadLine();

            Console.WriteLine("Ingrese las nuevas pruebas realizadas:");
            string pruebas = Console.ReadLine();

            Console.WriteLine("Ingrese los nuevos repuestos utilizados:");
            string repuestos = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo precio del servicio:");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las nuevas observaciones del servicio:");
            string observaciones = Console.ReadLine();

            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Direccion = direccion;
            cliente.NumeroTelefono = numeroTelefono;
            cliente.Facebook = facebook;
            cliente.Auto.Patente = patente;
            cliente.Auto.Marca = marca;
            cliente.Auto.Modelo = modelo;
            cliente.Auto.Anio = anio;
            cliente.Servicio.Problemas = problemas;
            cliente.Servicio.PruebasRealizadas = pruebas;
            cliente.Servicio.Repuestos = repuestos;
            cliente.Servicio.Precios = precio;
            cliente.Servicio.Observaciones = observaciones;

            Console.WriteLine("Cliente actualizado exitosamente.");
            Console.WriteLine();
        }

        static void EliminarCliente()
        {
            Console.WriteLine("Ingrese el ID del cliente que desea eliminar:");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == id);
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
        
    }
}
