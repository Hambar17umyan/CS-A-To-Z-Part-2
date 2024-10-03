using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagination
{
    internal record PaginationRequest
    {
        public readonly Func<Animal, bool> FilterPredicate;
        public IComparer<Animal> Comparer;
        public int PageSize;
        public int PageNumber;

        public PaginationRequest(Func<Animal, bool> filterPredicate, IComparer<Animal> comparer, int pageSize, int pageNumber)
        {
            FilterPredicate = filterPredicate;
            Comparer = comparer;
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}
