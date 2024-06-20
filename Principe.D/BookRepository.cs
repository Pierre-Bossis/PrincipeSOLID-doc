using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Principe.D
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new();

        public void Add(Book book)
            => books.Add(book);

        public void Delete(Book book)
            => books.Remove(book);

        public IEnumerable<Book> GetAll()
            => books;

        public Book? GetById(int id)
            => books.FirstOrDefault(b => b.Id == id);

        public Task Save()
            => Task.CompletedTask;

        public void Update(Book book)
        {
            books.RemoveAll(b => b.Id == book.Id);
            books.Add(book);
        }
    }
}
