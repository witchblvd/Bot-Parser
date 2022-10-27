using HtmlAgilityPack;

namespace Parser.Core;

public class ParserWorker
{
    private IParserSettings _settings;

    private HtmlLoader _loader;

    private IParser _parser;

    public ParserWorker(IParser parser, IParserSettings parserSettings)
    {
        _parser = parser;
        _settings = parserSettings;
        _loader = new HtmlLoader(_settings);
    }

    public async Task<List<string>> Start()
    {
        return await Worker();
    }

    private async Task<List<string>> Worker()
    {
        string source = await _loader.GetSinglePage();
        var document = new HtmlDocument();
        document.LoadHtml(source);
        var result = _parser.Parse(document);
        return result;
    }
    
   
}