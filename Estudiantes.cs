using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeProgramacion2
{
    internal class Estudiante

    {
        static string[] nombre = new string[3]; 
        static float[] notas = new float[3];    
        static byte indice = 0;

        


        private static void CrearEstudiantes()
        {
            string continuar = "s";
            do
            {
                Console.WriteLine("Digite el nombre del estudiante ({0}):", (indice + 1));
                nombre[indice] = Console.ReadLine();
                indice++;
                Console.WriteLine("Desea continuar(s/n): ");
                continuar = Console.ReadLine();
            } while (!continuar.Equals("n"));
        }

        private static void BuscarEstudiante()
        {
            Console.WriteLine("Digite el nombre:");
            string nombre = Console.ReadLine();

            for (int i = 0; i < Estudiante.nombre.Length; i++)
            {
                if (nombre.Equals(Estudiante.nombre[i]))
                {
                    Console.WriteLine("Estudiante Existe");
                }
            }
        }
        private static void AsignarNota()
        {
            string continuar = "s";
            do
            {
                Console.WriteLine("Digite el nombre:");
                string nombre = Console.ReadLine();

                for (int i = 0; i < Estudiante.nombre.Length; i++)
                {
                    if (nombre.Equals(Estudiante.nombre[i]))
                    {
                        Console.WriteLine("Estudiante Existe");
                        Console.WriteLine("Digite la nota del estudiate    " + Estudiante.nombre[i]);
                        float notas = float.Parse(Console.ReadLine());

                    }
                }
                Console.WriteLine("Desea agregar otra nota? (s/n):");
                continuar = Console.ReadLine() ;                 
            }while(!continuar.Equals("n"));
        }

        public static void EstudiantesConSusNotas()
        {
            for ( int i = 0;i < 3; i++)
            {
                Console.WriteLine("La nota del estudiante " + Estudiante.nombre[i] + " es " + Estudiante.notas[i]);


            } 
           
            
        }
        public static void menu()
        {
            byte opcion = 0;
            do
            {
                Console.WriteLine("1 - Agregar Estudiantes");
                Console.WriteLine("2 - Buscar Estudiante");
                Console.WriteLine("3 - Asignar nota al estudiante");
                Console.WriteLine("4 - Imprimir Estudiante con sus notas");
                Console.WriteLine("5 - salir");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearEstudiantes();
                        break;
                    case 2:
                        BuscarEstudiante();
                        break;
                    case 3:
                        AsignarNota();
                        break;
                    case 4:
                        EstudiantesConSusNotas();
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion != 4); // true

        }
    }
}
