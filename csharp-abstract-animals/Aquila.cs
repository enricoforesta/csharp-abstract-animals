using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale , IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("L' Aquila grida");
        }
        public override void Mangia()
        {
            Console.WriteLine("L' Aquila mangia carne");
        }
        public void Vola()
        {
            Console.WriteLine("Sto Volando");
        }
    }
}
