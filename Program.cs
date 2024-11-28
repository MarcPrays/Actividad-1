using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Crea un programa que simule un sistema de Registro de empleados.
            */
            List<Empleados> empleados = new List<Empleados>();
            int decision;
            while (true)
            {
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|     MENU DE ADMINISTRACION DE EMPLEADOS     |");
                Console.WriteLine("|                                             |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("\n1.- Agregar Empleado");
                Console.WriteLine("2.- Eliminar Empleado");
                Console.WriteLine("3.- Mostrar Empleado");
                Console.WriteLine("4.- Salir del Sistema");
                Console.Write("\nSELECCIONE UNA OPCION: ");
                bool verificarDato = uint.TryParse(Console.ReadLine(), out uint seleccion);
                if (!verificarDato)
                {
                    Console.WriteLine("\nERROR, USTED INGRESO UN DATO NO VALIDO, VUELVA A SELECCIONAR UNA OPCION.");
                    Console.Clear();
                    continue;
                }
                switch (seleccion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n---------- AGREGACION DE EMPLEADOS -----------");
                        Console.Write("\nINGRESE EL NOMBRE DEL EMPLEADO: ");
                        string nombre = Console.ReadLine();
                        Console.Write("\nINGRESE EL CARGO DEL EMPLEADO: ");
                        string cargo = Console.ReadLine();
                        Console.Write("\nINGRESE EL SUELDO DEL EMPLEADO: ");
                        double sueldo = double.Parse(Console.ReadLine());

                        empleados.Add(new Empleados(nombre, cargo, sueldo));

                        Console.Write("\nDESEA VOLVER AL MENU?: ");
                        Console.WriteLine("\n1.- SI");
                        Console.WriteLine("2.- NO");
                        decision = int.Parse(Console.ReadLine());
                        if (decision == 1)
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("EL PROGRAMA FUE CERRADO...");
                            return;
                        }
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n---------- ELIMINACION DE EMPLEADOS -----------");
                        Empleados.EmpleadosAEliminar(empleados);
                        Console.Write("\nSELECCIONE EL NUMERO DEL EMPLEADO A ELIMINAR: ");
                        int numeroEmpleado = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\nESTA SEGURO DE ELIMINAR AL EMPLEADO #{numeroEmpleado}??");
                        Console.WriteLine("1.- SI");
                        Console.WriteLine("2.- NO");
                        decision = int.Parse(Console.ReadLine());
                        if (decision == 1)
                        {
                            Console.Write($"\nSE ELIMINO AL EMPLEADO CON ");
                            empleados[numeroEmpleado - 1].NombreEmpleados();
                            empleados.RemoveAt(numeroEmpleado - 1);

                        }
                        else
                        {
                            Console.WriteLine("\nNO SE ELIMINO A NINGUN EMPLEADO, SE VOLVERA AL MENU...");
                            continue;
                        }
                        Console.Write("\nDESEA VOLVER AL MENU?: ");
                        Console.WriteLine("\n1.- SI");
                        Console.WriteLine("2.- NO");
                        decision = int.Parse(Console.ReadLine());
                        if (decision == 1)
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("EL PROGRAMA FUE CERRADO...");
                            return;
                        }
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n---------- LISTA DE EMPLEADOS -----------");
                        Empleados.MostrarEmpleados(empleados);
                        Console.ReadKey();
                        Console.Write("\nDESEA VOLVER AL MENU?: ");
                        Console.WriteLine("\n1.- SI");
                        Console.WriteLine("2.- NO");
                        decision = int.Parse(Console.ReadLine());
                        if (decision == 1)
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("EL PROGRAMA FUE CERRADO...");
                            return;
                        }
                    case 4:

                        break;
                    default:
                        Console.WriteLine("\nERROR, USTED SELECCIONO UNA OPCION QUE NO EXISTE\nVUELVA A SELECCIONAR UNA OPCION.");
                        Console.Clear();
                        continue;
                }
            }
        }
    }
}
