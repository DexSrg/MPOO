using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llamar el metodo que desee probar

        }

        private static void MetodoSaludar()
        {
            Console.WriteLine("Saludar");
            Console.ReadLine();
        }
        private static int MetodoNumero()
        {
            return 10;
        }
        private static int MetodoConParametrosSuma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        protected static void EstructuraDeSeleccionIf()
        {
            string leerLinea;

            Console.WriteLine("Ingrese el Número: ");
            leerLinea = Console.ReadLine();
            int a = Convert.ToInt32(leerLinea);

            if (a > 0)
            {
                Console.WriteLine("La condición se cumplio");
                Console.ReadLine();
            }
            else
            {
                Console.Write("No se cumplio la condición");
                Console.ReadLine();
            }
        }
        protected static void EstructuraDeSeleccionSwitch()
        {
            string leerLinea;

            Console.WriteLine("Ingrese un número entre 1 y 7: ");
            leerLinea = Console.ReadLine();
            int a = Convert.ToInt32(leerLinea);

            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Día Lunes");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Día Martes");
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Día Miércoles");
                        Console.ReadLine();
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Día Jueves");
                        Console.ReadLine();
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Día Viernes");
                        Console.ReadLine();
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Día Sábado");
                        Console.ReadLine();
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Día Domingo");
                        Console.ReadLine();
                    }
                    break;

                default:
                    Console.WriteLine("hOLA");
                    Console.ReadLine();
                    break;


            }
        }
        protected static void EstructuraCiclicaFor()
        {
            string leerLinea;

            Console.WriteLine("Ingrese hasta que numero quiere contar: ");
            leerLinea = Console.ReadLine();
            int a = Convert.ToInt32(leerLinea);

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.ReadLine();
        }
        protected static void EstructuraCiclicaWhile()
        {


            Console.Write("Teclea un número (0 para salir): ");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                if (numero > 0) Console.WriteLine("Es positivo");
                else Console.WriteLine("Es negativo");

                Console.WriteLine("Teclea otro número (0 para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
        }
        protected static void EstructuaCiclicaDoWhile()
        {
            int valor;
            string linea;
            do
            {
                Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor >= 100)
                {
                    Console.WriteLine("Tiene 3 dígitos.");
                }
                else
                {
                    if (valor >= 10)
                    {
                        Console.WriteLine("Tiene 2 dígitos.");
                    }
                    else
                    {
                        Console.WriteLine("Tiene 1 dígito.");
                    }
                }
            } while (valor != 0);
        }
        protected static void ArregloUniDimensional()
        {
            int Size = 0;
            Console.WriteLine("Ingrese Cuantas Notas quiere promediar");
            Size = Convert.ToInt32(Console.ReadLine());

            int[] NombreDelArreglo = new int[Size];

            //Escribiendo en el Arreglo
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Ingrese la Nota " + (i + 1));
                NombreDelArreglo[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Leer el Arreglo
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Nota " + (i + 1).ToString() + " " + NombreDelArreglo[i].ToString());
            }
            Console.ReadLine();

            decimal Promedio = 0;
            decimal Sumatoria = 0;
            //Calculando el promedio
            for (int i = 0; i < Size; i++)
            {
                Sumatoria = Sumatoria + NombreDelArreglo[i];
                if (i == 3)
                {
                    Promedio = Sumatoria / Size;
                    Console.WriteLine("El Promedio de notas es " + Promedio);
                }
            }
            Console.ReadLine();
        }
        protected static void ArregloBiDimensional()
        {
            //Declaramos las variables que utilizaremos para inicializar las filas y las columnas de la Matriz.
            int Filas = 0;
            int Columnas = 0;

            //Inicializando las Filas
            Console.WriteLine("Ingrese la cantidad de alumnos");
            Filas = Convert.ToInt32(Console.ReadLine());

            //Inicializando las Columnas
            Console.WriteLine("Ingrese Cuantas clases quiere Registrar");
            Columnas = Convert.ToInt32(Console.ReadLine());

            //Declarando e inicializando la Matriz Bidimencional
            string[,] matriz = new string[Filas, (Columnas + 1)];

            //Escribiendo en la Matriz 
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas + 1; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Ingrese el nombre del alumno");
                        matriz[i, j] = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ingrese la nota " + (j));
                        matriz[i, j] = Console.ReadLine();
                    }
                }
            }

            //Leyendo la Matriz
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas + 1; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
            Console.ReadLine();
        }
        protected static void ArregloBiDimensionalModificado()
        {
            int Filas;
            int Columnas;

            Console.WriteLine("Ingrese la cantidad de Alumnos");
            Filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese cuantas clases registrara");
            Columnas = Convert.ToInt32(Console.ReadLine());
            Columnas = Columnas + 2;

            string[,] Matriz = new string[Filas, Columnas];

            for (int Fila = 0; Fila < Filas; Fila++)
            {
                for (int Columna = 0; Columna < Columnas; Columna++)
                {
                    if (Columna == 0)
                    {
                        Console.WriteLine("Ingrese el Nombre del Alumno " + (Fila + 1));
                        Matriz[Fila, Columna] = Console.ReadLine();
                    }
                    else if (Columna == (Columnas - 1))
                    {
                        Matriz[Fila, Columna] = "0";
                    }
                    else
                    {
                        Console.WriteLine("Ingrese la nota " + (Columna));
                        Matriz[Fila, Columna] = Console.ReadLine();
                    }
                }
            }

            for (int i = 0; i < Filas; i++)
            {
                double SumatoriaNotas = 0;
                for (int j = 1; j < (Columnas - 1); j++)
                {
                    SumatoriaNotas = SumatoriaNotas + Convert.ToDouble(Matriz[i, j]);
                }
                Matriz[i, (Columnas - 1)] = (SumatoriaNotas / (Columnas - 2)).ToString();
            }

            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("\n Nombre del Alumno: " + (Matriz[i, j]));
                    }
                    else if (j == (Columnas - 1))
                    {
                        Console.WriteLine("Promedio: " + (Matriz[i, j]) + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Nota " + (j) + ": " + (Matriz[i, j]));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
