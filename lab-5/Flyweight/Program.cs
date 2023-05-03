using Flyweight;

DocumentParser documentParser = new DocumentParser();
string[] lines = documentParser._readFile("https://www.gutenberg.org/cache/epub/1513/pg1513.txt");

var main = new LightElementNode(
    "main",
    "block",
    true,
    new List<string> { }
);

LightElementNode tag;

MemoryMonitor.CheckCurrentProcess();

foreach (var row in lines)
{
    if (Array.IndexOf(lines, row) == 0)
    {
        tag = new LightElementNode("h1", "block", true, new List<string> { "usr-h1", "some-title1" });
        tag.AppendChild(new LightTextNode(row));
    }
    else if (row.Length < 20)
    {
        tag = new LightElementNode("h2", "block", true, new List<string> { "usr-h2", "some-title2", "some-style" });
        tag.AppendChild(new LightTextNode(row));
    }
    else if (row[0] == ' ')
    {
        tag = new LightElementNode("blockquote", "block", true, new List<string> { "usr-blockquote", "some-style" });
        tag.AppendChild(new LightTextNode(row));
    }
    else
    {
        tag = new LightElementNode("p", "block", true, new List<string> { "usr-p", "some-style", "some-style2", "some-style3" });
        tag.AppendChild(new LightTextNode(row));
    }

    main.AppendChild(tag);
}

main.OuterHTML();

MemoryMonitor.CheckCurrentProcess();
