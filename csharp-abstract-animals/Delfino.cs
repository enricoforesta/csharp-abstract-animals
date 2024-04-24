using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale , INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("Il Delfino canta");
        }
        public override void Mangia()
        {
            Console.WriteLine("Il Delfino mangia pesci");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto Nuotando");
        }
    }
}
