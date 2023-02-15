/*
 * Name : Parc Véhicules
 * Author : Jeremy-FullStack
 * Date: 15/02/2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicules
{
    class Program
    {
        static List<Vehicule> listeVehicules;

        static void Main(string[] args)
        {
            listeVehicules = new List<Vehicule>();
            int choix = AfficherMenu();

            // Choix 5 : quitter
            while (choix != 5)
            {
                switch (choix)
                {
                    case 1:
                        // Afficher la liste
                        AfficherListe();
                        break;
                    case 2:
                        // Ajouter une voiture
                        AjouterVoiture();
                        break;

                    case 3:
                        // Ajouter un utilitaire
                        AjouterUtilitaire();
                        break;
                    case 4:
                        // Supprimer un vehicule
                        SupprimerVehicule();
                        break;

                }
                AfficherMenu();
            }
        }

        private static void SupprimerVehicule()
        {
            Console.WriteLine("Suppression d'un véhicule à partie de son immatriculation");

            Console.WriteLine("immatriculation ?");
            string immatriculation = Console.ReadLine();

            int index = ChercherVehicule(immatriculation);
            if (index >= 0)
            {
                listeVehicules.RemoveAt(index);
                Console.WriteLine("Véhicule supprimer ! \n");

            }
            else
            {
                Console.WriteLine("Désolé pas de véhicule correspondant");
            }
        }

        private static int ChercherVehicule(string immatriculation)
        {
            int index = -1;
            foreach (Vehicule v in listeVehicules)
            {
                if (v.)
                {
                    return listeVehicules.IndexOf(v);
                }
            }
        }

        private static void AjouterUtilitaire()
        {
            Console.WriteLine("ajouter un utilitaire : ");
            Console.Write(": Immatriculation ?");
            string imm = Console.ReadLine();

            Console.Write("Couleur ?");
            string coul = Console.ReadLine();

            Console.Write("Marque ?");
            string marque = Console.ReadLine();

            Console.Write(" Volume utile ?");
            int volume = lireEntirer();

            Utilitaire util = new Utilitaire(imm, marque, coul, volume);
            listeVehicules.Add(util);

            Console.WriteLine("\n");
        }

        private static void AjouterVoiture()
        {
            Console.WriteLine("ajouter une voiture : ");
            Console.Write(": Immatriculation ?");
            string imm = Console.ReadLine();

            Console.Write("Couleur ?");
            string coul = Console.ReadLine();

            Console.Write("Marque ?");
            string marque = Console.ReadLine();

            Console.Write("Nombre de portes ?");
            int nbPortes = lireEntirer();

            Voiture voiture = new Voiture(imm, marque, coul, nbPortes);
            listeVehicules.Add(voiture);

            Console.WriteLine("\n");
        }

        private static int lireEntirer()
        {
            while (true)
            {
                int entier;
                if (int.TryParse(Console.ReadLine(), out entier))
                {
                    return entier;
                }
            }
        }

        private static void AfficherListe()
        {
            Console.WriteLine("liste des véhicules: ");
            foreach (Vehicule v in listeVehicules)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n");
        }

        private static int AfficherMenu()
        {

            while (true)
            {
                Console.WriteLine("Gestion d'un parc de véhicules");
                Console.WriteLine("Actuellement, il y'a  " + listeVehicules.Count + " véhicules dans le parc");

                Console.WriteLine(": 1 afficher la liste des véhicules");
                Console.WriteLine(": 2 ajouter une voiture");
                Console.WriteLine(": 3 ajouter un utilitaire");
                Console.WriteLine(": 4 suprimer un véhicule");
                Console.WriteLine(": 5 pour quitter");

                string reponse = Console.ReadLine();
                int choix;

                if (int.TryParse(reponse, out choix))
                {
                    if (choix > 0 && choix <= 5)
                    {
                        return choix;
                    }
                }

            }

        }
    }
}
   