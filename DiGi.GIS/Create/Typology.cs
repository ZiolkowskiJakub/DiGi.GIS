using DiGi.Core.IO.Table.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Classifies the rows of a table into a typology tree, grouping them by the chained columns of a column typology filter.
        /// <para>Each level of the chain resolves its column against the table by unique id, so a chain may be declared from the shared column constants: a constant carries no table index, and an index belongs to the table a column was added to rather than to the column itself. The caller's chain is never modified - a new chain is built over the table's own column instances, reusing the rule of each level rather than copying it.</para>
        /// <para>A row whose value resolves to no bucket at a level is excluded from that level's subtree, and from every level below it. A range rule resolves nothing for a null value, a value it cannot convert, and a value outside every declared range, so rows with no value in a range column are absent below that point. A unique value rule buckets nulls instead, under the name "null". There is no catch-all bucket.</para>
        /// <para>With <paramref name="includeReferences"/> set, every node from the matched one up to the root stores the reference, so an ancestor's references are those of its whole subtree. Clear it to solve structure and node metadata only, for a tree whose node to object association is held elsewhere.</para>
        /// <para>A chain this cannot honour in full is refused rather than solved in part: a level naming a column the table does not hold, a level carrying no rule, and a chain linking back on itself all return null, because each would otherwise answer with a tree ending above the level that was asked for.</para>
        /// </summary>
        /// <param name="table">The table whose rows are classified.</param>
        /// <param name="columnTypologyFilter">The root of the filter chain describing the grouping levels.</param>
        /// <param name="column_Reference">The column identifying a row. Resolved against the table by unique id, and required unless <paramref name="includeReferences"/> is cleared.</param>
        /// <param name="typologyItem_Root">The item naming the root node. When null the root is left unnamed.</param>
        /// <param name="includeReferences">A value indicating whether the identified references are stored on the nodes.</param>
        /// <returns>The solved typology, or null when the table or the chain is null, when the chain names no column, when a column named by the chain is absent from the table, when a level of the chain carries no rule, when the chain links back on itself, when a required reference column is absent or unresolvable, or when the solver produces nothing.</returns>
        public static DiGi.Typology.Classes.Typology? Typology(this Table? table, DiGi.Typology.Classes.ColumnTypologyFilter<Column>? columnTypologyFilter, Column? column_Reference, DiGi.Typology.Classes.TypologyItem? typologyItem_Root = null, bool includeReferences = true)
        {
            if (table is null || columnTypologyFilter is null)
            {
                return null;
            }

            Dictionary<string, Column> columns = [];
            foreach (Column column in table.Columns)
            {
                // Fully qualified: DiGi.PostgreSQL.Table.Query and DiGi.Core.Query both declare an applicable UniqueId,
                // and which one an unqualified call binds to is decided by the using block rather than by the call site.
                string? uniqueId_Column = Core.IO.Query.UniqueId(column);

                if (string.IsNullOrWhiteSpace(uniqueId_Column) || columns.ContainsKey(uniqueId_Column!))
                {
                    continue;
                }

                columns[uniqueId_Column!] = column;
            }

            DiGi.Typology.Classes.ColumnTypologyFilter<Column>? columnTypologyFilter_Result = null;
            DiGi.Typology.Classes.ColumnTypologyFilter<Column>? columnTypologyFilter_Last = null;

            HashSet<DiGi.Typology.Classes.ColumnTypologyFilter<Column>> columnTypologyFilters_Visited = [];
            DiGi.Typology.Classes.ColumnTypologyFilter<Column>? columnTypologyFilter_Current = columnTypologyFilter;

            while (columnTypologyFilter_Current is not null)
            {
                if (!columnTypologyFilters_Visited.Add(columnTypologyFilter_Current))
                {
                    // The chain links back on a level it already passed. Solving what was collected up to here
                    // would answer with a tree quietly missing the levels below it, so the chain is refused.
                    return null;
                }

                if (columnTypologyFilter_Current.Rule is null)
                {
                    // A level with no rule groups nothing, and the solver stops at it rather than reporting it -
                    // the tree would simply end above the level the caller asked for.
                    return null;
                }

                if (!TryResolveColumn(columnTypologyFilter_Current.Value, out Column? column_Level))
                {
                    return null;
                }

                DiGi.Typology.Classes.ColumnTypologyFilter<Column> columnTypologyFilter_Temp = new()
                {
                    Value = column_Level,
                    Rule = columnTypologyFilter_Current.Rule
                };

                if (columnTypologyFilter_Result is null)
                {
                    columnTypologyFilter_Result = columnTypologyFilter_Temp;
                }
                else
                {
                    columnTypologyFilter_Last!.Filter = columnTypologyFilter_Temp;
                }

                columnTypologyFilter_Last = columnTypologyFilter_Temp;
                columnTypologyFilter_Current = columnTypologyFilter_Current.Filter;
            }

            if (columnTypologyFilter_Result is null)
            {
                return null;
            }

            Column? column_Reference_Table = null;
            if (includeReferences && !TryResolveColumn(column_Reference, out column_Reference_Table))
            {
                return null;
            }

            Classes.ReferenceColumnTypologyFilterSolver referenceColumnTypologyFilterSolver = new()
            {
                Input = columnTypologyFilter_Result,
                Objects = table,
                ReferenceColumn = column_Reference_Table,
                TypologyItem = typologyItem_Root,
                IncludeReferences = includeReferences
            };

            return referenceColumnTypologyFilterSolver.Solve() ? referenceColumnTypologyFilterSolver.Output : null;

            bool TryResolveColumn(Column? column, out Column? column_Resolved)
            {
                column_Resolved = null;

                string? uniqueId = Core.IO.Query.UniqueId(column);
                if (string.IsNullOrWhiteSpace(uniqueId))
                {
                    return false;
                }

                return columns.TryGetValue(uniqueId!, out column_Resolved);
            }
        }
    }
}
