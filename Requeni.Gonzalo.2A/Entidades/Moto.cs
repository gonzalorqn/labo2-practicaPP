using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(string patente, Byte cantRuedas, EMarcas marca, float cilindrada) : base(patente, cantRuedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public Moto(EMarcas marca, float cilindrada, string patente, Byte cantRuedas) : this(patente,cantRuedas,marca,cilindrada)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cilindrada: " + this._cilindrada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
