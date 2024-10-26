using DiGi.BDOT10k.UI.Classes;
using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static async Task<bool> Write(this SlownikObiektowGeometrycznych slownikObiektowGeometrycznych, string directory, Range<int> range)
        {
            if (slownikObiektowGeometrycznych == null || string.IsNullOrWhiteSpace(directory) || range == null)
            {
                return false;
            }

            List<BUBD_A> bUBD_As = slownikObiektowGeometrycznych.GetObiektyGeometryczne<BUBD_A>();
            if (bUBD_As == null)
            {
                return true;
            }

            foreach (BUBD_A bUBD_A in bUBD_As)
            {
                await Write(bUBD_A, directory, range);
            }

            return true;
        }

        public static async Task<bool> Write(this IEnumerable<Building2D> building2Ds, string directory, Range<int> range)
        {
            if (building2Ds == null || string.IsNullOrWhiteSpace(directory) || range == null)
            {
                return false;
            }

            foreach (Building2D building2D in building2Ds)
            {
                await Write(building2D, directory, range);
            }

            return true;
        }

        public static async Task<bool> Write(this BUBD_A bUBD_A, string directory, Range<int> range)
        {
            if (bUBD_A == null || string.IsNullOrWhiteSpace(directory) || range == null)
            {
                return false;
            }

            string? id = bUBD_A.OT_PowierzchniowyObiektGeometryczny.identyfikatorEGiB?.FirstOrDefault();
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            string directory_BUBD_A = System.IO.Path.Combine(directory, id);
            if (!Directory.Exists(directory_BUBD_A))
            {
                Directory.CreateDirectory(directory_BUBD_A);
            }

            string directory_Orto = System.IO.Path.Combine(directory_BUBD_A, "orto");
            if (!Directory.Exists(directory_Orto))
            {
                Directory.CreateDirectory(directory_Orto);
            }

            Dictionary<int, string> dictionary_Path = new Dictionary<int, string>();
            for (int i = range.Min; i <= range.Max; i++)
            {
                string path_Orto = System.IO.Path.Combine(directory_Orto, string.Format("{0}.jpeg", i));
                if (path_Orto == null || File.Exists(path_Orto))
                {
                    continue;
                }

                dictionary_Path[i] = path_Orto;
            }

            if (dictionary_Path.Count == 0)
            {
                return true;
            }

            Dictionary<int, byte[]> dictionary = await Query.BytesDictionary(bUBD_A.BoundingBox2D, dictionary_Path.Keys);
            if (dictionary == null)
            {
                return true;
            }

            foreach (KeyValuePair<int, byte[]> keyValuePair in dictionary)
            {
                if (keyValuePair.Value == null)
                {
                    continue;
                }

                string path_Orto = System.IO.Path.Combine(directory_Orto, string.Format("{0}.jpeg", keyValuePair.Key));

                using (Stream memoryStream = new MemoryStream(keyValuePair.Value), fileStream = new FileStream(path_Orto, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                {
                    await memoryStream.CopyToAsync(fileStream);
                }
            }

            return true;
        }

        public static async Task<bool> Write(this Building2D building2D, string directory, Range<int> range)
        {
            if (building2D == null || string.IsNullOrWhiteSpace(directory) || range == null)
            {
                return false;
            }

            string? id = building2D.Reference;
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            string directory_Building = System.IO.Path.Combine(directory, id);
            if (!Directory.Exists(directory_Building))
            {
                Directory.CreateDirectory(directory_Building);
            }

            string directory_Orto = directory_Building;

            //string directory_Orto = System.IO.Path.Combine(directory_BUBD_A, "orto");
            //if (!Directory.Exists(directory_Orto))
            //{
            //    Directory.CreateDirectory(directory_Orto);
            //}

            Dictionary<int, string> dictionary_Path = new Dictionary<int, string>();
            for (int i = range.Min; i <= range.Max; i++)
            {
                string path_Orto = System.IO.Path.Combine(directory_Orto, string.Format("{0}.jpeg", i));
                if (path_Orto == null || File.Exists(path_Orto))
                {
                    continue;
                }

                dictionary_Path[i] = path_Orto;
            }

            if (dictionary_Path.Count == 0)
            {
                return true;
            }

            Dictionary<int, byte[]> dictionary = await Query.BytesDictionary(building2D.PolygonalFace2D?.GetBoundingBox(), dictionary_Path.Keys);
            if (dictionary == null)
            {
                return true;
            }

            foreach (KeyValuePair<int, byte[]> keyValuePair in dictionary)
            {
                if (keyValuePair.Value == null)
                {
                    continue;
                }

                string path_Orto = System.IO.Path.Combine(directory_Orto, string.Format("{0}.jpeg", keyValuePair.Key));

                using (Stream memoryStream = new MemoryStream(keyValuePair.Value), fileStream = new FileStream(path_Orto, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                {
                    await memoryStream.CopyToAsync(fileStream);
                }
            }

            return true;
        }
    }
}
