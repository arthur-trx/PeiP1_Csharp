namespace TP1
{
    class Program
    {
        static void Main()
        {
            //List <int> tab2 = new List<int>();
            int[] tab= new int[10];
            //int[] tab_sort = new int[10];
            int max = 0;
            Console.WriteLine("entrer 10 valeurs : ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("valeur " + i + " : ");
                tab[i] = int.Parse(Console.ReadLine());
                if (tab[i] > max) max = tab[i];
            }
            Console.WriteLine("max  :" + max);
            Console.WriteLine("moyenne :" + moyenne(tab));
            Array.Sort(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        static double moyenne(int[] tab)
        {
            double moyenne = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                moyenne += tab[i];
                Console.WriteLine( " : " + tab[i]);
            }
            Console.WriteLine("somme :" + moyenne);
            moyenne /= (tab.Length + 1);
            //Console.WriteLine("moyenne " + moyenne);
            return moyenne;
        }
    }
} 

