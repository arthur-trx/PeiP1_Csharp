namespace TP1
{
    class Program
    {
        static void Main()
        {
            int largeur;
            int longueur;
            Console.WriteLine("Calcul de la surface d'un rectangle");
            Console.WriteLine("veuillez rentrer la largeur");
            largeur = int.Parse(Console.ReadLine());
            Console.WriteLine("veuillez rentrer la longueur");
            longueur = int.Parse(Console.ReadLine());
            int surface = largeur * longueur;
            Console.WriteLine(surface);


        }
    }
}