using PrincipeS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principe.I
{
    public interface IReadRepository
    {
        Book? GetById(int id);
        IEnumerable<Book> GetAll();
    }
}
