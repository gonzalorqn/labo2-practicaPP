using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        public Camion(string patente, Byte cantRuedas, EMarcas marca,float tara) : base(patente,cantRuedas,marca)
        {
            this._tara = tara;
        }

        public Camion(Vehiculo camion, float tara) : this(camion.Patente,camion.CantRuedas,camion.Marca,tara)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Tara: " + this._tara);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
