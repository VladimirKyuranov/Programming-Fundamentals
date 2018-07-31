using System;
using System.Collections.Generic;
using System.Linq;

class Files
{
    static void Main(string[] args)
    {
        int filesCount = int.Parse(Console.ReadLine());

        var files = new Dictionary<string, List<File>>();

        for (int currentFile = 0; currentFile < filesCount; currentFile++)
        {
            string[] fileInfo = Console.ReadLine()
                .Split("\\;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string root = fileInfo[0];
            string fileName = fileInfo[fileInfo.Length - 2];
            long fileSize = long.Parse(fileInfo[fileInfo.Length - 1]);

            File file = new File
            {
                Name = fileName,
                Size = fileSize
            };

            if (files.ContainsKey(root) == false)
            {
                files.Add(root, new List<File>());
            }

            File thisFile = files[root].FirstOrDefault(x => x.Name == fileName);

            if (thisFile != null)
            {
                thisFile.Size = fileSize;
            }
            else
            {
                files[root].Add(file);
            }
        }

        string[] command = Console.ReadLine()
            .Split();

        string extension = command[0];
        string rootFolder = command[2];

        if (files.ContainsKey(rootFolder) == false || files[rootFolder].All(x => x.Name.EndsWith(extension) == false))
        {
            Console.WriteLine("No");
        }
        else
        {
            foreach (File file in files[rootFolder].Where(x => x.Name.EndsWith(extension)).OrderByDescending(x => x.Size).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{file.Name} - {file.Size} KB");
            }
        }
    }
}

class File
{
    public string Name { get; set; }
    public long Size { get; set; }
}