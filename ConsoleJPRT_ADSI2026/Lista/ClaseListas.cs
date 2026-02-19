using ConsoleJPRT_ADSI2026.Lista.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJPRT_ADSI2026.Lista
{
    public class ClaseListas
    {
        public ClaseListas()
        {
            ObtenerListaPersonas();
        }

        private void ObtenerListaPersonas()
        {
            //List<int> listaNumeros = new List<int>();

            //for (int i = 1; i <= 10; i++)
            //{
            //    listaNumeros.Add(i);
            //}


            //foreach (var numero in listaNumeros)
            //{
            //    int multiplicacion = numero * numero;
            //    string mensaje = $"Numero: {numero} - Multiplicacion {multiplicacion}";

            //    Console.WriteLine(mensaje);

            //}


            //List<Persona> listaPersona = new List<Persona>();
            List<Persona> listaPersona = new List<Persona>();
            //Persona persona = new Persona()
            //{
            //    Edad = 21,
            //    Nombre = $"Carmelo",
            //    Sexo = "Femino",
            //    TieneHijos = false
            //};
            //listaPersona.Add(persona);


            //Persona persona2 = new Persona()
            //{
            //    Edad = 33,
            //    Nombre = $"Pirulito",
            //    Sexo = "Masculito",
            //    TieneHijos = true
            //};
            //listaPersona.Add(persona2);

            for (int i = 0; i < 1000; i++)
            {
                Random rnd = new Random();
               int valor= rnd.Next(100, 1000);

                int precio = valor * i;


                Persona persona = new Persona()
                {
                    Edad = i,
                    Nombre = $"Name {i}",
                };

                listaPersona.Add(persona);
            }

            foreach (var item in listaPersona)
            {
                string mensaje = $"Nombre: {item.Nombre} - Edad: {item.Edad}";
                Console.WriteLine(mensaje);
            }
        }



    }
}
