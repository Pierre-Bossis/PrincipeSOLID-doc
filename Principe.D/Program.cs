using Principe.D;
using System.Runtime.Intrinsics.Arm;

//DIP - Principe d'inversion des dépendances :
//Les modules de haut niveau ne devraient pas dépendre des détails de l'implémentation des modules de bas niveau.
//Utilisez des abstractions pour inverser les dépendances et rendre le code plus flexible.

BookManager(new FileRepository());

void BookManager(IBookRepository repo)
{
    //menu pour gérer livres
    //1.récupérer livres
    repo.GetAll();
}