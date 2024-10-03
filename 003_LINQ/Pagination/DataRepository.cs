using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagination
{
    internal static class DataRepository
    {
        public static IEnumerable<Animal> Animals = Enumerable.Range(1, 10000)
            .Select(i => new Animal()
            {
                ID = -i,
                Name = $"Animal N{i}",
                Age = i % 15,
                Weight = i % 100
            });
    }
}
