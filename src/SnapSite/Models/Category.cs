using System;

namespace SnapSite.Models;

public class Category : Page
{
    public List<Page> SubPages { get; set; } = new List<Page>();

    public Category(string name) : base(name) { }
}
