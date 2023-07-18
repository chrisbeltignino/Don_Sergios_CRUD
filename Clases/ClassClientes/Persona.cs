using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string direccion;
        protected string telefono;
        protected string facebook;

        protected Persona() { }

        protected Persona(string nombre, string apellido, string direccion, string telefono, string facebook)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.facebook = facebook;
        }

        public virtual string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public virtual string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public virtual string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        public virtual string Telefono
        {
            get
            {
                return this.telefono;
            }
            set 
            { 
                this.telefono = value; 
            }
        }

        public virtual string Facebook
        {
            get
            {
                return this.facebook;
            }
            set 
            {
                this.facebook = value; 
            }
        }
    }
}
