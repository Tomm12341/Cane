using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane c= new Cane();

            c.Razza = "Labrador";
            
            c.Nome = "Ringhio";

 c.Proprietario = new Persona();
            c.Proprietario.Nome = "Simone";

         


            Console.ReadLine();
        }
    }
}
