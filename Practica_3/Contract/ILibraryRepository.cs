using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Contract
{
    public class ILibraryRepository
    {
    }
    public interface ILibraryRepository<T>
    {
        IEnumerable<T> GetAllAuthor();
    }
}

