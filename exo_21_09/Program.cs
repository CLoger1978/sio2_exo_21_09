class Program
{
    static void Main (string[] args)
    {
        var element = new Client("Alice", "alice@exemple.com");
        element.Afficher();
}
}
/*Questions
Quel est le type de la variable element ?
var
Quel est le type réel de l'objet dans le premier exemple ?
string et decimal
Quel est le type réel de l'objet dans le deuxième exemple ?
string et string
Pourquoi element.Afficher() fonctionne-t-il dans les deux cas ?
car il correspond au nouveaux produit
Peut-on écrire :
element.Prix
Pourquoi ?
non parce qu'il n'existe pas dans le programme*/