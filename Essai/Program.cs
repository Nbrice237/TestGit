using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Essai
{
    class Program
    {
        // variable globale pour la saisie des essais
        static int essai;
        /// <summary>
        /// retourne la saisie des essais
        /// </summary>
        static void Essai()
        {
            // saisie du premier essai
            bool correct = false;
            // boucle sur la saisie des essais
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
        }
        static void Main(string[] args)
        {
            // déclaration
            int valeur = 0, nbre = 1;
            essai = 0;
            bool correct = false;
            // saisie du nombre à chercher
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            Console.Clear();
            // saisie du premier essai
            Essai();
            // boucle sur les essais
            while (essai != valeur)
            {
                // test de l’essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand !");
                }

                else
                {
                    Console.WriteLine(" --> trop petit !");
                }
                // saisie d’un nouvel essai
                Essai();
                // compteur d’essais
                nbre++;
            }
            // valeur trouvée
            Console.WriteLine("Vous avez trouvé en " + nbre + " fois !");
            Console.ReadLine();
        }
    }
}
