using System;

public interface IAffichable
{
    void Afficher();
}
public class Produit: IAffichable
{
    public string Nom {get;set;}
    public decimal Prix {get;set;}

   public Produit(string nom, decimal prix)
   {
    Nom = nom;
    Prix = prix;
   }
   public void Afficher()
    {
        Console.WriteLine($"{Nom} – {Prix}€");
    }
}
public class Client: IAffichable
{
    public string Nom_c {get; set;}
    public string Email {get; set;}

    public Client(string nom_c, string email)
{
    nom_c = Nom_c;
    email = Email;
}

public void Afficher()
{
    Console.WriteLine($"{Nom_c} - {Email}");
}
}  
