namespace TP1
{
    class Program
    {
        static void Main()
        {   string cara;
            Console.WriteLine("veuillez entrer un texte");
            cara = Console.ReadLine();
            Console.WriteLine(cara.Length);
            for (int i = 0; i < cara.Length; i++)
            {
                if (cara[i] == 'e') Console.WriteLine("position de la lettre 'e': " + i);
            }
            string ucase = cara.ToUpper();
            Console.WriteLine(ucase);
            //Console.WriteLine("test" + (char)2026);
            Console.WriteLine(cara + "...");
        }
    }
}

