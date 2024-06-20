using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrincipeS
{
    public class BookRepository
    {
        public async Task SaveToFile(Book book)
        {
            await File.WriteAllTextAsync($"./book-{book.Title}.json", JsonSerializer.Serialize(book, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }));
        }
    }
}
