using ejer3;  // Asegúrate de que esta línea esté al principio del archivo

namespace ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un arreglo de desayunos de tamaño 5
            Desayuno[] desayunos = new Desayuno[5];

            // Bucle para ingresar los datos de cada desayuno
            for (int i = 0; i < desayunos.Length; i++)
            {
                // Crear una nueva instancia de Desayuno
                desayunos[i] = new Desayuno();

                // Ingresar el nombre del desayuno
                Console.WriteLine($"Ingrese el nombre del desayuno {i + 1}:");
                desayunos[i].Nombre = Console.ReadLine();

                // Ingresar el precio del desayuno
                Console.WriteLine($"Ingrese el precio del desayuno {i + 1}:");
                while (true)
                {
                    string inputPrecio = Console.ReadLine();
                    if (double.TryParse(inputPrecio, out double precio))
                    {
                        desayunos[i].Precio = precio;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un valor numérico válido para el precio.");
                    }
                }

                // Ingresar los días en los que se sirve el desayuno
                Console.WriteLine($"Ingrese los días en los que se sirve el desayuno {i + 1} (separados por coma):");
                desayunos[i].Dias = Console.ReadLine();
            }

            // Mostrar los desayunos ingresados
            Console.WriteLine("\nDesayunos ingresados:");
            foreach (var desayuno in desayunos)
            {
                if (desayuno != null)
                {
                    Console.WriteLine(desayuno);  // Usamos el método ToString() sobrecargado
                }
            }

            // Crear un nuevo desayuno adicional por consola (opcional)
            Desayuno des = new Desayuno();
            Console.WriteLine("\nIngrese un desayuno adicional:");
            Console.WriteLine("Nombre:");
            des.Nombre = Console.ReadLine();
            Console.WriteLine("Precio:");
            while (true)
            {
                string inputPrecioAdicional = Console.ReadLine();
                if (double.TryParse(inputPrecioAdicional, out double precioAdicional))
                {
                    des.Precio = precioAdicional;
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un valor numérico válido para el precio.");
                }
            }
            Console.WriteLine("Días (separados por coma):");
            des.Dias = Console.ReadLine();

            // Mostrar el desayuno adicional
            Console.WriteLine("\nDesayuno adicional:");
            Console.WriteLine(des);

            // Mostrar la lista de días del desayuno adicional
            string[] lista = des.ListaDias();
            Console.WriteLine("\nDías en los que se sirve el desayuno adicional:");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }
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



