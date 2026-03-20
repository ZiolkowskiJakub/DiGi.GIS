using System;
using System.IO;
using DiGi.Core.Classes;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Size? Size(byte[]? bytes)
        {
            if (bytes == null || bytes.Length < 30)
            {
                return null;
            }

            using MemoryStream memoryStream = new (bytes);

            using BinaryReader binaryReader = new (memoryStream);

            try
            {
                // Check for PNG magic numbers (0x89 50 4E 47)
                if (bytes[0] == 0x89 && bytes[1] == 0x50 && bytes[2] == 0x4E && bytes[3] == 0x47)
                {
                    memoryStream.Position = 16; // Skip to IHDR chunk

                    byte[] widthBytes = binaryReader.ReadBytes(4);
                    byte[] heightBytes = binaryReader.ReadBytes(4);

                    Array.Reverse(widthBytes);
                    Array.Reverse(heightBytes);

                    int width = BitConverter.ToInt32(widthBytes, 0);
                    int height = BitConverter.ToInt32(heightBytes, 0);

                    return new Size(width, height);
                }

                // Check for JPEG magic numbers (0xFF D8)
                memoryStream.Position = 0;
                if (binaryReader.ReadUInt16() == 0xD8FF)
                {
                    return GetSize(binaryReader);
                }
            }
            catch
            {
                return null;
            }

            return null;

            // --- LOCAL FUNCTION ---
            Size? GetSize(BinaryReader reader)
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    byte markerFixed = reader.ReadByte(); // Expected 0xFF
                    byte markerType = reader.ReadByte();

                    // 0xC0, 0xC1, 0xC2 are Start Of Frame markers
                    if (markerType == 0xC0 || markerType == 0xC1 || markerType == 0xC2)
                    {
                        reader.BaseStream.Position += 3; // Skip length (2) and precision (1)

                        byte[] heightBytes = reader.ReadBytes(2);
                        byte[] widthBytes = reader.ReadBytes(2);

                        Array.Reverse(heightBytes);
                        Array.Reverse(widthBytes);

                        ushort height = BitConverter.ToUInt16(heightBytes, 0);
                        ushort width = BitConverter.ToUInt16(widthBytes, 0);

                        return new Size(width, height);
                    }
                    else
                    {
                        byte[] chunkLengthBytes = reader.ReadBytes(2);
                        Array.Reverse(chunkLengthBytes);
                        ushort chunkLength = BitConverter.ToUInt16(chunkLengthBytes, 0);

                        // Move to the next marker (-2 because length includes itself)
                        reader.BaseStream.Position += (chunkLength - 2);
                    }
                }
                return null;
            }
        }
    }
}