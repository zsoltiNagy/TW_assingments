using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace SanityArchiver
{
    public class FileHandler
    {
        public static void ArchiveFile(DirectoryInfo archiveDir, FileInfo fileToArchive)
        {
            // Function tries to open the file, in case of IOException it tries it again after a second
            FileStream input = fileToArchive.OpenRead();
            FileStream output = File.Create(archiveDir.FullName + @"\" + fileToArchive.Name + ".gz");
            GZipStream Compressor = new GZipStream(output, CompressionMode.Compress);
            int b = input.ReadByte();
            while (b != -1)
            {
                Compressor.WriteByte((byte)b);
                b = input.ReadByte();
            }
            Compressor.Close();
            input.Close();
            output.Close();
        }

        public static string root;

        public static List<string> RecursiveSearch(string fileName, DirectoryInfo currentDirectory, List<string> results)
        {
            foreach (FileInfo fil in currentDirectory.GetFiles(fileName))
            {
                results.Add(fil.FullName.ToString().Replace(root, ""));
            }

            foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
            {
                try
                {
                    RecursiveSearch(fileName, dir, results);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return results;
        }

        public static List<string> GetFileProperties(FileInfo file)
        {
            List<string> properties = new List<string>();
            properties.Add("File name: " + file.Name);
            properties.Add("Attributes: " + file.Attributes);
            properties.Add("Creation time: " + file.CreationTime);
            properties.Add("Containing directory " + file.DirectoryName);
            properties.Add("File extension: " + file.Extension);
            properties.Add("Last Access Time: " + file.LastAccessTime);
            properties.Add("Last Write Time: " + file.LastWriteTime);
            properties.Add("File length: " + file.Length);
            return properties;
        }

        public static long DirectorySize(DirectoryInfo dir)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                size += file.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo d in dirs)
            {
                size += DirectorySize(d);
            }
            return size;
        }

        public static string SizeConverter(long bytesize)
        {
            string size;
            int bytes = unchecked((int)bytesize);
            int KB = bytes / 1024;
            int MB = bytes / 1024 / 1024;
            int GB = bytes / 1024 / 1024 / 1024;
            if (GB > 0.5)
            {
                size = GB.ToString() + "GB";
            } else if (MB > 0.5)
            {
                size = MB.ToString() + "MB";
            } else if (KB > 0.5)
            {
                size = KB.ToString() + "KB";
            } else
            {
                size = bytes + "bytes";
            }
            return size;
        }

        public static bool IsDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            return attr.HasFlag(FileAttributes.Directory);
        }
    }
}
