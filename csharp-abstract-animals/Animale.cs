using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("ZZZ");
        }
        public abstract void Verso();
        public abstract void Mangia();
    }

    public class Cane : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Il Cane abbaia");
        }
        public override void Mangia()
        {
            Console.WriteLine("Il Cane mangia  croccantini");
        }
    }
    public class Passerotto : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Il Passerotto cinguetta");
        }
        public override void Mangia()
        {
            Console.WriteLine("Il Passerotto mangia insetti");
        }
    }
    public class Aquila : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("L' Aquila grida");
        }
        public override void Mangia()
        {
            Console.WriteLine("L' Aquila mangia carne");
        }
    }
    public class Delfino : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Il Delfino canta");
        }
        public override void Mangia()
        {
            Console.WriteLine("Il Delfino mangia pesci");
        }
    }
    
}
