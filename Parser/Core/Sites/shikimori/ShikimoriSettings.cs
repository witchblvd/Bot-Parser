namespace Parser.Core.Sites.shikimori;

public class ShikimoriSettings : IParserSettings
{
    public ShikimoriSettings(int start, int end)
    {
        StartPoint = start;
        EndPoint = end;
    }
    public string BaseUrl { get; set; } = "https://shikimori.one/collections/3562-top-100-anime-po-mneniyu-polzovateley-sayta-anikore";
    
    public string Prefix { get; set; } //= "page/{CurrentId}";
    
    public int StartPoint { get; set; }
    
    public int EndPoint { get; set; }
}