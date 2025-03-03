using System;

namespace SnapSite.Models;

public class Page
{
    public string Name { get; set; }
    public List<ContentBlock> Content { get; set; } = new List<ContentBlock>();
}
