using System;
using ListDirTreeApp.Services;
using ListDirTreeApp.Models;

namespace ListDirTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter folder path:");
            string rootPath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(rootPath) || !System.IO.Directory.Exists(rootPath))
            {
                Console.WriteLine("Invalid folder path.");
                return;
            }

            var service = new DirectoryTreeService();
            DirectoryNode rootNode = service.BuildTree(rootPath);

            Console.WriteLine($"[DIR] {rootNode.Name}");
            PrintTree(rootNode, "");
        }


        // تابع نمایش درخت با تو رفتگی و خطوط
        static void PrintTree(DirectoryNode node, string indent, bool isLast = true)
        {
            int count = node.Children.Count;
            for (int i = 0; i < count; i++)
            {
                var child = node.Children[i];
                bool lastChild = (i == count - 1);
                string prefix = lastChild ? "└── " : "├── ";

                Console.Write(indent + prefix);

                if (child.IsDirectory)
                {
                    Console.WriteLine("[DIR]  " + child.Name);
                    string childIndent = indent + (lastChild ? "    " : "│   ");
                    PrintTree(child, childIndent);
                }
                else
                {
                    Console.WriteLine("[FILE] " + child.Name);
                }
            }
        }
    }
}
