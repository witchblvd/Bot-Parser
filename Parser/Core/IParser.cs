using HtmlAgilityPack;

namespace Parser.Core;

public interface IParser
{
    List<string> Parse(HtmlDocument document);
}