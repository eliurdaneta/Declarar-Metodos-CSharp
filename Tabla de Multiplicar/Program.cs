using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_Multipolicar
{
   class TablaMultiplicar
    {
        string linea;
        int numero;

        public void CargarDatos()
        {
            do
            {
                Console.Write("Ingrese Entero (Con -1 se sale)");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if(numero != -1)
                {
                  CalculaTabla(numero);
                }
                
            }
            while (numero != 1);
        }

        public void CalculaTabla(int num)
        {

            for (int f = num; f <= num * 10; f = f + num)
            {
                Console.Write(f + "-");
            }
            Console.WriteLine();

        }


        static void Main(string[] args)
        {
            TablaMultiplicar tm = new TablaMultiplicar();
            tm.CargarDatos();
        }
    }
}
