using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero = 0;

                for (int i = 0; i < 100; i++)
                {
                    numero++;
                    if (numero<100)
                    {
                        Console.Write(" " + numero + " -");
                    }
                    else
                    {
                        Console.Write(" "+numero);
                    }
                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un valor invalido");
            }
            Console.ReadKey();
        }
    }
}
