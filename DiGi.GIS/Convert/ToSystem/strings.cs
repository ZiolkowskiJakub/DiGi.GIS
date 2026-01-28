using DiGi.Typology.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static string[]? ToSystem_Strings(this Typology.Classes.Typology? typology)
        {
            List<TypologyPath>? typologyPaths = typology?.GetTypologyPaths(true);
            if (typologyPaths is null || typologyPaths.Count == 0)
            {
                return [];
            }

            List<Typology.Classes.Typology> subTypologies = [];

            foreach (TypologyPath typologyPath in typologyPaths)
            {
                Typology.Classes.Typology? subTypology = typology!.GetTypology(typologyPath);

                if (subTypology?.References is null || subTypology.References.Count == 0)
                {
                    continue;
                }

                subTypologies.Add(subTypology);
            }

            if (subTypologies.Count == 0)
            {
                return [];
            }

            subTypologies.Sort();

            List<string[]> values = [];

            Typology.Classes.Typology? typology_Header = subTypologies.Find(x => x.TypologyPath?.GetTypologyPaths() is List<TypologyPath> typologyPaths_Parent);
            if (typology_Header is not null)
            {
                List<TypologyPath> typologyPaths_Parent = typology_Header.TypologyPath?.GetTypologyPaths()!;

                string[] values_Typology = new string[typologyPaths_Parent.Count + 2];

                for (int i = 0; i < typologyPaths_Parent.Count; i++)
                {
                    TypologyPath typologyPath_Parent = typologyPaths_Parent[i];

                    Typology.Classes.Typology? typology_Parent = typology!.GetTypology(typologyPath_Parent);
                    if (typology_Parent is null)
                    {
                        continue;
                    }

                    values_Typology[i] = typology_Parent.Description ?? "???";
                }

                values_Typology[values_Typology.Length - 2] = typology_Header.Description ?? "???";

                values_Typology[values_Typology.Length - 1] = "Count";

                values.Add(values_Typology);
            }

            foreach (Typology.Classes.Typology subTypology in subTypologies)
            {
                if (subTypology.TypologyPath?.GetTypologyPaths() is not List<TypologyPath> typologyPaths_Parent)
                {
                    continue;
                }

                string[] values_Typology = new string[typologyPaths_Parent.Count + 2];

                for (int i = 0; i < typologyPaths_Parent.Count; i++)
                {
                    TypologyPath typologyPath_Parent = typologyPaths_Parent[i];

                    Typology.Classes.Typology? typology_Parent = typology!.GetTypology(typologyPath_Parent);
                    if (typology_Parent is null)
                    {
                        continue;
                    }

                    values_Typology[i] = typology_Parent?.Name is null ? "???" : typology_Parent.Name;
                }

                values_Typology[values_Typology.Length - 2] = subTypology.Name is null ? "???" : subTypology.Name;

                values_Typology[values_Typology.Length - 1] = subTypology.References.Count.ToString();

                values.Add(values_Typology);
            }

            return [.. values.ConvertAll(x => string.Join("\t", x))];
        }
    }
}