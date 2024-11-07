using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3
{
    internal class Desayuno:Object
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Dias { get; set; }

        public override string? ToString()
        {
            return $"Desayuno {Nombre} s/{Precio}, servido los dias {Dias}";
        }

        public string[] ListaDias() 
        {
        return Dias.Split(',') ;
        }
    }
}
