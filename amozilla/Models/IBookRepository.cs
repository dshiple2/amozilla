using System;
using System.Linq;

namespace amozilla.Models
{
    public interface IBookRepository 
    {
        IQueryable<Book> Books { get; }

    }
}
