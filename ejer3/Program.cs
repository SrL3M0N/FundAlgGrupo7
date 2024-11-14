using System;

namespace ejer3
{
    internal class Desayuno
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Dias { get; set; }

        public override string ToString()
        {
            return $"Desayuno {Nombre} s/{Precio}, servido los días {Dias}";
        }

        public string[] ListaDias()
        {
            return Dias.Split(',');
        }
    }
}
