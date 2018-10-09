using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;
        
        public Auto(string patente, Byte cantRuedas, EMarcas marca, int cantAsientos) : base(patente,cantRuedas,marca)
        {
            this._cantidadAsientos = cantAsientos;
        }

        public Auto(string patente, EMarcas marca, int cantAsientos) : this(patente,4,marca,cantAsientos)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cantidad de asientos: " + this._cantidadAsientos);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
