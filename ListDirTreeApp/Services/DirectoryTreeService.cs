using System;
using System.IO;
using ListDirTreeApp.Models;

namespace ListDirTreeApp.Services
{
    // سرویس ساخت درخت پوشه
    public class DirectoryTreeService
    {
        public DirectoryNode BuildTree(string path)
        {
            var attr = File.GetAttributes(path);
            bool isDir = (attr & FileAttributes.Directory) == FileAttributes.Directory;
            var node = new DirectoryNode(Path.GetFileName(path), isDir);

            if (isDir)
            {
                try
                {
                    var entries = Directory.GetFileSystemEntries(path);
                    foreach (var entry in entries)
                    {
                        var childNode = BuildTree(entry);
                        node.Children.Add(childNode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error accessing {path}: {ex.Message}");
                }
            }

            return node;
        }
    }
}
