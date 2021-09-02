/**
 * titre : Denombrements
 * description : programme permettant de faire plusieurs opérations mathématiques (permutation, arrangement, combinaison)
 * auteur : pas moi
 * date création : 02/09/2021
 * date dernière modification : 02/09/2021
 */
using System;


namespace Denombrements
{
    class Program
    {
        static int elements, sousEnsemble; // déclaration des variables 
        /// <summary>
        /// Permet la saisie du nombre d'éléments à gerer
        /// </summary>
        /// <returns>t</returns>
        static int SaisieT()
        {
            
            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
            elements = int.Parse(Console.ReadLine()); // saisir le nombre
            return elements;
        }
        /// <summary>
        /// Permet la saisie du nombre d'éléments dans le sous ensemble
        /// </summary>
        /// <returns>n</returns>
        static int SaisieN() // saisie du nombre d'éléments dans le sous ensemble
        {
            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
            sousEnsemble = int.Parse(Console.ReadLine()); // saisir le nombre
            return sousEnsemble;
        }
        /// <summary>
        /// Affichage des choix possible pour l'utilisateur et renvoie au module correspondant en fonction de la reponse, calcul et affichage de la reponse en fonction de la saisie de l'utilisateur
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                // affichage du menu 
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) { Environment.Exit(0); } // fermeture du programme

                // renvoi vers "Permutation"
                if (choix == 1) 
                {
                    // saisie du nombre d'éléments à gérer
                    SaisieT();
                    // calcul de r 
                    long r = 1;
                    for (int k = 1; k <= elements; k++)
                        r *= k;
                    Console.WriteLine(elements + "! = " + r); // affichage du resultat
                }
                else
                {
                    // renvoi vers "Arrangement"
                    if (choix == 2)
                    {
                        // saisie du nombre d'éléments à gérer
                        SaisieT();
                        // saisie du nombre d'éléments dans le sous ensemble
                        SaisieN();
                        // calcul de r
                        long r = 1;
                        for (int k = (elements - sousEnsemble + 1); k <= elements; k++)
                            r *= k;
                        Console.WriteLine("A(" + elements + "/" + sousEnsemble + ") = " + r); // affichage du resultat
                    }
                    else
                    {
                        // renvoi vers "Combinaison
                        SaisieT(); // saisie du nombre d'éléments à gérer
                        SaisieN(); // saisie du nombre d'éléments dans le sous ensemble
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (elements - sousEnsemble + 1); k <= elements; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= sousEnsemble; k++)
                            r2 *= k;
                        Console.WriteLine("C(" + elements + "/" + sousEnsemble + ") = " + (r1 / r2)); // affichage du resultat
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
