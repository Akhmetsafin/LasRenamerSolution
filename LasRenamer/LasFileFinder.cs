using System;
using System.IO;
using System.Linq;

namespace LasRenamer
{
    internal class LasFileFinder
    {
        public static FileInfo FindLatest(string folderPath)
        {
            return new DirectoryInfo(folderPath)
                .EnumerateFiles()
                .Where(file => file.Extension.Equals(
                    ".las",
                    StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(file => file.CreationTime)
                .FirstOrDefault();
        }
    }
}