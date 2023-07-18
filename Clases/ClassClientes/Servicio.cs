﻿using ClassClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Servicio
    {
        private string problemas;
        private string pruebasRealizadas;
        private string repuestos;
        private double precio;
        private string observaciones;
        private Cliente cliente;
        
        public Servicio() { }

        public Servicio(string problemas, string pruebasRealizadas, string repuestos, double precio, string observaciones, Cliente cliente)
        {
            this.problemas = problemas;
            this.pruebasRealizadas = pruebasRealizadas;
            this.repuestos = repuestos;
            this.precio = precio;
            this.observaciones = observaciones;
            this.cliente = cliente;
        }

        public string Problemas
        { 
            get { return problemas; }
            set { problemas = value; }
        }

        public string PruebasRealizadas
        {
            get { return pruebasRealizadas; }
            set { pruebasRealizadas = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public string Repuestos
        {
            get { return repuestos; }
            set { repuestos = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
    }
}