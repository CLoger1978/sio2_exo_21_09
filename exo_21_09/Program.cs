using System;
class Program
{
    public static void AfficherElement(IAffichable element)
    {
        element.Afficher();
    }

    static void Main(string[] args)
    {
        var produit = new Produit("Clavier", 49.90m);
        var client = new Client("Alice", "alice@example.com");

       
        AfficherElement(produit);
        AfficherElement(client);
        AfficherElement (new Commande(1, 150.00m));
    }
}
/*Questions
A-t-il été nécessaire de modifier AfficherElement() ?
non 
Pourquoi cette méthode peut-elle accepter des objets de classes différentes ?
puisqu'on précise ce qu'on utilise
Quel serait l'inconvénient d'écrire uniquement :
on ne peut que utiliser la classe produit*/