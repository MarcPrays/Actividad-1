using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Empleados
    {
        // hola MUNDO
        private string Nombre { get; set; }
        private string Cargo { get; set; }
        private double Sueldo { get; set; }

        public Empleados(string nombre, string cargo, double sueldo)
        {
            Nombre = nombre;
            Cargo = cargo;
            Sueldo = sueldo;
        }

        private void InfoEmpleados()
        {
            Console.WriteLine($"\nNOMBRE: {Nombre}\nCARGO: {Cargo}\nSUELDO: {Sueldo}");
        }

        public void NombreEmpleados()
        {
            Console.Write($"NOMBRE: {Nombre}\n");
        }
        public static void EmpleadosAEliminar(List<Empleados> empleados)
        {
            int i = 0;
            foreach (var empleado in empleados)
            {
                Console.Write($"EMPLEADO #{i + 1}: ");
                empleado.NombreEmpleados();
                i++;
            }
        }

        public static void MostrarEmpleados(List<Empleados> empleados)
        {
            int i = 0;
            foreach (var empleado in empleados)
            {
                Console.WriteLine("\n---------------------------------\n");
                Console.WriteLine($"EMPLEADO #{i + 1}:");
                empleado.InfoEmpleados();
                i++;
            }
        }
    }
}
