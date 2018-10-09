using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        protected string _patente;
        protected Byte _cantRuedas;
        protected EMarcas _marca;

        #region Propiedades
        public string Patente
        {
            get { return this._patente; }
        }

        public byte CantRuedas
        {
            get { return this._cantRuedas; }

            set { this._cantRuedas = value; }
        }

        public EMarcas Marca
        {
            get { return this._marca; }
        }
        #endregion

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente: " + this._patente);
            sb.AppendLine("Cantidad de ruedas: " + this._cantRuedas.ToString());
            sb.AppendLine("Marca: " + this._marca.ToString());

            return sb.ToString();
        }

        public Vehiculo(string patente,Byte cantRuedas, EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = cantRuedas;
            this._marca = marca;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            bool retorno = false;
            if (a._patente == b._patente && a._marca == b._marca)
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }
    }
}
