using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagination
{
    internal class PaginationManagementService
    {
        public PaginationResult ProvidePagination(PaginationRequest request)
        {
            var result = new PaginationResult();

            var items = DataRepository.Animals; //request
            result.TotalCount = items.Count(); //O(N)

            result.ResutingAnimals = items.Where(request.FilterPredicate).Order(request.Comparer).ToList();//O(N)

            return result;
        }
    }
}
