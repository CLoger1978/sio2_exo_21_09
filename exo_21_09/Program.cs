using System;
class Program
{
    // La méthode demandée pour l'exercice 4
    public static void AfficherElement(IAffichable element)
    {
        element.Afficher();
    }

    static void Main(string[] args)
    {
        var produit = new Produit("Clavier", 49.90m);
        var client = new Client("Alice", "alice@example.com");
        var commande = new Commande(1, 150.00m); // Exemple pour la commande

        // Utilisation de la même méthode avec les différents objets
        AfficherElement(produit);
        AfficherElement(client);
        AfficherElement(commande);
    }
}