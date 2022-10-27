using HtmlAgilityPack;

namespace Parser.Core.Sites.shikimori;

public class ShikimoriParser : IParser
{
    public List<string> Parse(HtmlDocument document)
    {
        var list = document.DocumentNode.Descendants("span")
            .Where(u => u.GetAttributeValue("class", "").Equals("name-ru")).Select(t => t.InnerText).ToList();
        return list;
    }
}