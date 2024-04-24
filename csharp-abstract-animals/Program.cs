namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animale> animali = new();
            animali.Add(new Cane());
            animali.Add(new Passerotto());
            animali.Add(new Aquila());
            animali.Add(new Delfino());

            foreach (Animale animale in animali)
            {
                Console.WriteLine(animale.GetType().Name);
                animale.Verso();
                animale.Mangia();
                animale.Dormi();
            }
        }
    }
}
