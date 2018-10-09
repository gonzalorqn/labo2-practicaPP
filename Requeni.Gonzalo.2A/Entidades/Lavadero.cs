using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Lavadero
    {
        List<Vehiculo> _vehiculos;
        static float _precioAuto;
        static float _precioCamion;
        static float _precioMoto;
        string _razonSocial;

        public string LavaderoToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Razon social: " + this._razonSocial);
                sb.AppendLine("Precio autos: " + Lavadero._precioAuto);
                sb.AppendLine("Precio camiones: " + Lavadero._precioCamion);
                sb.AppendLine("Precio motos: " + Lavadero._precioMoto);
                foreach(Vehiculo v in _vehiculos)
                {
                    sb.AppendLine(v.ToString());
                }

                return sb.ToString();
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this._vehiculos;
            }
        }

        static Lavadero()
        {
            Random rnd = new Random();
            Lavadero._precioAuto = rnd.Next(150, 565);
            Lavadero._precioCamion = rnd.Next(150, 565);
            Lavadero._precioMoto = rnd.Next(150, 565);
        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(string razonSocial) : this()
        {
            this._razonSocial = razonSocial;
        }

        public double MostrarTotalFacturado()
        {
            return this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
        }

        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double retorno = 0;
            switch (vehiculo)
            {
                case EVehiculos.Auto:
                    foreach (Auto v in this._vehiculos)
                    {
                        retorno += Lavadero._precioAuto;
                    }
                    break;
                case EVehiculos.Camion:
                    foreach (Camion v in this._vehiculos)
                    {
                        retorno += Lavadero._precioCamion;
                    }
                    break;
                case EVehiculos.Moto:
                    foreach (Moto v in this._vehiculos)
                    {
                        retorno += Lavadero._precioMoto;
                    }
                    break;
                default:
                    break;
            }
            
            return retorno;
        }

        public static bool operator ==(Lavadero l1, Vehiculo v1)
        {
            bool retorno = false;
            foreach(Vehiculo v2 in l1.Vehiculos)
            {
                if(v2 == v1)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Lavadero l1, Vehiculo v1)
        {
            return !(l1 == v1);
        }

        public static int operator ==(Vehiculo v1, Lavadero l1)
        {
            int retorno = -1;
            for(int i=0;i<l1.Vehiculos.Count;i++)
            {
                if(l1.Vehiculos[i] == v1)
                {
                    retorno = i;
                }
            }
            return retorno;
        }

        public static int operator !=(Vehiculo v1, Lavadero l1)
        {
            return (v1 == l1);
        }

        public static Lavadero operator +(Lavadero l1, Vehiculo v1)
        {
            if(!(l1 == v1))
            {
                l1._vehiculos.Add(v1);
            }
            return l1;
        }

        public static Lavadero operator -(Lavadero l1, Vehiculo v1)
        {
            if((v1 == l1) >= 0)
            {
                l1._vehiculos.Remove(v1);
            }
            return l1;
        }
    }
}
