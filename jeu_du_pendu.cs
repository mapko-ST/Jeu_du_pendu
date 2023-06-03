using System;

namespace JeuDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] motsSecrets = { "pendu", "informatique", "programmation", "ordinateur" };
            Random random = new Random();
            string motSecret = motsSecrets[random.Next(0, motsSecrets.Length)];
            int nombreEssais = 5;
            char[] lettresTrouvees = new char[motSecret.Length];

            for (int i = 0; i < motSecret.Length; i++)
            {
                lettresTrouvees[i] = '_';
            }

            while (nombreEssais > 0)
            {
                Console.WriteLine("Mot secret : " + string.Join(" ", lettresTrouvees));
                Console.WriteLine("Essais restants : " + nombreEssais);
                Console.Write("Entrez une lettre : ");
                char lettre = Console.ReadLine()[0];

                bool lettreTrouvee = false;
                for (int i = 0; i < motSecret.Length; i++)
                {
                    if (motSecret[i] == lettre)
                    {
                        lettresTrouvees[i] = lettre;
                        lettreTrouvee = true;
                    }
                }

                if (!lettreTrouvee)
                {
                    nombreEssais--;
                    Console.WriteLine("Lettre incorrecte !");
                }

                if (Array.IndexOf(lettresTrouvees, '_') == -1)
                {
                    Console.WriteLine("Félicitations, vous avez trouvé le mot secret : " + motSecret);
                    break;
                }
            }

            if (nombreEssais == 0)
            {
                Console.WriteLine("Vous avez perdu ! Le mot secret était : " + motSecret);
            }

            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
