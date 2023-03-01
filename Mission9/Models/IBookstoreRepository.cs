using System;
using System.Linq;

namespace Mission9.Models
{
	public interface IBookstoreRepository
	{
        IQueryable<Books> Books { get; }
    }
}

