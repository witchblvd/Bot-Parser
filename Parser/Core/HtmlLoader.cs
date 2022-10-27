using System.Net;

namespace Parser.Core;

public class HtmlLoader
{
    private string _url;

    private HttpClient _client;
    public HtmlLoader(IParserSettings settings)
    {
        _client = new HttpClient();
        _url = $"{settings.BaseUrl}";
    }

    public async Task<string> GetSinglePage()
    {
        string source = null;
  
        var response = await _client.GetAsync(_url);
            
        
            
        if(response != null && response.StatusCode == HttpStatusCode.OK)
        {
            source = await response.Content.ReadAsStringAsync();
        }

        return source;

    }

    public async Task<String> GetPageById(int id)
    {
        var currentUrl = _url.Replace("{CurrentId}", id.ToString());
        
        string source = null;
  
        var response = await _client.GetAsync(currentUrl);
        
        if(response != null && response.StatusCode == HttpStatusCode.OK)
        {
            source = await response.Content.ReadAsStringAsync();
        }

        return source;
    }
}