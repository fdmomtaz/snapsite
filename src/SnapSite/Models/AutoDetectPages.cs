using System;

namespace SnapSite.Models;

public class AutoDetectPages : List<Page>
{
    public string InputDirectory { get; set; }
    public bool IncludeSubdirectories { get; set; } = true;
    public string RegexPattern { get; set; } = "*";


    private void PopulateFiles()
    {
        if (!Directory.Exists(InputDirectory))
            return;

        var searchOption = IncludeSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
        var files = Directory.GetFiles(InputDirectory, RegexPattern, searchOption);


        foreach (var file in files)
        {
            Add(new Page()
            {
                Name = Path.GetFileNameWithoutExtension(file),
                Content = new List<ContentBlock> { 
                    new ContentBlock() { 
                        Type = ContentBlock.ContentBlockType.Markdown, 
                        Source = File.ReadAllText(file)
                    }
                }
            });
        }
    }
}
