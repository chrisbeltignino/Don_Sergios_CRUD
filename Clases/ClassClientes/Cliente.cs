using ClassLibrary;
using System;

namespace ClassClientes
{
    public class Cliente : Persona
    {
        private int id;
        private Auto auto;
        private Servicio servicio;

        public Cliente() { }

        public Cliente (int id, Auto auto, Servicio servicio)
        {
            this.id = id;
            this.auto = auto;
            this.servicio = servicio;
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
    }
}
