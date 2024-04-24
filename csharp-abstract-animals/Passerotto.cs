using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale ,IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("Il Passerotto cinguetta");
        }
        public override void Mangia()
        {
            Console.WriteLine("Il Passerotto mangia insetti");
        }
        public void Vola()
        {
            Console.WriteLine("Sto Volando");
        }
    }
}
