using ConsoleJPRT_ADSI2026.Lista.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJPRT_ADSI2026.Lista
{
    public class ListaEstudiantes
    {
        List<EstudianteModel> estudianteModels = new List<EstudianteModel>();

        public ListaEstudiantes()
        {
            estudianteModels = ObtenerEstudiantes();
        }

        private List<EstudianteModel> ObtenerEstudiantes()
        {
            List<EstudianteModel> listaEstuandites = new List<EstudianteModel>();
            for (int i = 1; i <= 10; i++)
            {
                EstudianteModel model = new EstudianteModel()
                {
                    Id = i,
                    Name = $"Estudiante {i}",
                    Nota = 0
                };
                listaEstuandites.Add(model);
            }

            return listaEstuandites;
        }

        public void Menu()
        {
            bool procesar = true;
            while (procesar)
            {
                Console.Clear();
                Console.WriteLine("** Menú estudiantes ***");
                Console.WriteLine("1. Meter ntoas");
                Console.WriteLine("2. Consultar estudiantes");
                Console.WriteLine("3. Mostrar estuantes aprobados  y la cantidad");
                Console.WriteLine("4. Mostrar estuantes reprobados");
                Console.WriteLine("5. Promedio de todos los estuantes");
                Console.WriteLine("6. Mostrar estudiante con mejor nota");
                Console.WriteLine("Distinto: Salir");
                if (int.TryParse(Console.ReadLine(), out int options))
                {
                    switch (options)
                    {
                        case 1:
                            MeterNotas();
                            break;
                        case 2:
                            Console.WriteLine("Lista estudiantes");
                            foreach (var item in estudianteModels)
                            {
                                Console.WriteLine($"Id:{item.Id} - Nombre: {item.Name} - Nota: {item.Nota}");
                            }
                            break;
                        case 3:
                            EstudiantesAprobados();
                            break;
                        case 4:
                            EstudiantesReprobados();
                            break;
                        case 5:
                            Console.WriteLine("Promedio de los estudiantes");
                            var promedio = estudianteModels.Average(x => x.Nota);
                            Console.WriteLine(promedio);
                            break;
                        case 6:
                            MejorNotas();
                            break;
                        default:
                            procesar = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor digita un número entero de las opciones disponibles");
                }
                Console.WriteLine("");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        private void MeterNotas()
        {
            Console.WriteLine("Meter notas - estudiantes");
            foreach (var item in estudianteModels)
            {
                Console.WriteLine($"Id:{item.Id} - Nombre: {item.Name}");
                bool succes = true;
                while (succes)
                {
                    if (double.TryParse(Console.ReadLine(), out double value))
                    {
                        item.Nota = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite una nota válida, un numero");
                    }
                }
                Console.WriteLine($"Id:{item.Id} - Nombre: {item.Name} - Nota: {item.Nota}");
                Console.WriteLine("");
            }
        }

        private void EstudiantesAprobados()
        {
            List<EstudianteModel> aprobados = estudianteModels.Where(x => x.Nota >= 30).ToList();
            Console.WriteLine("Lista estudiantes aprobados");
            foreach (var item in aprobados)
            {
                Console.WriteLine($"Id:{item.Id} - Nombre: {item.Name} - Nota: {item.Nota}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Cantidad aprobados {aprobados.Count()}");
        }

        private void EstudiantesReprobados()
        {
            List<EstudianteModel> rerpobados = estudianteModels.Where(x => x.Nota < 30).ToList();
            Console.WriteLine("Lista estudiantes reprobados");
            foreach (var item in rerpobados)
            {
                Console.WriteLine($"Id:{item.Id} - Nombre: {item.Name} - Nota: {item.Nota}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Cantidad reprobados {rerpobados.Count()}");
        }

        private void MejorNotas()
        {
            var mejorNota = estudianteModels.Max(x=>x.Nota);
            var estudiantes = estudianteModels.Where(x=>x.Nota== mejorNota).ToList();
            Console.WriteLine("Lista estudiantes con mejor nota");
            foreach (var item in estudiantes)
            {
                Console.WriteLine($"Id:{item.Id} - Nombre: {item.Name} - Nota: {item.Nota}");
            }
        }
    }
}
