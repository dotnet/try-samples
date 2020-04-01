using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/**
 * The code below will read all the game information for you.
 * On each game turn, information will be available on the standard input, you will be sent:
 * -> the total number of visible enemies
 * -> for each enemy, its name and distance from you
 * The system will wait for you to write an enemy name on the standard output.
 * Once you have designated a target:
 * -> the cannon will shoot
 * -> the enemies will move
 * -> new info will be available for you to read on the standard input.
 *
 *
 *
 * Votre programme doit détruire les vaisseaux ennemis en tirant sur l'ennemi le plus proche à chaque tour.
   Règles
   Les vaisseaux ennemis approchent en ligne droite vers votre canon.
   
   À chaque début d'un tour de jeu (dans la boucle game loop), vous obtenez les informations des deux ennemis
    les plus proches :
   variable enemy1 : le nom de l'ennemi 1.
   variable dist1 : la distance à laquelle se trouve l'ennemi 1.
   variable enemy2 : le nom de l'ennemi 2.
   variable dist2 : la distance à laquelle se trouve l'ennemi 2.
   Avant la fin du tour (fin de la boucle), vous devez indiquer en sortie le nom de l'ennemi le plus proche. 
    Pour afficher le nom de l'ennemi le plus proche, vous devez utiliser la variable enemy1 ou enemy2.
 **/
class Player
{

    static void Main(string[] args)
    {
        // game loop
        while (true)
        {

            int minDistance = 1000;
            string closestEnemy = null;


            if (!int.TryParse(Console.ReadLine(), out int count))
            {
                Console.WriteLine("Invalid arguments.");
                continue;
            }

            for (int i = 0; i < count; i++)
            {
                try
                {
                    (string enemy, int dist) = ParseEnemyInfo(Console.ReadLine());
                    if (dist < minDistance)
                    {
                        minDistance = dist;
                        closestEnemy = enemy;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid arguments.");
                    continue;
                }
               
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            Console.Out.WriteLine(closestEnemy);
            //Console.WriteLine("HotDroid"); // The name of the most threatening enemy (HotDroid is just one example)
        }
    }

    private static (string enemy, int dist) ParseEnemyInfo(string rawEnemy)
    {
        string[] components = Regex.Split(rawEnemy, @"\s+");
        if (components.Length != 2
            || !int.TryParse(components[1].Substring(0, components[1].Length - 1), out int distance))
        {
            throw new ArgumentException("Invalid enemy info");
        }

        var enemy = components[0];
        return (enemy, distance);
    }
}