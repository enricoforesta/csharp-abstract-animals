using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale, INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("Il Cane abbaia");
        }
        public override void Mangia()
        {
            Console.WriteLine("Il Cane mangia  croccantini");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto Nuotando");
        }
    }
}
