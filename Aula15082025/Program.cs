namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== Ser Vivo ===");
            SerVivo sv = new SerVivo();

            sv.Nascer();
            sv.Crescer();
            sv.Morrer();

            //Console.WriteLine("\n=== Animal ===");
            //Animal an = new Animal();
            //an.Mover();
            //an.Respirar();
            //an.Nascer();
            //an.Falar();

            Console.WriteLine("\n=== Peixe ===");
            Peixe px = new Peixe();
            px.Nascer();
            px.Crescer();
            px.Morrer();
            px.Respirar();
            px.Mover();
            px.Falar();


            Console.WriteLine("\n=== Ave ===");
            Ave av = new Ave();
            av.Nascer();
            av.Crescer();
            av.Morrer();
            av.Respirar();
            av.Mover();
            av.Falar();

        }
    }
}
