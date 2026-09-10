using DiGi.Core.IO.Table.Classes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Column typology filter solver that identifies each solved row by the value of a designated reference column.
    /// <para>The inherited identification returns the object's IUniqueObject.UniqueId, falling back to ToString(). A table row is neither, so the inherited form returns the same type name for every row and, because a node stores its references in a set, every node collapses to one meaningless reference. Setting <see cref="ReferenceColumn"/> is what makes a solved tree address real objects.</para>
    /// </summary>
    public class ReferenceColumnTypologyFilterSolver : DiGi.Typology.Classes.ColumnTypologyFilterSolver<Column, Row>
    {
        /// <summary>
        /// Gets or sets the column whose cell value identifies a row on the typology nodes that row is filed under.
        /// <para>This must be the column instance held by the table being solved, because the value is read by its Index and an index belongs to the table a column was added to rather than to the column itself.</para>
        /// <para>Left null, the inherited identification applies - see the remarks on this class for why that is rarely what a caller wants.</para>
        /// </summary>
        public Column? ReferenceColumn { get; set; }

        /// <summary>
        /// Returns the reference identifying the given row.
        /// </summary>
        /// <param name="row">The row to identify.</param>
        /// <returns>The reference column's value as a string, null when the row holds no value in that column or holds a blank one, or the inherited identification when no reference column is set.</returns>
        protected override string? GetReference(Row? row)
        {
            if (ReferenceColumn is null)
            {
                return base.GetReference(row);
            }

            if (row is null)
            {
                return null;
            }

            string? reference = row[ReferenceColumn.Index]?.ToString();

            // A blank cell is no identity. Left as an empty string it would be stored as a reference on
            // every node from the matched one up to the root, where it says nothing about any object.
            return string.IsNullOrWhiteSpace(reference) ? null : reference;
        }
    }
}
