namespace csharp_abstract_animals
{
    internal class Program
    {
        static List<Animale> animali = new();
        static List<IVolante> animaliVolante = new();
        static List<INuotante> animaleNuotante = new();
        static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }
        static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }
        static void Main(string[] args)
        {
            animali.Add(new Cane());
            animali.Add(new Passerotto());
            animali.Add(new Aquila());
            animali.Add(new Delfino());

            foreach (Animale animale in animali)
            {
                Console.WriteLine("Animale: " + animale.GetType().Name);
                animale.Verso();
                animale.Mangia();
                animale.Dormi();
                if (animale is IVolante volante) FaiVolare(volante);
                if (animale is INuotante nuotante) FaiNuotare(nuotante);
                Console.WriteLine();
            }

            // Esempi con liste 
            Console.WriteLine("volanti");
            animaliVolante.Add(new Passerotto());
            animaliVolante.Add(new Aquila());
            foreach (IVolante animale in animaliVolante)
            {
                FaiVolare(animale);
            }

            Console.WriteLine("nuotanti");
            animaleNuotante.Add(new Cane());
            animaleNuotante.Add(new Delfino());
            foreach (INuotante animale in animaleNuotante)
            {
                FaiNuotare(animale);
            }
            Console.WriteLine();

            // Esempi singoli
            FaiNuotare(new Cane());
            FaiVolare(new Passerotto());
            FaiVolare(new Aquila());
            FaiNuotare(new Delfino());


        }

    }
}
