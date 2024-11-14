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
    }// Método para eliminar un desayuno por nombre
    public static void EliminarDesayuno(ref Desayuno[] desayunos, ref int cantidadDesayunos)
    {
        Console.Write("Ingrese el nombre del desayuno a eliminar: ");
        string nombre = Console.ReadLine();

        int index = -1;
        for (int i = 0; i < cantidadDesayunos; i++)
        {
            if (desayunos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                index = i;
            break;
        }
    }

            if (index != -1)
            {
                for (int i = index; i<cantidadDesayunos - 1; i++)
                {
                    desayunos[i] = desayunos[i + 1];  // Mueve los elementos una posición hacia atrás
                }

cantidadDesayunos--;
desayunos[cantidadDesayunos] = null;  // Limpia la última posición

Console.WriteLine("Desayuno eliminado exitosamente.");
            }
            else
{
    Console.WriteLine("Desayuno no encontrado.");
}
        }



