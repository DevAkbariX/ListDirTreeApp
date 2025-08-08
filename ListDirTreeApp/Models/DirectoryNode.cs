using System.Collections.Generic;

namespace ListDirTreeApp.Models
{
    // مدل گره درخت پوشه/فایل
    public class DirectoryNode
    {
        public string Name { get; set; }
        public bool IsDirectory { get; set; }
        public List<DirectoryNode> Children { get; set; }

        public DirectoryNode(string name, bool isDirectory)
        {
            Name = name;
            IsDirectory = isDirectory;
            Children = new List<DirectoryNode>();
        }
    }
}
