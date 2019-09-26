using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_JeuPlusMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des valeurs
            int valeurATrouve = new Random().Next(0, 100);
            int valeurSaisie = 0;
            int chancesDonnees = 10;

            // partie principale de notre programme
            Console.WriteLine("Bienvenue dans le jeu du plus ou du moins." +
                "\n-----------------------------------------------------\n" +
                "Commençons sans plus tarder ! Voici les règles du jeu : " +
                "\n\t" + "Je vais choisir un nombre compris entre 0 et 99." +
                "\n\t" + "Toi, tu dois le trouver avant que tes chances ne tombent à 0. Tu as 10 chances pour cela." +
                "\n\t" + "Si tu ne réussis pas, tu perds ! Cas inverse, tu gagnes ! Bon courage." +
                "\n\n" + "Dernière information : je n'accepte que des nombres cas inverse une pénalité te seras donné(e)," +
                "\n" + "ne dis pas la suite, que je suis injuste parce que tu es déjà averti(e) des conséquences." +
                "\n-----------------------------------------------------\n");

            while(chancesDonnees != 0)
            {
                try
                {
                    Console.WriteLine("Veuillez insérer un entier uniquement");
                    valeurSaisie = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    valeurSaisie = new Random().Next(0, 100);
                    chancesDonnees -= 1;
                    Console.WriteLine("Tu m'as donné(e) une chaîne de caractère et non un nombre." +
                        "\n" + "Une pénalité t'es donné(e), tu perds une chances et je prends " + 
                        valeurSaisie + " pour la suite.\n");
                }

                if ((valeurSaisie < 0) || (valeurSaisie >= 100))
                {
                    chancesDonnees -= 1;
                    Console.WriteLine("Vous être en dehors des limites données.");
                }
                else
                {
                    if (valeurSaisie != valeurATrouve)
                    {
                        chancesDonnees -= 1;

                        if (valeurSaisie > valeurATrouve)
                        {
                            Console.WriteLine("Nombre trop grand.\n");
                        }
                        else
                        {
                            Console.WriteLine("Nombre trop petit.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Bravo ! Tu as gagné(e)." +
                            "\n" + "Tu as maintenant le droit à des chocolats (Bien sûr, ce ne sera pas possible).");
                        break;
                    }
                }

                if (chancesDonnees == 0)
                {
                    Console.WriteLine("\n" + "Dommage ! Tu as perdu(e) et pas de chocolat pour toi." +
                        "\n" + "La bonne réponse était : " + valeurATrouve);
                }
            }
            Console.WriteLine("\n" + "Au revoir et au plaisir de rejouer avec toi.");
            Console.ReadLine();
        }
    }
}
