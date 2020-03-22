using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMayorMenor
{
    class Program
    {
        //Confeccionar una clase que permita ingresar tres valores por teclado.Luego mostrar el mayor y el menor.
        int numero1;
        int numero2;
        int numero3;
        
        //En el Método CargaDatos se recibirin todos los datos solicitados desde la consola
        public void CargarDatos()
        {
         string linea;
            Console.Write("Ingrese Primer número: ");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.Write("Ingrese Segundo número: ");
            linea = Console.ReadLine();
            numero2 = int.Parse(linea);
            Console.Write("Ingrese Tercer número: ");
            linea = Console.ReadLine();
            numero3 = int.Parse(linea);  
        }

        //En el método LeerDatos se hará los cálculos para saber cuál de los números ingresados es el mayor y el menor

        public void LeerDatos()
        {
            int mayor = CalcularMayor(numero1, numero2, numero3);
            int menor = CalcularMenor(numero1, numero2, numero3);
            Console.Write("El Número mayor es: ");
            Console.WriteLine(mayor);
            Console.Write("El Número menor es: ");
            Console.WriteLine(menor);
        }

        //El método CalcularMayor como su nombre lo indica calcula el mayor de los 
        //número ingresados
        public int CalcularMayor(int a, int b, int c)
        {
            int max;
                if(a > b && a> c)
                {
                    max = a;
                }
                else
                {
                    if(b>a && b>c)
                    {
                        max = b;
                    }

                    else
                    {
                        
                    max = c;
                    }
                }

            return max;
        }

        //El método CalcularMenor como su nombre lo indica calcula el menor de los 
        //número ingresados
        public int CalcularMenor(int a, int b, int c)
        {
            int min;
            if(a<b && a<c)
            {
                min = a;
            }
            else
            {
                if(b<a && b<c)
                {
                    min = b;
                }
                else
                {
                    min = c;
                }
            }

            return min;
        }
        static void Main(string[] args)
        {
            Program mm = new Program();
            mm.CargarDatos();
            mm.LeerDatos();
            Console.ReadKey();
        }
    }
}
