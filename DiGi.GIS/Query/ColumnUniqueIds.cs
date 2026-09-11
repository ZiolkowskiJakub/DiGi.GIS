using DiGi.Core.IO.Table.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the unique ids of the columns a column typology filter chain groups by, root level first.
        /// <para>Use it to request exactly the columns a chain needs from a data source, rather than every column the source holds.</para>
        /// <para>A level naming no column contributes nothing, a unique id already collected is not repeated, and a chain that links back to a level it already visited stops there rather than looping.</para>
        /// </summary>
        /// <param name="columnTypologyFilter">The root of the filter chain.</param>
        /// <returns>The column unique ids in chain order, or null when the chain is null or names no column at all.</returns>
        public static List<string>? ColumnUniqueIds(this Typology.Classes.ColumnTypologyFilter<Column>? columnTypologyFilter)
        {
            if (columnTypologyFilter is null)
            {
                return null;
            }

            List<string> result = [];
            HashSet<string> uniqueIds = [];
            HashSet<Typology.Classes.ColumnTypologyFilter<Column>> columnTypologyFilters_Visited = [];

            Typology.Classes.ColumnTypologyFilter<Column>? columnTypologyFilter_Current = columnTypologyFilter;

            while (columnTypologyFilter_Current is not null && columnTypologyFilters_Visited.Add(columnTypologyFilter_Current))
            {
                // Fully qualified: DiGi.PostgreSQL.Table.Query and DiGi.Core.Query both declare an applicable UniqueId,
                // and which one an unqualified call binds to is decided by the using block rather than by the call site.
                string? uniqueId = Core.IO.Query.UniqueId(columnTypologyFilter_Current.Value);

                if (!string.IsNullOrWhiteSpace(uniqueId) && uniqueIds.Add(uniqueId!))
                {
                    result.Add(uniqueId!);
                }

                columnTypologyFilter_Current = columnTypologyFilter_Current.Filter;
            }

            return result.Count == 0 ? null : result;
        }
    }
}
