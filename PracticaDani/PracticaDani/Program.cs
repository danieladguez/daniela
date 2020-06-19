using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDani
{
    class Program
    {
        private static Estudiante[] estudiantes;

        struct Estudiante
        {
            public string nombre;
            public string apellidoPaterno;
            public string apellidoMaterno;
            public string matricula;
            public double calif1;
            public double calif2;
            public double calif3;
            public double promedio;
        }

        static void Main(string[] args)
        {

            int numeroEstudiantes = 0;
            Console.Write("Ingresa el número de estudiantes: ");

            numeroEstudiantes = Int16.Parse(Console.ReadLine());

            estudiantes = new Estudiante[numeroEstudiantes];
            Console.Clear();

            //int c = 0;
            /* do
             {
                 Console.WriteLine("Ingresa el nombre(s) del estudiante: ")
                 estudiantes[c].nombre = Console.ReadLine();
                 Console.WriteLine();
                 c++;

             } while (c < estudiantes.Length);
            */
            for (int x = 0; x < numeroEstudiantes; x++)
            {
                Console.Write("Ingresa el nombre(s) del estudiante No.{0} : ", x+1);
                estudiantes[x].nombre = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingresa el apellido paterno de {0}: ", estudiantes[x].nombre);
                estudiantes[x].apellidoPaterno = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingresa el apellido materno de {0}: ", estudiantes[x].nombre);
                estudiantes[x].apellidoMaterno = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingresa la matrícula de {0} {1}: ", estudiantes[x].nombre, estudiantes[x].apellidoPaterno);
                estudiantes[x].matricula = Console.ReadLine();
                Console.WriteLine();

                do
                {
                    Console.Write("Ingresa la calificación primer parcial de {0} {1}: ", estudiantes[x].nombre, estudiantes[x].apellidoPaterno);
                    estudiantes[x].calif1 = Double.Parse(Console.ReadLine());
                } while (estudiantes[x].calif1 < 1 || estudiantes[x].calif1 > 10);
                Console.WriteLine();

                Console.WriteLine();
                do
                {
                    Console.Write("Ingresa la calificación segundo parcial {0} {1}: ", estudiantes[x].nombre, estudiantes[x].apellidoPaterno);
                    estudiantes[x].calif2 = Double.Parse(Console.ReadLine());
                } while (estudiantes[x].calif2 < 1 || estudiantes[x].calif2 > 10);
                Console.WriteLine();

                do
                {
                    Console.Write("Ingresa la calificación tercer parcial {0} {1}: ", estudiantes[x].nombre, estudiantes[x].apellidoPaterno);
                    estudiantes[x].calif3 = Double.Parse(Console.ReadLine());
                } while (estudiantes[x].calif3 < 1 || estudiantes[x].calif3 > 10);
                Console.WriteLine();

                estudiantes[x].promedio = (estudiantes[x].calif1 + estudiantes[x].calif2 + estudiantes[x].calif3) / 3;

                //Console.WriteLine("Ingresa el promedio: ");
                //estudiantes[x].promedio = Double.Parse(Console.ReadLine());

                Console.Clear();
            }
            int accion;
            do
            {
                accion = AccionMenu();
                switch (accion)
                {
                    case 1:
                        PromedioAlto();
                        break;
                    case 2:
                        promedioBajo();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Environment.Exit(7);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (accion != 7);
        }

        static void Menu()
        {
            Console.WriteLine("         MENU");
            Console.WriteLine();
            Console.WriteLine("1.- El promedio más alto. ");
            Console.WriteLine("2.- Promedio más bajo. ");
            Console.WriteLine("3.- Calificación más alta.");
            Console.WriteLine("4.- Nombre más largo.");
            Console.WriteLine("5.- Promedio General.");
            Console.WriteLine("6.- Todos los datos.");
            Console.WriteLine("7.- Salir del sistema.");

            //Enmumerados en orden alfabético con los datos, preguntar por ordenamiento
        }   
        static int AccionMenu()
        {
            int accion = 0;
            do
            {
                Menu();
                Console.WriteLine();
                Console.Write("Ingrese la accion deseada: ");
                accion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (accion < 0 || accion > 6);
            return accion;
        }
        static void PromedioAlto()
        {
            double a = 0, b = 0, c = 0;
            string nombreApellido = "";

            for (int x = 0; x < estudiantes.Length; x++)
            {
                a = (estudiantes[x].calif1 + estudiantes[x].calif2 + estudiantes[x].calif3) / 3;
                if (a > b)
                {
                    b = a;
                    c = b;
                    nombreApellido = estudiantes[x].nombre + " " + estudiantes[x].apellidoPaterno;
                }
            }

            Console.WriteLine("El promedio más alto es " + c.ToString() + " y es de " + nombreApellido);
        }
        static void promedioBajo()
        {
            double a = 0, b = 0, c = 0;
            string nombreApellido = "";
            for (int i = 0; i < estudiantes.Length; i++)
            {
                a = estudiantes[i].promedio;
                if (a > b)
                {
                    b = a;
                    c = b;
                }
                else
                {
                    b = a;
                    c = b;
                    nombreApellido = estudiantes[i].nombre + " " + estudiantes[i].apellidoPaterno;
                }
            }
            Console.WriteLine("El promedio más bajo es " + c.ToString() + " y es de " + nombreApellido);
        }


    }
}
