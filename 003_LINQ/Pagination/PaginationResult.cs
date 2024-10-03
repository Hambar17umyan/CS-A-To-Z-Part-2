using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagination
{
    internal class PaginationResult
    {
        public bool isSuccess;
        public List<Animal>? ResutingAnimals;
        public int? TotalCount;
    }
}
