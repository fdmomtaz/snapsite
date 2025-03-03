using System;

namespace SnapSite.Models;

public class Options
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Version {get; set; }

    public string Url { get; set; }

    public List<Page> StaticPages { get; set; }
}
