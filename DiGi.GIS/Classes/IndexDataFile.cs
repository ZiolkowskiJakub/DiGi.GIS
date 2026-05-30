using DiGi.GIS.Interfaces;
using System.Collections.Generic;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents an index data file that stores mappings of index values to references and names
    /// </summary>
    public class IndexDataFile : List<IndexData>, IGISObject
    {
        /// <summary>
        /// Initializes a new instance of the IndexDataFile class
        /// </summary>
        public IndexDataFile()
            : base()
        {
        }

        /// <summary>
        /// Reads index data from the specified file path
        /// </summary>
        public bool Read(string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return false;
            }

            string[] values = System.IO.File.ReadAllLines(path);
            if (values == null || values.Length == 0)
            {
                return false;
            }

            foreach (string value in values)
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                string[] values_IndexData = value.Split('\t');
                if (values_IndexData == null)
                {
                    continue;
                }

                int count = values_IndexData.Length;

                if (count < 1)
                {
                    continue;
                }

                if (!int.TryParse(values_IndexData[0], out int index))
                {
                    continue;
                }

                string? reference = null;
                if (count > 1)
                {
                    reference = values_IndexData[1];
                }

                string? name = null;
                if (count > 2)
                {
                    name = values_IndexData[2];
                }

                Add(new IndexData(index, reference, name));
            }

            return true;
        }

        /// <summary>
        /// Writes index data to the specified file path
        /// </summary>
        public bool Write(string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            System.IO.File.WriteAllText(path, ToString());
            return true;
        }

        /// <summary>
        /// Tries to get the index value associated with the given reference
        /// </summary>
        public bool TryGetIndex(string? reference, out int index)
        {
            index = -1;

            if (reference == null)
            {
                return false;
            }

            IndexData indexData = Find(x => x.Reference == reference);
            if (indexData == null)
            {
                return false;
            }

            index = indexData.Index;
            return true;
        }

        /// <summary>
        /// Returns a string representation of all index data entries
        /// </summary>
        public override string ToString()
        {
            List<string> values = [];
            foreach (IndexData indexData in this)
            {
                if (indexData == null)
                {
                    values.Add(string.Empty);
                }

                values.Add(indexData?.ToString() ?? string.Empty);
            }

            return string.Join("\n", values);
        }
    }
}