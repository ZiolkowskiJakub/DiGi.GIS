using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides functionality for managing GIS model files and implements the <see cref="IGISObject"/> interface.
    /// </summary>
    public class GISModelFileManager : IGISObject
    {
        private readonly Dictionary<GuidExternalReference, GISModelFile> dictionary = [];

        /// <summary>
        /// Initializes a new instance of the GISModelFileManager class
        /// </summary>
        public GISModelFileManager()
        {
        }

        /// <summary>
        /// Retrieves the GIS model associated with the specified external reference.
        /// </summary>
        /// <param name="guidExternalReference">The external reference used to identify the GIS model.</param>
        /// <returns>The matching <see cref="GISModel"/> if found; otherwise, <see langword="null"/>.</returns>
        public GISModel? GetGISModel(GuidExternalReference? guidExternalReference)
        {
            if (guidExternalReference is null)
            {
                return null;
            }

            if (!dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return null;
            }

            return gISModelFile.Value;
        }

        /// <summary>
        /// Retrieves the external reference associated with the specified file path.
        /// </summary>
        /// <param name="path">The file path to search for.</param>
        /// <returns>The matching <see cref="GuidExternalReference"/> if found; otherwise, <see langword="null"/>.</returns>
        public GuidExternalReference? GetGuidExternalReference(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            foreach (KeyValuePair<GuidExternalReference, GISModelFile> keyValuePair in dictionary)
            {
                if (keyValuePair.Value?.Path is not string path_GISModelFile)
                {
                    continue;
                }

                if (path_GISModelFile.Equals(path, System.StringComparison.OrdinalIgnoreCase))
                {
                    return keyValuePair.Key;
                }
            }

            return null;
        }

        /// <summary>
        /// Retrieves the external reference associated with the specified GIS model.
        /// </summary>
        /// <param name="gISModel">The <see cref="GISModel"/> for which the external reference is being retrieved.</param>
        /// <returns>The matching <see cref="GuidExternalReference"/> if found; otherwise, <see langword="null"/>.</returns>
        public GuidExternalReference? GetGuidExternalReference(GISModel? gISModel)
        {
            if (gISModel is null)
            {
                return null;
            }

            GuidReference guidReference = new(gISModel);

            foreach (GuidExternalReference guidExternalReference in dictionary.Keys)
            {
                if (guidExternalReference.Reference is not GuidReference guidReference_Temp)
                {
                    continue;
                }

                if (!guidReference.Equals(guidReference_Temp))
                {
                    continue;
                }

                return guidExternalReference;
            }

            return null;
        }

        /// <summary>
        /// Retrieves all external reference identifiers currently managed by the GIS model file manager.
        /// </summary>
        /// <returns>A <see cref="HashSet{T}"/> containing all <see cref="GuidExternalReference"/> keys, or <see langword="null"/> if no references are available.</returns>
        public HashSet<GuidExternalReference>? GetGuidExternalReferences()
        {
            return [.. dictionary.Keys];
        }

        /// <summary>
        /// Retrieves the file path associated with the specified GIS model.
        /// </summary>
        /// <param name="gISModel">The <see cref="GISModel"/> for which to retrieve the file path.</param>
        /// <returns>The file path of the GIS model if it exists in the manager; otherwise, <see langword="null"/>.</returns>
        public string? GetPath(GISModel? gISModel)
        {
            if (GetGuidExternalReference(gISModel) is not GuidExternalReference guidExternalReference)
            {
                return null;
            }

            if (!dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile) || gISModelFile is null)
            {
                return null;
            }

            return gISModelFile.Path;
        }

        /// <summary>
        /// Opens a GIS model file from the specified path and adds it to the manager's collection.
        /// </summary>
        /// <param name="path">The file path of the GIS model file to open.</param>
        /// <returns>The <see cref="GuidExternalReference"/> of the opened GIS model file if successful; otherwise, <see langword="null"/>.</returns>
        public GuidExternalReference? Open(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            GISModelFile gISModelFile = new(path);
            if (gISModelFile.Open())
            {
                GuidExternalReference? guidExternalReference = gISModelFile.GuidExternalReference;
                if (guidExternalReference is not null)
                {
                    dictionary[guidExternalReference] = gISModelFile;
                    return guidExternalReference;
                }
            }

            return null;
        }

        /// <summary>
        /// Removes the GIS model file associated with the specified external reference.
        /// </summary>
        /// <param name="guidExternalReference">The external reference of the GIS model file to remove.</param>
        /// <returns><see langword="true"/> if the GIS model file was successfully removed; otherwise, <see langword="false"/>.</returns>
        public bool Remove(GuidExternalReference? guidExternalReference)
        {
            if (guidExternalReference is null || !dictionary.TryGetValue(guidExternalReference, out _))
            {
                return false;
            }

            return dictionary.Remove(guidExternalReference);
        }

        /// <summary>
        /// Removes all GIS model files from the manager.
        /// </summary>
        /// <returns><see langword="true"/> if one or more GIS model files were successfully removed; otherwise, <see langword="false"/>.</returns>
        public bool RemoveAll()
        {
            bool result = false;

            foreach (GuidExternalReference guidExternalReference in dictionary.Keys)
            {
                if (Remove(guidExternalReference))
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Saves the GIS model file associated with the specified external reference.
        /// </summary>
        /// <param name="guidExternalReference">The external reference of the GIS model file to save.</param>
        /// <returns><see langword="true"/> if the GIS model file was successfully saved; otherwise, <see langword="false"/>.</returns>
        public bool Save(GuidExternalReference? guidExternalReference)
        {
            if (guidExternalReference is null || !dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return false;
            }

            return gISModelFile.Save();
        }

        /// <summary>
        /// Saves the GIS model file associated with the specified external reference to the given path and updates its reference in the manager.
        /// </summary>
        /// <param name="guidExternalReference">The external reference of the GIS model file to save.</param>
        /// <param name="path">The destination file path where the GIS model file will be saved.</param>
        /// <returns>The new <see cref="GuidExternalReference"/> if the operation was successful; otherwise, <see langword="null"/>.</returns>
        public GuidExternalReference? SaveAs(GuidExternalReference? guidExternalReference, string path)
        {
            if (guidExternalReference is null || !dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return null;
            }

            bool saved = gISModelFile.SaveAs(path);
            if (!saved)
            {
                return null;
            }

            GuidExternalReference? result = gISModelFile.GuidExternalReference;
            if (result is null)
            {
                return null;
            }

            dictionary.Remove(guidExternalReference);
            dictionary[result] = gISModelFile;
            return result;
        }

        /// <summary>
        /// Tries to retrieve a GIS unique object of the specified type using the provided file and object reference.
        /// </summary>
        /// <typeparam name="YIGISUniqueObject">The type of the GIS unique object to retrieve, which must implement <see cref="IGISUniqueObject"/>.</typeparam>
        /// <param name="gISModelFileUniqueObjectReference">The reference containing the external and internal GUIDs used to locate the object.</param>
        /// <param name="gISUniqueObject">When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value.</param>
        /// <returns><see langword="true"/> if the object was successfully found; otherwise, <see langword="false"/>.</returns>
        public bool TryGetObject<YIGISUniqueObject>(GISModelFileGuidObjectReference? gISModelFileUniqueObjectReference, out YIGISUniqueObject? gISUniqueObject) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;

            if (gISModelFileUniqueObjectReference is null)
            {
                return false;
            }

            return TryGetObject(gISModelFileUniqueObjectReference.GuidExternalReference, gISModelFileUniqueObjectReference.GuidReference, out gISUniqueObject);
        }

        /// <summary>
        /// Tries to retrieve a GIS unique object of the specified type and its associated GIS model using the provided file and object reference.
        /// </summary>
        /// <typeparam name="YIGISUniqueObject">The type of the GIS unique object to retrieve, which must implement <see cref="IGISUniqueObject"/>.</typeparam>
        /// <param name="gISModelFileUniqueObjectReference">The reference containing the external and internal GUIDs used to locate the object.</param>
        /// <param name="gISUniqueObject">When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value.</param>
        /// <param name="gISModel">When this method returns, contains the retrieved GIS model if successful; otherwise, null.</param>
        /// <returns><see langword="true"/> if the object and its associated model were successfully found; otherwise, <see langword="false"/>.</returns>
        public bool TryGetObject<YIGISUniqueObject>(GISModelFileGuidObjectReference? gISModelFileUniqueObjectReference, out YIGISUniqueObject? gISUniqueObject, out GISModel? gISModel) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;
            gISModel = null;

            if (gISModelFileUniqueObjectReference is null)
            {
                return false;
            }

            return TryGetObject(gISModelFileUniqueObjectReference.GuidExternalReference, gISModelFileUniqueObjectReference.GuidReference, out gISUniqueObject, out gISModel);
        }

        /// <summary>
        /// Tries to retrieve a GIS unique object of the specified type using the provided external reference and internal reference GUIDs.
        /// </summary>
        /// <typeparam name="YIGISUniqueObject">The type of the GIS unique object to retrieve, which must implement <see cref="IGISUniqueObject"/>.</typeparam>
        /// <param name="guidExternalReference">The external reference GUID used to locate the GIS model containing the object.</param>
        /// <param name="guidReference">The internal reference GUID used to identify the specific object within the model.</param>
        /// <param name="gISUniqueObject">When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value.</param>
        /// <returns><see langword="true"/> if the object was successfully found; otherwise, <see langword="false"/>.</returns>
        public bool TryGetObject<YIGISUniqueObject>(GuidExternalReference? guidExternalReference, GuidReference? guidReference, out YIGISUniqueObject? gISUniqueObject) where YIGISUniqueObject : IGISUniqueObject
        {
            return TryGetObject(guidExternalReference, guidReference, out gISUniqueObject, out _);
        }

        /// <summary>
        /// Tries to retrieve a GIS unique object of the specified type and its associated GIS model using the provided external reference and internal reference GUIDs.
        /// </summary>
        /// <typeparam name="YIGISUniqueObject">The type of the GIS unique object to retrieve, which must implement <see cref="IGISUniqueObject"/>.</typeparam>
        /// <param name="guidExternalReference">The external reference GUID used to locate the GIS model.</param>
        /// <param name="guidReference">The internal reference GUID used to identify the specific object within the model.</param>
        /// <param name="gISUniqueObject">When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value.</param>
        /// <param name="gISModel">When this method returns, contains the retrieved GIS model if successful; otherwise, null.</param>
        /// <returns><see langword="true"/> if the object and its associated model were successfully found; otherwise, <see langword="false"/>.</returns>
        public bool TryGetObject<YIGISUniqueObject>(GuidExternalReference? guidExternalReference, GuidReference? guidReference, out YIGISUniqueObject? gISUniqueObject, out GISModel? gISModel) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;
            gISModel = null;

            if (guidExternalReference is null || guidReference is null)
            {
                return false;
            }

            gISModel = GetGISModel(guidExternalReference);
            if (gISModel == null)
            {
                return false;
            }

            if (!gISModel.TryGetObject(guidReference, out gISUniqueObject))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Tries to retrieve a GIS unique object of the specified type and its associated GIS model using the provided external reference and reference string.
        /// </summary>
        /// <typeparam name="TGISGuidObject2D">The type of the GIS unique object to retrieve, which must derive from <see cref="GISGuidObject2D"/>.</typeparam>
        /// <param name="guidExternalReference">The external reference GUID used to locate the GIS model.</param>
        /// <param name="reference">The reference string used to identify the specific object within the model.</param>
        /// <param name="gISUniqueObject">When this method returns, contains the retrieved GIS unique object if successful; otherwise, the default value.</param>
        /// <param name="gISModel">When this method returns, contains the retrieved GIS model if successful; otherwise, null.</param>
        /// <returns><see langword="true"/> if the object and its associated model were successfully found; otherwise, <see langword="false"/>.</returns>
        public bool TryGetObject<TGISGuidObject2D>(GuidExternalReference? guidExternalReference, string reference, out TGISGuidObject2D? gISUniqueObject, out GISModel? gISModel) where TGISGuidObject2D : GISGuidObject2D
        {
            gISUniqueObject = default;
            gISModel = null;

            if (guidExternalReference is null || string.IsNullOrWhiteSpace(reference))
            {
                return false;
            }

            gISModel = GetGISModel(guidExternalReference);
            if (gISModel == null)
            {
                return false;
            }

            if (!gISModel.TryGetObject(reference, out gISUniqueObject))
            {
                return false;
            }

            return true;
        }
    }
}
