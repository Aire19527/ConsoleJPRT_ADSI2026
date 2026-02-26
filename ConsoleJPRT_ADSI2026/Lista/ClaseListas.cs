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
                int valor = rnd.Next(100, 1000);

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

        public void LlenarProducto()
        {
            List<ProductoModel> listaProductos = new List<ProductoModel>();

            Random random = new Random();

            for (int p = 0; p < 100; p++)
            {
                int count = random.Next(1000);
                ProductoModel producto = new ProductoModel()
                {
                    Producto = $"Referencia {p}",
                    Cantidad = count,
                    Precio = CalcularPrecio(count, p)
                    //Precio = count * p
                };

                listaProductos.Add(producto);
            }

            List<ProductoModel> listaOrdenada = listaProductos.OrderByDescending(x => x.Precio).ToList();

            double sumaTotalSimple = listaProductos.Sum(x => x.Precio);
            double promedioPrecio = listaProductos.Average(x => x.Precio);

            //double sumaTotal = 0;
            //List<ProductoModel> preciosAltosV2 = new List<ProductoModel>();
            //foreach (var item in listaOrdenada)
            //{
            //    sumaTotal = sumaTotal + item.Precio;

            //    if (item.Precio > 5000)
            //    {
            //        preciosAltosV2.Add(item);
            //    }

            //    Console.WriteLine($"Nombre Producto: {item.Producto} - Cantidad: {item.Cantidad} - Precio: {item.Precio}");
            //}

            Console.WriteLine("");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            //var listaPreciosAltos = listaProductos.Where(x => x.Precio > 5000 && x.Cantidad >= 500).ToList();
            listaProductos = listaProductos.Where(x => x.Precio > 5000 && x.Cantidad >= 500).ToList();

            foreach (var item in listaProductos)
            {
                Console.WriteLine($"Nombre Producto: {item.Producto} - Cantidad: {item.Cantidad} - Precio: {item.Precio}");
            }

            var product = listaProductos.FirstOrDefault(x => x.Precio > 8000);
            if(product != null)
            {
                Console.WriteLine($"Producto: {product.Producto}");
            }
        }

        private double CalcularPrecio(int cantidad, int indice)
        {
            double precio = cantidad * indice;

            return precio;
        }
    }
}
