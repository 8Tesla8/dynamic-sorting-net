using System;
using System.Collections.Generic;
using System.Linq;

namespace ResourceServer.Domain.Helpers
{
    public static class SimpleObject
    {

        public static IEnumerable<T> Sorting<T>(this IEnumerable<T> source, string property, bool sortingByAsc)
        {
            var type = typeof(T);
            var sortProperty = type.GetProperty(property);

            if (sortingByAsc)
            {
                return source.OrderBy(p => sortProperty.GetValue(p, null)).ToList();
            }

            return source.OrderByDescending(p => sortProperty.GetValue(p, null)).ToList();
        }

    }

}
