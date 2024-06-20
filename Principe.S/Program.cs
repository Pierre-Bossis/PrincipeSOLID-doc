using PrincipeS;

class Program
{
    static void Main(string[] args)
    {
        //single responsabilité Principle
        //une et une seule raison de changer, ce a quoi elle est destinée (si l'aspect business ou technique evolue ou doit changer)

        //la methode SaveFile était dans la classe Book mais ce n'est pas sa responsabilité, elle a été déplacé dans un repository
        Book book = new();
        book.Title = "Title";
        book.ISBN = "156164564";
        book.Author = "Author";
        book.NbPages = 105;

        BookRepository repo = new();

        repo.SaveToFile(book);
    }
}