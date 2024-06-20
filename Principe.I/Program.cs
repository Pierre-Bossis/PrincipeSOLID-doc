//interface segregation principe

//au lieu d'avoir une seule grosse interface qui fait tout il est mieux d'avoir plusieurs petites interfaces qui ont des roles bien définis.
//IBookRepository qui implémente IReadRepository et IWriteRepository
//si on a besoin de tout la ou on l'utilise, on passe en parametre IBookRepository simplement

using Principe.I;
using PrincipeS;


DisplayAllBooks(new BookRepository());

void DisplayAllBooks(IReadRepository repo)
{
    IEnumerable<Book> books = repo.GetAll();
    foreach (Book book in books)
    {
        Console.WriteLine(book.Title);
    }
}