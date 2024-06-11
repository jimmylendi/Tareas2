

namespace Tareas.Class
{
   public class Bucle
    {
        public void Valores10()
        {
            int cantidad = 10;
            int[] valores = new int[cantidad];
            int suma = 0;
            double promedio;

            
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el valor {i + 1}: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < cantidad; i++)
            {
                suma += valores[i];
            }

            
            promedio = (double)suma / cantidad;

            
            Console.WriteLine($"La suma de los valores es: {suma}");
            Console.WriteLine($"El promedio de los valores es: {promedio}");

            Console.ReadLine(); 
        }

        public void Piezas()
        {
            int n;
            int cantidadPiezasAptas = 0;

            Console.Write("Ingrese la cantidad de piezas a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double longitud;

                Console.Write($"Ingrese la longitud de la pieza {i}: ");
                longitud = Convert.ToDouble(Console.ReadLine());

                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    cantidadPiezasAptas++;
                }
            }

            Console.WriteLine($"La cantidad de piezas aptas es: {cantidadPiezasAptas}");

            Console.ReadLine();
        }

        public void NotasAlumnos()
        {
            int cantidad = 10;
            int notasAltas = 0;
            int notasBajas = 0;

            for (int i = 0; i < cantidad; i++)
            {
                double nota;

                Console.Write($"Ingrese la nota del alumno {i + 1}: ");
                nota = Convert.ToDouble(Console.ReadLine());

                if (nota >= 7)
                {
                    notasAltas++;
                }
                else
                {
                    notasBajas++;
                }
            }

            Console.WriteLine($"Cantidad de alumnos con notas mayores o iguales a 7: {notasAltas}");
            Console.WriteLine($"Cantidad de alumnos con notas menores a 7: {notasBajas}");

            Console.ReadLine(); 
        }
    }
}
