namespace ConsoleJPRT_ADSI2026.Ciclos
{
    public class CiclosFor
    {
        //public CiclosFor()
        //{
        //    ForBasico();
        //}

        public void ForBasico()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Indice: {i}");
            }
        }

        public void ForMultiplicar()
        {
            bool acceso = true;
            while (acceso)
            {
                Console.WriteLine("Tabla de multiplicar");
                Console.WriteLine("1. Multiplar");
                Console.WriteLine("2. Salir");
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1)
                {
                    Console.WriteLine("Por favor digita un número a multiplicar del 1 al 10");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            int resultado = i * numero;
                            Console.WriteLine($"{numero} * {i} = {resultado}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor digita un número entero");
                    }
                }
                else
                {
                    break;
                }

                //acceso = false;
                //break;
            }
        }



        public void PromedioNotas()
        {
            bool success = true;
            while (success)
            {
                Console.WriteLine("**** Programa para calcular las notas ***");
                Console.WriteLine("¿Cuantas notas deseas calcular?");
                Console.Write("Digite la cantidad de notas: ");
                if (int.TryParse(Console.ReadLine(), out int cantidad))
                {
                    double notas = 0;
                    for (int i = 1; i <= cantidad; i++)
                    {
                        bool intento = true;
                        while (intento)
                        {
                            Console.WriteLine($"Digite la nota: {i}");
                            if (double.TryParse(Console.ReadLine(), out double nota))
                            {
                                if(nota>=0 && nota<=5)
                                {
                                    notas = notas + nota;
                                    //break;
                                    intento = false;
                                }
                                else
                                {
                                    Console.WriteLine("Por favor digita una nota entre 0 y 5");
                                    Console.WriteLine("");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Por favor digita una nota válida");
                                Console.WriteLine("");
                            }
                        }

                        Console.WriteLine($"Sunma notas: {notas} ");
                    }

                    double promedio = notas / cantidad;
                    Console.WriteLine("");
                    Console.WriteLine($"** Promedio notas: {promedio} **");
                    Console.WriteLine("");
                    if(promedio>=3)
                    {
                        Console.WriteLine("Estudiante aprobó");
                    }
                    else
                    {
                        Console.WriteLine("Estudiante Reprobó");
                    }
                }
                else
                {
                    Console.WriteLine("Señor usuario, sea serio y escriba un numero entero positvo.");
                }
                Console.WriteLine("");
            }
        }
    }
}
