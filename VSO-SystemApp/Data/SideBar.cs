namespace VSO_SystemApp.Data
{
    public class SideBar
    {
       public string? Title { get; set; }
       public string? Url { get; set; }
       public string? Icon { get; set; }

       public SideBar(string title, string url, string icon) 
       {
            Title = title;
            Url = url;
            Icon = icon;
       }
    }
}
