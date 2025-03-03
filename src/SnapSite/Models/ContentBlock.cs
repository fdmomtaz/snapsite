using System;

namespace SnapSite.Models;

public class ContentBlock
{
    public enum ContentBlockType
    {
        Markdown,
        Html,
        Text
    }

    public ContentBlockType Type { get; set; }
    public string Source { get; set; }
}
