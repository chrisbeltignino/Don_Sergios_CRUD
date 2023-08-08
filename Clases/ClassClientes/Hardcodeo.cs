using ClassClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Hardcodeo
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int lastClientId = 0;

        public static List<Cliente> CargarDatosAleatorios()
        {
            Random random = new Random();

            string[] nombres = { "Juan", "María", "Carlos", "Laura", "Luis"};
            string[] apellidos = { "Gómez", "Rodríguez", "Pérez", "Fernández", "García", "López", "Martínez", "Díaz" };
            string[] direcciones = { "Calle 123", "Avenida 456", "Plaza Principal", "Camino Real", "Boulevard 789" };
            string[] numerosTelefono = { "555-1234", "444-5678", "333-9876", "222-6543", "666-8765" };
            string[] facebookIds = { "usuario1", "usuario2", "usuario3", "usuario4", "usuario5" };
            string[] patentes = { "ABC123", "XYZ987", "LMN456", "QRS789", "DEF234" };
            int[] modelos = { 2, 3, 0, 1, 1 };
            string[] problemas = { "Problema en el motor", "Fallo eléctrico", "Fuga de aceite", "Problema en la transmisión" };
            string[] pruebas = { "Prueba de frenos", "Prueba de aceleración", "Prueba de suspensión" };
            string[] repuestos = { "Bujías", "Filtro de aire", "Pastillas de freno", "Amortiguadores" };
            double[] precios = { 100, 150, 200, 250, 300 };

            for (int i = 0; i < 5; i++)
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
                        Observaciones = $"Observaciones del cliente {i + 1}",
                        FechaLlegada = DateTime.Now.AddDays(-random.Next(1, 30)), // Fecha aleatoria de llegada en los últimos 30 días
                        FechaSalida = DateTime.Now.AddDays(-random.Next(0, 5)) // Fecha aleatoria de salida en los últimos 5 días
                    },
                    
                };

                clientes.Add(cliente);
            }

            return clientes;
        }
    }
}
