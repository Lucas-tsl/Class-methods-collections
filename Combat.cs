using Class_methods_collections;
using System.Collections.ObjectModel;

namespace Combat_en_cours // Remplacez YourNamespace par le nom de votre espace de noms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Créez une bataille pour le test
            programme bataille = new Battaile();
            bataille.Date = DateTime.Now;
            bataille.Lieu = "Champ de bataille";
            bataille.Duree = 120;

            Collection<Personnage> attaquants = new Collection<Personnage>();
            Collection<Personnage> defenseurs = new Collection<Personnage>();

            Personnage chefAttaquant = new Personnage(1, "Chef Attaquant");
            chefAttaquant.EnBataille = true;
            chefAttaquant.Valeur = 100;
            attaquants.Add(chefAttaquant);

            Personnage chefDefenseur = new Personnage(2, "Chef Défenseur");
            chefDefenseur.EnBataille = true;
            chefDefenseur.Valeur = 90;
            defenseurs.Add(chefDefenseur);

             Console.WriteLine("Bataille le " + bataille.Date + " à " + bataille.Lieu + " (Durée : " + bataille.Duree + " minutes)");


            // Affichez les pertes et le gagnant
            Console.WriteLine("Pertes dans l'armée des attaquants : " + bataille.RetournerNbPerte(attaquants));
            Console.WriteLine("Pertes dans l'armée des défenseurs : " + bataille.RetournerNbPerte(defenseurs));
            Console.WriteLine("Le gagnant est : " + bataille.DefinirGagnant());
            Console.ReadKey(true);
        }