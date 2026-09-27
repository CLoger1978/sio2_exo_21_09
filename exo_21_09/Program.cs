class Program
{
    static void Main (string[] args)
    {
        var monProduit = new Produit("Clavier", 49.90m);
        monProduit.Afficher();
        
        var client = new Client("Alice" , "alice@example.com");
        client.Afficher();
    }
}