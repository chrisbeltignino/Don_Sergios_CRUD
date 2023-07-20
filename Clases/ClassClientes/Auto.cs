using ClassClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Auto
    {
        private string patente;
        private eModelos modelo;
        private int año;
        /*private Cliente cliente;

        public Auto(string patente, eModelos modelo, Cliente cliente) 
        {
            this.patente = patente;
            this.modelo = modelo;
            this.cliente = cliente;
        }*/

        public Auto(string patente, eModelos modelo, int año)
        {
            this.patente = patente;
            this.modelo = modelo;
            this.año = año;
        }

        public Auto() { }

        public static bool operator ==(Auto a1, Auto a2)
        {
            bool equals = false;
            if (!(a1 is null || a2 is null))
            {
                equals = (a1.patente == a2.patente);
            }

            return equals;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool isOk = false;
            if (obj is Auto)
            {
                isOk = this == ((Auto)obj);
            }
            return isOk;
        }

        public static Auto ObtenerCrucero(string patente, List<Auto> list)
        {
            Auto aux = new Auto();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].patente == patente)
                {
                    aux = list[i];
                    break;
                }
            }
            return aux;
        }

        public string Patente
        { 
            get { return this.patente; } 
            set { this.patente = value; } 
        }

        public eModelos EnumModelo 
        {
            get {  return this.modelo; }
            set { this.modelo = value; }
        }

        public string ModeloSeleccionado
        {
            get
            {
                string modelo = this.modelo.ToString();
                return modelo;
            }
        }

        public int EnumAño 
        {
            get { return this.año; }
            set { this.año = value; }
        }
        /*
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }*/
    }
}
