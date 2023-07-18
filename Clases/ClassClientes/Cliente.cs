using ClassLibrary;
using System;

namespace ClassClientes
{
    public class Cliente : Persona
    {
        private int id;
        private Auto auto;
        private DateTime fechaLlegada;
        private DateTime fechaSalida;
        private Servicio servicio;

        public Cliente (int id, Auto auto, Servicio servicio, DateTime fechaLlegada, DateTime fechaSalida)
        {
            this.id = id;
            this.auto = auto;
            this.servicio = servicio;
            this.fechaLlegada = fechaLlegada;
            this.fechaSalida = fechaSalida;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Auto Auto
        { 
            get { return auto; } 
            set { auto = value; } 
        }

        public Servicio Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }

        public DateTime FechaLlegada
        {
            get { return fechaLlegada; }
            set { fechaLlegada = value; }
        }

        public DateTime FechaSalida
        {
            get { return fechaSalida; } 
            set { fechaSalida = value; }
        }
    }
}
