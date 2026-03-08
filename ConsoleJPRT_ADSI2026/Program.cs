using ConsoleJPRT_ADSI2026.Ciclos;
using ConsoleJPRT_ADSI2026.Lista;

namespace ConsoleJPRT_ADSI2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEstudiantes estudiantes = new ListaEstudiantes();
            estudiantes.Menu();
        }
    }
}
