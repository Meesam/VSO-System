namespace VSO_SystemApp.Data
{
    public class TableColumnSetting
    {
        public string Title { get; set; }
        public bool Sortable { get; set; }

        public TableColumnSetting(string title, bool sortable) 
        {
           Title = title;
           Sortable = sortable;
        }
    }
}
