using Practica_3.Contract;
using Practica_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.implementation
{
    public class LibraryRepository : ILibraryRepository<Author>
    {
        readonly LibraryContext _libraryContext;

        public LibraryRepository(LibraryContext context)
        {
            _libraryContext = context;
        }

        public IEnumerable<Author> GetAllAuthor()
        {
            return _libraryContext.Authors.ToList();
        }
    }
}
